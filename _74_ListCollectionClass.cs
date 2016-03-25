using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*List Collection
      ARRAY FIXED SIZE'dır genişlemez. Alabileceğinden fazla üye eklenmeye çalışılırsa, çalışma zamanı hatası verir -> (Index was outside the bounds of the array)
      
      LIST CLASS'ında da başlangıç SIZE'ı belirtilebilir. Fakat bu hem zorunlu değildir hemde size genişler. LIST generic bir CLASS olduğu için sadece belirtilen türde veri alabilir. Bu TYPE SAFE mantığı çalışma zamanı hatasını önler. Farklı bir tür eklemeye çalışırsak, düzenleme zamanı hatası alırız.
      Insert(): Listede belirli bir INDEX'e nesne eklemek için kullanılır. Birinci parametreye eklenecek INDEX, 2. ye nesne girilir.
      IndexOf(): Listedeki bir nesnenin INDEX'ini almak için kullanılır
     */
    public class _74_ListCollectionClass
    {
        public static void Main()
        {
            #region ARRAY
            _74_Customer customer1 = new _74_Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            _74_Customer customer2 = new _74_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _74_Customer customer3 = new _74_Customer() { ID = 104, Name = "Rob", Salary = 5500 };

            _74_Customer[] arrayCustomers = new _74_Customer[2];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;
            //arrayCustomers[2] = customer3;
            #endregion
            #region LIST
            List<_74_Customer> listCustomers = new List<_74_Customer>(2);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            _74_Customer cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("------------------------------------------------");

            #region LIST örneği içinde gezinme
            for (int i = 0; i < listCustomers.Count; i++)
            {
                _74_Customer customer = listCustomers[i];
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }Console.WriteLine("------------------------------------------------");

            foreach (_74_Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }Console.WriteLine("------------------------------------------------");

            #endregion
            #endregion
            
            // listCustomers.Add("This will not compile");
            //Insert()
            listCustomers.Insert(1, customer3);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", listCustomers[1].ID, listCustomers[1].Name, listCustomers[1].Salary);
            Console.WriteLine("------------------------------------------------");
            //IndexOf()
            Console.WriteLine("Index of Customer3 object in the List = " + listCustomers.IndexOf(customer3));
            Console.WriteLine("------------------------------------------------");
        }
    }

    public class _74_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
