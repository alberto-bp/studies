public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving with my four wheels");
    }

    public string Brag()
    {
        return "I can go 100 miles per hour";
    }
}