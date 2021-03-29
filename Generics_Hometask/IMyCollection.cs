using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Hometask
{
    interface IMyCollection<T>
    {
        int Count { get; }
        int Capacity { get; }
        void Clear();
        bool Contains(T item);
        bool Remove(T item);
        void Add(T element);
        void RemoveAt(int index);
        void Insert(int index, T element);

    }
}
