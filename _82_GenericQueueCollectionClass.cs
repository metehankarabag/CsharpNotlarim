using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*QUEUE
      Enqueue(): Öğe eklemek için kullanılır.
      Dequeue(): LIST'edeki ilk itemi QUEUE'den döner sonra siler.
      Peek(): Buda ilk nesneyi döner ama silmez.
     
      Queue is a generic FIFO (First In First Out) İlk giren ilk çıkar
    */
    public class _82_GenericQueueCollectionClass
    {
        public static void Main()
        {
            #region Customer nesnesi
            _82_Customer customer1 = new _82_Customer() { ID = 101, Name = "Mark", Gender = "Male" };
            _82_Customer customer2 = new _82_Customer() { ID = 102, Name = "Pam", Gender = "Female" };
            _82_Customer customer3 = new _82_Customer() { ID = 103, Name = "John", Gender = "Male" };
            _82_Customer customer4 = new _82_Customer() { ID = 104, Name = "Ken", Gender = "Male" };
            _82_Customer customer5 = new _82_Customer() { ID = 105, Name = "Valarie", Gender = "Female" };
            #endregion
            Queue<_82_Customer> queueCustomers = new Queue<_82_Customer>();
            #region Enqueue()
            queueCustomers.Enqueue(customer1); queueCustomers.Enqueue(customer2); queueCustomers.Enqueue(customer3); 
            queueCustomers.Enqueue(customer4); queueCustomers.Enqueue(customer5);
            #endregion
            #region Dequeue()
            _82_Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c1.ID ,c1.Name, queueCustomers.Count);
            _82_Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c2.ID ,c2.Name, queueCustomers.Count);
            _82_Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c3.ID, c3.Name, queueCustomers.Count);
            _82_Customer c4 = queueCustomers.Dequeue();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c4.ID, c4.Name, queueCustomers.Count);
            _82_Customer c5 = queueCustomers.Dequeue();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c5.ID, c5.Name, queueCustomers.Count);
            Console.WriteLine("\n-----------------------------------------------------------");
            #endregion
            #region Some house keeping stuff
            #region Enqueue() Silindiği için
            queueCustomers.Enqueue(customer1); queueCustomers.Enqueue(customer2); queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4); queueCustomers.Enqueue(customer5);
            #endregion
            foreach (_82_Customer customer in queueCustomers){
                Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", customer.ID, customer.Name, queueCustomers.Count);}
            Console.WriteLine("\n-----------------------------------------------------------");
            #endregion
            #region Peek()
            _82_Customer c = queueCustomers.Peek();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c.ID, c.Name, queueCustomers.Count);
            Console.WriteLine("\n-----------------------------------------------------------");
            #endregion

            if (queueCustomers.Contains(customer1)) Console.WriteLine("customer1 is in Queue");
            else Console.WriteLine("customer1 is not in Queue");
        }
    }

    public class _82_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

}
