using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string to hold the user input from the console
            string conInput = null;
            //int that will be printed once altered 
            int prod = 1;
           
            //for loop that gathers, converts, and then multiplies user input to generate the final product
            for(int i = 0; i < 4; i++)
            {
                //prompts and gathers user input
                Console.WriteLine("Enter an Integer: ");
                conInput = Console.ReadLine();

                //multiplies the user input once converted to the product
                prod *= Convert.ToInt32(conInput);
            }

            //prints the final product to the console
            Console.WriteLine(prod);



        }
    }
}
