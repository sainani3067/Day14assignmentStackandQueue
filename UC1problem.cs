using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Stack_Queueproblems
{
    class UC1problem
    {

        private Node top;
        public UC1_CreateStack()
        {
            this.top = null;
        }
        internal void Push(int Value)
        {
            Node node = new Node(Value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} inserted into Stack", Value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.next;
            }
        }
    }
}
   
