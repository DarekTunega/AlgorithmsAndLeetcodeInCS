namespace MyQueue;

public class Queue
{
    private Node first;
    private Node last;
    private int size;

    public Queue()
    {
        first = null;
        last = null;
        size = 0;
    }

    public void AddLast(int i)
    {
        Node n = new Node(i);
        if (size == 0)
        {
            first = n;
            last = n;
        }
        else
        {
            last.next = n;
            last = n;
        }
        size++;
    }

    public int RemoveFirst()
    {
        if (size == 0)
        {
            throw new Exception("Fronta je prazdna");
        }

        int value = first.value;
        first = first.next;
        size--;
        return value;
    }

    public int GetFirst()
    {
        if (size == 0)
        {
            throw new Exception("Fronta je prazdna");
        }
        return first.value;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public int NumberOfElements()
    {
        return size;
    }

    public override string ToString()
    {
        string result = "";
        Node current = first;
        for (int i = 0; i < size; i++)
        {
            result += current.value + ", ";
            current = current.next;
        }
        return result;
    }
}
