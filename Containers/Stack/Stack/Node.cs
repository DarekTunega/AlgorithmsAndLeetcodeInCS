namespace MyStack;

public class Node
{
    public int value { get; private set; }
    public Node next{ get;  set; }
    public Node(int value)
    {
        this.value = value;
        
    }
}

