using System;
using System.Collections.Generic;
using System.Text;

namespace STD_Delegates_Hometask
{
    class Calculator
    {
        public Func<double,double> funcs = ;
        public  void Add(double x, double y) { Console.WriteLine($"x + y = {x + y}"); }
        public void Minus(double x, double y) { Console.WriteLine($"x + y = {x - y}"); }
        public double Calculate(double x, double y,Func<double,double> func)
        {
            double result = x + y;
            func(result);
            return result;
        }
    }
}
