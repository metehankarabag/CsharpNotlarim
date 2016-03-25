using System;
using System.Collections.Generic;
using System.Linq;

namespace Dersler
{
    /*FUNC
      GENERIC DELEGATE'dir. 17 overload'ı var. Yani herhangi bir türde 16 giriş parametresi alabilir.
      Dikkat edilmesi gereken nokta tüm GENERIC DELEGATE'lerde son TYPE sonuç türünü belirler.
      
      Not: SELECT gibi EXTENSION METHOD'lar kendilerinden önceki IEUMERABLE nesneler üzerinde çalışır.
      Derste SELECT methodunu kullandık. 2 Overload'ı var ve ikiside parametre olarak FUNC alıyor.
      1. Overload'da FUNC -> bir nesne örneği alıp sting dönerken, 2. Overload'da bir nesne örneği ve bir int aldıktan sonra string dönüyor.
      Yani FUNC'ın 1. overload tek parametreli, 2. overload 2 parametreli bir method istiyor.
      
      FUNC DELEGATE'ın kullanım şekilleri.
      1. kullanım 
            DELEGATE'lerin parametre olarak method alıdığın biliyoruz.
            ilk satırda yeni bir örnek kurmak yerine LAMDA EXPRESSION ile bir method veriyoruz.
            ikinci satırda bu FUNC'ı parametre olarak atıyoruz.
      Bu kullanımda LAMBDA'dan sonra ANONYMOUS method kullanılamaz. Çünkü LAMBDA sadece DELEGATE türündeki değişkenlerine uygulanabilir. ANONYMOUS method VAR düründe değer döner.
      (Anonymous method'un property'sini uygulayarak yapabiliriz. new{prop = ""}.prop) 
      2. kullanım
            FUNC DELEGATE örneği oluşturmak yerine LAMBDA EXPRESSION'u direk parametre olarak veriyoruz.("Anonymous method kullanmak gibi")
      Bu kullanımda LAMBDA'dan sonra ANONYMOUS METHOD kullanabiliriz. Sonuçu Anonymous PROPERTY'si olarak yansıtabiliriz.
      
      3. kullanımda FUNC DELEGATE'ine birden fazla parametrenin nasıl girilebileceği gösterilmiş. (x,y,...)
     
     */
    class _100_FuncDelegate
    {
        public static void Main()
        {


            List<_100_Employee> listEmployees = new List<_100_Employee>()
            {
                new _100_Employee{ ID = 101, Name = "Mark"},
                new _100_Employee{ ID = 102, Name = "John"},
                new _100_Employee{ ID = 103, Name = "Mary"},
            };
            //1. kullanım
            Func<_100_Employee, string> selector = employee => "Name = " + employee.Name;
            var names1 = listEmployees.Select(selector);
            //2. kullanım
            IEnumerable<string> names = listEmployees.Select(employee => "Name = " + employee.Name);

            //3. kullanım
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();
            string result = funcDelegate(10, 20);
            Console.WriteLine(result);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public class _100_Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
