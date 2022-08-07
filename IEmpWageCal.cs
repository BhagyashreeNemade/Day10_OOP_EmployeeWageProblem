using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_OOP_EmployeeWageProblem
{
    interface IEmpWageCal
    {
        Company AddCompany(String company, Double empRatePerHour, int numOfWorkingDays, int workingHrs);

        // Double getTotalWage(string company);

    }
}
