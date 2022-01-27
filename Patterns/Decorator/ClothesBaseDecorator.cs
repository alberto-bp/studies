public class ClothesBaseDecorator : Clothes
{
    protected Clothes newOutfit;
    public ClothesBaseDecorator(Clothes outfit)
    {
        this.newOutfit = outfit;
    }

    public override void Wear()
    {
        newOutfit.Wear();
    }
}
