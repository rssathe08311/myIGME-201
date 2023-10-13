using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3
{
    //parent class MyClass
    public class MyClass
    {
        //field
        private string myString;

        //property with only a setter
        public string MyString
        {
            set
            {
                this.myString = value;
            }
        }

        //GetString method that works just like a getter
        public virtual string GetString()

        {
            return this.myString;
        }
    }

    //child class that overrides the GetString() method
    public class MyDerivedClass : MyClass
    {
        public override string GetString()

        {
            return base.GetString() + " (output from derived class)";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //instance of the myDerivedClass
            MyDerivedClass myDerivedClass = new MyDerivedClass();

            //prints method output to console
            Console.WriteLine(myDerivedClass.GetString());
        }
    }

    
}
