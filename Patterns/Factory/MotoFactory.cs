public class MotoFactory : VehicleFactory
{
    public override IVehicle GetVehicle()
    {
        return new Motorcycle();
    }
}