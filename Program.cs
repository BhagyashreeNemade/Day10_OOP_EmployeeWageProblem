
namespace Day8_OOP_EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage program");

            Console.WriteLine("Enter the choice");
            Console.WriteLine(" 1.checkingpresentORAbsent ");
            Console.WriteLine(" 2.caldailywage");
            Console.WriteLine(" 3.parttimeornot");
            Console.WriteLine(" 4.usingswitch");
            Console.WriteLine(" 5. monthlywage");
            Console.WriteLine(" 6.totaoWorkingDaysOrHoursReached");
            Console.WriteLine(" 7.ClassMethodAndVars");
            Console.WriteLine(" 8.Wage for Multiple Companies");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    checkingpresentORAbsent a = new checkingpresentORAbsent();
                    a.CheckingpresentORAbsent();


                    break;
                case 2:
                    caldailywage c = new caldailywage();
                    c.Caldailywage();

                    break;
                case 3:
                    parttimeornot d = new parttimeornot();
                    d.Parttimeornot();

                    break;
                case 4:
                    usingswitch e = new usingswitch();
                    e.Usingswitch();


                    break;
                case 5:
                    monthlywage f = new monthlywage();
                    f.Monthwage();

                    break;
                case 6:
                    totalWorkingDaysOrHoursReached g = new totalWorkingDaysOrHoursReached();
                    g.TotalWorkingDaysOrHoursReached();

                    break;
                case 7:
                    ClassMethodAndVars h = new ClassMethodAndVars();
                    h.EmpWage();

                    break;
                case 8:
                    multiplecompanies.empwage("Dmart", 20, 2, 10);
                    multiplecompanies.empwage("Reliance", 10, 4, 20);

                    break;

                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }





        }

    }
}