using System;
using System.Collections.Generic;
using System.Threading;

namespace Delegate_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus("Bogdan");
            Freight freight = new Freight("VW Transporter");
            SuperCar super = new SuperCar("Ferrari");

            super.Go();
            bus.Go();
            freight.Go();
            

        }
    }
}
