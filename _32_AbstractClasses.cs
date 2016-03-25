using System;
namespace Dersler
{
    /*Abstract Class
      Abstract anahtarını kullanmaya üyeleri uygulama içerebilir ama tam bir sınıf olmadıkları için kurulamazlar. ABSTRACT anahtarı kullanan üyleri uygulama kodu içermez. Abstract sınıflar sadece base sınıf olarak kullanılabilir ve türeyen sınıfları abstract eki almış üyeler için uygula belirlemek zorundadır 
	  Bir CLASS'ın ABSTRACT bir CLASS'dan miras alabilmesi için sadece ABSTRACT üylerine uygulama belirmesi yeterlidir.
      ABSTRACT CLASS'lar METHOD, PROPERTY, INDEXER ve EVENT'ları üyle olarak barındırabilir.
	 
      Sealed Ön eki Base olmayı engeller. Abstract sınıflar sadece Base Public sınıflar olarak kullanılabilir.  Yani Abstract ve Sealed  aynı anda kullanılamaz.
     */

    public abstract class _32_AbstractClasses_Customer
    {
        public abstract void Print();
        //{
        //    Console.WriteLine("Print");
        //}
    }
    public class _32_AbstractClasses : _32_AbstractClasses_Customer
    {
        public static void Main()
        {
            _32_AbstractClasses P = new _32_AbstractClasses();
            P.Print();
            //_32_AbstractClasses_Customer c;
            //c.Print();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }
    }
}