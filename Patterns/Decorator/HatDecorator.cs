public class SweaterDecorator : ClothesBaseDecorator
{
    public SweaterDecorator(Clothes outfit) : base(outfit)
    {
    }
    public override void Wear()
    {
        base.Wear();
        Console.WriteLine("and a nice sweater to go along with your blue shirt");
    }
}