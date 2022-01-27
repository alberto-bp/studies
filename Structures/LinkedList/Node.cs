public class Node
{
    public int value;
    public Node? Next { get; set; }
    public Node(int val)
    {
        this.value = val;
    }
}