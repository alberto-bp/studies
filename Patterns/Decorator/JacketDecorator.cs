public class JacketDecorator : ClothesBaseDecorator
{
    public JacketDecorator(Clothes outfit) : base(outfit)
    {
    }
    public override void Wear()
    {
        base.Wear();
        Console.WriteLine("and a leather jacket to go along with your sweater");
    }
}