using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading6
{
    public class Program
    {
        static Printing p;

        static object locker = new object();
        static void ThreadMain1()
        {
            while (true)
            {
                Monitor.Enter(locker);
                p.asterisks();
                Thread.Sleep(1000);
                Monitor.Pulse(locker);
                Monitor.Wait(locker);
            }
        }

        static void ThreadMain2()
        {
            while (true)
            {
                Monitor.Enter(locker);
                p.gardenGates();
                Thread.Sleep(1000);
                Monitor.Pulse(locker);
                Monitor.Wait(locker);
            }
        }
        static void Main(string[] args)
        {
            p = new Printing();

            Thread tid1 = new Thread(new ThreadStart(ThreadMain1));
            Thread tid2 = new Thread(new ThreadStart(ThreadMain2));

            tid1.Start();
            tid2.Start();
        }
    }
}
