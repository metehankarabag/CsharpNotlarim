using System;
using System.Reflection;

namespace Dersler
{
    /*
	  ASSEMBLY CLASS'ı abstract bir CLASS'dır ve 14 STATIC methodu vardır ve çoğu programa dışarıdaki bir ASSEMBLY'i yüklemek için kullanılır.
		GetExecutingAssembly(): uygulamayı çalıştıran ASSEMBLY'leri programa getirir.
		GetAssembly(): Parametre bir CLASS'ı TYPE'ını alır ve CLASS'ı barındıran ASSMBLY'i döner. Yani parametre olarak girilecek CLASS tanımlı olduğu için ASSEMBLY'ninde yüklenmiş olması gerekir. vs...
	
	  Programa getirilen assembly'i bir FIELD'a aldıktan sonra, ASSEMBLY içinden bir CLASS'ı alabilmek için, FIELD'a GetType("CLASSIN.TAMADI") methodunu uygulamalıyız. GetType() methodu CLASS'ı bir TYPE türü olarak dönüyor. 
	  TYPE FIELD'ından CLASS'ın methodunu alabilmek için FIELD'a Getmethod("MethodAdi") methodu uygularız. Bu method METHODINFO türü dönüyor. 
	  Çalıştırmayı istediğimiz bu method CLASS'ın INSTANCE üyesi olduğu için ACTIVATOR CLASS'ının CreateInstance() STATIC methoduna parametre olarak oluşturduğumuz TYPE'ı vererek nesne örneğini oluşturmalıyız. Methodun bu overload'ı object döner. methodun 15 overload'ı vardır.
	  MethodInfo FIELD'ındaki methodu çalıştırmak için Invoke() metohdunu kullanıyoruz. 1. parametre olarak INSTANCE nesnesi 2. parametre olarak da methodun istediği parametreleri bir dizi içinde veriyoruz.
    */

    public class _55_Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }

    public class _55_LateBindingUsingReflection
    {
        public static void Main()
        {
            #region EARLY BİNDİNG
            //Customer c1 = new Customer();
            //string fullname = c1.GetFullName("Pragim","Tech");
            //Console.WriteLine("Full Name = {0}",fullname);
            #endregion

            Assembly executingAssembly = Assembly.GetExecutingAssembly() ;
            Type customertype = executingAssembly.GetType("Dersler._55_Customer");
            object customerInstance = Activator.CreateInstance(customertype);//method static olmadığı için kullandık static olsaydı gerek yoktu
            MethodInfo GetFullNameMethod = customertype.GetMethod("GetFullName");

            string[] parameters= new string[2];
            parameters[0] = "pragim";
            parameters[1] = "Technologies";

            string fullname =(string)GetFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name = {0}", fullname);

            
        }
    }
}