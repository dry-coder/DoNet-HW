using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Node<T>
    {
        public  Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public delegate void Action<T>(T n);
    public class List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public List() { head = null; tail = null; }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if(tail== null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }
}
