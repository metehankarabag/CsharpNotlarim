using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    public class _64_HowAndWhereIndexersUsingInCSharp
    {

        /*INDEXER
         Bir CLASS'ın dizisini oluşturmak ile CLASS'a INDEX eklemek aynı şey değil.
         Bir CLASS'ın dizini oluşturmak aynı FIELD'da bir kaç nesne örneği oluşturmak demektir.
         FIELD'a verilen değer ise nesnelerin FIELD'daki INDEX değeridir.
         
         Bir CLASS'a INDEX eklemek CLASS'ın nesnelerinden birini bulmak için kullanılır.
         Yani bir FIELD var bir nesne örneği var ve bu nesne örneği içinde birden fazla nesne/veri içeriyor.
         İçerideki nesne/veriyi bulmak için INDEX oluşturuyoruz.
         
         Yani ARRAY, RAM'deki bir alanda birden fazla nesne olmasını sağlar ve her nesneye int INDEX değeri verir. 
              INDEXER ise RAM'daki bir alanda bir nesnenin içindeki nesneleri/verileri belirli bir şarta göre arar.
          
         INDEXER oluşturma mantığı methodlara, çalışma mantığı PROPERTY'ler ile benzerdir.
          Farklar
          1 . METHOD'ların ve PROPERTY'lerin dönüş türünden sonra adı yazılır. Fakat INDEXER'ların adı olmaz dönüş türünden sonra THIS yazılır.                 (Direk nesneye uygulanmasının nedeni budur belki)
                DönüşTürü this[int a] {} -> classOrnegi[2] 
                DönüşTürü methodAdi(int a) {} -> classOrnegi.methodAdi(2)
                DönüşTürü PropertyAdi {} -> classOrnegi.PropertyAdi
          
          2. Önemli -> Methodlar parametresiz oluşturulabilir fakat INDEXER'lar parametresiz oluşturulamaz. Çünkü bir değer girilmeden bir nesne aranamaz. Indexer'ların aldığı değer [] içindedir. INDEXER'ın Get() methodu bu değer ile CLASS içindeki bir nesne getirir. Bu PROPERTY ile INDEXER'ın çalışma sırasındaki farklıdır. 
          Property GET methodu kullanıldığında CLASS içindeki bir FIELD'dan aldığı değeri getirir. 
          Indexer ise girilden değer, liste içindeki nesnelerde aranır ve nesnenin tamamı getirilir. (class.PropertyAdi == class[2])
          SET() methodlarıda aynı 
           Örnekler 
          1. HTTPSESSIONSTATE CLASS'ının METADATA'sına baktığımızda bir int ve bir string değer alan object dönen INDEXER tanımlandığını görürürüz.
          2. INT veya STRING INDEXER kullanarak (SESSION KEY numarasını veya KEY adını sütun adını verecek.)
             SQLDATAREADER, nesnesinin tamamını dönerken belirli bir sütundan veri almaktır. 
             Not: Index parameteleri KEY olarak adlandırılır.
        */


        public static void Main()
        {
            // köşeki parantez için key oluyor.
            //Session["Session1"] = "Session 1 Data";
            //Session["Session2"] = "Session 2 Data";
            string[] a = { "Session 1 Data", "Session 2 Data" };

            Console.WriteLine("Session 1 Data = " + a[0].ToString());
            Console.WriteLine("Session 2 Data = " + a[1].ToString());
        }
    }
}
