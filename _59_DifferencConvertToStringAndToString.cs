using System;

namespace Dersler
{
    /*Convert.ToString() ve .ToString()
      1. Convert.ToString() methodu C#'ın anlayabildiği bir nesneyi STRING'e çevirmeye çalışır. Yani tanımsız nesne alırsa hata verir. Null c#'da tanımlanmış.
      2. ToString() metodu INSTANCE method'dur. Çünkü STRING'e çevirmek için bir nesne örneği bekliyor. Bir object NULL değeri almış ise henüz oluşturulmadığı anlamına gelir ve  olmayan bir şeyi STRING'e çeviremeyiz. Bu yüzden NULL REFERANCE EXCEPTION hatası alıyoruz.
      3. Ne zaman ne kullanacağımızı araştıracağız. Anlamadım ne dedi.
    */

    public class _59_DifferencConvertToStringAndToString
    {
        public static void Main()
        {
            _59_Customer c1 = null;
            string str1 = Convert.ToString(c1);
            Console.WriteLine(str1);

            Console.ReadLine();
            string str = c1.ToString();
            Console.WriteLine(str);
        }
    }
    public class _59_Customer
    {
        public string Name { get; set; }
    }
}
