using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /* SORT METHODU
      Sort methodu ile karmaşıki bir türü sıralamaya kalktığımız zaman hata alırız. Çünkü sort methodu önceden berliten bir düzene göre çalışıyor. Bizim oluşturduğmuz karmaşık türde böyle bir belirleme yoksa hata alırız. ICompareble INTERFACE'si short() methodu için iş tanımı yapan bir methodun açıklaması var. Burda işlemi uygulamak için ICompareble INTERFACE'den türetildikten sonra ComparaTo açıklamasına uygulama vereceğiz.
      Bunu bir sonraki derste yapacağız. 
	 */
    public class _77_SortListOfSimpleTypes
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };
            #region List<CUSTOMER>
            _77_Customer customer1 = new _77_Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            _77_Customer customer2 = new _77_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _77_Customer customer3 = new _77_Customer() { ID = 103, Name = "Rob", Salary = 5500 };

            List<_77_Customer> listCustomers = new List<_77_Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            #endregion

            #region INT SIRALAMA

            Console.WriteLine("Numbers before sorting"); foreach (int i in numbers) { Console.WriteLine(i); }
            numbers.Sort();// Sort() methodunu artan sıra
            Console.WriteLine("Numbers after sorting"); foreach (int i in numbers) { Console.WriteLine(i); }
            numbers.Reverse();// Reverse() method azalan sıra
            Console.WriteLine("Numbers in descending order"); foreach (int i in numbers) { Console.WriteLine(i); }
            #endregion
            #region STRİNG SIRALAMA (Aynı)

            Console.WriteLine("Alphabets before sorting"); foreach (string i in alphabets) { Console.WriteLine(i); }
            alphabets.Sort();// Sort() methodunu artan sıra
            Console.WriteLine("Alphabets after sorting"); foreach (string i in alphabets) { Console.WriteLine(i); }
            alphabets.Reverse();// Reverse() method azalan sıra
            Console.WriteLine("Alpabets in descending order"); foreach (string i in alphabets) { Console.WriteLine(i); }
            #endregion
            #region CUSTOMER SIRALAMA
            Console.WriteLine("Customers before sorting"); foreach (_77_Customer c in listCustomers) { Console.WriteLine(c.Name); }
            listCustomers.Sort();
            Console.WriteLine("Customers after sorting"); foreach (_77_Customer c in listCustomers) { Console.WriteLine(c.Name); }
            #endregion
        }
    }

    public class _77_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
}
