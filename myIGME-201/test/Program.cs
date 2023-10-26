using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        public class MyClass
        {
            public int myInt;
            public MyClass(int nVal)
            {
                this.myInt += nVal;
                Console.WriteLine(this.myInt);
            }
        }
        static void Main(string[] args)
        {
            MyClass temp = new MyClass(34);
            Console.WriteLine(temp);
        }
    }
}
