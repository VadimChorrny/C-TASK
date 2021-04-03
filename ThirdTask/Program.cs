using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ThirdTask
{

    class Auto : IEquatable<Auto>
    {
        public string Brand { get; set; }

        public bool Equals([AllowNull] Auto other)
        {
            return this.Brand == other.Brand;
        }

        public IEnumerator GetEnumerator()
        {
            return Brand.GetEnumerator();
        }

        public override int GetHashCode()
        {
            if (Brand != null)
            {
                return Brand.GetHashCode();
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            HashSet<Auto> hs = new HashSet<Auto>();
            hs.Add(new Auto() { Brand = "Ferrari" });
            hs.Add(new Auto() { Brand = "KIA" });
            hs.Add(new Auto() { Brand = "Toyota" });
            hs.Add(new Auto() { Brand = "Bentley" });
            hs.Add(new Auto() { Brand = "Fiat" });
            hs.Add(new Auto() { Brand = null });

            HashSet<Auto> hs1 = new HashSet<Auto>();
            hs1.Add(new Auto() {Brand = "Motor" });
            hs1.Add(new Auto() {Brand = "Toyota" });//
            hs1.Add(new Auto() {Brand = "Bentley" });//
            hs1.Add(new Auto() { Brand = "Ferrari" }); //


            // IntersectWith()


            hs.IntersectWith(hs1);
            Console.WriteLine("----0----");
            foreach (var item in hs)
            {
                Console.WriteLine(item.Brand);
            }

            // Union()

            Console.WriteLine("----1----");
            hs.UnionWith(hs1);
            foreach (var item in hs)
            {
                Console.WriteLine(item.Brand);
            }
            
            // ExceptWith()

            Console.WriteLine("----2----");
            hs.ExceptWith(hs1);
            foreach (var item in hs)
            {
                Console.WriteLine(item.Brand);
            }

            // RemoveWhere()

            Console.WriteLine("----3----");
            hs.RemoveWhere(isExist);
            foreach (var item in hs)
            {
                Console.WriteLine(item.Brand);
            }

            bool isExist(Auto auto)
            {
                return auto.Brand == null;
            }
        }
    }
}
