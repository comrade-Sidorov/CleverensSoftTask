namespace Server.Service;

public class ServerService : IServerService
{
    public int AddCounter(int counter)
    {
        counter++;
        return counter;
    }

    public int RemoveCounter(int counter)
    {
        counter--;
        return counter;
    }
}
