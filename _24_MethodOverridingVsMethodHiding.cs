using System;

namespace Dersler
{
    /*OVERRİDE vs METHOD HİDDİNG ARASINDAKİ TEK FARK
      New: Reference'ın türündeki methodu kullandırır. Normal olan da bu
      Override: Türeyen sınıfın methodunu kullandırır.
    */
    #region Method Override başlangıcı
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a BaseClass Print method");
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am a DerivedClass Print method");
        }
    }
    #endregion

    #region Method Hidding başlangıcı
    public class BaseClass2
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a BaseClass Print method");
        }
    }
    public class DerivedClass2 : BaseClass2
    {
        public new void Print()
        {
            Console.WriteLine("I am a DerivedClass Print method");
        }
    }
    #endregion

    public class _24_MethodOverridingVsMethodHiding
    {
        public static void Main()
        {
            BaseClass bs = new DerivedClass();
            bs.Print();
            Console.WriteLine("***********************");
            BaseClass2 bs2 = new DerivedClass2();
            bs2.Print();
            DerivedClass2 ds2 = new DerivedClass2();
            ds2.Print();
        }
    }
}
