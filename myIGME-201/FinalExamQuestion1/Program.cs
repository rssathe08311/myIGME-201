using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamQuestion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack();

            //prints out the empty stack
            Console.WriteLine(myStack.ToString());

            //populating the stack
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            //prints out the populated stack
            Console.WriteLine(myStack.ToString());
            //prints out the index that was removed
            Console.WriteLine(myStack.Pop());
            //prints out the last index
            Console.WriteLine(myStack.Peek());
        }
    }

   public class MyStack
    {
        //global variable
        List<int> myStack;

        //myStack constructor
        public MyStack() { 
            this.myStack = new List<int>();
        }

        //method that lets you add to the stack from the top
        public void Push(int x)
        {
            this.myStack.Add(x);
        }

        //method that lets you remove and see the item at the top of the stack
        public int Pop()
        {
            int num = this.myStack[this.myStack.Count - 1];
            this.myStack.RemoveAt(myStack.Count - 1);

            return num;
        }

        //method that lets you see the item at the top of the stack
        public int Peek()
        {
            return this.myStack[this.myStack.Count - 1];
        }

        //ToString method for stack that returns the stack's contents
        public override string ToString()
        {
            string str = "[";

            if(this.myStack.Count == 0)
            {
                str += " ]";
            }
            else
            {
                for (int i = 0; i < this.myStack.Count - 1; i++)
                {
                    str += this.myStack[i] + ", ";
                }
                str += this.myStack[this.myStack.Count - 1] + "]";
            }

            return str;
        }
    }
}
