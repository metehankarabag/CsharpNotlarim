using System;

namespace Dersler
{
    /*GENERİC
      CLASS'lar ve METHOD'lar ile kullanılır. Kullanabiliyor olmamız için yazdığımız kodun tüm veri türeleri ile çalışabiliyor olması gerekir. Çünkü kullanılacak veri türü kullanıcı tarafından belirlenir ve istediği türü belirleyebilir. GENERIC aynı işi farklı veri türleri ile yapan farklı method ve CLASS'ları tek seferde yazmamızı sağlar.
      
      Generic bir CLASS veya METHOD tanımlamak için isimlerinden sonra <T> belirlenir. CLASS düzeyinde GENERIC type belirleme CLASS seviyesinden belirtilen TYPE ile FIELD, PROPERTY, vs.. oluşturmamızı sağlar. Generic bir CLASS'ı kurmak için hem CLASS adından hemde CONSTRUCTOR'ında TYPE belirtilmelidir. Generic bir methodu kullanırken de method adından sonra TYPE'ı belirleriz ve type sadecee method alanı içinde geçerlidir. Bir TYPE belirlendiğinde(örn T), belirlenen TYPE tüm CLASS'da aynı veri türü ile çalıştığı için GENERIC'ler STRONGLY TYPED'dır.
      
      Aşağıdaki örnekte her tür verinin eşitliğini kontrol edebilen bir method var.
      Bunu sağlayan GENERIC kullanmamızdır.
      Method'a parametre olarak object türü de alabilirdik. Fakat aynı anda hem int hemde string kullanabileceğimiz için doğru olmazdı ve bir VALUE TYPE'ı REFERANCE TYPE'a çevirmek performansı düşürür.(boxing)
     */

    public class _56_Calculator<T>//generic class
    {
        public static bool AreEqual(T Value1, T Value2)//generic method
        {
            return Value1.Equals(Value2);
        }
    }

    public class _56_Generics
    {
        public static void Main()
        {

            //bool Equal = _56_Calculator.AreEqual(10, 10);
            bool Equal = _56_Calculator<int>.AreEqual(1, 2);
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}