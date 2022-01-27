public class Director
{
    private Builder builder;

    public Director(Builder builder)
    {
        this.builder = builder;
    }

    public void ChangeBuilder(Builder builder)
    {
        this.builder = builder;
    }

    public void BuildHouse()
    {
        builder.Reset();
        builder.SetDoors();
        builder.SetRoof();
        builder.SetWalls();
        builder.SetWindows();
    }

    public void BuildMansion()
    {
        builder.Reset();
        builder.SetDoors();
        builder.SetRoof();
        builder.SetWalls();
        builder.SetWindows();
    }
}