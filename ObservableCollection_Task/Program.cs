using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // create freelancer
            Freelancer freelancer = new Freelancer()
            {
                Name = "Rick",
                Age = 32,
                Technology = "C# .NET WinForms/WPF"
            };
            Task task = new Task()
            {
                NameTask = "Make Desktop app",
                NeedTechnology = "C# .NET WinForms/WPF"
            };
            FreeLanceJobs jobs = new FreeLanceJobs();

            //Console.WriteLine(freelancer);

            // output freelancer
            jobs.RenderAllFreelancer();

        }
    }
    class Freelancer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Technology { get; set; }
        public bool isWork = false; // checks if he has a job
        public Freelancer() { }
        public Freelancer(string name, int age, string tech, bool work)
        {
            this.Name = name;
            this.Age = age;
            this.Technology = tech;
            this.isWork = work;
        }
        public void Freelance_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Freelancer newFreelancer = e.NewItems[0] as Freelancer;
                    Console.WriteLine($"Has been added new freelancer : {newFreelancer.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Freelancer oldFreelancer = e.OldItems[0] as Freelancer;
                    Console.WriteLine($"Has been remove freelancer : {oldFreelancer.Name}");
                    break;
            }
        }
        public override string ToString()
        {
            return $"___FREELANCER___\n" +
                $"Name : {Name}\n" +
                $"Age  : {Age}\n" +
                $"Technology : {Technology}\n" +
                $"Is Work : {isWork}";
        }
    }
    class Task
    {
        public string NameTask { get; set; }
        public string NeedTechnology { get; set; }
        public Task()
        {

        }
        public Task(string name, string tech)
        {
            this.NameTask = name;
            this.NeedTechnology = tech;
        }
    }

    class FreeLanceJobs
    {
        public List<Task> tasks = new List<Task>();
        private Freelancer freelancer1 = new Freelancer();
        public ObservableCollection<Freelancer> worker = new ObservableCollection<Freelancer>();
        public void AddTask(Task @task)
        {
            if (freelancer1.Technology == task.NeedTechnology)
            {
                tasks.Add(task);
            }
            else
            {
                Console.WriteLine("Error!\nTechnologies do not match!");
            }
        }
        public void RemoveTask(Task @task)
        {
            tasks.Remove(task);
        }
        public void AddFreelancer(Freelancer freelancer)
        {
            worker.Add(freelancer);
            freelancer.isWork = true;
        }
        public void RemoveFreelancer(Freelancer freelancer)
        {
            worker.Remove(freelancer);
            freelancer.isWork = false;
        }
        public void RenderAllFreelancer()
        {
            foreach (var item in worker)
            {
                Console.WriteLine(item);
            }
        } // no need

    }

}
