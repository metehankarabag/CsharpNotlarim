using System;
using System.IO;
namespace Dersler
{
    class ExceptionHandling
    {
		/*Try Cache
		  Cache hata olduğunda çalışan alandır ve sadece parametresi olarak aldığı hata türünde bir hata gelirse çalışır. Bir try bloğuna birden fazla CACHE uygulayabiliriz. Bu yüzden CACHE'de yazdığımız kodda çıkabileceğini düşündüğümüz hatalara özel sınıfları kullanabiliriz. Bu base sınıfı kullanmaktan daha iyidir. En son tahmin edemediğimiz hatalar olduğunda çalışması için EXCEPTION sınıfını kullanabiliriz.
		  
		  Not: StackTrace  break point kullanıldığı zaman hangi satır programda hatalı onu gösteriyormuş
		*/
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"E:\Uygulamalar\C# UYGULAMALARI1\Verkant\StreamReadher.txt");//@ koymasaydık \\ olcaktı
                Console.WriteLine(streamReader.ReadToEnd());

            }
            catch (FileNotFoundException ex)
            {
                
                Console.WriteLine("Please check if  the file {0} exists", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }

                Console.WriteLine("Finally Block");
            }

        }
    }
}