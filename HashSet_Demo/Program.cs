using System;
using System.Collections.Generic;

namespace HashSet_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Latte");
            hs.Add("Cold Latte");
            hs.Add("Tea");
            hs.Add("Water");

            hs.Remove("Tea");
            // output
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            //hs.Clear();
            HashSet<string> hsuniq = new HashSet<string>();
            hsuniq.Add("Americano"); // add in hs
            hsuniq.Add("Cold Latte");
            hsuniq.Add("Coca-Cola"); // add in hs
            hsuniq.Add("Water");

            hs.UnionWith(hsuniq);

            Console.WriteLine("____________");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("~~~~~~~~~~~~");
            hs.IntersectWith(hsuniq);
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("............");
            hs.ExceptWith(hsuniq);
            foreach (var item in hs)
            {
                Console.WriteLine(item); // clean
            }
            
            HashSet<int> hs1 = new HashSet<int>();
            hs1.Add(1);
            hs1.Add(3);
            hs1.Add(2);
            hs1.Add(5);
            hs1.Add(4);
            hs1.Add(7);
            hs1.Add(6);
            Console.WriteLine("**********");
            foreach (var item in hs1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
