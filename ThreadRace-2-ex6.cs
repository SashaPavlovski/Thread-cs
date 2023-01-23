using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class ThreadRace_2_ex6
    {
        Race_2_ex6[] Cars;
        List<string> RaceResults;
        List<string> NameCar;
        public ThreadRace_2_ex6 ()
        {
            Cars = new Race_2_ex6[10];
            RaceResults = new List<string>();
            NameCar = new List<string>();
            Init();
        }
        public void NameList()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter car name: ");
                NameCar.Add(Console.ReadLine());
                Console.WriteLine("\n");
            }
        }
        public void Init () 
        {
            NameList();
            if (NameCar.Count > 0)
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    Console.WriteLine("Please enter car name: ");
                    Cars[i] = new Race_2_ex6(NameCar[i]);
                    Console.WriteLine("\n");
                }
            }

        }
        public void MainLoop()
        {
            int i = 1;
            if (Cars[Cars.Length - 1] != null)
            {
                while (RaceResults.Count < 3)
                {
                    RaceResults.Add(Cars[i].Drive());
                    if (RaceResults.Count != 0)
                    {
                        Console.WriteLine("*****************************************");
                        Console.WriteLine($"***In the {i} place won: {RaceResults.Last<string>()}*****");
                        Console.WriteLine("*****************************************");
                    }
                    i++;
                }
            }
        }
    }
}
