using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    //defines the delegate type and data type
    delegate double MathRound(double num1, int num2);
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates an instance of the delegate
            MathRound mathRound;

            //variables for calculation
            double z = 0.0;
            int xInd = 0;
            int yInd = 0;

            //calls method that completes the function of the delegate
            mathRound = new MathRound(roundNum);

            double[,,] ans = new double[21, 31, 3];

            for (double x = 0; x <= 4; x += 0.1, xInd++)
            {
                yInd = 0;
                for (double y = -1; y <= 1; y += 0.1, yInd++)
                {
                    //z = 4y3 + 2x2 - 8x + 7
                    z = (4 * Math.Pow(y, 3)) + (2 * Math.Pow(x, 2)) - (8 * x) + 7;

                    ans[xInd, yInd, 0] = x;
                    ans[xInd, yInd, 1] = y;
                    ans[xInd, yInd, 2] = z;

                }
            }
        }

        //method that performs the function of the delegate
        static double roundNum(double num1, int num2)
        {
            return Math.Round(num1, num2);
        }
    }
}
