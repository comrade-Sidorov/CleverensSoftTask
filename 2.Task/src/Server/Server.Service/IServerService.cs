namespace Server.Service;

public interface IServerService
{
    int AddCounter(int counter);
    int RemoveCounter(int counter);
}