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
            Console.WriteLine("Stack Is Empty.");
        }

        /// <summary>
        /// Peek method will return top element from stack.
        /// </summary>
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty!!!");
                return;
            }
            Console.WriteLine("{0} is a TOP elements of the stack ", this.top.data);
        }

        /// <summary>
        /// Pop method will delete top element from thre stack.
        /// </summary>
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty...You can not delete.(Underflow condition)");
                return;
            }
            Console.WriteLine("Elements popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        /// <summary>
        /// Peek and pop till stack is empty.
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            //this.top=null;
        }
    }
}
