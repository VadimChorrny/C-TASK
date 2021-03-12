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
        public static bool operator !=(Vector one, Vector two)
        {
            return !(one == two);
        }
        public static bool operator ==(Vector one, Vector two)
        {
            if (Equals(one, two))
                return true;
            else if (one == null)
                return false;
            return one.Equals(two);
        }
        public static Vector operator ++(Vector vector)
        {
            return new Vector
            {
                x = vector.x + 1 ,
                y = vector.y + 1
            };
        }
        public static Vector operator --(Vector vector)
        {
            return new Vector
            {
                x = vector.x - 1 ,
                y = vector.y - 1
            };
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Vector vector = obj as Vector;
            if (vector == null)
            {
                return false;
            }
            return vector.Equals(vector);
        }
    }
}
