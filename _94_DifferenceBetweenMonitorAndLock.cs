using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Desler
{

    /* 
     Monitor CLASS ve Lock nesneye ulaşmak için bir düzenleme sağlar.
     Lock monitor.Enter()'in try/final ile kullanımının kısaltmasıdır.
     
     C# 4'de Monitor.Enter() için bir overload geldi.
     2 parametreli olan bu overload için 2. parametre boolen değer alıyor.
     Boolen değerin ref olarak alınmasının nedeni tüm THREAD'lerde aynı değeri görmek. Debug moddaki karmaşanın nedeni birden fazla THREAD'in methoda girmesinden kaynaklanıyor. 
     
     */
    class _94_DifferenceBetweenMonitorAndLock
    {
        static int Total = 0;
        public static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread thread1 = new Thread(_94_DifferenceBetweenMonitorAndLock.AddOneMillion);
            Thread thread2 = new Thread(_94_DifferenceBetweenMonitorAndLock.AddOneMillion);
            Thread thread3 = new Thread(_94_DifferenceBetweenMonitorAndLock.AddOneMillion);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();

            Console.WriteLine("Total = " + Total);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }
        static object _lock = new object();

        public static void AddOneMillion()
        {
            //for (int i = 1; i <= 1000000; i++)
            //{
            //    lock (_lock)
            //    {
            //        Total++;
            //    }
            //}

            //for (int i = 1; i <= 1000000; i++)
            //{
            //    // Acquires the exclusive lock
            //    Monitor.Enter(_lock);
            //    try
            //    {
            //        Total++;
            //    }
            //    finally
            //    {
            //        // Releases the exclusive lock
            //        Monitor.Exit(_lock);
            //    }
            //}

            for (int i = 1; i <= 1000000; i++)
            {
                bool lockTaken = false;
                // Acquires the exclusive lock
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Total++;
                }
                finally
                {
                    // Releases the exclusive lock
                    if (lockTaken)
                        Monitor.Exit(_lock);
                }
            }
        }
    }
}

