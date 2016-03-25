using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dersler
{
	/*
      THREAD parametresinde kullanılan delegate'lerden dolayı, THREAD'lere sadece VOID dönen methodlar kullanabiliriz.
      Bu yüzden kullandığımız method'dan veri alamayız.
      Derste yapılan THREAD methodu içinde başka bir method çalıştırmaktır.
      THREAD methodu çalıştırdığında method içinde bir DELEGATE'i çalıştırır. DELEGATE'de THREAD metodunun içinde işaret ettiği methodu çalıştırır.
      Böylece method içindeki değerleri dışarıda tanımladığımız method'da kullanabiliriz.
     */
    public delegate void SumOfNumbersCallback(int sumOfNumbers); //Method işaretçisidir. kullanılabilecek methodun parametresini ve dönüştürünü belirtir.

    public class _91_RetrievingDataFromThreadFunctionUsingCallback
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers is " + sum);
        }

        public static void Program()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callbackMethod = new SumOfNumbersCallback(PrintSum);

            Number number = new Number(target, callbackMethod);
            Thread T1 = new Thread(new ThreadStart(number.PrintSumOfNumbers));
            T1.Start();
        }

        class Number
        {
            int _target;

            SumOfNumbersCallback _callbackMethod;
            //
            public Number(int target, SumOfNumbersCallback callbackMethod)
            {
                this._target = target;
                this._callbackMethod = callbackMethod;
            }

            //
            public void PrintSumOfNumbers()
            {
                int sum = 0;
                for (int i = 1; i <= _target; i++)
                {
                    sum = sum + i;
                }

                if (_callbackMethod != null)
                {
                    _callbackMethod(sum);
                }
            }
        }
    }
}
