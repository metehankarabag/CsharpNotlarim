using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler
{
     /* PARTIAL CLASS
      Bir sınıf ne kadar parçadan oluşurda oluşsun bir sınıf olacağı için bir parçasına uygulanan özellikler diğerleri içinde geçerlidir.
      Tüm parçalarda ACCES MODIFIERS'i kullanılır.
      CLASS'ın bir parçası ABSTRACT veya SEALED olarak belirlemesi, bir türden türemesi durumlarında diğer parçalarda bundan etkilenir.
       Örneğin bir parçada CLASS'dan türetirsek başka bir parçada başka bir CLASS'ı kullanamayız.
       Bir parça interface'den türettiğimizde uygulama methodlarını başka bir parçaya ekleyebiliriz.
   */

    public class _61_PartialClasses
    {
        public static void Main()
        {
            _61_Customer c1 = new _61_Customer();
            c1.FirstName = "Pragim";
            c1.Lastname = "Technologies";
            string FullName1 = c1.GetFullName();
            Console.WriteLine("FullName = " + FullName1);

            _61_PartialCustomer c2 = new _61_PartialCustomer();
            c2.FirstName = "Pragim";
            c2.Lastname = "Tech";
            string FullName2 = c2.GetFullName();
            Console.WriteLine("FullName = " + FullName2);
        }
    }

    #region Partial Classlar birinden method var birinde fieldlar ve propertyler
    public partial class _61_PartialCustomer
    {
        string _firstname;
        string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }
    }
    public partial class _61_PartialCustomer
    {

        public string GetFullName()
        {
            return _firstname + " " + _lastname;
        }
    }
    #endregion
    #region Tek parca hali
    public class _61_Customer
    {
        string _firstname;
        string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }
        public string GetFullName()
        {
            return _firstname + " " + _lastname;
        }
    }
    #endregion
}
