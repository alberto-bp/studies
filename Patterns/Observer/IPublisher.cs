public interface IPublisher
{
    public void Subscribe(ISubscriber subscriber);
    public void Unsubscribe(ISubscriber subscriber);
    public void Notify(string message, StoreEvents eventType);
}