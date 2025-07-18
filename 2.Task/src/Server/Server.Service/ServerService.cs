using Server.Domain;

namespace Server.Service;

public class ServerService : IServerService
{
    public int AddCounter(Count count)
    {
        count.Counter++;
        return count.Counter;
    }

    public int RemoveCounter(Count count)
    {
        count.Counter--;
        return count.Counter;
    }
}
