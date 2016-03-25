using System;
using System.Collections.Generic;//List bu isim uyzayında.
namespace Dersler
{
    public class _52_Attributes
    {
        /* ATTRIBUTE(Öznitelik)
          ATTRIBUTE'lar ATTRIBUTE sınıfından türeterek oluşturulan, ABSTRACT sınıflardır.
          ATTRIBUTE çalışma zamanında uygulandığı nesnelerin METADATA'larına bilgiler, işler/ekler. Anladığım kadarıyla yazılan kod yapsısını bozmadan yeni çalışma durumu belirlemek için kullanılır.
          Herhangi bir nesneye ATTRIBUTE uygulandığında, ATTRIBUTE'u çalışma zamanında devreye girmesi için .net REFLECTION kullanır.
		  Çünkü REFLECTION çalışma zamanında CLASS METADATA'ı kontrol edebilir.
          .net tarafından oluşturulmuş ATTRIBUTE var. 
        */

        public class _52_Attributes_Calculator
        {
            //Eski
            [Obsolete("Use Add(List<int>Numbers) Method", true)]
            // Obsolete string bölümüne yazılan true ile 2 parametreli methodun kullanılmasını engelledik.
            public static int Add(int FisrtNumber, int SecondNumber)
            {
                return FisrtNumber + SecondNumber;
            }
            public static int Add(List<int> Numbers)
            {
                int Sum = 0;
                foreach (int Number in Numbers)
                {
                    Sum = Sum + Number;
                }
                return Sum;
            }

        }
        public static void Main()
        {
            //Calculator.Add(20, 30);
            _52_Attributes_Calculator.Add(new List<int>() { 10, 20, 30, 40 });


        }
    }
}