using System;
using System.Linq;
using System.Collections.Generic;

namespace String_
{
    class Program
    {
        static void RemoveSymbols(ref string line, params char[] arr)
        {
            foreach(var item in arr)
            {
                line = line.Replace(item, '\0');
            }
        }

        static void StatsLetters(string line)
        {
            char[] letter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[][] countLetter = new char[0][];
            int index = 0;
            foreach (var item in letter)
            {
                int count = line.Count((e) => e.Equals(item));
                if (count > 0)
                {
                    Array.Resize(ref countLetter, countLetter.Length + 1);
                    Array.Resize(ref countLetter[index], count);
                    countLetter[index][0] = item;
                    ++index;
                }
            }
            foreach (var item in countLetter)
            {

                Console.Write($"{item[0]} [{item.Length}]");
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string line = "Hello,world!";
            char[] del = { 'H', 'e', 'l','l', 'o', '!',',' }; // can ascii

            RemoveSymbols(ref line,del);
            Console.WriteLine(line);

            Console.WriteLine("---------");
            StatsLetters("C# - best programming language!");
        }
    }
}
