using System.Reflection;
using ProtoBuf;

namespace EvilBlizzard;

public abstract class Service
{
    public static uint GetServiceHash(Type type)
    {
        return type.GetCustomAttribute<ServiceAttribute>()?.ServiceHash ?? 0;
    }

    public object? Dispatch(uint methodId, byte[] data, RequestContext context)
    {
        // Get all methods
        var (_, method) = GetType().GetMethods()
            .Select(m => (info: m.GetCustomAttribute<ServiceMethodAttribute>(), m))
            .FirstOrDefault(tuple => tuple.info?.MethodId == methodId);

        try
        {
            var dataStream = new MemoryStream(data);
            var dataParam = method.GetParameters()[0];
            var deserialize = typeof(Serializer).GetMethod("Deserialize", new[] { typeof(Stream) });
            var deserializeMethod = deserialize!.MakeGenericMethod(dataParam.ParameterType);
            var parameters = new List<object> { deserializeMethod.Invoke(null, [dataStream]) };
            if (method.GetParameters().FirstOrDefault(p => p.ParameterType == typeof(RequestContext)) != null)
                parameters.Add(context);

            var result = method.Invoke(this, parameters.ToArray());

            if (result != null && result.GetType() != typeof(void))
                return result;

            return null;
        }
        catch (NullReferenceException)
        {
            throw new NotImplementedException($"Method {methodId} for service {GetType().Name} not implemented");
        }
    }

    public string? GetMethodName(uint methodId)
    {
        var (_, method) = GetType().GetMethods()
            .Select(m => (info: m.GetCustomAttribute<ServiceMethodAttribute>(), m))
            .FirstOrDefault(tuple => tuple.info?.MethodId == methodId);
        return method?.Name;
    }
}

public class ServiceAttribute : Attribute
{
    public uint ServiceHash;

    public ServiceAttribute(uint serviceHash)
    {
        ServiceHash = serviceHash;
    }
}

public class ServiceMethodAttribute : Attribute
{
    public uint MethodId;

    public ServiceMethodAttribute(uint id)
    {
        MethodId = id;
    }
}