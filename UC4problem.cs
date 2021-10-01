using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Stack_Queueproblems
{
    class UC4problem
    {
        Node head = null;

        public object Data { get; private set; }

        internal void Enqueue(int data)
        {
            Node node = new Node(Data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.Data);
        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("\nQueue is Empty");
            }
            else
            {
                Console.Write("\n{0} Dequeued For Queue", head.Data);
                head = (Node)head.next;
            }
        }
        internal void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = (Node)temp.next;
            }
        }
    }
}

