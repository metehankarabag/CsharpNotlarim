using System;
namespace Dersler//
{
    /* FARKLAR
     1- Abstract sınıfında Abstract ön eki almayan üyelerinin uygulaması olabilir, 
        Interface'nin hiç bir üyesinde uygulama olmaz.
     2- Abstract üyeleri Access modifyer alabilir ve varsayılanı Private'dir, 
        Interface üyeleri Access modifyer alamaz ve varsayılanı Public'dir. 
     3- Field Abstract üylesi olabilir, 
        Field Interface üyesi olamaz. 
     4- Abstract sınıflar bir Abstract sınıftan veya Interface'den miras alabilir, 
        Interface sadece başka bir Interface'den miras alabilir.
     5- Bir CLASS aynı anda birden fazla Interface'den miras alabilir, 
        Birdan fazla CLASS'tan miras alamaz ve Abstract'da bir sınıf türüdür.
     6- Abstract sınıfdan türeyen Abstract Class Base üyelerine uygulama yapmak zorunda değil. Fakat CLASS'larda aynı açıklma varsa hata verir. Interfacede vermez.
	 
	*/

    public abstract class _33_Customer
    {
        public void Print()
        {
            Console.WriteLine("Abstract Class'lar içinde Abstract olmayan methodlar barındırabilir ve bunların bodysi olabilir\nInterface üyelerinin uygulaması olamaz.");
        }
    }

    public Interface ICustomer
    {
        void Print();
    }


    public class _33_ : _33_Customer
    {
        public static void Main()
        {
            _33_Customer c = new _33_();
            c.Print();
        }
    }
}