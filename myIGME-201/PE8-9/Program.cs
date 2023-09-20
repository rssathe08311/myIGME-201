using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string ans = "";

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = "\"" + words[i] + "\"";
               
                ans += words[i] + " ";
            }

            Console.WriteLine(ans);
        }
    }
}
