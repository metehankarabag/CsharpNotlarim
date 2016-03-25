using System;

namespace Dersler
{
    /*
     Bir CLASS örneğini string'e çevirdiğimzde değer olarak sınıf adını alırız.
	 ToString() methoduna OVERRIDE yaparak, bu değeri değiştirebiliriz.
	 Örnek: bir CLASS örneğine toString() uygulandığında bütün PROPERTY değerlerini yazdırabiliriz.
    */
    public class _57_WhyShouldYouOverrideToStringMethod
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());
            _57_Customer c1 = new _57_Customer();
            c1.FistName = "Simon";
            c1.LastName = "Tan";
            Console.WriteLine(c1.ToString());//c1'ı dırek yazdırabiliriz ama bu iyi değil
        }
    }
    public class _57_Customer
    {
        public string FistName{ get; set; }
        public string LastName { get; set; }

        public override string ToString() 
        {
            return this.LastName + ", " + FistName;
        }
    }
}