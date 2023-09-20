using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string word = Console.ReadLine();

            char[] chars = word.ToCharArray();

            word = "";

            for (int i = chars.Length -1 ; i >= 0; i--) 
            {
                word += chars[i];
            }

            Console.WriteLine(word);
        }
    }
}
