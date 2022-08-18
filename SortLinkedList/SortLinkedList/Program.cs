// See https://aka.ms/new-console-template for more information
using SortLinkedList;

Console.WriteLine("Hello, World!");
Operation x = new Operation();

x.Enqueue(1);
x.Enqueue(2);
x.Enqueue(2);
x.Enqueue(1);
x.Enqueue(8);

x.SortLinkedList(true);


x.Print();
