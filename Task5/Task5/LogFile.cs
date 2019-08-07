using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task5
{
    class LogFile
    {
        private static string DirectoryPath;

        private static string logDirectoryPath
        {
            get => DirectoryPath + @"\log";
        }

        private static DirectoryInfo logDirectory
        {
            get => new DirectoryInfo(logDirectoryPath);
        }

        public static FileInfo logFile
        {
            get => new FileInfo(logDirectoryPath + @"\log.json");
        }
        public static void CreateLog(string directoryPath)
        {
            DirectoryPath = directoryPath;
            if (!logDirectory.Exists)
                logDirectory.Create();

            using (FileStream fileStream = new FileStream(logFile.FullName, FileMode.OpenOrCreate))
            {
                fileStream.Close();
            }
        }
    }
}