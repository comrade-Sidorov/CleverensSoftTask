namespace Server.Domain;

public class Count
{
    private int _count = 0;

    public int GetCount()
    {
        return _count;
    }

    public void AddToCount()
    {
        _count++;   
    }
}
