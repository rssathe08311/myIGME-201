using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _3questions
{
    internal class Program
    {
        //initialization of timer and timer boolean
        static Timer timeOutTimer;
        static bool bTimeOut = false;

        static void Main(string[] args)
        {
            //variables for question handling
            int quesNum = 0;
            string sQuesNum;
            string correctAns = "";

        //tag for playing the game
        start:
            //promts the user for what question they want
            Console.WriteLine("Chose your question (1-3): ");
            sQuesNum = Console.ReadLine();

            bool bValid = false;

            while (!bValid) {
                try
                {
                    quesNum = int.Parse(sQuesNum);
                    bValid = true;
                }
                catch
                {
                    Console.WriteLine("Enter an integer 1-3.");
                }

                if(quesNum >= 1 && quesNum <= 3)
                {
                    bValid = true;
                }
                else
                {
                    bValid = false;
                }
            }

            //prints question and defines correlating answer
            switch (quesNum)
            {
                case 1:
                    Console.WriteLine("What is your favorite color?");
                    correctAns = "black";
                    break;
                case 2:
                    Console.WriteLine("What is the answer to life, the universe and everything?");
                    correctAns = "42";
                    break;
                case 3:
                    Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                    correctAns = "What do you mean? African or European swallow?";
                    break;
            }

            //new instance of a timer along with definition for delegate method
            timeOutTimer = new Timer(5000);
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

            //allows the user to guess on the question
            Console.WriteLine("You have 5 seconds to answer this question.");

            timeOutTimer.Start();
            string ans = Console.ReadLine();

            if (ans.ToLower() == correctAns.ToLower() && !bTimeOut)
            {
                timeOutTimer.Stop();
                Console.WriteLine("Well done!");
            }
            else
            {
                timeOutTimer.Stop();
                bTimeOut = true;
                Console.WriteLine("You did not get it right.");
                Console.WriteLine("Wrong! The correct answer is: " + correctAns);
            }

            //prompts users if they want to play again
            Console.WriteLine("Play again?");
            string again = Console.ReadLine();

            if (again[0] == 'y')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("");
            }





        }
        //method to handle the timer
        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");
            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
