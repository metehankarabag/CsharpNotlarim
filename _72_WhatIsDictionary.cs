using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*
      DICTIONARY, 2 parametreli GENERIC bir TYPE dır. 1. TYPE KEY 2. TYPE VALUE içindir.
      DICTIONARY'e eklenmiş bir üyeye ulaşmanın en kolay yolu, DICTIONARY örneğine index değeri(key) vermektir. -- Değerde üye yoksa hata alırız.
      
      DICTIONARY, IEnumerable<out T> INTERFACE'inden türemiştir ve TYPE olarak KEYVALUEPAIR GENERIC STRUCT'ı verilmiş. Bu STRUCT, DICTIONARY'e verdiğmiz 2 TYPE'ı da alıyor ve INTERFACE içinde Foreach'ı oluşturan GetEnumerator()'ün base dönüş türü oluyor. (IEnumerator<Struct>)
      Not:in/out anahtarı ile TYPE belirleme işini sadece generic Interface'lerde ve delegatelerde kullanabiliyormuşuz.
          out parametre methodlardan farklı bir değer çıkarmak için kullanlıyor. 
          in TYPE sadece üylerin sadece giriş parametrelerinde kullanılabilen tür demek.
          out TYPE ise üyelerin dönüş türlerinde veya çıkış parametrelerinde kullanılabilecek tür demek.
      Bu anahtarlardan birini kullamadan belirttiğimiz TYPE ise her türlü kullanılabiliyor.
      
      Yani GetEnumerator() methodu DICTIONARY CLASS'ında IEnumerator<KeyValuePair> dönen bir method alanı oluşturacak. (Bu alan görünmüyor.)
      Fakat bu method'da yapılan sadece Foreach'in çalışma düzenini belirlemek. Foreach'in çalışacağı nesneler IEnumerator<KeyValuePair> Interface'sinden türeyen typelardan alınıyor. DICTIONARTY'de Enumerator STRUCT'i bu INTERFACE'den türüyor ve bu İNTERFACE'in üyleri GetEnumerator() methoduna KeyValuePair türünde değer gönderiyor. Dictionary örneğini foreach'e attığımızda üylerini KeyValuePair türünde almamızın nedeni bu.
     
      DICTIONARY'de mevcut olan bir anahtarı sözlüğe eklemeye çalıştığında, çalışma zamanında (An item with SAME KEY has already been added.) hatası alırsın. Olmayan bir anahtarı almaya çalıştığında (KEYNOTFOUND) hatası alırsın
      Hata olasılığından kurtulmak için değeri önce CONTAINSKEY() ile kontrol et. (Boolen döner.)
     */
    public class _72_WhatIsDictionary
    {
        public static void Main()
        {
            //Key türünü int, Value türü Customer olarak belirlenmiştir.
            Dictionary<int, _72_Customer> dictionaryCustomers = new Dictionary<int, _72_Customer>();
			
            #region Create Customer Objects and add to the list
            _72_Customer customr1 = new _72_Customer() { ID = 101, Name = "Mark", Salary = 5000 };
            _72_Customer customr2 = new _72_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _72_Customer customr3 = new _72_Customer() { ID = 104, Name = "Rob", Salary = 5500 };

            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

            #endregion
            Console.WriteLine("Customer 101 in customer dictionary");
            _72_Customer customer101 = dictionaryCustomers[101];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer101.ID, customer101.Name, customer101.Salary);
            Console.WriteLine("\n--------------------------------------------------\n\nAll customer keys and values in customer dictionary");
            #region foreach with Key Value Pair
            foreach (KeyValuePair<int, _72_Customer> customerKeyValuePair in dictionaryCustomers)                                          
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                _72_Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            #endregion
            Console.WriteLine("\n--------------------------------------------------\n\nAll customer keys and values in customer dictionary");
            #region foreach with VAR
            foreach (var customerKeyValuePair in dictionaryCustomers)                                                                    ///
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                _72_Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            #endregion
            Console.WriteLine("\n--------------------------------------------------\n\nAll Keys in Customer Dictionary");
            #region KEYS, VALUES
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("\n--------------------------------------------------\n\nAll Customer objects in Customer Dictionary");
 
            foreach (_72_Customer customer in dictionaryCustomers.Values)
            {//foreach te customer'a değer in içinden gelir. Bu yüzden türü gelen değere uygun olmak zorunda
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }
            #endregion
            #region CONTAINSKEY
            if (!dictionaryCustomers.ContainsKey(101))
            {
                dictionaryCustomers.Add(101, customr1);
            }

            if (dictionaryCustomers.ContainsKey(110))
            {
                _72_Customer cus = dictionaryCustomers[110];
            }
            else
            {
                Console.WriteLine("\n\nKey does not exist in the dictionary");
            }
            #endregion
        }
    }

    public class _72_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
