namespace MyQueue;

public class Node
{
    public int value { get; private set; }
    public Node next { get; set; }

    public Node(int value)
    {
        this.value = value;
        this.next = null;
    }

    public int GetValue()
    {
        return this.value;
    }

    public Node GetNext()
    {
        return this.next;
    }

    public void SetNext(Node next)
    {
        this.next = next;
    }
}