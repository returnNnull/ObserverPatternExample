namespace ObserverPatternExample;

public interface IObservable
{
    
    void Add(IObserver o);
    void Remove(IObserver o);
    void NotifyAll();
}