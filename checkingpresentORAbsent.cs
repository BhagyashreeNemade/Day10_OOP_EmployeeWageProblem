using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class checkingpresentORAbsent
    {
        bool present;
        public void CheckingpresentORAbsent()

        {
            Random value = new Random();

            int empCheck = value.Next(0, 2);


            if (empCheck == 1)
            {
                present = true;

                Console.WriteLine(" full timeEmployee is present");


            }
            else
            {
                present = false;
                Console.WriteLine(" full timeEmployee is Absent");
            }
        }

    }

}
