namespace ObserverPatternExample;

public class Chat: IObservable
{
    private readonly List<Message> _messages = new ();
    private readonly List<IObserver> _observers = new();

    public delegate void MessageDelegate(Message message);

    public event MessageDelegate NewMessageEvent;
    
    public void SendMessage(Message message)
    {
        _messages.Add(message);
        NotifyAll();
        NewMessageEvent(message);
    }
    
    
    public void Add(IObserver o)
    {
       _observers.Add(o);
    }

    public void Remove(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyAll()
    {
        var size = _messages.Count;
        foreach (var variable in _observers)
        {
           variable.NotifyChange(_messages[size - 1]);
        }
    }
}