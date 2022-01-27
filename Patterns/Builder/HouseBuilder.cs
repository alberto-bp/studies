public class HouseBuilder : Builder
{
    private House house;

    public HouseBuilder()
    {
        house = new House();
    }

    public House GetResult()
    {
        return house;
    }

    public void Reset()
    {
        this.house = new House();
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