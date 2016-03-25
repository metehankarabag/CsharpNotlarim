using System;
namespace Dersler
{
    /*MULTİCAST DELEGE
	  DELEGATE'ler CONTRUCTER'ında sadece bir method adı alarak oluşturulur. Fakat DELEGATE örneklerine +=/-= operatörlerini kullanarak DELEGATE açıklamasında uymak şartı ile yeni methodlar ekleyebiliriz. DELEGATE örneği bir method gibi çalıştırıldığında eklenen methodların hepsi sırayla çalışır. Çalıştırılan methodları dönüştürü varsa, DELEGATE örneğinden en son çalışan methodun dönüş değeri alınır. Aynı durum out parametreli methodlar için de geçerlidir. En son çalışan methodun out değeri alınır. 
    */
    public delegate void SampleDelegate();
    public delegate int SampleDelegate1();
    public delegate int SampleDelegate2(out int Integer);

    public class _39_MulticastDelegates
    {

        public static void Main()
        {
            //SampleDelegate del, del1, del2, del3; 
            //del = new SampleDelegate(SempleMethodOne);
            //del1 = new SampleDelegate(SempleMethodOne1);
            //del2 = new SampleDelegate(SempleMethodOne2);

            //del3 = del + del1 + del2 - del1; 
            //del3();//Delegeyi çalıştırdı.

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodOne1;
            del += SampleMethodOne2;
            del -= SampleMethodOne;
            del();

            // 2 - 
            SampleDelegate1 del1 = new SampleDelegate1(IntMethodOne);
            del1 += IntMethodOne1;
            int DelegateReturnValue = del1();
            Console.WriteLine("DelegateReturnValue = {0}", DelegateReturnValue);

            // 3 -
            SampleDelegate2 del2 = new SampleDelegate2(OutIntMethodOne);
            del2 += OutIntMethodOne1;
            //4 - 
            int DelegateReturnOutputParameterValue = -1;
            del2(out DelegateReturnOutputParameterValue);
			
            Console.WriteLine("DelegateReturnValue = {0}", DelegateReturnOutputParameterValue);


        }

        public static void SampleMethodOne()
        {
            Console.WriteLine("SempleMethodOne Invoked");
        }

        public static void SampleMethodOne1()
        {
            Console.WriteLine("SempleMethodOne1 Invoked");
        }
        public static void SampleMethodOne2()
        {
            Console.WriteLine("SempleMethodOne2 Invoked");
        }

        public static int IntMethodOne()
        {
            return 1;
        }
        public static int IntMethodOne1()
        {
            return 2;
        }

        public static int OutIntMethodOne(out int Number)
        {
            return Number = 1;
        }
        public static int OutIntMethodOne1(out int Number)
        {
            return Number = 2;
        }
    }
}