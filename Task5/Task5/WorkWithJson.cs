    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Task5
{
    public class WorkWithJson
    {
        private static DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Version>));
        private static List<Version> fileVersions;

        public static string[] SelectVersion(string filePath)
        {

            var selectedVersions = Read().Where(item => item.FilePath == filePath)
                .OrderBy(item => item.Date)
                .Select(item => item.LastWriteTime)
                .ToArray();

            return selectedVersions;
        }

        public static void GoBackToVersion(string filePath, string date)
        {
            using (StreamWriter fs = new StreamWriter(filePath, false, Encoding.Default))
            {
                fs.Write(GetFileData(date));
            }
        }

        public static string GetFileData(string date)
        {
            var fileData = Read().Where(item => item.LastWriteTime == date)
                .Select(item => item.FileVersion)
                .ToString();

            return fileData;
        }

        private static List<Version> Read()
        {
            using (FileStream fs = new FileStream(LogFile.logFile.FullName, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    fileVersions = (List<Version>)jsonSerializer.ReadObject(fs);
                }
                catch (SerializationException)
                {
                    fileVersions = new List<Version>();
                }
            }

            return fileVersions;
        }
    }
}