public class GamingTechFactory : ITechFactory
{
    public IComputer CreateComputer()
    {
        return new GamingComputer();
    }

    public IMouse CreateMouse()
    {
        return new GamingMouse();
    }
}