using System;
namespace Dersler

    /*INTERFACE
	  INTERFACE'ler, üye olarak Method, Property ve Indexer gibi nesnelerin açıklamalarını içerir ve türettiği CLASS'ı, tüm açıklamaları için uygulama barındırmaya zorlar.  Interface'leri birbirine benzeyen nesneler oluşturmak istiyorsak, ve temel nesnenin hiç uyguma ihtiyacı yoksa, kullanırız. Temel nesnenin işe ihtiyacı olsaydı Interface yerine sınıfları kullanırdık.
     
 	  1 - Üyleri ile Access Modifyer kullanmaz.  Varsayılanı Public'tir. 
 	  2 - Field, üyesi olamaz.
 	  3 - Tüm üyelerin türeyen sınıflarda kullanılması gerekir.
 	  5 - Bir Interface Base Interface'in method açıklamalarını barındırmak zorunda değil. Fakat son Interface bir sınıfa miras verirse, sınıf tüm Interface'lerin açıklamalarını taşımak zorunda. Bu sınıf başka bir sınıfa miras verirse son sınıf Interface açıklamasını taşımak zorunda değil zaten base sınıfta var.)
 	  6 - Interface'lerin bir örneğini oluşturamayız, zaten bu mantıklı değil Interface'ler iş yapmaz.
          
	  NOT: I sadece interface olduğunu belirtiyor sınıftan ayırmak için
      NOT: Ctrl + . ile eklenebilir.
    */
    interface ICustomer1
    {
        void Print1();
    }
    interface ICustomer2 : ICustomer1
    {
        void Print2();

    }
	
    public class _30_Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface print1 method");
        }

        public void Print2()
        {
            Console.WriteLine("Interface print2 method");
        }
    }
    public class _30_Interfaces
    {
        public _30_Interfaces()
        {
            _30_Customer c1 = new _30_Customer();
            c1.Print1();
            c1.Print2();
        }
    }
}