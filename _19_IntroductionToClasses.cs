using System;

namespace Dersler
{
    /* CLASS NEDİR? ...  KURUCUNUN AMACI NEDİR? ... DESTRUCTOR NEDİR?
     
      Bu derse kadar basit veri türlerini gördük(int,float,string, etc.).  Karmaşık veri türleri istediğimiz zaman sınıfları kullanırız. Sınıflar veri ve davranış içerir.
      
      KURUCUNUN(CONSTRUCTOR) AMACI NEDİR?
      Bir sınıfı kullanabilmemiz için bir nesne örneğini oluşturmamız gerekir. Kurucu method(constructor) sınıfın bir örneğini oluşturmak için kullanılır. Yani kurucudur. Basşatıcı ve çalıştırıcı method olarak da adlandırılabilir. Nesne oluşturulurken her zaman yapılmasını istediğimiz varsayılan tüm işler constructor body'de yapılır ve o işler için gerekli tüm bilgiler CONSTRUCTOR parametresinden alınır. Farklı durumlar için farklı kurucular kulurmalıdır.
     
      Araba a = new Araba();
      Yukarıdaki örnekte constructor method "Araba()" dır ve tüm sınıf içeriğini a'ya verir.
      a referans değişkenidir. Ram'de bir alanı temsil eder ve aldığı değerleri daha sonra tekrar ulaşabilmek için bu alana atar. 
      Araba bir karmaşık bir türdür ve Ram'de oluşturulacak alanın niteliklerini belirler. Yani a'nın türünü belirler.
     
      CONSTRUCTOR, SINIF adını alır, dönüş türü yoktur, tanımlanması zorunlu değildir(kendiliğinde bir tane boş kurulur.), aşırı yüklenebilirler.
      
      DESTRUCTOR NEDİR? 
      Önüne ~ sembolü alarak sınıf adı ile aynı yazılır acces modifyer,dönüştürü olmaz, parametre almaz.
    */
    public class _19_IntroductionToCLASSes_Customer
    {
        string _FistName;
        string _LastName;

		//This bu CLASS'ın bir örneği ve bu CLASS'taki her şeye sahip. (Bu CLASS'ın 2 parametreli kurucusu). 
        public _19_IntroductionToCLASSes_Customer() : this("No Fist Name provided ", "No Last Name provided ") { }
        
        public _19_IntroductionToCLASSes_Customer(string fisrtName, string lastName)
        {
            this._FistName = fisrtName;
            this._LastName = lastName;
        }
        public void printFullName()
        {
            Console.WriteLine("Fist Name : {0} , Last Name : {1}", _FistName, _LastName);
        }

        //Normalde C# garbage toplayıcıları hafızadan senin nesnelerini silmeye karar verir.
        ~_19_IntroductionToCLASSes_Customer()
        {
            //Temizlemek istediğim kodlar, bir önceki değerinin silinmesini istediğim field lar falan anladığım kadarıyla
        }
    }

    public class _19_IntroductionToCLASSes
    {
        public static void Main()
        {
            _19_IntroductionToCLASSes_Customer c1 = new _19_IntroductionToCLASSes_Customer();
            c1.printFullName();

            _19_IntroductionToCLASSes_Customer c2 = new _19_IntroductionToCLASSes_Customer("Metehan", "Karabağ");
            c2.printFullName();
            
        }
    }
}
