using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler//_79_SrtComplexTypsUsngComparisonDlegate
{
    public class _79_SrtComplexTypsUsngComparisonDlegate
    {
        public static void Main()
        {
            #region List<CUSTOMER>
            _79_Customer customer1 = new _79_Customer() { ID = 101, Name = "Mark", Salary = 4000 };
            _79_Customer customer2 = new _79_Customer() { ID = 103, Name = "John", Salary = 7000 };
            _79_Customer customer3 = new _79_Customer() { ID = 102, Name = "Ken", Salary = 5500 };

            List<_79_Customer> listCutomers = new List<_79_Customer>();
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);
            #endregion

            Console.WriteLine("Customers before sorting"); foreach (_79_Customer customer in listCutomers) { Console.WriteLine(customer.ID); }

            #region Aaproach 3: Using lambda expression
            listCutomers.Sort((x, y) => x.ID.CompareTo(y.ID));
            #endregion
            Console.WriteLine("Customers after sorting by ID");
            foreach (_79_Customer customer in listCutomers)
            {
                Console.WriteLine(customer.ID);
            }

            listCutomers.Reverse();
            Console.WriteLine("Customers in descending order of ID");
            foreach (_79_Customer customer in listCutomers)
            {
                Console.WriteLine(customer.ID);
            }
        }
    }

    public class _79_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
