public abstract class VehicleFactory
{
    public abstract IVehicle GetVehicle();

    public string MilesPerHour()
    {
        var vehicle = GetVehicle();
        return vehicle.Brag();
    }
}