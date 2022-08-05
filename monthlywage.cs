using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class monthlywage
    {
        int workingday = 20;
        int hour = 8;
        int rateperhour = 20;
        int parttimerate = 8;
        int parthour = 4;

        public void Monthwage()
        {
            Random value = new Random();
            int num2 = value.Next(0, 2);
            switch (num2)
            {
                case 1:

                    int monthswage = hour * rateperhour * workingday;
                    Console.WriteLine("mothly  wage of full time employee is {0}", monthswage);
                    break;

                case 0:
                    int monthswagepart = parttimerate * parthour * workingday;
                    Console.WriteLine("mothly  wage of part time employee is {0}", monthswagepart);
                    break;

                default:
                    Console.WriteLine(" Employee is Absent in this months");
                    break;

            }
        }
    }
}
