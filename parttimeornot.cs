using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class parttimeornot
    {
        int parttimerate = 8;
        int parthour = 4;
        bool parttime;
        public void Parttimeornot()
        {
            Random value = new Random();
            int num = value.Next(0, 2);


            if (num == 1)

            {
                parttime = true;
                Console.WriteLine("Employee is part time");
                int partsalary = parttimerate * parthour;
                Console.WriteLine("part time wage is {0}", partsalary);

            }
            else
            {
                parttime = false;
                Console.WriteLine(" parttime Employee is absent");

            }
        }
    }
}
