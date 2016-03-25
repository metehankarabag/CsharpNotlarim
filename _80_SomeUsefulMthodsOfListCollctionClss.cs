using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    public class _80_SomeUsefulMthodsOfListCollctionClss
    {
        /*
		TrueForAll(): Lambda Expression ile girilen koşulun tüm liste için sağlanıp sağlanmadığını kontroleder. Boolen döner.
		ReadOnlyCollection<Customer>: Listeyi ReadOnly olarak ayarladığımız zaman Add ve Remove gibi Düzenleme methodlarını kullanamıyoruz.
		TrimExcess(): Listenin kapasitesi tamamen dolu değilse boş olanları siliyor. Bu bize zaman kazandırır. Fakat listenin %90 dolu ise işe yaramaz.
		*/
        public static void Main()
        {
            #region List<_80_Customer> listCutomers = new List<_80_Customer>(100);
            _80_Customer customer1 = new _80_Customer() { ID = 101, Name = "Mark", Salary = 5200 };
            _80_Customer customer2 = new _80_Customer() { ID = 103, Name = "John", Salary = 7000 };
            _80_Customer customer3 = new _80_Customer() { ID = 102, Name = "Ken", Salary = 5500 };

            List<_80_Customer> listCutomers = new List<_80_Customer>(100);
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);
            #endregion

            Console.WriteLine("Are all salaries greater than 5000: " + listCutomers.TrueForAll(x => x.Salary > 5000));

            System.Collections.ObjectModel.ReadOnlyCollection<_80_Customer> readOnlyCustomers = listCutomers.AsReadOnly();
            Console.WriteLine("Total Items in ReadOnlyCollection = " + readOnlyCustomers.Count);
            Console.WriteLine("List capacity before invoking TrimExcess = " + listCutomers.Capacity);

            listCutomers.TrimExcess();
            Console.WriteLine(listCutomers.Capacity);
        }
    }

    public class _80_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
