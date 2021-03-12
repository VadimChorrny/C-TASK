using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Point start = new Point { x = 1 };
            Point end = new Point { y = 2 };
            Point s = new Point { x = 2 };
            Point e = new Point { y = 4 };

            Vector vector = new Vector(start,end);
            Vector vector1 = new Vector(s,e);
            vector++;
            Vector res = vector + vector1;

            Console.WriteLine($"Vector :\n{vector}");
            Console.WriteLine($"Vector1 :\n{vector1}");
            Console.WriteLine($"Result - vector + vector1 = {res}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Hash-Code vector :\n{vector.GetHashCode()}");
            Console.WriteLine($"Hash-Code vecto1r :\n{vector1.GetHashCode()}");
            Console.WriteLine($"Hash-Code result :\n{res.GetHashCode()}");

        }
    }
}
