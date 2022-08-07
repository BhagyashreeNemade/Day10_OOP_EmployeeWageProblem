
namespace Day8_OOP_EmployeeWageProblem
{
    class Program
    {

        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;


        static void Main(string[] args)
        {
            //Variables
            Double empRatePerHour = 0;
            Double workingHrs = 0;
            Double numOfWorkingDays = 0;

            Random random = new Random();
            int empType = random.Next(1, 3);

            switch (empType)
            {
                case IS_FULL_TIME:

                    empRatePerHour = 120;
                    workingHrs = 8;
                    numOfWorkingDays = 20;

                    Console.WriteLine("Full Time Employee Details in following companies");
                    break;

                case IS_PART_TIME:

                    empRatePerHour = 80;
                    workingHrs = 5;
                    numOfWorkingDays = 20;
                    Console.WriteLine("Part Time Employee Details in following companies");
                    break;

                default:
                    break;
            }

            ManageEmpWageOfMultileCompanies apple = new ManageEmpWageOfMultileCompanies();
            apple.addCompanyWage("Apple", empRatePerHour, numOfWorkingDays, workingHrs);
            Console.WriteLine("Total wage in Apple: " + apple.getTotalWage("Apple"));

            ManageEmpWageOfMultileCompanies google = new ManageEmpWageOfMultileCompanies();
            google.addCompanyWage("Google", empRatePerHour, numOfWorkingDays, workingHrs);
            Console.WriteLine("Total wage in google : " + google.getTotalWage("Google"));


        }
    }
}