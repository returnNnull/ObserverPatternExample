namespace ObserverPatternExample;

public class ChatClient : IObserver
{
    public string DisplayName { get; }
    

    public ChatClient(string displayName)
    {
      
        DisplayName = displayName;
    }
    

    public void NotifyChange(Message message)
    {
        Console.WriteLine($"/////////Вид для:{DisplayName}///////");
        Console.WriteLine($"{message.Sender} написал: {message.Text} ");
        Console.WriteLine("////////////////////////////////////");
        Console.WriteLine();
    }
}