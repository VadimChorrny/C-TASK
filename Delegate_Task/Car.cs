using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_Task
{
    public class Mess
    {
        public string message { get; set; }
    }
    public abstract class Car
    {
        public delegate void Start(string message);
        public delegate void End(string message);
        public delegate string Notify(string message);
        string name;
        public String Name { get => name; set { name = value; } }
        public event  Notify Message ;
        public readonly byte Way = 100;
        private ushort speed;
        public ushort Speed
        {
            get => speed;
            set
            {
                speed = value;
                if(value < Way)
                {
                    Drive();
                    Message?.Invoke($"Update speed {value}");
                }
                else if ( value >= Way)
                {
                    Message += Winner;
                }
            }
        }
        public string Winner(string name) => $"{name} finished!";

        public readonly byte Finish = 100;
        public Car(string name)
        {
            this.Name = name;
        }
        
        public void Drive()
        {
            Speed = (ushort)new Random().Next(0, 250);
            Message?.Invoke($"Go to speed {Speed}");
        }
        public void SlowDown()
        {
            if(Speed > 1)
            {
                Speed -= 1;
            }
            else
            {
                Message?.Invoke($"You stand in place!\n{Speed}" +
                    $" - speed {Name}");
            }
        }

    }

    public class SuperCar : Car
    {
        public SuperCar(string name) : base(name){}
        public void Go()
        {
            Drive();
        }
    }
    public class Bus : Car
    {
        public Bus(string name) : base(name)
        { }
        public void Go()
        {
            Drive();
        }

    }
    public class Freight : Car
    {
        public Freight(string name) : base(name)
        { }
        public void Go()
        {
            Drive();
        }

    }



}
