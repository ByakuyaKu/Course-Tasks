using System;
using Users.BLL;
using Users.Entities;
using System.Linq;

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
                    Guid UserId;
                    Guid AwardId;
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter user name");
                                var Name = Console.ReadLine();

                                Console.WriteLine("Enter date of birth");
                                DateTime DateOfBirth;

                                if (!DateTime.TryParse(Console.ReadLine(), out DateOfBirth))
                                    Console.WriteLine("Error!!! Wrong date format");
                                else if (DateOfBirth > DateTime.Now)
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

                                if (!Guid.TryParse(Console.ReadLine(), out UserId))
                                    Console.WriteLine("Error!!! Wrong id format");
                                else if (!manager.GetAllUsers().Exists(n => n.UserId == UserId))
                                    Console.WriteLine("Error!!! This user does not exist");
                                else
                                    manager.DeleteUser(UserId);


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
                                Console.WriteLine("Enter award name");
                                var Name = Console.ReadLine();

                                Awards award = new Awards(Name);
                                manager.AddAward(award);

                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Enter user Id");

                                if (!Guid.TryParse(Console.ReadLine(), out UserId))
                                    Console.WriteLine("Error!!! Wrong id format");
                                else if (!manager.GetAllUsers().Exists(n => n.UserId == UserId))
                                    Console.WriteLine("Error!!! This user does not exist");
                                else
                                {
                                    Console.WriteLine("Enter award Id");

                                    if (!Guid.TryParse(Console.ReadLine(), out AwardId))
                                        Console.WriteLine("Error!!! Wrong id format");
                                    else if (!manager.GetAllAwards().Exists(n => n.Id == AwardId))
                                        Console.WriteLine("Error!!! This award does not exist");
                                    else
                                        manager.AddAwardToUser(UserId, AwardId);
                                }

                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Enter award Id");

                                if (!Guid.TryParse(Console.ReadLine(), out AwardId))
                                    Console.WriteLine("Error!!! Wrong id format");
                                else if (!manager.GetAllAwards().Exists(n => n.Id == AwardId))
                                    Console.WriteLine("Error!!! This award does not exist");
                                else
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
                else
                    Console.WriteLine("Error!!! Wrong option");
            }
        }
    }
}
