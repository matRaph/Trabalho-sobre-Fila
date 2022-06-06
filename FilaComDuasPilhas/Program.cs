// See https://aka.ms/new-console-template for more information

FilaComDuasPilhas.DoubleStackQueue Queue = new();

Queue.Enqueue(1);
Queue.Enqueue(2);
Queue.Enqueue(3);
Console.WriteLine(Queue.Dequeue());
Queue.Enqueue(4);
Queue.Enqueue(5);

Console.WriteLine(Queue.Dequeue());
Console.WriteLine(Queue.Dequeue());
