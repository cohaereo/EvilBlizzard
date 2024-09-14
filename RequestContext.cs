using bgs.protocol;

namespace EvilBlizzard;

public class RequestContext
{
    public RequestContext(Client client, Header header)
    {
        Client = client;
        Header = header;
    }

    public Client Client { get; set; }
    public Header Header { get; set; }
    public ErrorCode Error { get; set; } = ErrorCode.Ok;

    /// <summary>
    ///     Sends a notification associated with this request to the client
    /// </summary>
    /// <param name="serviceHash">The hash of the listener service</param>
    /// <param name="methodId">The method id for the notification</param>
    /// <param name="message"></param>
    /// <returns></returns>
    public void SendNotification<T>(uint serviceHash, uint methodId, T message)
    {
        Console.WriteLine($"\tSendNotification service=0x{serviceHash:X} method={methodId} token={Header.Token}");
        // Notifications are initiated outbound, making this a "request" (service id = 0)
        var packet = BgsMessage.Create(0, serviceHash, methodId, message, Header.Token);
        Client.Send(packet);
    }
}