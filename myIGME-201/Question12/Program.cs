using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //local variables
            string sName;
            double dSalary = 30000;
            bool gotSal;

            Console.WriteLine("What's your name? ");
            sName = Console.ReadLine();

            gotSal = GiveRaise(sName, ref dSalary);

            if (gotSal)
            {
                Console.WriteLine("Congratulations on the raise! Your salary is now: $" + dSalary);
            }
        }

        static bool GiveRaise(string name, ref double salary)
        {
            bool gotSal = false;
            name = name.ToLower();
            if(name == "reva")
            {
                salary += 19999.99;
                gotSal = true;
            }

            return gotSal;
        }

    }
}
