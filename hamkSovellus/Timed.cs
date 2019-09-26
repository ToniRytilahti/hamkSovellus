using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace hamkSovellus
{
    class Timed
    {
        public Stopwatch stopwatch;
        public Timed()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        ~Timed()
        {
            stopwatch.Stop();
        }
        /*

            for (int i = 0; i< 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }
    stopwatch.Stop();

            Console.WriteLine("Aikaa kulunut: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

            Console.ReadLine();*/

         
        }
}
