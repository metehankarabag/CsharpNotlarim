using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Dersler
{
    /*
     SHARED RESOURCE = Birden fazla method/işlem tarafından kullanılabilen FIELD ve PROPERTY.., gibi nesnelerden gelen bilgiye deniyor.
     MULTITHREAD programda bir SHARED RESOURCE'ın aynı anda 2 işlem bağlanırsa, bir işlemin değiştirdiği veri diğer alanda değişmediği için eski değer üzerinden iş gerçekleşir.
     Tek THREAD'lı programlarda bu sorun olmaz. Çünkü bütün iş aynı çalışma ortamında ve sırayla gerçekleşir.
     
     Aşağıda
     THREAD kullanmadan programa 3 kez 1 milyon ekledik.
     CMD'de programı çalıştırdık. Her çalıştırdığımızda 3 milyon aldık.
     "D:\2_Uygulamalar\1_C#\93 ProtectingSharedResourcesFromConcurrentAccessInMultithreading\_93_ProtectingSharedResourcesFrmCncurrntAccss\bin\Debug\_93_ProtectingSharedResourcesFrmCncurrntAccss.exe"
     
     THREAD kullandıktan bazen farklı sonuçlar aldık.
     Bunun nedeni SHARED RESOURCE kullanmamız ve ++ operatörünün THREAD güvenliği olmaması.
     
     Bu sorunu çözmenini 2 yolu var
     1. ++ yerine Interlocked CLASS'ının Increment() methodunu kullanarak değeri arttırmak.
     
     Parametre olarak vereceğimiz değer REF türünde olacak.
     REF: VALUE TYPE'ların çalışma şeklini REFERANS TYPE'lara benzetmek için kullanılır.
          VALUE TYPE değer aktarımı yarken sadece değerini gönderir. Bu yüzden değerin alındığı yerde yapılan işten etkilenmez.
          Çünkü olay farklı bir alanda oluyor.
          REFERANCE TYPE'larda ise  değer olarak alanı işaret eden REFERANCE gittiği için yapılan her değişiklik aynı alanı etkiler.
          REF anahtarı VALUE TPYE'ların değer olarak REFERANCE'ını göndermesini sağlar.
     
      ++'ın THREAD güvenliğini olmama nedeni de bu değer türü olarak çalışıldığı için ve değerler bir birinden bağımsız çalışıyor ve istenen sonucu alamıyoruz.
      Not: Ref anahatarı method parametrelerinde kullanılır. Değer gönderirkende yazılır.
      
     2. STATIC bir OBJECT oluşturup
       lock anahtarı içinde ++ kullanmak
      
     
     Bu sorunu çözmenin 2 yolu var ama hangisi daha iyi?
     Hız testi yapmak için System.Diagnostics NAMESPACE'sini kullanıyoruz.(işlem aşağıda belli)
     Performas olarak Interlocked CLASS'ı daha iyi (Neredeyse 2 kat daha hızlı. Büyük ihtimalle çift çekirdekden dolayı)
     Çünkü LOCKING bir RESOURCE ile geçerli THREAD'i kilitlediği için diğer THREAD'lerin bu RESOURCE'u kullanmasını engeller.
     Interlocked CLASS'da ek olarak çıkarma toplama veya incrementing, decrementing, adding, and reading gibi işlemlerde var
     
     Not: 1 mili saniye = on bin ticks
          Ticks in saat li dk lık günlük değerlerini öğrenmek için TimeSpan.Ticks yazarak bulabiliriz.
     
     
     */
    class _93_ProtectingSharedResourcesFrmCncurrntAccss
    {
        #region THREAD kullanmadan önce
        //static int Total = 0;
        //public static void Main()
        //{
        //    AddOneMillion();
        //    AddOneMillion();
        //    AddOneMillion();
        //    Console.WriteLine("Total = " + Total);
        //}

        //public static void AddOneMillion()
        //{
        //    for (int i = 1; i <= 1000000; i++)
        //    {
        //        Total++;
        //    }
        //}
        #endregion

        static int Total = 0;
        public static void Main()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread thread1 = new Thread(_93_ProtectingSharedResourcesFrmCncurrntAccss.AddOneMillion);
            Thread thread2 = new Thread(_93_ProtectingSharedResourcesFrmCncurrntAccss.AddOneMillion);
            Thread thread3 = new Thread(_93_ProtectingSharedResourcesFrmCncurrntAccss.AddOneMillion);

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

        public static void AddOneMillion()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                //Total++;
                Interlocked.Increment(ref Total);
            
            }
        }

        static object _lock = new object();
        public static void AddOneMillion2()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    Total++;
                }
            }
        }
    }
}
