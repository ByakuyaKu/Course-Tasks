using System;
using _3_User;

namespace _5_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee user1 = new Employee("Jmishenko", "Valerii", "Albertovuch", 1965, 02, 28, 3, 10);
            Console.WriteLine(user1);
            Console.ReadKey();
        }
    }
}
