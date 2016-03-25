using System;
using System.IO;
namespace Dersler
{
	/*
      Inner Exception EXCEPTION sınıfına ait bir PROPERTY'dir.
	  Exception'lar TRY içindeki kodlarda bir hata olduğunda çalışır.
	  hata nedeni ile birlikte CATCH alanına gelir.
	  Hata bilgisine CATCH alanının exception parametresinden ulaşılır.
	  
	  İç içe TRY CATCH bloğu varsa ve içerideki TRY'da bir hata olursa, içerideki CACHE çalışır.
	  İçerideki CACHE'de bir hata olursa, dışarıdaki CACHE çalışır.
	  Dışarıdaki CATCH'ı çalıştıran hata OUTER EXCEPTION olur. 
	  Çünkü CACHE'nin exception değişkeninden direk alınır.
	  İçerideki CACHE'in çalışmasına neden oldan hata ise INNEREXCEPTION'dır.
	  Exception değişkeninden INNEREXCEPTION verisine ulaşmak için değişkene property'i uygulamak zorundayız.
	  
	  1. Not: GetType() methodundan hata ile ilgili bir çok bilgiye ulaşabiliriz.(Hata adı)
	  2. Not: Message PROPERTY'si hata varsayılan mesajını döner.
	  3. Not: Exception değişkenine InnerException property'sini uyguladıktan sonra bilgilerine ulaşabiliriz.
	*/
	/*StreamWriter
	  Dosyaya yazı yazmak için kullanılır.
	  CONTRUCTER'ının 7 overload'ı vardır ve parametresiz olanı yoktur.
	  Overload'larda kullanılan parametreler var amaçları
	  String parametre oluşturulacak veya varolan dosya yolunu belirtmek için kullanılır.
	  STREAM parametre kullanılır.
	  ENCODING parametre yazdırılacak veriyi şifrelemek için kullanılır.
	  bool parametre varolan dosyanın üzerine yazılıp yazılmayacağını belirler. Dosya varsa ve bu değer False ile dosya yeniden yazılır, bu değer TRUE ise veri dosyaya yazılır. Dosya yoksa yeni bir dosya oluşturulur.
	  int parametre dosya boyutunu ayarlar.
	  
	  Write() methodu dosyaya metin yazdırmak için kullanılır.
	  dosyanın tüm işlemleri bitirildikten sonra serberst bırakılması için Close() methodu kullanılmalıdır.
	*/
    public class _41_InnerExceptions
    {
        public static void Main()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first Number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    string FilePath = @"E:\Uygulamalar\C# UYGULAMALARI\Verkant\StreamReadher1.txt";
                    if (File.Exists(FilePath))
                    {
                        StreamWriter sw = new StreamWriter(FilePath);
                        sw.Write(ex.GetType().Name);// fullname de alınabilir.
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();

                        Console.WriteLine("There is a problem, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(FilePath + "is not present");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(" Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine(" Inner Exception = {0}", exception.InnerException.GetType().Name);
                }

            }
        }
    }
}