using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desler
{
    /*LAMBDA
      => -> LAMBDA operatörü olarak adlanıdırlır. Okuma sırasında GOES TO denir.
      ANONYNMOUS MEHOD'lara benzerdir
      Bir çok durumda ANONYNMOUS MEHOD'ların yerini alır.
      
      LAMBDA oluşturmak için 
      Parametre türünü belirlememize gerek yok.(kendi kendine belirlenir.)
      Operatörün solunda paramatreler, sağında parametrelerin kullanılabileceği işlemler belirlenir.
     
      ANONYMOUS METHOD'un tek kullanım avantajı -> DELEGATE'in istediği method parametrelerini işlemlerde kullanmıyorsak, parametreleri belirtme zorunluluğumuzun olmamasıdır.
      ANONYMOUS METHOD'u LAMBDA'ya tercih edeceğimiz tek durum budur. 
      Yani DELEGATE'in belirtmeye zorladığı method parametrelerini kullanmıyorsak yazmayabiliriz.
     
     LAMBDA ile Clik olayı 
     Button1.Click += (eventSender, eventAgrs) =>
     {
         MessageBox.Show("Button Clicked");
     };
     
     */
    class _99_LambdaExpression
    {
        static void Main(string[] args)
        {
            List<_99_Employee> listEmployees = new List<_99_Employee>()
            {
                new _99_Employee{ ID = 101, Name = "Mark"},
                new _99_Employee{ ID = 102, Name = "John"},
                new _99_Employee{ ID = 103, Name = "Mary"},
            };

            _99_Employee employee = listEmployees.Find(delegate(_99_Employee Emp) { return Emp.ID == 102; });//Anonymous method
                     employee = listEmployees.Find(Emp => Emp.ID == 102);
                     employee = listEmployees.Find((_99_Employee Emp) => Emp.ID == 102);
                     int count = listEmployees.Count(x => x.Name.StartsWith("M"));
                     Console.WriteLine(count);
        }
    }
    public class _99_Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
