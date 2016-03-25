using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
	 /*
      Bu derste geçen derste ek olarak Employee CLASS'ının GENDER özelliğini kullanarak oluşturduğumuz Employee listesi içinde kaç tane erkek kaç tane kadın var onu dönüyoruz ve bulunan Employee lerin GENDER değerlerini değiştiriyoruz.
      Get() methodunda
      listeye COUNT() Extension methodunu uyguluyoruz. Bu method parametre olarak listenin base türünden alınan bir değer ile boolen değer dönen bir iş yapmamızı bekliyor. Bu işi Lambda expression kullanarak yapıyoruz.(base => base.gender == gender)
      Set() methodunda
      şlem yapmadan önce kullanıcı tarafında gönderilen Key ile aynı değeri almış nesne örneklerini bulmalıyız. Üzerinde çalışmayı istediğimiz nesneler sadece onlar. önemli olan bu işi yaptıktan sonra GENDER PROPERTY değerini güncelliyoruz.
     */
    public class _66_OverloadingIndexers
    {
        public static void Main()
        {
            _66_Company company = new _66_Company();
            Console.WriteLine("Before Update");

            Console.WriteLine("Total Male Employees : " + company["Male"]);
            Console.WriteLine("Total Female Employees : " + company["Female"]);
            Console.WriteLine();
            company["Male"] = "Female";
            Console.WriteLine("After Update");
            Console.WriteLine("Total Male Employees : " + company["Male"]);
            Console.WriteLine("Total Female Employees : " + company["Female"]);
        }
    }

    public class _66_Employee
    {
        public _66_Employee()
        {

        }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
    }

    public class _66_Company
    {
        private List<_66_Employee> listEmployees;
        public _66_Company()
        {
            listEmployees = new List<_66_Employee>();
            listEmployees.Add(new _66_Employee() { EmployeeID = 1, EmployeeName = "Mike", EmployeeGender = "Male" });
            listEmployees.Add(new _66_Employee { EmployeeID = 2, EmployeeName = "Maxine", EmployeeGender = "Famale" });
            listEmployees.Add(new _66_Employee { EmployeeID = 3, EmployeeName = "Emiliy", EmployeeGender = "Famale" });
            listEmployees.Add(new _66_Employee { EmployeeID = 4, EmployeeName = "Scott", EmployeeGender = "Male" });
            listEmployees.Add(new _66_Employee { EmployeeID = 5, EmployeeName = "Todd", EmployeeGender = "Male" });
            listEmployees.Add(new _66_Employee { EmployeeID = 6, EmployeeName = "Ben", EmployeeGender = "Male" });
            listEmployees.Add(new _66_Employee { EmployeeID = 7, EmployeeName = "Pam", EmployeeGender = "Famale" });
        }
        public string this[int EmpyoleeID]
        {

            get
            {
                return listEmployees.FirstOrDefault(emp => emp.EmployeeID == EmpyoleeID).EmployeeName;
            }
            set
            {
                listEmployees.FirstOrDefault(emp => emp.EmployeeID == EmpyoleeID).EmployeeName = value;
            }
        }
        public string this[string Gender]
        {
            get
            {
                return listEmployees.Count(emp => emp.EmployeeGender == Gender).ToString();
                //
            }
            set
            {
                foreach (_66_Employee employee in listEmployees)
                if (employee.EmployeeGender == Gender)
                   employee.EmployeeGender = value;
            }
        }
    }

    
}
