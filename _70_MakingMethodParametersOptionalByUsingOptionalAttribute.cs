using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;// Attribute kullanmak için bunu ekledik.

namespace Dersler
{
	/*
      OPTIONAL parametre oluşturmak için bir parametreye OPTIONAL ATRRIBUTE'unu uygulayabiliriz ve bu parametreden sonra OPTIONAL olmayan bir parametre ekleyebiliriz. Eklediğimizde methodu kullanırken parametre Optional özelliğini kaybediyor. Fakat kullanıcıya parametrenin varsayılan değer aldığı gösteriliyor.
     */
    public class _70_MakingMethodParametersOptionalByUsingOptionalAttribute
    {
        public static void Main()
        {
            AddNumbers(10, 63);
        }                                                               //[OptionalAttribute] de yazılabilir.
        public static void AddNumbers(int firstNumber, int secondNumber, [Optional]int[] restOfNumbers)
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

    }
}
