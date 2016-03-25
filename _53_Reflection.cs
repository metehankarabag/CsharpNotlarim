using System;
using System.Reflection; 

namespace Dersler//_53_Reflection    
{
    public class _53_Reflection
    {
        /* REFLECTİON(Yansıma)
         REFLECTİON çalışma zamanında herhangi bir ASSEMBLY'nin METADATA'larına ulaşmayı sağlar. (METADATA = sınıfın içeriği)
         Bir ASSEMBLY'deki tüm CLASS'ları bulmak ve üyelerini çalıştırmak için kullanılır.
        
         REFLECTİON KULLANIMI
         1. Visual Studio PROPERTY'i penceresi kullanır. Alana bir nesne attığımızda, TYPE CLASS'ı kullanılarak nesnenin türü alınır ve TYPE CLASS'ının INSTANCE methodları olan GETPROPERTY() gibi methodlar ile tüm özellikleri pencereye yansıtılır.
         
		 2. REFLECTİON ile LATE BİNDİNG'e kullanılabilir. (55.ders)
		 Uygulamamızda yüklü olmayan bir ASSEMBLY'i, ASSEMBLY CLASS'ının STATIC methodlarını kullanarak uygulamaya çekebiliriz. Oluşturduğumuz ASSMBLY örneğine GETTYPE() method uygulanır ve parametre olarak da ASSMEBLY içindeki bir CLASS'ın tam adı string olarak girilir. Bulunan CLASS TYPE CLASS türündeki bir değişkene atıldıktan sonra tüm CLASS bilgisi uygulamaya getirilmiş olur. Artık gerekli CLASS'ları ve methodları kullanara eklenen CLASS'ın üylerini çalıştırabiliriz.
		 
         3. Bir INTERFACE'in 2 uygulaması varsa ve hangi uygulama sınıfının çalışacağınıa kullanıcı karar verecekse CONFIG dosyasını kullanarak bunu yapabiliriz.
			Kullanıcı çalışma zamanında istediği CLASS'ı seçer ve program o CLASS'ın nesnelerini oluşturur ve kullanır.
        */

       public class _53_Customer
       {
           public int Id { get; set; }
           public string Name { get; set; }

           public _53_Customer(int Id, string Name)
           {
               this.Id = Id;
               this.Name = Name;
           }
           public _53_Customer()
           {
               this.Id = -1;
               this.Name = string.Empty;
           }
           public void PrintID()
           {
               Console.WriteLine("ID= {0}", this.Id);
           }
           public void PrintName()
           {
               Console.WriteLine("Name = {0}", this.Name);
           }
       }

        public static void Main()
        {

            //Type T = Type.GetType("Pragim.Customer1111");
            //Type T = typeof(Customer);
            //üstteki ile aynı
            _53_Customer C1 = new _53_Customer();
            Type T = C1.GetType();

            #region Burada T. yazıp tam tür adı, tür adı, ve türün içinde olduğu NAMESPACE adını aldık
            Console.WriteLine("Full Name = {0}",T.FullName);
            Console.WriteLine("Just the Name = {0}", T.Name);
            Console.WriteLine("Just the Namespace = {0}", T.Namespace);
            Console.WriteLine();
            #endregion

            Console.WriteLine();
            Console.WriteLine("Properties in Customer");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                #region property Türü adını ve property adını aldık.
                Console.WriteLine(property.PropertyType.Name +" "+ property.Name);
                #endregion
            }

            Console.WriteLine();
            Console.WriteLine("Method in Customer class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                #region Methoların dönüş türü ve method adlarını aldık
                Console.WriteLine(method.ReflectedType.Name+ " " + method.Name);
                #endregion
            }

            Console.WriteLine();
            Console.WriteLine("Constructor in Customer class");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(/*constructor.Name*/constructor.ToString()); //.ctor consturcter'i gösteriyor. ToString deyince komple adı alıyoruz.
            }
        }
    }
}