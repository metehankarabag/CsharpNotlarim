using System;

namespace Dersler
{
    /*POLYMORPHISM
	  Referans türü Base sınıf olduğunda, türeyen sınıfın kurusunu uygulasak bile base sınıfın üyelerini çalıştırabiliriz. Polymorhism, base sınıfın türeyen sınıflar gibi davranabilmesidir. Yani Base sınıfın metodunu kullanıp türeyen sınıfdaki methodu çalıştırmak istiyoruz. Bu işi yapabilmek için base sınıfdaki methodu virtual kelimesiyle sanallaştırıp, türeyen sınıfdaki methodlara override kelimesini eklemeliyiz. Bu işleme Method overriding denir.  Türeyen sınıfda override method varsa, her zaman türeyen sınıftaki method çalışır yoksa base sınıfdaki method çalışır.
      NOT: Geçersiz kılma işleminin kısayolu: CHILD sınıfda OVERRIDE yaz boşluk ver. BASE method görüncek otomatik ekle
    */


    public class _23_Employee
    {
        public _23_Employee() 
        { 
        }
        public string firstname = "FN";
        public string lastname = "LN";

        public virtual void printfullname() 
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }
    public class _23_ParttimeEmloyee : _23_Employee
    {
        public int a = 1;
        public override void printfullname()
        {
            Console.WriteLine(firstname + " " + lastname + " - Part Time");
        }
    }
    public class _23_FulltimeEmployee : _23_Employee
    {
        public override void printfullname()
        {
            Console.WriteLine(firstname + " " + lastname + " - Full Time");
        }
    }
    public class _23_Polymorphism_TemporaryEmployee : _23_Employee
    {
        public override void printfullname()
        {
            Console.WriteLine(firstname + " " + lastname + " - Temporart");
        }
    }
    public class _23_Polymorphism
    {
        public static void Main()
        {
            _23_Employee[] E = new _23_Employee[4];
            E[0] = new _23_Employee();
            E[1] = new _23_ParttimeEmloyee();
            E[2] = new _23_FulltimeEmployee();
            E[3] = new _23_Polymorphism_TemporaryEmployee();

            foreach (_23_Employee e in E)
            {
                e.printfullname();
            }


        }
    }

}