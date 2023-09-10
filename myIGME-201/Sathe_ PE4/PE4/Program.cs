using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers, both cannot be over 10 though.");
            string s_val1 = Console.ReadLine();
            string s_val2 = Console.ReadLine();

            int val1 = int.Parse(s_val1);
            int val2 = int.Parse(s_val2);

            if (((val1 > 10) || (val2 > 10)) && !((val1 > 10) && (val2 > 10)))
            {
                //idk have to check what the output should be
                Console.WriteLine("You submitted: " + val1 + " and " + val2);
            }
            else if((val1 < 10) && (val2 < 10)){
                Console.WriteLine("You submitted: " + val1 + " and " + val2);
            }
            else
            {
                Console.WriteLine("Enter two new integers");
                s_val1 = Console.ReadLine();
                s_val2 = Console.ReadLine();
            }
        }
    }
}
