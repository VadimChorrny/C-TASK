using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{
    class Team : IWorker
    {
        String NameTeam { get; }

        string IWorker.Name => NameTeam;
        public TeamLeader leader;
        public List<Worker> workers;
        public Team(TeamLeader leader)
        {
            this.leader = leader;
            workers = new List<Worker> { new Worker("Ivan"), new Worker("Vasya"), new Worker("Andrii") };
        }
    }
}
