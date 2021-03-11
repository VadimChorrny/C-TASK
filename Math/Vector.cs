using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class Vector
    {
        public int x { get; set; }
        public int y { get; set; }

        public Vector() { } // default

        public Vector(Point start, Point end)
        {
            x = end.x - start.x; y = end.y - start.y;
        }

        public override string ToString() => $"X = {x},\nY = {y}.";

        public static Vector operator +(Vector one, Vector two)
        {
            return new Vector
            {
                x = one.x + two.x,
                y = one.y + two.y
            };
        }
        public static Vector operator -(Vector one, Vector two)
        {
            return new Vector
            {
                x = one.x - two.x,
                y = one.y - two.y
            };
        }
        public static Vector operator *(Vector one, int num)
        {
            one.x *= num;
            one.y *= num;
            return one;
        }
    }
}
