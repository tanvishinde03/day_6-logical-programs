using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
    {
        internal class timeElapsed
        {
            public static void stopwatch()
            {

                Stopwatch stopwatch = new Stopwatch();


                stopwatch.Start();


                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(10);
                }


                stopwatch.Stop();


                Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
                 Console.ReadLine();
            }
        }





    }












