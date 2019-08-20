using System;
using Users.BLL;
using Users.Entities;

namespace Users.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            for(; ; )
            { 
            Console.WriteLine(               "-----------------------------------"
                     + Environment.NewLine + "Please choose option:"
                     + Environment.NewLine + "\t 1: Add user"
                     + Environment.NewLine + "\t 2: Delete user"
                     + Environment.NewLine + "\t 3: See all users"
                     + Environment.NewLine + "\t 4: Add award"
                     + Environment.NewLine + "\t 5: Add award to user"
                     + Environment.NewLine + "\t 6: Delete award"
                     + Environment.NewLine + "\t 7: See all awards"
                     + Environment.NewLine + "-----------------------------------");

                if (uint.TryParse(Console.ReadLine(), out uint option) 
                    && option > 0 
                    && option < 8) 
                {
                    UsersManager manager = new UsersManager();
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter user name");
                                var Name = Console.ReadLine();

                                Console.WriteLine("Enter date of birth");
                                DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());

                                if (DateOfBirth > DateTime.Now)
                                    Console.WriteLine("Error!!! Wrong date");
                                else
                                {
                                    Userss newUser = new Userss(Name, DateOfBirth);

                                    manager.AddUser(newUser);
                                }

                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Enter user id");
                                Guid Id = Guid.Parse(Console.ReadLine());

                                manager.DeleteUser(Id);

                                break;
                            }

                        case 3:
                            {
                                foreach(Userss user in manager.GetAllUsers())
                                    Console.WriteLine(user);
                                break;
                            }
                        case 4:
                            {
                                string Name = Console.ReadLine();
                                Awards award = new Awards(Name);
                                manager.AddAward(award);

                                break;
                            }
                        case 5:
                            {
                                Guid UserId = Guid.Parse(Console.ReadLine());
                                Guid AwardId = Guid.Parse(Console.ReadLine());
                                manager.AddAwardToUser(UserId, AwardId);

                                break;
                            }
                        case 6:
                            {
                                Guid AwardId = Guid.Parse(Console.ReadLine());
                                manager.DeleteAward(AwardId);

                                break;
                            }
                        case 7:
                            {
                                foreach (Awards award in manager.GetAllAwards())
                                    Console.WriteLine(award);

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unknown command!");
                                break;
                            }
                    }
                }
            }
        }
    }
}
