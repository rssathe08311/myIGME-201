using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    //defines the delegate type and data type
    delegate double MathRound(double num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates an instance of the delegate
            MathRound mathRound;

            //calls method that completes the function of the delegate
            mathRound = new MathRound(roundNum);
        }

        //method that performs the function of the delegate
        static double roundNum(double num1, int num2)
        {
            return Math.Round(num1, num2);
        }
    }
}
