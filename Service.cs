using System.Reflection;
using ProtoBuf;

namespace EvilBlizzard;

public abstract class IService
{
    public object? Dispatch(uint methodId, byte[] data)
    {
        // Get all methods
        var methods = GetType().GetMethods();
        var (_, method) = GetType().GetMethods()
            .Select(m => (info: m.GetCustomAttribute<ServiceMethodAttribute>(), m))
            .FirstOrDefault(tuple => tuple.info?.MethodId == methodId);

        try
        {
            var dataStream = new MemoryStream(data);
            var dataParam = method.GetParameters()[0];
            var deserialize = typeof(Serializer).GetMethod("Deserialize", new[] { typeof(Stream) });
            var deserializeMethod = deserialize!.MakeGenericMethod(dataParam.ParameterType);
            var result = method.Invoke(this, new[] { deserializeMethod.Invoke(null, new object[] { dataStream }) });

            if (result != null && result.GetType() != typeof(void))
                return result;

            return null;
        }
        catch (NullReferenceException)
        {
            throw new NotImplementedException($"Method {methodId} for service {GetType().Name} not implemented");
        }
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