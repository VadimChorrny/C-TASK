using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Hometask
{
    class House
    {
        public Basement basement;
        public List<Walls> walls; // 4 walls
        public List<Window> window; // 4 windows
        public Roof roof;
        public Door door;
        
        public void RenderHouse()
        {
            // add if for roof
            string str = @"\n
                *
               * *
              * * *
             * * * *
             *     *
             *     *
             *     *
             *******
            \n";
        }

    }
}


// in build-classes add animation