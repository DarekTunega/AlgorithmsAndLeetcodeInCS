using MyStack;

Stack stack = new Stack();
stack.Push(10);
stack.Push(30);
Console.WriteLine(stack.GetSize());
Console.WriteLine(stack.Top());
Console.WriteLine(stack.ToString());
stack.Pop();
Console.WriteLine(stack.Top());

