﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{
    class TeamLeader : IWorker
    {
        public string NameLeader { get; }
        public string Name => NameLeader;
        public List<String> message = new List<String>();
        public TeamLeader(String name)
        {
            this.NameLeader = name;
        }
    }
}
