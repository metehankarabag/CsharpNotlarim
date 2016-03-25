using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Desler
{
    /*Performance Of a Multithreaded Program
      Makinede kaç tane işleyici olduğunu bulmak için 3 yol var.
      1. Görev yöneticisini - Performance sekmesindeki - CPU Usage History'den
      2. Environment.ProcessorCount ile 
      3. Run da echo %NUMBER_OF_PROCESSORS% yazarak kaç işleyici olduğu bulunabilir.
      
     Benim PC'de 2 işleyici olduğu için aynı anda (simultaneously) 2 THREAD çalışabilir.
      
     On a machine that has multiple processors, multiple threads can execute application code in parallel on different cores. 
     Birden fazla işleyicisi olan bir PC de, THREAD'ler farklı çekirdeklerde uygulama kodunu aynı ayna çalıştırabilir.
     Örneğin iki işlemci ve 2 THREAD varsa, her THREAD kendi çekirdeğinde çalışır.
     
     Tek işleyicili PC'ler THREAD'ler sıra ile çalışır. Biri işini bitirmeden diğeri çalışamaz.
     */
    class _97_PerformanceOfaMultithreadedProgram
    {
        public static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread T1 = new Thread(EvenNumbersSum);
            Thread T2 = new Thread(OddNumbersSum);

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total milliseconds with multiple threads = " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();

            stopwatch = Stopwatch.StartNew();
            EvenNumbersSum();
            OddNumbersSum();
            stopwatch.Stop();
            Console.WriteLine("Total milliseconds without multiple threads  = " + stopwatch.ElapsedMilliseconds);
        }

        public static void EvenNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of even numbers = {0}", sum);
        }
        public static void OddNumbersSum()
        {
            double sum = 0;
            for (int i = 0; i <= 50000000; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of odd numbers = {0}", sum);
        }
    }
}
