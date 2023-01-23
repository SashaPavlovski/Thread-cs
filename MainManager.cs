using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_CS
{
    internal class MainManager
    {
        static void Main(string[] args)
        {
            //1
            //Ex1
            //PrintNumber_ex1 printNumber_Ex1 = new PrintNumber_ex1 ("ex1");

            ////Ex2
            //CreateFile_ex2 createFile_Ex2 = new CreateFile_ex2("ex2_3", "ex", 500);
            //Console.ReadLine();
            //Ex4
            //LogFile_ex4 logFile = new LogFile_ex4();
            //for (int I = 0; I < 300; I++)
            //{
            //    logFile.CreateLog("Event", "bay");
            //    logFile.CreateLog("Error", "hi");
            //}
            //Console.ReadLine();
            ////2
            ////Ex1+Ex2
            //PrintingStringsAtTheSameTime_2_ex1_ex2 newThread = new PrintingStringsAtTheSameTime_2_ex1_ex2("a", 500, 10);

            //PrintingStringsAtTheSameTime_2_ex1_ex2 newThread1 = new PrintingStringsAtTheSameTime_2_ex1_ex2("b", 1000, 10);

            //PrintingStringsAtTheSameTime_2_ex1_ex2 newThread2 = new PrintingStringsAtTheSameTime_2_ex1_ex2("a", 500, 100);

            //PrintingStringsAtTheSameTime_2_ex1_ex2 newThread3 = new PrintingStringsAtTheSameTime_2_ex1_ex2("b", 1000, 100);

            //PrintingStringsAtTheSameTime_2_ex1_ex2 newThread4 = new PrintingStringsAtTheSameTime_2_ex1_ex2("c", 250, 100);

            //Ex4
            //RunnerLoopFile_2_ex4 run = new RunnerLoopFile_2_ex4();
            //run.runner();
            //Console.ReadLine();

            //Ex5
            //InfinityThread_2_ex5 InfinityThread = new InfinityThread_2_ex5("A", 500);
            //InfinityThread_2_ex5 InfinityThread1 = new InfinityThread_2_ex5("B", 500);
            //Console.ReadLine();


            //Ex6

            ThreadRace_2_ex6 threadRace_2_Ex6 = new ThreadRace_2_ex6();
           // threadRace_2_Ex6.NameList();
            threadRace_2_Ex6.MainLoop();
            Console.ReadLine();
        }
    }
}
