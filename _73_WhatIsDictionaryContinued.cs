using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*
     TryGetValue(): Birinci parametre olarak KEY, içinci parametre olarak OUT anahtarı ile VALUE alır.
					DICTONARY'de belirtilen KEY varsa, True döner ve
					Belirtilen KEY'den gelen değerler nesne örneğinden alınır.
     Remove(): Parametre olarak aldığı Key ve değerini siler.
     Clear():  Tamamını siler.
	 Add(): eleman ekler.
     
     ToDictionary(): Extension method'dur. Birden fazla overload'ı vardır. Uygulandğı nesneden bir veya daha fazla tür alarak Dictionary oluşturabiliriz.
     */
    public class _73_WhatIsDictionaryContinued
    {
        public static void Main()
        {
            #region Create Customer Objects and add to the list
            _73_Customer customr1 = new _73_Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            _73_Customer customr2 = new _73_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _73_Customer customr3 = new _73_Customer() { ID = 104, Name = "Rob", Salary = 5500 };

            Dictionary<int, _73_Customer> dictionaryCustomers = new Dictionary<int, _73_Customer>();
            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);
            #endregion
            #region Try Get Value
            _73_Customer customer999;
            if (dictionaryCustomers.TryGetValue(999, out customer999))
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID, customer999.Name, customer999.Salary);
            else
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary\n--------------------------------------------------");
            #endregion
            
            //Count
     Console.WriteLine("Total items in Dictionary = {0}\n--------------------------------------------------", dictionaryCustomers.Count());
            //LINQ Extension
     Console.WriteLine("Items in dictionary where Salary is greater than 5000 = {0}\n", dictionaryCustomers.Count(x => x.Value.Salary > 5000));
            dictionaryCustomers.Remove(101);
            dictionaryCustomers.Clear();

            #region ToDictionary
            _73_Customer[] arrayCustomers = new _73_Customer[3];// List te olabilir 
            arrayCustomers[0] = customr1;
            arrayCustomers[1] = customr2;
            arrayCustomers[2] = customr3;
            

            Dictionary<int, _73_Customer> dict = arrayCustomers.ToDictionary(customer => customer.ID, customer => customer);
            //OR        
            Dictionary<int, _73_Customer> dict1 = arrayCustomers.ToDictionary(customer => customer.ID);
            //OR use a foreach loop
            Dictionary<int, _73_Customer> dict2 = new Dictionary<int, _73_Customer>();
            foreach (_73_Customer cust in arrayCustomers)
             {
                 dict2.Add(cust.ID, cust);
             }
            #endregion
        }
    }

    public class _73_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}