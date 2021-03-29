using System;

namespace STD_Delegates_Hometask
{
    class Program
    {
        static void Add(int x, int y) { Console.WriteLine($"x + y = {x + y}"); }
        static void Minus(int x, int y) { Console.WriteLine($"x - y = {x - y}"); }
        static double Calculate(double x, double y, Func<double, double> func)
        {
            double result = x + y;
            func(result);
            return result;
        }
        static void Main(string[] args)
        {
            Func<double, double> func;
        }
    }
}
