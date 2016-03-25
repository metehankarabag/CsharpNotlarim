using System;

namespace Dersler
{
    /*BİRDEN FAZLA CLASS MİRAS PROBLEMİ
      A - B ve C yi türetti ve aynı methodun sonuçunu override ile değiştirildi.
      D, B vs C CLASS'larından türedi ve bir örneğinden her sınıfda faklı sonuç veren bu methodu çağırıldı, B ve C bu methodun üzerine farklı olarak yazı, sonra hangi sınıf miras verecek hiç düşündün mü? B'mi C'mi
 
      Bu ambiguity(belirsizlik) diamond(baklava biziçi(elmas)) sorunu olarak adlandırılır.
    */
    public class A___
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
    public class B___ : A___
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }
    public class C : A___
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }
    public class D : B___//, C
    {
    }

    public class _34_ProblemsOfMultipleClassInheritance
    {
        public static void Main()
        {
            D d = new D();
            d.Print();
        }
    }
}