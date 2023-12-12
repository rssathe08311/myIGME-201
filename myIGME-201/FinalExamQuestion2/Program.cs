using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQuestion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();

            //prints out the empty queue
            Console.WriteLine(myQueue.ToString());

            //populating the queue
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);

            //prints out the populated queue
            Console.WriteLine(myQueue.ToString());
            //prints out the index that was removed
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.ToString());
            //prints out the last index
            Console.WriteLine(myQueue.Peek());

            myQueue.Enqueue(5);
            //prints out the queue
            Console.WriteLine(myQueue.ToString());
        }
    }

    public class MyQueue
    {
        //global variable
        List<int> myQueue;

        //myStack constructor
        public MyQueue()
        {
            this.myQueue = new List<int>();
        }

        //method that lets you add to the queue from the back
        public void Enqueue(int x)
        {
            this.myQueue.Add(x);
        }

        //method that lets you remove and see the item at the front of the queue
        public int Dequeue()
        {
            int num = this.myQueue[0];
            this.myQueue.RemoveAt(0);

            return num;
        }

        //method that lets you see the item at the front of the queue
        public int Peek()
        {
            return this.myQueue[0];
        }

        //ToString method for queue that returns the queue's contents
        public override string ToString()
        {
            string str = "[";

            if (this.myQueue.Count == 0)
            {
                str += " ]";
            }
            else
            {
                for (int i = 0; i < this.myQueue.Count - 1; i++)
                {
                    str += this.myQueue[i] + ", ";
                }
                str += this.myQueue[this.myQueue.Count - 1] + "]";
            }

            return str;
        }
    }
}
