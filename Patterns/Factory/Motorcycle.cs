public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Two wheel drive passing by");
    }

    public string Brag()
    {
        return "I can go 80 miles per hour";
    }
}