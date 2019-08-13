using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task5._2
{
    public class BackUp
    {
        static string sourceDir = Directory.GetCurrentDirectory() + "/Watching";
        static string backupDir = Directory.GetCurrentDirectory() + "/Backups";

        public static void CopyFile(string name)
        {
            try
            { 
                string thisDateTime = DateTime.Now.ToString("yyy.MM.dd-HH.mm.ss ");

                string newfname = thisDateTime + name;
                try
                {
                    File.Copy(Path.Combine(sourceDir, name), Path.Combine(backupDir, newfname));
                    PrintInfoAboutBackupedFile(name, thisDateTime);
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }

        private static void PrintInfoAboutBackupedFile(string fileName, string dateTime) =>
            Console.WriteLine($"File {fileName} is rollback to {dateTime}");

        public static string ChooseFile()
        {
            string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

            foreach (var file in txtList)
                Console.WriteLine(file);

            string filename = Console.ReadLine();

            return filename;
        }

        public static string ChooseDate(string filename)
        {
            
            string[] txtList = Directory.GetFiles(backupDir, "*" + filename + ".txt");

            foreach (var file in txtList)
                Console.WriteLine(file);

            string date = Console.ReadLine();
            if (DateTime.TryParse(Console.ReadLine(), out var dateTime))
                date = dateTime.ToString("yyyy.MM.dd-HH.mm.ss");
            else
                new ArgumentException("Wrong date format!");

            return date + " ";
        }

        public static void GoToVersion(string filename)
        {
            string[] files = Directory.GetFiles(backupDir, filename);
            string name = filename.Substring(20);
            File.Copy(Path.Combine(backupDir, filename), Path.Combine(sourceDir, name), true);      
        }

        
    }
}