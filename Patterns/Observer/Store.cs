public class Store
{
    private IPublisher publisher;
    private int iphoneCount = 0;

    public Store(IPublisher publisher)
    {
        this.publisher = publisher;
    }

    public void ReceiveiPhones(int quantity)
    {
        if (iphoneCount == 0 && quantity > 0)
            publisher.Notify("New iPhones received", StoreEvents.iPhonesInStock);

        iphoneCount += quantity;
    }

    public void SelliPhones(int quantity)
    {
        iphoneCount -= quantity;

        if (iphoneCount == 0)
            publisher.Notify("Sold out of iPhones", StoreEvents.iPhonesOutOfStock);
    }
}

public enum StoreEvents
{
    iPhonesInStock,
    iPhonesOutOfStock
}