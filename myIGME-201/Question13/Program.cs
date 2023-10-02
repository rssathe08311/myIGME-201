using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question13
{
    internal class Program
    {
        //creates the Employee struct
        struct Employee
        {
            public string sName;
            public double dSalary;

            public Employee(string sName)
            {
                this.sName = sName;
                dSalary = 30000;
            }
        }
        //method to check if the employee will get a raise based on their name
        static bool GiveRaise(Employee emp)
        {
            bool gotSal = false;
            string name;

            name = emp.sName.ToLower();
            if (name == "reva")
            {
                gotSal = true;
            }

            return gotSal;
        }

        static void Main(string[] args)
        {
            //local variable
            string sName;
            bool gotSal;

            //askes the user for their name
            Console.WriteLine("What's your name? ");
            sName = Console.ReadLine();

            //initializes an employee with the name given by the user
            Employee employee = new Employee(sName);
            
            //calls on GiveRaise to see if the employee can get a raise
            gotSal = GiveRaise(employee);

            //gives the employee a raise if they have my name
            if (gotSal)
            {
                employee.dSalary += 19999.99;
                Console.WriteLine("Congratulations on the raise! Your salary is now: $" + employee.dSalary);
            }
        }


    }
}
