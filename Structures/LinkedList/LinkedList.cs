class LinkedList
{
    public Node? Head { get; set; }

    public int Length()
    {
        int count = 0;

        var temp = this.Head;

        while(temp != null)
        {
            temp = temp!.Next;
            count++;
        }

        return count;
    }

    public void Print()
    {
        var temp = this.Head;

        while(temp != null)
        {
            Console.WriteLine($"{temp!.value}");
            temp = temp.Next;
        }
    }

    public void AddToEnd(Node newNode)
    {
        var temp = this.Head!;

        while(temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
    }

    public void AddToStart(Node newNode)
    {
        newNode.Next = this.Head;
        this.Head = newNode;
    }

    public void AddToPosition(Node newNode, int position)
    {
        if(position <= 1) 
        {
            AddToStart(newNode);
            return;
        }

        var temp = this.Head;

        for (int i = 2; i < position; i++)
        {
            temp = temp!.Next;
        }

        newNode.Next = temp!.Next;
        temp!.Next = newNode;
    }

    public void DeleteAt(int position)
    {
        if (this.Length() <= 0 || position > this.Length()) { return; }
        
        if (position <= 1)
        {
            this.Head = this.Head!.Next;
            return;
        }

        var temp = this.Head;
        for (int i = 2; i < position; i++)
        {
            temp = temp!.Next;
        }

        temp!.Next = temp!.Next!.Next;
    }
}