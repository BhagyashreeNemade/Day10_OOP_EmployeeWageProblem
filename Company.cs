using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    class Company
    {
        public List<Double> DailyWage = new List<double>();

        public String CompName { get; set; }
        public double WagePerHour { get; set; }
        public int TotalWorkingDays { get; set; }
        public int TotalWorkingHours { get; set; }

        public double MonthlyTotalWage { get; set; }


        //company constructor
        public Company(String compName, double wagePerHour, int totalWorkingDays, int totalWorkingHours)
        {
            this.CompName = compName;
            this.WagePerHour = wagePerHour;
            this.TotalWorkingDays = totalWorkingDays;
            this.TotalWorkingHours = totalWorkingHours;
            this.MonthlyTotalWage = 0;

            Console.WriteLine("\nCompany " + this.CompName + " Created\n");

        }
    }
}
