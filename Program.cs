
namespace Day8_OOP_EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {


            const int ADDCompany = 1;
        const int GetCompWage = 2;

            ManageEmpWageOfMultileCompanies ew = new ManageEmpWageOfMultileCompanies();

        bool loop = true;

            while (loop)
            {
                Console.WriteLine("1. Add Company and Caluclate Wage\n2.Get total monthly wage of a company \n3.Exit");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {

                    case ADDCompany:

                                    Company company = ew.AddCompany("Apple", 120, 20, 100);
                                     ew.CalculateWage(company);

                                    company = ew.AddCompany("Google", 100, 25, 150);
                                     ew.CalculateWage(company);
                                     break;
                    case GetCompWage:

                                     Console.Out.WriteLine("Enter the company to get total wage");
                                     String name = Console.ReadLine();
                                     double monthlyWage = ew.GetTotalWage(name);
                                     if (monthlyWage > 0)
                                     {
                                        Console.Out.WriteLine(name+"'s Monthly total wage is: "+monthlyWage);
                                     }
                                     else
                                     {
                                         Console.Out.WriteLine("Invalid Company Name");
                                     }
                                    break;

                        default:
                                  loop = false;
                                  break;
                      }

                         Console.Out.WriteLine("\n**************************************\n");

            }



        }
    }
}