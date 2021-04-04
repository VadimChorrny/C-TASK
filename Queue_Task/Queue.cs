using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue_Task
{
    interface IQueue<T>
    {
        void Add(T elem);
        T Extract();
        T Top();
        uint Size { get; }
    }
    class Node<T>
    {
        public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node<T> Next { get; set; }
    }
    class Queue<T> : IEnumerable<T>, IQueue<T>
    {
        Node<T> head;
        Node<T> tail;
        public uint Size{ get; set; }

        public void Add(T elem)
        {
            Node<T> node = new Node<T>(elem);
            Node<T> tmpNode = tail;
            tail = node;
            if (Size == 0)
            {
                head = tail;
            }
            else
            {
                tmpNode.Next = tail;
            }
            Size++;
        }

        public T Extract()
        {
            if (Size == 0)
            {
                Console.WriteLine("error ! count = 0");
            }
            T output = head.Data;
            head = head.Next;
            Size--;
            return output;
        }


        public T Top()
        {
            return head.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();

        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = head;
            while (curr != null)
            {
                yield return curr.Data;
                curr = curr.Next;
            }
        }
    }
}
