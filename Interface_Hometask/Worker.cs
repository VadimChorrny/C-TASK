using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{

    interface IBuilder
    {
        void BuildHouse(House house, TeamLeader leader);
    }

    class Worker : IWorker,IBuilder
    {
        private String Name { get; set; }
        String IWorker.Name => Name;
        public readonly uint ID;
        public static uint Counter;
        public Worker(String name)
        {
            this.Name = name;
            ID = ++Counter;
        }

        public void BuildHouse(House house, TeamLeader leader)
        {
            if (house.basement == null) // clean
            {
                Basement basement = new Basement();
                basement.Work(house);
                leader.message.Add($"Worker {Name} create basement...");
            }
            if (house.door == null)
            {
                Door door = new Door(DoorType.Glasses);
                door.Work(house);
                leader.message.Add($"Worker {Name} create door...");

            }
            if (house.walls == null)
            {
                house.walls = new List<Walls>();
                Walls walls_ = new Walls();
                walls_.Work(house);
                leader.message.Add($"Worker {Name} create walls...");

            }
            if (house.window == null)
            {
                house.window = new List<Window>();
                Window window_ = new Window(TypeWindow.Regtangle);
                window_.Work(house);
                leader.message.Add($"Worker {Name} create window...");
            }
            if (house.roof == null)
            {
                Roof roof = new Roof(TypeRoof.Cement);
                roof.Work(house);
                leader.message.Add($"Worker {Name} create roof...");
            }
        }
        public override string ToString()
        {
            return $"ID worker {ID}\n" +
                $"Name worker {Name}";
        }
    }
}
