using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment4
{
    public class Node<T> { 
    public Node<T> Next { get; set; }
        public T Data { get; set; }
    public Node( T data)
        {
            Next = null;
            Data = data;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            this.head = null;
            this.tail = null;
        }
        public GenericList(params T[] values)
        {
            Node<T> tail = null;
            foreach (T t in values)
            {
                Node<T> newNode = new Node<T>(t);
                if (head == null)
                {
                    head = newNode;  
                    tail = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    tail = newNode;      
                }
            }
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            if(tail == null)
            {
                tail = head = new Node<T>(t);
                return;
            }
            tail.Next = new Node<T>(t);
            tail = tail.Next;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> temp = head;
            while (temp != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
        }
    }

}
