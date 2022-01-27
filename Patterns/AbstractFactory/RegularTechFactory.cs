public class RegularTechFactory : ITechFactory
{
    public IComputer CreateComputer()
    {
        return new RegularComputer();
    }

    public IMouse CreateMouse()
    {
        return new RegularMouse();
    }
}