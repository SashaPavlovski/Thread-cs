using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class PrintNumber_ex1
    {
        private readonly string InputString;

        public PrintNumber_ex1(string inputString)
        {
            InputString = inputString;
            CreateThread();
        }

        public void CreateThread()
        {
            Thread thread = new Thread(PrintString);
            thread.Start();

        }
        public void PrintString()
        {
            for (int i = 1; i <= 10; i++)
            {
                string line = $"{i}. {InputString}";
                Console.WriteLine(line);
            }
        }
    }
}
