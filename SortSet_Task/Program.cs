using System;
using System.Collections.Generic;

namespace SortSet_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();

            set.Add(1);
            set.Add(3);
            set.Add(5);
            set.Add(6);
            set.Add(4);
            set.Add(2);
            set.Add(7);

            set.Remove(1);
            set.Remove(5);
            
            if(set.Contains(3) == true)
            {
                Console.WriteLine("Element is exist!");
            }
            else
            {
                Console.WriteLine("Element don't exist!");
            }

            // for output
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
