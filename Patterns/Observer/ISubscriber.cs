public interface ISubscriber
{
    void Update(string context, StoreEvents eventType);
}