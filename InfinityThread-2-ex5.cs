using System;
using System.Threading;

namespace Thread_CS
{
    public class InfinityThread_2_ex5
    {
        private static bool Continue = true;
        public string StringValue { set; get; }
        public int SleepTime { get; set; }

        Thread thread;
        public InfinityThread_2_ex5(string stringValue, int sleepTime)
        {
            StringValue = stringValue;
            SleepTime = sleepTime;
            // Task.Run(RunThread);
            thread = new Thread(RunThread);
            thread.Start();
        }

        public void RunThread()
        {
            int i = 1;
            while (Continue)
            {
                if (!(i % 10 == 0)) Console.WriteLine($"{i} - {StringValue} - {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                else
                {
                    Console.WriteLine("please enter a number : ");
                    string stringUserNum = Console.ReadLine();
                    if (int.TryParse(stringUserNum, out int NumericValue))
                    {
                        int userNumber = int.Parse(stringUserNum);
                        if (userNumber == 0) Continue = false;
                    }
                }
                Thread.Sleep(SleepTime);
                i++;
            }
        }
    }
}