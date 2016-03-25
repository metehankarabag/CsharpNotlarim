using System;

namespace Dersler
{
    /*35 Multiple Class Inheritance Using Interfaces
	  Son sınıfı iki Interfaceden türetmeden de oluşturabilirdik.
	  Fakat böyle yapsaydık kullanıcı sınıflar arasında bir bağlantı olup olmadığını anlayamazdı.
	  Bu yüzden isimleri aynı olan farklı işler yapan iki method sanardı.	  
    */


    interface IA
    {
        void Amethod();
    }

    public class A : IA
    {
        public void Amethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void Bmethod();
    }

    public class B : IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B");
        }
    }

    public class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void Amethod()
        {
            a.Amethod();
        }

        public void Bmethod()
        {
            b.Bmethod();
        }
    }

    public class _35_MultipleClassInheritanceUsingInterfaces
    {
        public static void Main()
        {
            AB ab = new AB();
            ab.Amethod();
            ab.Bmethod();
        }
    }
}