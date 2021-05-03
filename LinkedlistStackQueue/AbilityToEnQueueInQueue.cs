using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistStackQueue
{
    class AbilityToEnQueueInQueue
    {
        Node head = null;

        /// <summary>
        /// Inserting elements in queue -----> FIFO order.
        /// </summary>
        /// <param name="data"></param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into queue. ", node.data);
        }

        /// <summary>
        /// Display queue elements.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty!!!");
                return;
            }
            while (temp != null)
            {
                Console.Write("Queue elements are : " + temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
