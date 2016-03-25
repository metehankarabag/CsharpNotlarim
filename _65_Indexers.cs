using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
	/*
     INDEXER'lar bir nesne içindeki nesneleri arar.
     Bu yüzden Emloyee CLASS'ı oluşturduk ve Company CLASS'ında 7 örneğini ekledik.
     Artık Employee'ler oluştulan her Company örneğinin alt nesneleri olacak.
     INDEXER'ı bu nesneler üzerinde çalıştırabiliriz.
     
     Indexer da yapılan iş
     Get() methodu içinde FirOrDefault() Extension methodu kullanıyoruz. Bu method parametresinden true değeri aldığı ilk nesneyi döner. Bu nesnenin EmpName adında bir PROPERTY'si var olduğu için PROPERTY'i buraya ekleyebiliyoruz. 
       Yani PROPERTY'i uygulamasaydık ve INDEXER'ın dönüş türü Employee olsaydu, nesnelerin sadece belirtilen PROPERTY'sine bakarak tüm nesneyi gönderebilirdik. Bu arama bize arama hızı kazandırır.
     
    SET() methodunda VALUE otomatik olarak dönderdiğimiz değeri alır. Bu değerin türünü metodun dönüş türü de belirliyor. Yani dönüştürü Employee olsaydı tüm nesneyi değiştirebilirdik.
    */
    #region Veri tutan sınıf
    public class _65_Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
    }
    #endregion

    #region İndexer'in kurulduğu sınıf
    public class _65_Company
    {//
        private List<_65_Employee> listEmployees;
        public _65_Company()
        {
            listEmployees = new List<_65_Employee>();
            listEmployees.Add(new _65_Employee { EmpID = 1, EmpName = "Mike", EmpGender = "Male" });
            listEmployees.Add(new _65_Employee { EmpID = 2, EmpName = "Maxine", EmpGender = "Famale" });
            listEmployees.Add(new _65_Employee { EmpID = 3, EmpName = "Emiliy", EmpGender = "Famale" });
            listEmployees.Add(new _65_Employee { EmpID = 4, EmpName = "Scott", EmpGender = "Male" });
            listEmployees.Add(new _65_Employee { EmpID = 5, EmpName = "Todd", EmpGender = "Male" });
            listEmployees.Add(new _65_Employee { EmpID = 6, EmpName = "Ben", EmpGender = "Male" });
            listEmployees.Add(new _65_Employee { EmpID = 7, EmpName = "Pam", EmpGender = "Famale" });
        }
        public string this[int EmpyoleeID]
        { //
            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmpID == EmpyoleeID).EmpName;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmpID == EmpyoleeID).EmpName = value;
            }
        }
    }
    #endregion

    public class _65_Indexers
    {
        public static void Main()
        {
            _65_Company company = new _65_Company();
            Console.WriteLine("Name of the Employee with ıd = 2 " + company[2]);
            Console.WriteLine("Name of the Employee with ıd = 5 " + company[5]);
            Console.WriteLine("Name of the Employee with ıd = 7 " + company[7]);
            Console.WriteLine();

            Console.WriteLine("Changing names of Empyloyee with id = 2,5 & 7");
            Console.WriteLine();

            company[2] = "2nd Employee Name Changed";
            company[5] = "5th Employee Name Changed";
            company[7] = "7th Employee Name Changed";

            Console.WriteLine("Name of the Employee with ıd = 2 " + company[2]);
            Console.WriteLine("Name of the Employee with ıd = 5 " + company[5]);
            Console.WriteLine("Name of the Employee with ıd = 7 " + company[7]);
        }
    }    
}
