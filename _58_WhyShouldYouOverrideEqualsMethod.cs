using System;

namespace Dersler
{
	/*
      Equals() methodu ile nesne içindeki değerleri karşılaştırmayı istiyoruz.
      VALUE TPYE'lar kullandığı nesnenin değerlerini getirdiği için Equals() methodu sorun çıkarmaz.
      Fakat REFERANCE TYPE'lar ile çalışırken sorun çıkar. REFERANCE TYPE'lar değer olarak yol getirdiği için Equals() methodu sadece yol değeri aynımı değilmi diye kontrol edebilir. Bizim istediğimiz şey yolların karşılaştırılması değil yolların içindeki değerlerin karşılaştırılması. Çünkü yollar farklı olsa bile içindeki değerler aynı olabilir. Bu yüzden Equals() methodunun üzerine yazacağız.
	  
      EQUALS() methodunda yapmamız gereken 3 şey var.
         1. Gönderilecek nesne örneğine bir CONSTURCTER uygulanmış mı diye kontrol ediyoruz.(null mı değil mi)
         2. Gönderilen nesnenin türünü kontrol etmeliyiz..
         3. Gelen nesne örneğinin FIELD'ları aynı değerleri taşıyor mu taşımıyor mu
             
      NOT: Equals metodunun üzerine yazdığımızda sınıf adında uyarı mesajı verir. GETHASHCODE() methodununda üzerine yazmamız isteniyor.
           HashCode: nesnelerin RAM'de tanımını sağlayan int değeridir. Her nesnenin kendine özel değerleri vardır.
           not:  VALUE TYPE'ların RAM'deki int değerleri her zaman aynıdır. REFERANCE TYPE'ların ise değişkendir.  
        Bu methodun üzerine yazmadığımızda nesneler farklı int değerler veriyor. Yazdığımızda ise aynı değeri alıyoruz.(değer önceki değerlerden farklı)
     */
    public class _58_WhyShouldYouOverrideEqualsMethod
    {
       #region Enum oluşturduk
        //public enum Direction
        //{
        //    East = 1,
        //    West,
        //    North,
        //    South
        //}
        #endregion
        public class _58_Customer
        {

            

            public string FistName { get; set; }
            public string LastName { get; set; }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is _58_Customer))
                {
                    return false;
                }
                return this.FistName == ((_58_Customer)obj).FistName && this.LastName == ((_58_Customer)obj).LastName;
            }
            public override int GetHashCode()
            {
                return this.FistName.GetHashCode() ^ this.LastName.GetHashCode();
            }
        }
        public static void Main()
        {
            

            _58_Customer c1 = new _58_Customer();
            c1.FistName = "Simon";
            c1.LastName = "Tan";

            _58_Customer c2 = c1;

            _58_Customer c3 = new _58_Customer();
            c3.FistName = "Simon";
            c3.LastName = "Tan";

            Console.WriteLine(c1 == c3);
            Console.WriteLine(c1.Equals(c3));

            #region Value type için == operatörü ve Equals() metodu sonuçları beklendiği olur.
            int i = 10;
            int j = 10;
            Console.WriteLine(i == j);
            Console.WriteLine(i.Equals(j));
            #endregion

            #region Enumlar için == operatörü ve Equals() metodu sonuçları beklendiği olur.
            //Direction direction1 = Direction.East;
            //Direction direction2 = Direction.East;
            //Console.WriteLine(direction1 == direction2);
            //Console.WriteLine(direction1.Equals(direction2));
            #endregion

        }
    }
}
