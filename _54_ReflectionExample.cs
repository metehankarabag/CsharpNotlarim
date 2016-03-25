using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Dersler
{
	/*
	  Herhangi bir CLASS'ı tüm üyleri ile birlikte TYPE CLASS'ında tutabiliriz ve CLASS'ların TYPE almanın 3 farklı yolu vardır.
	  1. TYPE CLASS'ının STATIC methodu GetType()'ı string parametresi ile CLASS'ın tam adını alır.
	  2. typeOf() methodu parametre olarak uygulamada tanımlı bir TYPE adını alır.
	  3.Bir nesne örneğinin INSTANCE methodu olan GetType() methodu uygulamaktır. Parametre almaz.
	  
	  1. Not: Type CLAS'ı ABSTRACRT'dır.
	  TYPE türündeki bir FIELD'a bir tür attığımızda TYPE CLASS'ının INSTANCE methodlarını kullanarak atılan türün tüm üylerine ulaşabiliriz.
	  Bu methodlar sadece TYPE içindeki PUBLİC öğeleri alabilir.
	  GetMethods(): Tüm PUBLİC METHOD'larını MethodInfo[] dizisi olarak döner.
	  GetProperties(): tüm PUBLIC PROPERTY'lerini PropertyInfo[] dizisi olarak döner.
	  GetConstructors(): Tüm PUBLIC CONSTRUCTORS'larını ConstructorInfo[] dizisi olarak döner.
	  
	  MEMBERINFO CLASS'ı üstteki CLASS'ların BASE CLASS'ıdır. PROPERTY'lerinin hepsi TYPE döner. CLASS üylerden bağımsız olan TYPE'larını dönen PROPERTY'leri içerir. Üstteki CLASS'lar ise sadece üylerine özgü olan TYPE'ları dönen PROPERTY'leri içerir.
	  PropertyInfo Class'nın PropertyType özelliği PROPERTY'nin TYPE'ını döner. TYPE CLASS'ının NAME property'si ile PROPERTY adını alırız.
	  MEMBERINFO CLASS'ının ReflectedType özelliği geçerli üyeyi veren nesnenin TYPE'ını döner. TYPE CLASS'ının Name property'si ile nesnenin tür adını alırız.
	  vs..
	*/
    public class _54_ReflectionExample
    {
        public static void Main()
        {
            Console.Write("Enter a Type name. for example System.String: ");
            string TypeName = Console.ReadLine();
            Type T = Type.GetType(TypeName);

            Console.Clear();

            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine("--------------{0} type'ına ait methodlerın bilgileri----", TypeName);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
            Console.WriteLine();
            Console.WriteLine("----{0} type'ına ait propertylerin bilgileri başladı----", TypeName);
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            Console.WriteLine();
            Console.WriteLine("----{0} type'ına ait Contructor bilgileri başladı----", TypeName);
            ConstructorInfo[] cunstructors = T.GetConstructors();
            foreach (ConstructorInfo cunstructor in cunstructors)
            {
                Console.WriteLine(cunstructor.ToString());
            }
        }
    }
}
