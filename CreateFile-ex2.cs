using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class CreateFile_ex2
    {
        public string WriteToFile { get; set; }
        public int timeSleep { get; set; }

        private string _FileName;
        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value + ".txt"; }
        }

        public CreateFile_ex2(string fileName,string writeToFile, int time)
        {
            FileName = fileName;
            timeSleep = time;
            WriteToFile = writeToFile;
            Task.Run(CreatingAndWritingToFile);


        }

        public void CreatingAndWritingToFile()
        {
            if (!(File.Exists(FileName)))
            {
                using (FileStream file = new FileStream(FileName, FileMode.Create)) ;
            }
            using (StreamWriter sw = new StreamWriter(FileName, true))
            {
                sw.WriteLine(WriteToFile);
            }
                    
            Thread.Sleep(timeSleep);
        }
    }
}
