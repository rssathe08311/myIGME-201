using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double z = 0.0;
            int xInd = 0;
            int yInd = 0;

            double[,,] ans = new double[21, 31,3];

            for(double x = -1; x <= 1; x += 0.1, xInd++)
            {
                yInd = 0;
                for(double y = 1;  y <= 4; y += 0.1, yInd++)
                {
                    z = (3 * Math.Pow(y, 3)) + (2 * x) - 1;

                    ans[xInd, yInd, 0] = x;
                    ans[xInd, yInd, 1] = y;
                    ans[xInd, yInd, 2] = z;

                    Console.WriteLine(ans[xInd, yInd, 0].ToString());
                    Console.WriteLine(ans[xInd, yInd, 1].ToString());
                    Console.WriteLine(ans[xInd, yInd, 2].ToString());

                }
            }

        }
    }
}
