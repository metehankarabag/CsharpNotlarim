using System;
namespace Dersler
{
    /*45. derste enum yerine INT kullanıldı. 46'da Enum kullanıldı.
      47. Ders
	  Enum'lar Abstract sınıfdır, Value Type'dır, Strongly type'dır, içlerinde sayım bildirir. Yani Enum değişkenine bir Int değeri atmak için Cast gerekir. Bir Enum üyesinin alt türü olan INT'i INT değişkenine atmak için de CAST gerekir. Bu durum Farklı ENUM türleri içinde geçerlidir.
	  Not: Bir Enum değişkeni sadece INT değer alır. Yani başka bir ENUM üyesi attığımızda da int değerini göndermiş oluruz.
	 		Gönderilen int değerinin alındığı yerde bir karşılığı yoksa, değişkenden int değer alınır varsa varolan üye alınır.
      
	  ENUM'ların varsayılan alt değerleri INTEGER, başlangış değeri 0'dır ve 1'er 1'er artar. Üyeler atama operatörünün solunda alt değerleri sağında olur. ENUM'un alt değer türünü, oluşturduğumuz Enum'u sayısal bir türden türeterek ile değiştirebiliriz. Başlangıç değeri belirtebilir veya her üyeye rasgele değer atayabiliriz. 
	  Küçük harfler ile ENUM yazımı ENUM sıralaması oluşturmak için kullanılırken, ENUM CLASS'ı, static methodlarını barındırır. Bu methodların hepsi ilk parametre olarak typeof() içinde oluşturduğumuz ENUM türünü ister.
      
      GetValues() methodu ENUM türüne ait üyelerin alt değerlerini döner.(Varsayılanı INT)		
      GetNames() methodlarıda üylerin adlarını döner.
	  GetName() gibi methodları 2 parametre alır. 1. parametredeki türde, 2. parametredeki değeri arar.(int değeri veya üye adı olabilir)
	  
	  switch(kontrolEdilecekDegeriVerenNesne) 
	  { case degerinAlabilecegideğer: işlem return İslemSonucu; .... default: return:"Hiç bir durum gerçekleşmediğinde dönecek değer."}
     */
    public enum Gender : short
    {
        Unknown,
        Male,
        Famale
    }
	
    public  class _45_Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
    public class _45_WhyEnums
    {
        public static string GetGender(Gender Gender)
        {
            switch (Gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Famale:
                    return "Famale";
                default:
                    return "Invalid data detected";
            }
        }

        public static void Main()
        {
            _45_Customer[] cstm = new _45_Customer[3];
            cstm[0] = new _45_Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };
            cstm[1] = new _45_Customer
            {
                Name = "Mary",
                Gender = Gender.Famale
            };
            cstm[2] = new _45_Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };
            foreach (_45_Customer cstma in cstm)
            {
                Console.WriteLine("Name = {0} and Gender = {1}", cstma.Name, GetGender(cstma.Gender));
            }
			//47.ders
			int[]values = (int[])Enum.GetValues(typeof(Gender));
			string[]values1 = Enum.GetNames(typeof(Gender));
			string value = Enum.GetName(typeof(Gender), 2);
			Gender gender = (Gender)3;
			int value1 = (int)Gender.Famale;
			
        }
    }
}