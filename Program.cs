using System;
namespace Salary_slip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kindly Enter your designation by number");
            Console.WriteLine("1 for Manager");
            Console.WriteLine("2 for Engineer");
            Console.WriteLine("3 for Analyst");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Manager manager = new Manager();
                    Console.WriteLine("Your Sallery is $" + manager.Salary_slip());
                    break;
                case 2:
                    Engineer engineer = new Engineer();
                    Console.WriteLine("Your Sallery is $" + engineer.Salary_slip());
                    break;
                case 3:
                    Analyst analyst = new Analyst();
                    Console.WriteLine("Your Sallery is $" + analyst.Salary_slip());
                    break;
            }
        }
    }
}
