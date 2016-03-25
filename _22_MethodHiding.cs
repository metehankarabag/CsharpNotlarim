using System;

namespace Dersler
{
     /* Methodu saklama
        Referans değişkeni türeyen sınıfsa ve bir method hem base sınıfda hemde türeyen sınıfda varsa, base sınıfdaki method saklanır. Zaten referans değişkeninin kendi türündeki methodu kullanması normal olan. Referans türü base sınıf olsaydı bu sefer base sınıfdaki method kullanılacaktık.
     */
    public class _22_Employee
    {
        public string firstname;
        public string lastname;
        public string email;
        public _22_Employee() 
        { 
        }
        public void Printfullname()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }
    public class _22_Fulltimeemployee : _22_Employee
    {
        public _22_Fulltimeemployee() 
        { 
        }
        //public string firstname1; -- en alttaki yorum satırında bir şey denedim, kendime gıcıklık olsun diye ne denediğimi yazmıyorum.
        public new void Printfullname()
        {
            Console.WriteLine(firstname + " " + lastname + " - Constractor");
        }
    }
    public class _22_Parttimeemployee : _22_Employee
    {
        public float hourlyRate;
    }
    public class _22_MethodHiding
    {
        public static void Main()
        {
            
            //_22_Parttimeemployee PTE = new _22_Parttimeemployee();
            //_22_Fulltimeemployee FTE = new _22_Fulltimeemployee();
            _22_Employee ETE = new _22_Fulltimeemployee();

			//1. Not
            //_22_Employee a = new _22_Employee();
            //FTE = (_22_Fulltimeemployee)a;
            //a.Printfullname();

            //FTE.firstname = "FullTime";
            //FTE.lastname = "Employee";
            //FTE.Printfullname();
            

            //PTE.firstname = "PartTime";
            //PTE.lastname = "Employee";
            //((_22_Employee)PTE).Printfullname();

            ETE.firstname = "PartTime";
            ETE.lastname = "Employee";
            ETE.Printfullname();
            //((_22_Fulltimeemployee)ETE).firstname = ETE.firstname == "PartTime" ? null: "Fulltime";
            //((_22_Fulltimeemployee)ETE).Printfullname();
        }
    }
    
}