namespace MyStack;

public class Stack
{
    public int size { get; private set; }
    public Node first { get; private set; }

    public Stack()
    {
        this.first = null;
        this.size = 0;
    }

    public void Push(int v)
    {
        Node n = new Node(v);
        Node currentFirst = this.first;
        this.first = n;
        n.next = currentFirst;
        this.size++;
    }

    public int Pop()
    {
        if(this.first == null) throw new Exception("Řada je prazdna");
        int value = this.first.value;
        this.first = this.first.next;
        this.size--;
        return value;
    }

    public int Top()
    {
        if(this.first == null) throw new Exception("Řada je prazdna");
        return this.first.value;
    }

    public int GetSize()
    {
        return this.size;
    }

    public new string ToString()
    {
        string str = "";
        Node current = this.first;
        for (int i = 0; i < this.size; i++)
        {
            str += current.value + " , ";
            current = current.next;
        }

        return str;
    }
}