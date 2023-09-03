using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    //Debugging: Reva Sathe
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //This is a syntax error as the code is not able to run due to a missing semi-colon and it uses the same variable name as the loop iterator
            int counter = 0;

            //the string will be initailized here so everything inside of Main can access it
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (int i = 1; i <= 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null;

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");
                //Above is a logical error, there is a '-' in the Console.Write statement which cannot exist in a string 
                int temp = i - 1;
                Console.Write(i + "/" + temp + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));
                //Above is a logical error as an integer is being divided by 0 which is impossible 
                if(temp == 0)
                {
                    Console.WriteLine("Does Not Exist");
                }
                else
                {
                    Console.WriteLine(i/temp);
                }

                // concatenate each number to allNumbers
                allNumbers += counter + " ";

                // increment the counter
                counter =+ 1;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);
            //Above has both a compile-time/syntax error, it is missing a comma or '+' in between the string and the variable
            //There is also a runtime error in refrencing the variable allNumbers as the statement is trying to refrence a variable it cannot access
            Console.WriteLine("These numbers have been processed: " + allNumbers);

        }
    }
}

