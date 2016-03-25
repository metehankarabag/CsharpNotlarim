using System;
using System.Threading;

namespace Dersler
{
    /* 
      THREAD'i parametreli bir method ile kullanabilmek için ParameterizedThreadStart DELEGATE'sini kullanmalıyız.
      DELEGATE object parametre bekleyen bir method istiyor.
      DELEGATE'nin TYPE SAFE özelliğinden dolayı sadece object parametre alan bir methodu girebiliriz.
      Fakat OBJECT TYPE her türlü veriyi tutabileceği için TYPE SAFE özelliğini kaybederiz.
    */
    class _89_ParameterizedThreadStartDelegate
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the target number: ");
            int target = Convert.ToInt32(Console.ReadLine());//string'de gönderebiliriz
            _89_Number number = new _89_Number();
            //Bu delege parametre olarak object türünde bir değer istiyor, bizim method'daki parametremiz int bu yüzden hata alıyoruz. Bunu düzelttik.
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(number.PrintNumbers);

            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target);
        }
    }

    class _89_Number
    {
        public void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
