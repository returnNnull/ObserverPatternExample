namespace ObserverPatternExample;

public interface IObserver
{
    void NotifyChange(Message message);
}