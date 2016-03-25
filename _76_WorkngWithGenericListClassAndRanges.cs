using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*
     Add(): Liste sonuna bir her seferde 1 tane nesne ekler.
     AddRange(): Base TYPE'ı uygulandığı liste ile aynı olan bir listeyi parametre olarak alıp uygulandığı listeye ekler.  -- VOİD DÖNER.
     GetRange(): Uygulandığı listenin bir parçasını alır ve döner. 1. Başlangıç INDEX'i, 2. eleman sayısı				   -- List<TYPE> DÖNER
     Remove(): Uygulandığı listenin base TYPE'ında bir nesne alır aldığı nesne listede varsa siler.					       -- BOOLEN DÖNER.
     RemoveAt(): parametre olarak aldığı index'deki elemanı listesinden siler.			                                   -- VOİD DÖNER.
     RemoveAll(): Parametre olarak PRDICATE istiyor. Konuşla uyan tüm elemanları siler. lisinen eleman sayısını döner 	   -- INT DÖNER.
     RemoveRange(): Uygulandığı listenin bir parçasını alır ve siler. 1. başlangıç INDEX'i 2. Silinecek öğe sayısı.        -- VOİD DÖNER.
     Insert(): listesindeki bir yere eleman ekler. 1. Index, 2. eleman                                              	   -- VOİD DÖNER.
     InsertRange(): listesindeki bir yere birden fazla eleman ekler. 1. index 2. list									   -- VOİD DÖNER.
     Clear(): Listedeki tüm elemanları siler.
    */
    public class _76_WorkngWithGenericListClassAndRanges
    {
        public static void Main()
        {
            #region CUSTOMER NESNELERİ OLUŞTURDUK VE 2 FARKLI LİSTEYE EKLEDİK
            _76_Customer customer1 = new _76_Customer() { ID = 101, Name = "Mark", Salary = 4000, Type = "RetailCustomer" };
            _76_Customer customer2 = new _76_Customer() { ID = 102, Name = "Pam", Salary = 7000, Type = "RetailCustomer" };
            _76_Customer customer3 = new _76_Customer() { ID = 103, Name = "Rob", Salary = 5500, Type = "RetailCustomer" };
            _76_Customer customer4 = new _76_Customer() { ID = 104, Name = "John", Salary = 6500, Type = "CorporateCustomer" };
            _76_Customer customer5 = new _76_Customer() { ID = 105, Name = "Sam", Salary = 3500, Type = "CorporateCustomer" };
            
            List<_76_Customer> listCustomers = new List<_76_Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<_76_Customer> listCorporateCustomers = new List<_76_Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);
            #endregion
            #region ADDRANGE, GETRANGE
            listCustomers.AddRange(listCorporateCustomers);
            foreach (_76_Customer customer in listCustomers){
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", customer.ID, customer.Name, customer.Salary, customer.Type);}
            Console.WriteLine("------------------------------------------------------");

            List<_76_Customer> corporateCustomers = listCustomers.GetRange(3, 2);
            foreach (_76_Customer customer in corporateCustomers)            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}", customer.ID, customer.Name, customer.Salary, customer.Type);}
            Console.WriteLine("------------------------------------------------------");
            #endregion
            #region REMOVE, REMOVEAT, REMOVEALL, REMOVERANGE
            
            listCustomers.Remove(customer1);
            listCustomers.RemoveAt(0);
            //Predicate<_76_Customer> a = new Predicate<_76_Customer>(BoolenDonenBirDelegateMethoduDaha);
            //a(listCustomers[0]);
            listCustomers.RemoveAll(x => x.Type == "RetailCustomer");

            foreach (_76_Customer customer in listCustomers){Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);}
            Console.WriteLine("------------------------------------------------------");
            listCustomers.RemoveRange(0, 2);
            #endregion
            #region INSERT INSERTRANGE

            listCustomers.Insert(0, customer1);
            listCustomers.Insert(1, customer2);
            listCustomers.Insert(2, customer3);
            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (_76_Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");
            #endregion


            listCustomers.Clear();
            Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
        }
        public static bool BoolenDonenBirDelegateMethoduDaha(_76_Customer a)
        {
            return true;
        }
    }

    public class _76_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
