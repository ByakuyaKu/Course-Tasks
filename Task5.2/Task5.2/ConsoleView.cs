using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._2
{
    public class ConsoleView
    {
        private static void RunProgram()
        {
            FileWatcher.DeleteFiles();

            Console.WriteLine("Watching...");
            Console.WriteLine("Press 'q' to stop watching mode.");

            FileWatcher.Run();
        }

        public static void ProgramInterface()
        {
            for(; ; )
            {
                Console.Clear();
                Console.WriteLine("Please choose mode:"
                                  + Environment.NewLine + "\t 1: watcher mode"
                                  + Environment.NewLine + "\t 2: backup mode");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                            {
                                RunProgram();
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Input file name for back up without .txt");
                                string fname = BackUp.ChooseFile();

                                Console.WriteLine($"Input date of {fname} for back up and Press enter twice I dont know why (T_T)");
                                string date = BackUp.ChooseDate(fname);

                                BackUp.GoToVersion(date + fname + ".txt");
                                Console.WriteLine($"file {fname} backuped");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
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
