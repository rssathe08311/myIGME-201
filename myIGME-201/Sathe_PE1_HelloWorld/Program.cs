//Reva Sathe IGME 201
//8-31-23
//This program is meant to be an introduction to printing in the console in C# and Visual Studio 2022
//Other things like variables and addition in a print statement were also tested as a way to compare
//and contrast syntax with javascript

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sathe_PE1_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing strings to the console
            Console.WriteLine("Hello World!");
            Console.WriteLine("Reva Sathe");

            //addition in the console print statement
            int num = 35;
            Console.WriteLine(num + 7);

            //initialization and declaration of variable on different lines
            string sent;
            sent = "word";
            Console.WriteLine(sent);

            //testing out for loops
            for(int i = 0; i < 10; i++)
            {
                Console.Write("| |");
            }

            Console.WriteLine("");

            //testing out while loops
            int count = 0;
            while(count < 5){
                Console.WriteLine(count + "*");
                count++;
            }
        }
    }
}
