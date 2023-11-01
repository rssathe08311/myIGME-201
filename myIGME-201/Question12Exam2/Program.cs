using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays.Add("Dylan", new DateTime(2004, 2, 5));
            friendBirthdays.Add("Sid", new DateTime(2004, 4, 10));
            friendBirthdays.Add("Jack", new DateTime(2004, 9, 9));
            friendBirthdays.Add("Eytam", new DateTime(2003, 10, 6));


            List<DateTime> dateList = friendBirthdays.Values.ToList();
            foreach (string friend in friendBirthdays.Keys)
            {
                int index = friendBirthdays.IndexOfKey(friend);

                Console.WriteLine(friend + "'s birthday is {0:MM/dd/yy}",
                   dateList[index]);
            }
        }
    }
}
