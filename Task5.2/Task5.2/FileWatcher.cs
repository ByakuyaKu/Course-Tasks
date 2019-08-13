using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task5._2
{
    public class FileWatcher
    {
        public static void DeleteFiles()
        {
            string[] OldBackups = Directory.GetFiles(Directory.GetCurrentDirectory() + "/Backups", "*.txt");
            foreach (string file in OldBackups)
                File.Delete(file);
        }

        public static void Run()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = Directory.GetCurrentDirectory() + "/Watching";

                watcher.NotifyFilter = NotifyFilters.LastAccess
                                                | NotifyFilters.LastWrite
                                                | NotifyFilters.FileName
                                                | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;

                while (Console.Read() != 'q') ;
            }
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine($"File: {e.Name} {e.ChangeType}");
            BackUp.CopyFile(e.Name);
        }

        private static void OnRenamed(object source, RenamedEventArgs e) =>
            Console.WriteLine($"File: {e.OldName} renamed to {e.Name}"); 
    }
}