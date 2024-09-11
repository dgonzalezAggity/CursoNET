public interface IMyService
{

}

public class MyService : IMyService
{
    public string GetMessage()
    {
        return "Hello";
    }
}