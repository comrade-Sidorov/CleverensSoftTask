using Server.Domain;

namespace Server.Service;

public interface IServerService
{
    int AddCounter(Count count);
    int RemoveCounter(Count count);
}