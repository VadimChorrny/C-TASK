using System;
using System.Collections.Generic;
using System.Text;

namespace Birthday_Agency
{
    class Event
    {
        public String Name { get; set; }
        public String Place { get; set; }
        public int CountPeople { get; set; }
        private DateTime date = new DateTime();
        public readonly uint ID;
        private static uint Count = 0;
        private List<Event> notepad = new List<Event>();
        //static Event()
        //{
        //    Count = Count /*(uint)new Random().Next(1, 1000)*/;
        //}
        public Event(Client client,String Name,String Place,int CountPeople,DateTime date)
        {
            this.Name = Name;
            this.Place = Place;
            this.CountPeople = CountPeople;
            ID = Count++;
            this.date = date;
        }

        public override string ToString() => $"ID {ID}\nName event {Name}\nPlace {Place}\nCount people {CountPeople}\nDate {date}";

        public void AddEvent(Event @event)
        {
            notepad.Add(@event);
        }

        public void RemoveEvent(int id)
        {
            notepad.RemoveAt(id);
        }

        public void AddDays(int day)
        {
            date.AddDays(day);
        }

        public void AddWeek(int week)
        {
            // output int days
            date.AddDays(week * 7);
        }

        public void Render()
        {
            foreach (var item in notepad)
            {
                Console.WriteLine(item);
            }
        }
    }
}
