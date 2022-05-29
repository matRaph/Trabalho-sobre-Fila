// See https://aka.ms/new-console-template for more information
PilhaEncadeada.Heap heap = new();

heap.Push(1);
Console.WriteLine(heap.Top());
heap.Push(2);
Console.WriteLine(heap.Top());
Console.WriteLine(heap.Pop());
heap.Push(3);
Console.WriteLine(heap.Top());
Console.WriteLine(heap.Pop());
Console.WriteLine(heap.Pop());
heap.Pop();