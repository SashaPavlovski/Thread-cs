using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Thread_CS
{
    public class LogFile_ex4
    {
        public string LogFileName { get; set; } = @"mylog.txt";

        public void CreateLog(string MessageType, string MessageTxt)
        {
            CheckFileSize();
            using (StreamWriter sw = new StreamWriter(LogFileName, true))
            {
                sw.WriteLine($"Log {MessageType} : {DateTime.Now} - {MessageTxt}");
            }
        }

        public void CreateFile()
        {
            int CountNumberFile = 1;

            while (System.IO.File.Exists(LogFileName))
            {
                LogFileName = $@"mylog{CountNumberFile}.txt";

                CountNumberFile++;
            }
            using (FileStream file = new FileStream(LogFileName, FileMode.Create)) ;
        }

        public void CheckFileSize()
        {

            if (!System.IO.File.Exists(LogFileName)) { using (FileStream file = new FileStream(LogFileName, FileMode.Create)); }

            else
            {
                var fi1 = new FileInfo(LogFileName);
                if (fi1.Length >= 1048576)
                {
                    CreateFile();
                }
            }
        }
    }
}
