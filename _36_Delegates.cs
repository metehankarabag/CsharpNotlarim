using System;
namespace Dersler
{
    /*DELEGE NEDİR?
	  Delegate method işaretçisidir. Delegate oluşturmak method açıklaması oluşturmaya benzer. Ek olarak dönüş türünden önce Delegate anahtarı alır.  Yani Delegate anahtarını çıkardığımızda bir method açıklaması görürüz ve oluşturacağımz Delegate örneği sadece bu açıklamaya uyan methodları çalıştırabilir. Bu yüzde DELEGATE'lere güvenli method işaretçisi denir.
	  Delegate kullanımı ise sınıflara benzerdir. Kurulurken Consructor'ı çalıştıracağı methoun adını parametre olarak ister. Delege türündeki referans artık metodu temsil eder. Referansın kullanıldığı yerde metod çalıştırılır. Gerçek method parametreleri ile birlikte Delegate Contructer'ında kullanırsak. Delegate oluşturulduğu yerde metod çalıştırılır.
	  
	  Delegete'ler referans türüdür.
    */
    public delegate void HelloFunctionDelegate(string Message);

    public class _36_Delegates
    {
        public static void Main()
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello From Delegate");
        }
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}