using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class Race_2_ex6
    {
        public string CarName { get; set; }
        public int CarKM { get; set; } = 0;
        public int SleepTime { get; set; } = 500;
        public bool StopLoop { get; set; } = false;

        public Race_2_ex6(string carName)
        {
            CarName = carName;
            Task.Run(Drive);
        }
        public string Drive()
        {
            int randomKM;
            while (!StopLoop)
            {
                Random random = new Random(DateTime.Now.Millisecond);
                randomKM = random.Next(101);
                CarKM = CarKM + randomKM;
                Console.WriteLine($"The car {CarName} has driven: {randomKM}KM in total {CarKM}");
                if (CarKM > 10000) StopLoop = true;

                Thread.Sleep(SleepTime + randomKM);
            }
            return CarName;
        }
    }
}
