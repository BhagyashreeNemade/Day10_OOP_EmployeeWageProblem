using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    interface IEmpWageCal
    {
        void addCompanyWage(String company, Double empRatePerHour, Double numOfWorkingDays, Double workingHrs);

        Double getTotalWage(string company);

        Double getDailtWage(string company);

    }
}
