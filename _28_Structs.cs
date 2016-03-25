using System;
namespace Dersler
{
	/*OBJECT INITIALIZER SYNTAX
	 Asp.net 3.0 ile gelmiş bu yazım bicimi refans değerini bir kez yazıp tüm propery'lere ulaşmamızı sağlıyor.
	*/
    public struct _28_Structs_Customer
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public _28_Structs_Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetail()
        {
            Console.WriteLine("Id = {0}, Name = {1}", this._id, this._name);
        }
    }
    public class _28_Structs
    {
        public static void Main()
        {
            _28_Structs_Customer c1 = new _28_Structs_Customer(101, "Mark");
            c1.PrintDetail();

            _28_Structs_Customer c2 = new _28_Structs_Customer();
            c1.ID = 101;
            c1.Name = "John";
            c2.PrintDetail();
            _28_Structs_Customer c3 = new _28_Structs_Customer 
            {
                ID = 101,
                Name = "Mark",
                
            };
            c3.PrintDetail();
		}
    }
}