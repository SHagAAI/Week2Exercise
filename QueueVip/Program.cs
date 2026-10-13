
List<char> queue = [];
void Enqueue(char element)
{
    Console.WriteLine($"Queued {element}");
    queue.Add(element);
}

void Process()
{
    if (queue.Count == 0)
    {
        Console.WriteLine("Queue is empty");
        return;
    }

    Console.WriteLine($"Processed {queue[0]}");
    queue.RemoveAt(0);
}

void EnqueueVip(char element)
{
    List<char> templist = [element, .. queue];
    queue = [.. templist];
    Console.WriteLine($"VIP Queued [{element}]");
    templist = [];

}

Enqueue('A');
Enqueue('B');
EnqueueVip('a');
Process();
Process();