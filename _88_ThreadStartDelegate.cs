using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dersler
{
    /*ThreadStart Delegesinin amacı
     THREAD CLASS kurucusunun 4 overload'ı var.
     Bu Overload'larda 2 DELEGATE kullanılıyor.(ParameterizedThreadStart, ThreadStart)
     
     Geçen derste ThreadStrat delegesi içinde vermemiştik methodu nasıl çalıştı?
     Bizim oluşturmamış olmamıza rağmen çalışır. Çünkü fremework otomatik oluşturuyor. 
     
     THREAD'ler method çalıştırdığından, DELEGATE'lerde TPYE SAFE avantajı sağladığında OVERLOAD'larda DELEGATE kullanılıyor.
     
     ParameterizedThreadStart: Giriş parametresi olarak 1 object alan ve void dönen bir method alır.
     ThreadStart: Giriş parametresi olmayan ve void dönen bir method alır.
     */
    class _88_ThreadStartDelegate
    {
        public static void Main()
        {
            Thread T1 = new Thread(_88_Number.PrintNumbers);
            Thread T2 = new Thread(new ThreadStart(_88_Number.PrintNumbers));
            Thread T3 = new Thread(delegate() { _88_Number.PrintNumbers(); });
            Thread T4 = new Thread(() => _88_Number.PrintNumbers());
            
            //Number number = new Number();
            //Thread T5 = new Thread(number.PrintNumbers);
            //T1.Start();
        }
    }

    class _88_Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
