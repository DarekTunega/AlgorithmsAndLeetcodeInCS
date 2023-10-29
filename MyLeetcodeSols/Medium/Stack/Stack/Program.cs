public class MinStack
{
    private Stack<int> _stack;
    private Stack<int> _minStack;

    public MinStack()
    {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        _stack.Push(val);

        if (_minStack.Count == 0 || val <= _minStack.Peek())
        {
            _minStack.Push(val);
        }
    }

    public void Pop()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int poppedValue = _stack.Pop();
        if (poppedValue == _minStack.Peek())
        {
            _minStack.Pop();
        }
    }

    public int Top()
    {
        if (_stack.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return _stack.Peek();
    }

    public int GetMin()
    {
        if (_minStack.Count == 0)
        {
            throw new InvalidOperationException("MinStack is empty");
        }
        return _minStack.Peek();
    }
}