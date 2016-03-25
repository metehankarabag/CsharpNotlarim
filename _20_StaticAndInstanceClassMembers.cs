using System;

namespace Dersler
{
    /*STATİC VE INSTANCE CONSTRUCTOR ve CLASS ÜYELERİ
      Static bir öğe oluşturmak için static kelimesi kullanılır. Static olmayan öğelere Nonstatic veya Instance öğe denir. 
      Farklı sınıf örnekleri üzerinden ulaşarak farkı değerler verdiğimiz bir sınıf üyesi, kendisine verilen son değeri alıyorsa, statik üyedir. Farklı örnekler için farklı değerler alıyorsa Instance üyedir. Çünkü Static üyeler sınıfa ait üylerdir sadece bir kez oluşturulur, Instance üyeler ise örneğe ait üyelerdir her örnek için bir kez oluşturulur.
      
      Static Constructor  
      Statik üyeler static kurucu method tarafından kurulur/başlatılır. Instance üyeler, Instance kurucu tarafından kurulur/başlatılır. Bu yüzden C# sınıf örneği üzerinden'den Static üyelere erişimi engeller. Yani Instance üyeler this ve referans değişkeni ile, STATİC üyler sınıfın kendisi ile çalışır.
      Static kurucu parametre almaz. 
      Statik kurucu metod, Instance kurucu metod'dan daha önce çalışır. Haliyle statik üyelerde önce çalışır. 
      Statik kurucu, içinde statik olmayan bir öğeyi barındıramaz.
    */

    public class _20_Circle
    {
       
        public static float _PI;
        int _Radius;
         
        static _20_Circle()
        {
            //_20_Circle a = new _20_Circle(5);
            //a._Radius = 3;

            _PI = 3.141F;
            Console.WriteLine("Static constructor is called");
        }
        public _20_Circle(int radius) // static methodlar 
        {
            Console.WriteLine("Instance constructor is called");
            this._Radius = radius;
        }

        public static void Print()
        {
            //
        }

        public float Calculate()
        {
            
            
			//_PI artık per object temelli yani CLASS'ın bir örneği ile çağarılmasına gerek yok direk CLASS' ile çağarılabilir.
            return _20_Circle._PI * this._Radius * this._Radius;
        }
    }

    public class _20_StaticAndInstanceClassMembers
    {
        public static void Main()
        {
            Console.WriteLine(_20_Circle._PI);
            _20_Circle c1 = new _20_Circle(5);
            //Console.WriteLine(c1.Calculate());
            //Circle c2 = new Circle(6);
            //Console.WriteLine(c2.Calculate());
        }
    }
}