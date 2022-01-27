public class StorePublisher : IPublisher
{
    private List<ISubscriber> subscribers = new();
    public void Notify(string message, StoreEvents eventType)
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(message, eventType);
        }
    }

    public void Subscribe(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void Unsubscribe(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
    }
}