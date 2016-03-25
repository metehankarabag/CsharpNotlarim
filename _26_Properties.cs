using System;

namespace Dersler
{
    /*PROPERTY Kullanımı
      Property'ler sınıfların, methodların ve field'ların güvenliğini sağlamak için ve kullanılır. Kullanıcının sınıf field'larına girdiği değeri kontrol edemeyiz. Bu yüzden kullanıcı direk sınıf field'larına erişememeli, aynı şekilde method parametrelerine girilen değerleri de kontrol edemeyiz. Bu yüzden method işlemlerinde sınıf field'larını kullanmalıyız. Kısaca kullanıcıdan alınan her değeri bir property'den geçirip değeri sınıf field'larına almalıyız ve bu field'ları methodlarda kullanmalıyız. 
        Property iki alandan oluşur.
        1. Set {} : Kullanıcının Property'e set alanıyla değer gönderir. Değere value anahtarı ile ulaşıp değeri field'a atırız.
        2. Get {} : Return anahtarı ile kullanacıya Field'daki değeri göndeririz.
     */
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public string Email { get; set; }
        public string City { get; set; }

        public Student()
        {
        }

        public void print(int _id, string _name)
        {
            Name = _name;
            SetId = _id;

            Console.WriteLine("Student ID = {0}\n" + "Student Name = {1}\n" + "Student Pass mark = {2}", this._id, this._name, this._passMark);
        }
        
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No name" : this._name;

            }
        }

        public int SetId
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student id can not be negative");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
    }
    public class _26_Properties
    {
        public static void Main()
        {//önemli
            Student c1 = new Student();
            c1.SetId = 101;
            c1.Name = "Mark";
            c1.print(1,"Main");
            //Console.WriteLine("Student ID = {0}", c1.SetId);
            //Console.WriteLine("Student ID = {0}", c1.Name);
            //Console.WriteLine("Student ID = {0}", c1.PassMark);
        }
    }
}