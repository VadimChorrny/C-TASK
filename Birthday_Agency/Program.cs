using System;

namespace Birthday_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
           // DateTime time = new DateTime();
            //Client clients = new Client("Petro", 996434323);
            //Event events = new Event(clients,"Birthday", "Aquapark", 16,time);
            //Event events_ = new Event(clients,"Party", "Dance Cluv", 20,time);
            //events.AddEvent(events_);
            //events.AddDays(100);
            //Console.WriteLine(events);
            ////events.RemoveEvent(0);
            //events.Render();

            
            Event events = new Event(new Client("Ivan",1234567891),"New Year","Club",16, new DateTime(2021,03,11));
            events.AddDays(69);
            events.AddYear(2020);
            Console.WriteLine(events);

        }
    }   
}
