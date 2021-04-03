﻿using System;
using System.Collections.Generic;
using System.Text;

namespace STD_Delegates_Hometask
{
    public delegate double OperationDelegate(double x, double y);
    public enum Operation { Add = 1, Minus }
    class Calculator
    {
        public Func<double> func;
        Operation operations;
        public void SetOperation(Operation operation) => this.operations = operation;
        public double Calculate(double x, double y)
        {
            if ((int)operations == 1) // зводимо до інта, щоб вибрати Add в enum
            {
                func = () => { return x + y; };
            }
            else if ((int)operations == 2)
            {
                func = () => { return x - y; };
            }
            return func.Invoke();
        }

    }
}
