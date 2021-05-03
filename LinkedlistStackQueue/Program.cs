﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linkedlist stack and queue problem");
            
            Stack stackOBJ = new Stack();
            AbilityToEnQueueInQueue queueOBJ = new AbilityToEnQueueInQueue();

            //Pushing(adding) elements one by one.
            //Top elements will be 50.
            stackOBJ.Push(70);
            stackOBJ.Push(30);
            stackOBJ.Push(56);

            //Displaying stack.
            stackOBJ.DisplayStackElements();

            Console.WriteLine();
            stackOBJ.Peek();
            stackOBJ.Pop();
            stackOBJ.IsEmpty();
            stackOBJ.DisplayStackElements();

            //Queue operations
            queueOBJ.Enqueue(44);
            queueOBJ.Enqueue(440);
            queueOBJ.Enqueue(344);
            queueOBJ.Enqueue(333);
            queueOBJ.Enqueue(12);
            queueOBJ.Display();

            queueOBJ.Dequeue();
            queueOBJ.Display();

            Console.ReadLine();

        }
    }
}
