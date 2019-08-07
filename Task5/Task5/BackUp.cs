using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
//using DocumentFormat.OpenXml.Spreadsheet;
using System.Runtime.Serialization;

namespace Task5
{
    class BackUp
    {
        private static DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(List<Version>));
        private static List<Version> temporaryFileVersion;

        public static void SaveChangesToLogFile(Version fileVersion)
        {
            Read();
            Add(fileVersion);
            Write();
        }

        //private static void Add(Version fileVersion)
        //{
        //    throw new NotImplementedException();
        //}

        private static void Read()
        {
            using (FileStream fs = new FileStream(LogFile.logFile.FullName, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    temporaryFileVersion = (List<Version>)jsonSerializer.ReadObject(fs);
                }
                catch (SerializationException)
                {
                    temporaryFileVersion = new List<Version>();
                }
            }
        }

        private static void Add(Version fileVersion)
        {
            temporaryFileVersion.Add(fileVersion);
        }

        private static void Write()
        {
            using (FileStream fs = new FileStream(LogFile.logFile.FullName, FileMode.Create, FileAccess.Write))
            {
                jsonSerializer.WriteObject(fs, temporaryFileVersion);
            }
            temporaryFileVersion.Clear();
        }
    }
}