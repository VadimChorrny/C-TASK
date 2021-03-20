using System;

namespace Interface_Hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader leader = new TeamLeader("Vasil");
            Team team = new Team(leader);
            House house = new House();
            Worker worker = new Worker("Katya");
            team.workers.Add(worker);
            Console.WriteLine(worker);
            foreach (var item in team.workers)
            {
                Console.WriteLine(item);
            }
            worker.BuildHouse(house,leader);
            foreach (var item in leader.message)
            {
                Console.WriteLine(item);
            }
            house.RenderHouse();

        }
    }
}
