using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _98_AnonymousMethods
{

    /*ANONYMOUS METHOD
      İsmi olmayan method demektir.
      Derste FIND() EXTENSION METHOD'unu kullandık.
      FIND() methodunun 1. parametresi bir PREDICATE DELEGATE'i istiyor. Delegate sadece method işaretcisidir. Bunu kullanmak yerine direk method oluşturabiliriz.
      Daha sonra kod karmaşasına neden olabilecek harici bir method yazmak yerine ANONYMOUS METHOD kullanabiliriz.
      (Method işi birden fazla kez kullanılıyorsa harici method kullanmak mantıklı olabilir.)
      
      Not: PREDICATE DELEGATE'i boolen döner. Yani boolen dönen bir işlem belirmeliyiz.
           FIND() ve delegate aynı giriş parametreleri tür GENERIC TYPE'dır. FIND() uygulandığı nesnenin temel türünü aldığı için delegate de bu türü alır.
           Yani delegate giriş türü olarak her zaman uygulandığı method nesnesinin temel türünü alır.
     
      EventHandler bir DELEGATE'dir ve PROGRAM için olaylar tanımlar.
      ANONYMOUS method kullanarak PROGRAMda herhangi bir olayın içinde 
      Başka bir olayı ayrıca method yazmadan rahatlıkla çalıştırabiliriz.
     
      NOT: DELEGATE'i, ANONYMOUS METHOD ile oluşturuyorsak, ANONYMOUS methodun parametreleri OPTIONAL'dır.
     
     */
    class _98_AnonymousMethods
    {
        public static void Main()
        {
            List<_98_Employee> listEmployees = new List<_98_Employee>()
            {
                new _98_Employee{ ID = 101, Name = "Mark"},
                new _98_Employee{ ID = 102, Name = "John"},
                new _98_Employee{ ID = 103, Name = "Mary"},
            };
            Predicate<_98_Employee> predicateEmployee = new Predicate<_98_Employee>(FindEmployee);
                                                      //FindEmployee(x));
            _98_Employee employee = listEmployees.Find(x => predicateEmployee(x));
            Console.WriteLine("ID = {0}, Name {1}", employee.ID, employee.Name);

            //ANONYMOUS METHOD
            employee = listEmployees.Find(
                delegate(_98_Employee x)
                {
                    return x.ID == 102;
                }

                );
            Console.WriteLine("ID = {0}, Name {1}", employee.ID, employee.Name);
        }

        private static bool FindEmployee(_98_Employee Emp)
        {
            return Emp.ID == 102;
        }

        public class _98_Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
