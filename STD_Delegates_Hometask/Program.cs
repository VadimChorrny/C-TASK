using System;

namespace STD_Delegates_Hometask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.SetOperation(Operation.Minus);
            Console.WriteLine(calculator.Calculate(10,1));
            Console.WriteLine(calculator.Calculate(51,13.4));
        }
    }
}
