using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class multiplecompanies
    {
        public const int PartTime = 1;
        public const int FullTime = 2;
        public static int empwage(string company, int emprateperhour, int noofwokingdays, int maxhourspermonth)
        {
            int emphours = 0, totalemphours = 0, totalworkingdays = 0;
            while (totalemphours <= maxhourspermonth && totalworkingdays < noofwokingdays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case PartTime:
                        emphours = 8;
                        break;
                    case FullTime:
                        emphours = 16;
                        break;
                    default:
                        emphours = 0;
                        break;
                }
                totalemphours += emphours;
                Console.WriteLine("Day#" + totalworkingdays + "Emp Hrs" + emphours);
            }
            int totalempwage = totalemphours * emprateperhour;
            Console.WriteLine("Total employee Wage for the company" + company + totalempwage);
            return totalempwage;
        }
    }
}
