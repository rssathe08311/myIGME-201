using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber = "";//added to get rid of the compile time error on line 25
            int nX;
            //compile time error - missing semicolon
            //int nY - original
            int nY = 0;//set to 0 to get rid of the error on line 36
            int nAnswer;

            //compile time error - missing quotation marks around a string
            //Console.WriteLine(This program calculates x ^ y.);


            //runtime error - there is no variable to break out of the do while statment
            do
            {
                Console.Write("Enter a whole number for x: ");
                //logical error - not assigned to a variable
                sNumber = Console.ReadLine();



            //compile time error - sNumber is never declared so it has no value to be parsed to
            } while (!int.TryParse(sNumber, out nX));

            //runtime error - there is no variable to break out of the do while statment
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
             //logical error - the do while loop to get a value for y is based upon the numerical value of x not y
             //runtime error - missing the ! opperator to maintain the loop
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }

        //compile time error - no return statement
        //compile time error - visibility and static are not set 
        public static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //logical error - should be 1 so the entire thing isn't equal to 0
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //runtime error - the base case will never be achieved as nExponent is being added to unless it was initially negative
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            //compile timer error - no return statement
            return returnVal;
        }
    }
}
