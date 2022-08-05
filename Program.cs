
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

                default:
                    Console.WriteLine("Please enter the correct choice");
                    break;
            }





        }

    }
}