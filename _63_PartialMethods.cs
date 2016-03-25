using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /* PARTIAL METHOD
     1. PARTIAL METHOD'lar iki kısımdan oluşur. - HEADER -BODY
     2. PARTIAL METHOD'un uygulaması tercihe bağlıdır. 
        Olmassa hata almayız düzenleyiciler görmezden gelir.
     3. PARTIAL METHOD'larda ACCES, VIRTUAL, ABSTRACT, OVERRIDE,NEW, SEALED MODIFIER'lar kullanılamaz. 
        Varsayılan ACCES MODIFIER private'dır.
     4. PARTIAL METHOD'un açıklamasını belirtmessek o zaman hata alırız. 
        Çünkü böyle olduğunda normal bir method gibi görünüyor.
     5. PARTIAL METHOD'ların dönüştürü olmaz.
     6. PARTIAL METHOD'lar PRİVATE olduğu için dışarıdan çağırılamaz. 
        Bu yüzden bir method içinde dışarı çıkabilir.
     7. PARTIAL METHOD'lar PARTIAL CLASS veya STRUCT'lar içinde oluşturulabilir.
     8. Bir PARTIAL METHOD'ın sadece bir uygulama kısımı olur. 2 tane oluşsa hata alırız.
    */

    public class _63__ialMethods
    {
        public static void Main()
        {
            _63_Sample_ialClass spc = new _63_Sample_ialClass();
            //spc.PulicMethod();
            spc.PulbicMethod1();
        }
    }

    #region PARTIAL CLASS'lar
    public partial class _63_Sample_ialClass
    {
        partial void Sample_ialMethod();// boş olduğu için düzeneme zamanında hata vermiyor ve çalışma zamanında görmezdan geliyor.
        
        public void PulicMethod()
        {
            Console.WriteLine("PublicMethod Invoked");
            Sample_ialMethod();// doğal olarak bunuda görmezdan geliyor.
        }
    }

    public partial class _63_Sample_ialClass
    {
        partial void Sample_ialMethod()
        {
            Console.WriteLine("Sample_ialMethod Invoked");
        }
        partial void Sample_ialMethod1(int i);

        partial void Sample_ialMethod1(int i)
        {
            Console.WriteLine("Metehan KARABAĞ");
        }

        public void PulbicMethod1()
        {
            Sample_ialMethod1(10);
            Console.WriteLine("Public");

        }
    }
    #endregion
}
