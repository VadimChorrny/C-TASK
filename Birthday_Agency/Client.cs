using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Birthday_Agency
{
    class Client
    {
        private string name;
        private int number;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Number
        {
            get => number;
            set
            {
                if (value >= 12)
                {
                    this.number = value;
                }
                else
                {
                    Console.WriteLine("error number!");
                }
            }
        }
        public Client(String Name,int Number)
        {
            this.Name = Name;
            this.Number = Number;
        }

        public override string ToString() => $"Name {Name}\nNumber {number}";
    }
}
