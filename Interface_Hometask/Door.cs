using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{
    enum DoorType { Glasses, Iron, Wooden, Profile };

    class Door : IPart
    {
        public DoorType door;
        public Door(DoorType type)
        {
            this.door = type;
        }
        public void Work(House house)
        {
            house.door = new Door(new DoorType());
        }


    }
}
