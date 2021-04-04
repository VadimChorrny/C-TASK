using System;

namespace Queue_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            q.Add(5);
            q.Add(6);
            q.Add(7);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Extract();

            Console.WriteLine("After remove");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"First element - {q.Top()}");

            Console.WriteLine($"All size collection - {q.Size}");
        }
    }
}
