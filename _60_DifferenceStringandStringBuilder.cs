using System;
using System.Text;

namespace Dersler//_60_DifferenceStringandStringBuilder
{
    /* SYSTEM.STRING() ile STRINGBUİLDER arasındaki farklar
      1. SYSTEM.STRING() değişmezdir. STRINGBUİLDER ise değişkendir. 
        a) Aynı SYSTEM.STRING()'e bir yazı yazdığımızda heapte bir alan oluşurur. 
           += kullanarak bu yazıya bir yazı eklemeye çalıştırğımızda SYSTEM.STRING() değiştirilimez olduğu için 
           REFERANCE değeri 2. alanı oluşturur ve yazıları baştan ekler. 
           Heap'de oluşturulan tüm alanı GARBAGE siler ve GARBAGE çalışana kadar program fazla RAM kullanır.
        b) STRINGBUİLDER'a bir yazı yazdığımızda, değişken olduğu için STRINGBUİLDER CLASS'ının Append() INSTANCE methodu ile alana yeni metin eklediğimizde yeni nesne oluşturulmaz yazı aynı nesneye eklenir. 
           Bu Heap'te alan ve prerformans sağlar.

      2. Bunun gibi yazıların değiştiği durumlar için SystemBuilder kullanılır.(Çok fazla değişmiyorsa string de kullanılabilir.)
    */

    public class _60_DifferenceStringandStringBuilder
    {
        public static void Main()
        {
            string userString = "C# "; // her string için heap alanında bir yer açıyor.
            userString += "Video ";
            userString += "Tutorial ";
            userString += "For ";
            userString += "Beginners ";
            Console.WriteLine(userString);

            StringBuilder UserString = new StringBuilder("C# ");
            UserString.Append("Video ");
            UserString.Append("Tutorial ");
            UserString.Append("For ");
            UserString.Append("Beginners ");
            Console.WriteLine(UserString);

            //string usrString = string.Empty;
            //for (int i = 0; i <= 10000; i++)
            //{
            //    usrString += i.ToString() + " ";
            //}
            //Console.WriteLine(usrString);

            StringBuilder UsrString = new StringBuilder();
            for (int i = 0; i <= 10000; i++)
            {
                UsrString.Append(i.ToString() + " ");
            }
            Console.WriteLine(UsrString);
        }
    }
}
