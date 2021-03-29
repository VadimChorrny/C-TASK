using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Hometask
{
    interface IMyList<T>
    {
        T this[int index] { get; set; }
        int IndexOf(T item);
        void Insert(int index, T item);
        void RemoveAt(int index);
    }
}
