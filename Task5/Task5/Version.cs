using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace Task5
{
    [DataContract]
    public class Version
    {
        public readonly DateTime Date;
        [DataMember]
        public readonly string LastWriteTime;
        [DataMember]
        public readonly string FileVersion;
        [DataMember]
        public readonly string FilePath;

        public Version(string path)
        {
            FilePath = path;
            FileInfo file = new FileInfo(path);

            Date = file.LastWriteTime;
            LastWriteTime = Date.ToString();

            using (StreamReader reader = new StreamReader(file.FullName, Encoding.Default))
                FileVersion = reader.ReadToEnd();
        }

    }
}