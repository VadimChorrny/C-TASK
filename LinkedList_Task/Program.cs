using System;
using System.Collections.Generic;

namespace LinkedList_Task
{
    class Program
    {
        class LinkedListDemo
        {
            public string Name { get; set; }
            public uint Age { get; set; }
        }
        static void Main(string[] args)
        {
            // for test
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddFirst(1);
            list.AddAfter(list.Last,4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            LinkedList<LinkedListDemo> persone = new LinkedList<LinkedListDemo>();
            persone.AddFirst(new LinkedListDemo() { Name = "Vasya", Age = 32 });
            persone.AddAfter(persone.Last, new LinkedListDemo() { Name = "Vadim", Age = 17 });
            persone.AddLast(new LinkedListDemo() { Name = "Tanya", Age = 24 });
            foreach (var item in persone)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Age);
            }
        }
    }
}
