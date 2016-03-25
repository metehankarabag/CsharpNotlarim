using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*Optional Parameters By Specifying Parameter Defaults
      Bir methodu kurarken değer atadığımız parametre Optional parametre olur. Kullanıcı bu parametrelere değer girmesse hata almaz girerse girdiği değer geçerlidir. kullanıcı parametreye değer vermek istemiyorsa parametreyi atlamak için parametre adı + : (c:) yazmalıdır.
      Son parametre olarak bir ARRAY girilirse ve ARRAY'a NULL değeri verilerilirse, Dizi OPTIONAL parametre olur. 
      PARAMS anahtar kelimesi ile ir parametre eklediğimzde varsayıaln değer atamamıza gere yok. Parametre OPTIONAL olur.
      Not: OPTIONAL bir parametreden sonra ancak başka bir OPTIONAL parametre yazılabilir.
       */


    public class _69_MakingMethodParametersOptionalBySpecifyingParameterDefaults
    {

        public static void Main()
        {
            AddNumbers(10, 20, 30, 40);// 2 method aynı işi farklı yaptığı için kabul etmiyor galiba ismi
            Console.WriteLine();
            AddNumbers1(10, 20, new int[] { 30, 40, 50 });

            Test(10, c: 20);
        }
        public static void AddNumbers(int firstNumber, int secondNumber, params int[] restOfTheNumbers)// son kısım kullanıcının isteğinde
        {
            int result = firstNumber + secondNumber;
            foreach (int i in restOfTheNumbers)
            {
                result *= i;
            }
            Console.WriteLine("Total = " + result.ToString());
        }
        /*Ders 68*//*Ders 69*/
        public static void AddNumbers1(int firstNumber, int secondNumber, int[] restOfNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int i in restOfNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Sum = " + result);
        }


        public static void Test(int a = 1, int b = 2, int c = 3)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
