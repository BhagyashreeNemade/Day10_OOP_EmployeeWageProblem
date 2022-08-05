using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class usingswitch
    {
        int hour = 8;
        int rateperhour = 20;
        int parttimerate = 8;
        int parthour = 4;

        public void Usingswitch()
        {
            Random value = new Random();
            int num1 = value.Next(0, 2);
            switch (num1)
            {
                case 1:



                    Console.WriteLine(" full timeEmployee is present");
                    int salary = hour * rateperhour;
                    Console.WriteLine("daily wage is {0}", salary);
                    break;

                case 0:

                    Console.WriteLine("Employee is part time");
                    int partsalary = parttimerate * parthour;
                    Console.WriteLine("part time wage is {0}", partsalary);

                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
        }
    }
}
