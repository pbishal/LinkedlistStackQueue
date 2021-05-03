using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistStackQueue
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }

        /// <summary>
        /// Push elements into stack.
        /// </summary>
        /// <param name="value"></param>
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed into stack ", value);
        }

        /// <summary>
        /// Display method to display stack elements.
        /// </summary>
        public void DisplayStackElements()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
