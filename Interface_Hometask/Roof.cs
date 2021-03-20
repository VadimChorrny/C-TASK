using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{
    enum TypeRoof { Thatched, Stone, Cement,Pitched};
    class Roof : IPart
    {
        public TypeRoof roof;
        public Roof(TypeRoof roof)
        {
            this.roof = roof;
        }
        public void Work(House house)
        {
            house.roof = new Roof(new TypeRoof());
        }
    }
}
