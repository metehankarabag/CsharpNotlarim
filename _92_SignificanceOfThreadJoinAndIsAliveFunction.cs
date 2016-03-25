using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dersler
{
    /*Significance Of Thread Join And IsAlive Function
     Worker THREAD'in bir değerine göre program devam edecek ise WORKER THREAD işini bitirene kadar Programın(MAIN THREAD'in) ilerleyişini durdurmak isteyebiliriz.
     Join() worker thread'lere uygulandığında anda MAIN THREAD'in ilerleyişini durdurur, THREAD'in işi bittiğinde program çalışmaya devam eder.
     JOIN() methodunun 2 overload'ı var ve boolen döner.
     1. parametresiz olan
     2. timeout parametreli olan. 
		Bu overload'ı kullandığımızda, belirtilen süre boyunca MAIN THREAD bekler. Süre dolduğunda THREAD methodunun işi bitmemiş olsa bile program devameder.
     Belirtilen süreden önce iş biterse program sürenin bitmesini beklemez.
     
     IsAlive methodu da boolen değer döner. Çalışmakta olan THREAD METHOD'unu işinin bitip bitmediğini kontrol eder.
     */
    public class _92_SignificanceOfThreadJoinAndIsAliveFunction
    {
        public static void Main()
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(_92_SignificanceOfThreadJoinAndIsAliveFunction.Thread1Function);
            T1.Start();

            Thread T2 = new Thread(_92_SignificanceOfThreadJoinAndIsAliveFunction.Thread2Function);
            T2.Start();
            //Console.WriteLine("Main completed");

            if (T1.Join(1000)) Console.WriteLine("Thread1Function completed");
            else               Console.WriteLine("Thread1Function hot not completed in 1 second");
            T2.Join();
                               Console.WriteLine("Thread2Function completed");

            for (int i = 1; i <= 10; i++)
            {
                if (T1.IsAlive){Console.WriteLine("Thread1Function is still doing it's work");
                    Thread.Sleep(500);}
                else{           Console.WriteLine("Thread1Function Completed");
                    break; //for dışına çıkar.
                }
            }
            Console.WriteLine("Main Completed ");
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1Function started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1Function is about to return");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
        public static _92_SignificanceOfThreadJoinAndIsAliveFunction _92_Type()
        {
            _92_SignificanceOfThreadJoinAndIsAliveFunction a = new _92_SignificanceOfThreadJoinAndIsAliveFunction();
            return a;
        }
    }
}
