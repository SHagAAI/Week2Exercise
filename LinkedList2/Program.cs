using LinkedList2;




CustomNode checkIsTail(CustomNode checkThisNode)
{
    if (checkThisNode.tail is not null)
    {
        return checkIsTail(checkThisNode.tail);
    }

    return checkThisNode;
}


void Appended(int val)
{
    if (CustomNode.head is null)
    {
        CustomNode.head = new CustomNode { myNum = val };
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    if (CustomNode.head.tail is null)
    {
        CustomNode.head.tail = new CustomNode { myNum = val, prev = CustomNode.head };
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    // recursive ?
    var theLast = checkIsTail(CustomNode.head.tail);
    theLast.tail = new CustomNode { myNum = val, prev = theLast };
    Console.WriteLine($"Appended [{val}]");
}

void Print()
{
    Console.Write("Sequence : ");
    PrintHelper(CustomNode.head);
    Console.WriteLine("");
}

void PrintHelper(CustomNode printThisNode)
{
    Console.Write($"{printThisNode.myNum}");
    if (printThisNode.tail is not null)
    {
        Console.Write(" -> ");
        PrintHelper(printThisNode.tail);
    }
    Console.WriteLine("");
}

void PrintReverse()
{
    if (CustomNode.head is not null)
    {
        
        CustomNode last = checkIsTail(CustomNode.head);
        PrintReverseHelper(last);
    } else
    {
        Console.Write($"{CustomNode.head!.myNum}");
    }

}

void PrintReverseHelper(CustomNode first)
{
    Console.Write("Reverse : ");
    Console.Write($"{first.myNum}");
    if (first.prev is not null)
    {
        Console.Write(" -> ");
        PrintReverseHelper(first.prev);
    }
}



Appended(245);
Appended(5);
Appended(6);
Appended(7);
Appended(2);
Print();

PrintReverse();