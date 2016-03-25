using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*
      IComparable<T> INTERFACE'i için belirlenen TYPE,  methodunun giriş türü olarak kullanıldığı için başka bir nesne örneği işleme giremiyor. 
	  CompareTo() methodunun çalışma mantığı bir CLAS örneği ile dışarıdan gelen bir örneği tarşılaştırmak. Dışarıdan gelebilecek nesne türünü belirlediğimiz için TYPE SAFE sağlamış oluyoruz. Artık CLASS'ımız bu method ile sıralama yapacak. Diğer PROPERTY'lere göre de sıralama yapılabilsin istiyorsak. Tek bir method olduğu için sıralama sınıfları oluşturmalıyız.
      Bu sınıfta IComparer<T> Interface'ini kullanılıyoruz. Çünkü bu INTERFACE'in methodu bir türde 2 örnek alıyor. Bu yüzden gerçek CLASS'ımızdan bağımsız olarak oluşturabiliriz.
     */
    public class _78_SortListOfComplexTypes
    {
        public static void Main()
        {
            #region List<CUSTOMER>
            _78_Customer customer1 = new _78_Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            _78_Customer customer2 = new _78_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _78_Customer customer3 = new _78_Customer() { ID = 103, Name = "Rob", Salary = 5500 };

            List<_78_Customer> list = new List<_78_Customer>();
            list.Add(customer1);
            list.Add(customer2);
            list.Add(customer3);
            #endregion

            Console.WriteLine("Customers before sorting"); foreach (_78_Customer c in list) { Console.WriteLine(c.Name + "\t" + c.Salary); }
            list.Sort(); // Sort() method should sort customers by salary
            Console.WriteLine("Customers after sorting"); foreach (_78_Customer c in list) { Console.WriteLine(c.Name + "\t" + c.Salary); }

            SortByName sortByName = new SortByName(); 
            list.Sort(sortByName); // To sort customers by name instead of salary
            Console.WriteLine("Customers after sorting by Name"); 
            foreach (_78_Customer c in list) { Console.WriteLine(c.Name + "\t" + c.Salary); }
        }

        public class _78_Customer : IComparable<_78_Customer>
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

            public int CompareTo(_78_Customer obj)
            {
                //if (this.Salary > obj.Salary)
                //    return 1;
                //else if (this.Salary < obj.Salary)
                //    return -1;
                //else
                //    return 0;

                // OR, Alternatively you can also invoke CompareTo() method. 
                return this.Salary.CompareTo(obj.Salary);
            }
        }

        public class SortByName : IComparer<_78_Customer>
        {
            public int Compare(_78_Customer x, _78_Customer y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
