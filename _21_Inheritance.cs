using System;

namespace Dersler
{	
	/*Neden Inherıtance
	  Bir birine benzeyen nesneler oluşturmak istediğimizde Inherıtance'i kullanırız. Inheritance bir sınıfın kendi üyelerini başka sınıflarla paylaşmasıdır. Nesnenelerin benzer özelliklerini bir sınıfda topladıktan sonra, bu sınıfı diğerlerinin base sınıfı yapıyoruz. 
      Türeyen sınıfın kurucusunu çalıştırdığımızda ilk önce base sınıfın kurucusu çalışır ve base sınıf kurulur. Yani Referans değişkenine iki sınıf gönderilir. Referans'ın türü base ise base sınıfın üyelerini türeyen sınıf ise türeyen sınıfın üyelerini kullanırız. Type cast ile tür degiştirebiliriz. 
        Türeyen sınıfda Base kelimesini base class'ın bir örneğini temsil eder.
    */
    public class _21_Inheritance
    {
        public class _21_Employee
        {
            public _21_Employee() { }
            public string firstname;
            public string lastname;
            public string email;
            public void Printfullname()
            {
                Console.WriteLine(firstname + " " + lastname);
            }
        }
        public class _21_Fulltimeemployee : _21_Employee
        {
            public float yearlysalary;
        }

        public class _21_Parttimeemployee : _21_Employee
        {
            public _21_Parttimeemployee() { }
            public float hourlyRate;
            
        }

        public static void Main()
        {
            _21_Fulltimeemployee FTE = new _21_Fulltimeemployee();
            FTE.firstname = "Pragim";
            FTE.lastname = "Tech";
            FTE.yearlysalary = 500000;
            FTE.Printfullname();

            _21_Parttimeemployee PTE = new _21_Parttimeemployee();
            PTE.firstname = "Pragim";
            PTE.lastname = "Tech";
            PTE.hourlyRate = 100;
            PTE.Printfullname();
        }
    }
}