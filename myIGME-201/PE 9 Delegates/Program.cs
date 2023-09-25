using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//initialize delagate type
delegate string ReadLine();


namespace PE_9_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// delegate steps
            /// 1. define the delegate method data type based on the method signature
            ///         delegate double MathFunction(double n1, double n2);
            /// 2. declare the delegate method variable
            ///         MathFunction processDivMult;
            /// 3. point the variable to the method that it should call
            ///         processDivMult = new MathFunction(Multiply);
            /// 4. call the delegate method / add the delegate method to the object's event handler
            ///         nAnswer = processDivMult(n1, n2);
            ///         timer.Elapsed += TimesUp;
            ///         

            //instance of the delagate
            ReadLine readLine;

            //creates a delagate object
            readLine = new ReadLine(ReadStatement);

            //calls on the delagate and prints it
            string sent = readLine();
            Console.WriteLine(" ");
            Console.WriteLine(sent);
            
        }

        //function to give the delagate function
        static string ReadStatement()
        {
            return Console.ReadLine();
        }
    }
}
