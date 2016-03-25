using System;
namespace Dersler
{
	/*Referance Type ve Value Type nedir?
	  Referans'lar taşıdığı değer göre 2 tür dedir. Referance türündeki referansların değeri Ram'de temsil ettiği alana(nesneye) giden yoldur. Bu yüzden değerlerini başka referanslara attıklarında kendi alanını paylaşmış olur ve diğer referanslarla yapılan işten etkilenirler.
	   VALUE türündeki referans değişkenleri ise temsil ettiği alanda bulunan tüm değerleri gönderir. Bu yüzden değerini başka bir değere attığında kendi alanındaki nesne etkilenmez. 
	  1. Not: REF anahtarı uygulanmış değişkene gönderilen değeri yoluyla birlikte almamızı(sadece almak) sağlar. Yani sadece Value Type'larla ve metod parametrelerinde kullanılır
	  2. VALUE TYPE'lar RAM'in STACK, REFANCE TYPE'lar ise HEAP alanında tutulur.
	*/
    /* STRUCT ile CLASS ARASINDAKİ FARKLAR
	  1.Struct Value türüdür. Class Referans türüdür. Bir Field'daki değeri başka bir field'a veya metod'a attığımızda, field struct türünde ise işlemler yeni alanlarda gerçekleşeceği için field'daki değer etkilenmez. Fİeld' Class türünde ise Field'daki nesne etkilenir.
		 Struct türündeki değişkeni bir field'a veya metoda attığımızda yapılan değişikliklerden  nesnesi(alanı)etkilenmez.
	  2.Program, Struct türündeki değişkenin geçersiz olduğu bir alana aktığı anda Field kullandığı alan ile birlikte hemen silinir. Çünkü kullanılan alanın tekrar kullanılmayacağı kesindir. Class türündeki değişken de ise sadece yol silinir nesne(alan) kalır. GARBAGE aynı nesneyi(alanı) kullanan başka bir FIELD varmı diye kontrol eder yoksa nesneyi(alanı) siler.
	  Dolayısıyla Struct'larda Destructor yoktur. Class'larda vardır.
      3. STRUCT'ların nesnesi olmadığı için parametresiz CONSTRUCTOR ekleyemeyiz ama CLASS'lara ekleyebiliriz. 
      4. STRUCT bir CLASS'tan miras alamaz fakat bir CLASS bir CLASS'tan miras alabilir. İkiside bir INTERFACE'den miras alabilir.
      Not: Bir CLASS veya bir STRUCT bakşa bir STRUCT'tan miras alamaz. Çünkü STRUCTlar SEALED türlerdir.
     */

    public struct _29_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class _29_DifferenceBetweenClassesAndStructs
    {
        public static void Main()
        {
			int i = 0; 
            if (i == 10)
            {
                //int j = 20;
                _29_Customer c1 = new _29_Customer();
                c1.ID = 101;
                c1.Name = "Mark";
            }
			
            int a = 10;
            int b = a;

            b++;
            _29_Customer A1 = new _29_Customer();
            A1.ID = 101;
            A1.Name = "Mark";
            _29_Customer A2 = A1;
            A2.Name = "Mary";
        }
    }
}