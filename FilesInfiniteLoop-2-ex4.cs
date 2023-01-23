using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class FilesInfiniteLoop_2_ex4
    {
        private string _FileName;
        public string WriteToFile { get; set; }
        public int timeSleep { get; set; }

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value + ".txt"; }
        }


        public FilesInfiniteLoop_2_ex4(string fileName, int time)
        {
            FileName = fileName;
            timeSleep = time;
            Task.Run(FileExists);
        }

        public void FileExists()
        {
                if (!(File.Exists(FileName)))
                {
                    using (FileStream file = new FileStream(FileName, FileMode.Create)) ;
                    Console.WriteLine("1");
                }
                using (StreamWriter sw = new StreamWriter(FileName, true))
                {

                    Random random = new Random(DateTime.Now.Millisecond);
                    for (int i = 0; i < 5; i++)
                    {

                        int randomNum = random.Next(10000);

                        sw.WriteLine(randomNum);
                    }
                }
            Thread.Sleep(timeSleep);
        }

    }
}
