using System;
namespace Dersler
{
	/*
	  Sürekli kontrol sağlayarak programın hata olasılığını düşürmek.
	  Not: Int32 sınıfının static methodu olan TryParse() parametre alır. Birinci int'e çevirilecek string'in int'e çevirilmesi gerçekleşirse değer out parametresi ile çıkar ve method true döner. Gerçekleşmesse false döner.
	*/
    public class _44_ExceptionHanlingAbuse
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Please  enter Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccesfull = Int32.TryParse(Console.ReadLine(), out Numerator);// boolen türünde değer veriyor TryParse

                if (IsNumeratorConversionSuccesfull)
                {
                    Console.WriteLine("Please  enter Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccesfull = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDenominatorConversionSuccesfull && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Reslt = {0}", Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator can not be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valied number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Numerator should be a valied number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
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