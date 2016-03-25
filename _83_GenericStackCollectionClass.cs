using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
    /*STACK
      GENERIC kullanılarak oluşturulmuş bir CLASS'dır. Tek bir tür bekler.
      Push(): Stack'e öğe eklemek için kullan. Bu nesne ile ilk eklenen en altta kalır.
      Pop(): Stack'de en üstteki(son eklenen) nesneyi alır ve siler.
      Peek(): Son eklenen öğeyi alır fakat silmez.
	
     Stack is a generic LIFO (Last In First Out) Son giren ilk çıkar 
    */
    public class _83_GenericStackCollectionClass
    {
        public static void Main()
        {
			#region Customer nesnesi
            _83_Customer C1 = new _83_Customer() { ID = 101, Name = "Mark", Gender = "Male" };
            _83_Customer C2 = new _83_Customer() { ID = 102, Name = "Pam", Gender = "Female" };
            _83_Customer C3 = new _83_Customer() { ID = 103, Name = "John", Gender = "Male" };
            _83_Customer C4 = new _83_Customer() { ID = 104, Name = "Ken", Gender = "Male" };
            _83_Customer C5 = new _83_Customer() { ID = 105, Name = "Valarie", Gender = "Female" };
			#endregion
            Stack<_83_Customer> stackCustomers = new Stack<_83_Customer>();
			#region Push()
			stackCustomers.Push(C1); stackCustomers.Push(C2); stackCustomers.Push(C3); stackCustomers.Push(C4); stackCustomers.Push(C5);
			#endregion
			#region Pop()

            _83_Customer c1 = stackCustomers.Pop();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c1.ID, c1.Name, stackCustomers.Count);
            _83_Customer c2 = stackCustomers.Pop();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c2.ID, c2.Name, stackCustomers.Count);
            _83_Customer c3 = stackCustomers.Pop();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c3.ID, c3.Name, stackCustomers.Count);
            _83_Customer c4 = stackCustomers.Pop();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c4.ID, c4.Name, stackCustomers.Count);
            _83_Customer c5 = stackCustomers.Pop();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c5.ID, c5.Name, stackCustomers.Count);
            
            #endregion		
            
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");

            #region Silindiği için tekrar ekledik
            stackCustomers.Push(C1); stackCustomers.Push(C3); stackCustomers.Push(C3); stackCustomers.Push(C4); stackCustomers.Push(C5);
			#endregion

            foreach (_83_Customer customer in stackCustomers){
                Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", customer.ID, customer.Name, stackCustomers.Count);}

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");

            #region Peek()
            _83_Customer c = stackCustomers.Peek();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c.ID, c.Name, stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            _83_Customer c99 = stackCustomers.Peek();
            Console.WriteLine("{0} - {1}\t" + "Items left in the Queue = {2}", c.ID, c.Name, stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");
			#endregion
            
            if (stackCustomers.Contains(C5)) Console.WriteLine("customer5 is in stack");
                                        else Console.WriteLine("customer5 is not in stack");
            Console.ReadKey();
        }        
    }

    public class _83_Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    } 
}
