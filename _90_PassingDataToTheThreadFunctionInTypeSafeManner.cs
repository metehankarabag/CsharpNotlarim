using System;
using System.Threading;

namespace Dersler
{
    /*Thread methoduna type safe şeklinde veri girmek 
      ParameterizedThreadStart delegesi object type parametre alan bir method çalıştırdığından ve object type'a her türlü veri girebileceğimizden dolayı TYPE özelliğini kaybediyoruz.
      
      Bu sorunu THREADSTART delegatesini kullanarak çözeceğiz. Yani kullanacağımız method parametresiz olacak ama methodun yazıldığı CLASS'ı parametreli kullanacağız.
      CLASS kurulurken girilen değeri method'da kullanacağız.
      Bunu düzelmek için Thread methodunun kullanacağı methodun kurucusundaki parametreleri alıyor ve bu parametreleri sınıfın kurucusuna veriyoruz.
      Şimdi yaptığımız kanımca sınıf için iyi değil.
     */
    class _90_PassingDataToTheThreadFunctionInTypeSafeManner
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the target number: ");
            int target = Convert.ToInt32(Console.ReadLine());
            _90_Number number = new _90_Number(target);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumbers));
            T1.Start();
        }
    }

    class _90_Number
    {
        int _target;
        public _90_Number(int _target)
        {
            this._target = _target;
        }

        public void PrintNumbers()
        {
            for (int i = 1; i <= _target; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
