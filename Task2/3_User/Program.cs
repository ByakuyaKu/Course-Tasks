using System;

namespace _3_User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Jmishenko", "Valerii", "Albertovuch", 1965, 02, 28);
            Console.WriteLine(user1);
            Console.ReadKey();
        }
    }
}
