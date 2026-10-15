using Stack2;

List<string> myStack = [];

void Type(string text)
{
    if (myStack.Count == 3)
    {
        myStack.RemoveAt(0);
        myStack.Add(text);
        Console.WriteLine($"Dropped bottom, Typed [{text}]");
        return;
    }
    Console.WriteLine($"Typed [{text}] ");
    myStack.Add(text);
}

void Undo()
{

    if (myStack.Count != 0)
    {

        var text = myStack[myStack.Count - 1];
        myStack.RemoveAt(myStack.Count - 1);
        Console.WriteLine($"Undid [{text}] ");
        return;
    }

    Console.WriteLine("Stack Empty ");
}


Type("foo");
Type("bar");
Type("stranger");
Type("things");

Undo();
Undo();
Undo();

Type("Superman");
Undo();
