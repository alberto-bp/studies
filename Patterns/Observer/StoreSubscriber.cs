public class StoreSubscriber : ISubscriber
{
    public void Update(string context, StoreEvents eventType)
    {
        Console.WriteLine(context);
        
        if (eventType is StoreEvents.iPhonesInStock)
        {
            Console.WriteLine("Gotta go buy my new iPhone");
        }
        else if (eventType is StoreEvents.iPhonesOutOfStock)
        {
            Console.WriteLine("Damn son, missed my chance, gotta wait.");
        }
    }
}