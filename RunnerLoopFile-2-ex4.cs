using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_CS
{
    public class RunnerLoopFile_2_ex4
    {
        public void runner()
        {
            for (int i = 0; i < 4; i++)
            {
                FilesInfiniteLoop_2_ex4 newFile = new FilesInfiniteLoop_2_ex4(Console.ReadLine(), 500);
            }
        }

    }
}
