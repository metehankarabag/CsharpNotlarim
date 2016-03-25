using System;
namespace Dersler
{
    /*IMPLEMENT INTERFACE ve EXPLICITLY IMPLEMENT
    
     IMPLEMENT INTERFACE
     Her Interface üyesinin türeyen sınıfa ait uygulama alanları oluşturulur. Aynı üyeye sahip olan 2 Interface'den miras alan sınıfda Interface Implementatıon uygulanırsa, türeyen Class'da oluşan alan Parent Interface'e aittir. Parentlik eşit ise o zaman sınıfın referansını bir Interface'e Cast etmemiz gerekir
	 
     EXPLICITLY IMPLEMENT INTERFACE
     Bunun anlamı Interface üyesinin uygulaması türeyen sınıfının içinde yazılmış ama üye türeyen sınıfa ait değil. Bu yüzden türeyen sınıfının referans değişkeni ile metodu çağıramayız.      
    */
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }

    public class _31_ExplicitInterfacesImplementation : I1, I2
    {
        #region Aşağıdaki INTERFACE açıklaması
        void I1.InterfaceMethod()
        {
            throw new NotImplementedException();
        }

        void I2.InterfaceMethod()
        {
            throw new NotImplementedException();
        }
        #endregion
        public static void Main()
        {
            _31_ExplicitInterfacesImplementation P = new _31_ExplicitInterfacesImplementation();
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();
			
            I1 i1 = new _31_ExplicitInterfacesImplementation();
      /*I2*/I1 i2 = new _31_ExplicitInterfacesImplementation();
            i1.InterfaceMethod();
            ((I2)i2).InterfaceMethod();
        }
    }
}