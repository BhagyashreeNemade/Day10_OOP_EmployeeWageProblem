using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    public class totalWorkingDaysOrHoursReached
    {


        int hours;
        int rateperhour;
        int totalemphrs = 0;
        int totalworkingday = 0;
        int totalempwage;


        public void TotalWorkingDaysOrHoursReached()
        {
            while (totalemphrs < 100 && totalworkingday < 20)
            {
                totalworkingday++;
                Random value = new Random();
                int num4 = value.Next(0, 2);
                switch (num4)
                {
                    case 0:
                        hours = 8;
                        break;
                    case 1:
                        hours = 4;
                        break;
                    default:
                        hours = 0;
                        break;
                }
                totalemphrs = totalemphrs + hours;
            }
            int totalempwage = totalemphrs + rateperhour;
            Console.WriteLine("wage till a total working hours or days is reached is{0}", totalempwage);
        }
    }
}
