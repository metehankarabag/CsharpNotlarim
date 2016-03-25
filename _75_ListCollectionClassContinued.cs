using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler//_75_ListCollectionClassContinued
{
     /*LISTE METHODLARI
      SEARCH METHODLARI
      CONTAINS():  Parametre olarak aldığı nesnenin uygulandığı listedeki varlığını kontrol eder. --> BOOLEN DÖNER.
	  Aşağıdakiler PREDICADE DELEGATE'i kullandığı için hepsi karşılaştırma işleminin sonuçuna göre çalışr.
      EXISTS(): Uygulandığı listedeki elemanlar üzerinde bir koşul arar. -- BOOLEN DÖNER.
      FIND(): Koşula uyan ilk elemanı döner --> GENERIC TYPE DÖNER.
      FINDLAST(): Koşula uyan son elemanı döner --> GENERIC TYPE DÖNER.
      FINDALL(): koşula  uyan tüm üyleeri döner -- LIST<GENERIC TYPE> DÖNER.
      FINDINDEX() : Koşula uyan ilk elemanın INDEX'ini döner. 3 OVERLOAD'ı var. - Başlangıç INDEX'i, Aranacak üye sayısı ile oluşur. -- hepsi INT DÖNER.
      FINDLASTINDEX() üstteki ile aynı sadece son bulduğunu dönüyor. -- INT DÖNER.
    
      ÇEVİRME METHODLARI
      Aktarma için TYPE benzerliği şart.
      ToList(): LIST'e aktarılacağı için Solda List<Type> list
      ToArray(): ARRAY'a aktarılacağı için solda Type[] array 
      ToDictionary(): FUNC DELEGATE'si istiyor. methodun 4 overload'ı var.
      1. overload'da 1 Func() methodu allır. int değer döner. Bu int değer KEY değeri olur.
      3. overload'da 2 func() alır. 2. func()'ın dönüş türü liste elemanlarından alınabilecek herhangi tür olabilir. Bu da yeni value değeri olur
	     2. func kullanılmassa otomatik olarak value değeri elemanların kendisi olur.
      2. ve 4. overload'larda ise eşitlik kontrolü yapan IequalityComparer parametresi isteniyor.
    */
    public class _75_ListCollectionClassContinued
    {
        public static void Main()
        {
            #region Customer nesneleri ve ARRAY'a ekleme
            _75_Customer customer1 = new _75_Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            _75_Customer customer2 = new _75_Customer() { ID = 102, Name = "Pam", Salary = 7000 };
            _75_Customer customer3 = new _75_Customer() { ID = 104, Name = "Rob", Salary = 5500 };

            _75_Customer[] arrayCustomers = new _75_Customer[3];
            arrayCustomers[0] = customer1;  arrayCustomers[1] = customer2;  arrayCustomers[2] = customer3;
            #endregion
            #region ÇEVİRME METOHLARI
            #region ARRAY'ı LİST'e çevirme ve yazdırma
            List<_75_Customer> listCustomers = arrayCustomers.ToList();//
            foreach (_75_Customer c in listCustomers) { Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary); }
            Console.WriteLine("------------------------------------------------------");
            #endregion
            #region Lİst'i ARRAY'a çevirme ve yazdırma
            _75_Customer[] arrayAllCustomers = listCustomers.ToArray();//
            foreach (_75_Customer c in arrayAllCustomers) { Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary); }
            Console.WriteLine("------------------------------------------------------");
            #endregion
            #region List'i DİCTİONARY'ye çevirme ve yazdırma

            Dictionary<int, _75_Customer> dictionaryCustomers = listCustomers.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, _75_Customer> keyValuePairCustomers in dictionaryCustomers)
            {
                Console.WriteLine("Key = {0}", keyValuePairCustomers.Key);
                _75_Customer c = keyValuePairCustomers.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------------");
            #endregion
            #endregion
            #region ARAMA METHODLARI
            #region Contains and Exists

            switch (listCustomers.Contains(customer2))
            {
                case true: Console.WriteLine("Customer2 object exists in the list\n----------------------------------------"); break;
                case false: Console.WriteLine("Customer2 object does not exist in the list\n---------------------------------"); break;
            }

            //Predicate<_75_Customer> a = new Predicate<_75_Customer>(ExistsMethoduicinBenYaptimOldu);
            //a(listCustomers[0]);
            switch (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                case true: Console.WriteLine("List contains customer whose name starts with M\n-------------------------------------"); break;
                case false: Console.WriteLine("List does not contain a customer whose name starts with M\n----------------------------"); break;
            }
            #endregion
            #region FIND, FINDLAST, FINDALL, FINDINDEX, FINDLASTINDEX  --> Hepsi için LINQ Extension kullanılabilir.

            _75_Customer FIST = listCustomers.Find(customer => customer.Salary > 5000);
            _75_Customer LAST = listCustomers.FindLast(customer => customer.Salary > 5000);
            int FISTINDEX = listCustomers.FindIndex(x => x.Salary > 5000); //listCustomers.FindIndex(x => x.Salary > 5000) LINQ Extension
            int LASTINDEX = listCustomers.FindLastIndex(x => x.Salary > 5000);//listCustomers.FindLastIndex(2, x => x.Salary > 5000)
            List<_75_Customer> ALL = listCustomers.FindAll(customer => customer.Salary > 5000);

            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}\n-------------------------------------------", FIST.ID, FIST.Name, FIST.Salary);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}\n-------------------------------------------", LAST.ID, LAST.Name, LAST.Salary);
            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 = {0}\n---------------------", FISTINDEX);
            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = {0}\n----------------------", LASTINDEX);
            foreach (_75_Customer c in ALL)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}\n----------------------------------", c.ID, c.Name, c.Salary);
            }

            #endregion
            #endregion
        }
        public static bool ExistsMethoduicinBenYaptimOldu(_75_Customer c)
        {

            return true;
        }
    }

    public class _75_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
