using System;
namespace Dersler
{
    /*EXCEPTİON HANDLİNG
     EXCEPTİON progam çalıştığında ordaya çıkan(occur) beklenmedik hatalardır. 
     Örneğin bir uygulama sorgu ile çalışırken, veri tabanı bağlantısı kayboldu. 
     EXCEPTİON HANDLİNG bu senaryoları işlemek için kullanılır.
     Programın mantıksal akışı için EXCEPTİON HANDLİNG kullanma kötüdür ve EXCEPTİON HANDLİNG'i kötüye kullanma olarak adlandırılır.(Yani hatalar üzerinden bir mantık kurma diyor.)
	 
	 Not: int32 sınıfının statik PROPERTY'leri olan MinValue ve MaxValue int değerinin sınırlarını belirler.
    */
    public class _43_ExceptionHanlingAbuse
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please  enter Numerator");
                int Numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please  enter Denominator");
                int Denominator = Convert.ToInt32(Console.ReadLine());

                int Result = Numerator / Denominator;
                Console.WriteLine("Reslt = {0}", Result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Only number between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Denominator can not be zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}