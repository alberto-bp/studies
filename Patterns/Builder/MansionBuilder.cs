public class MansionBuilder : Builder
{
    private Mansion mansion;

    public MansionBuilder()
    {
        mansion = new Mansion();
    }

    public Mansion GetResult()
    {
        return mansion;
    }

    public void Reset()
    {
        this.mansion = new Mansion();
    }

    public void SetDoors()
    {
        Console.WriteLine("Installing Doors");
    }

    public void SetRoof()
    {
        Console.WriteLine("Installing Roof");
    }

    public void SetWalls()
    {
        Console.WriteLine("Installing Walls");
    }

    public void SetWindows()
    {
        Console.WriteLine("Installing Windows");
    }
}