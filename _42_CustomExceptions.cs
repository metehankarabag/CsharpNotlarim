using System;
using System.IO;
using System.Runtime.Serialization;

namespace Dersler
{
    /*Costum Exception
     .NET istediğimiz hatayı sağlamıyorsa kullanırız.
	 EXCEPTION CLASS'ı tüm EXCEPTION CLASS'larının BASE CLASS'ıdır. Bir CLASS'ı bu CLASS'dan türeterek kendi EXCEPTION CLASS'ımızı oluşturabiliriz.
	 Oluşturduğumuz CLASS'ın her kullanıma açık olmarı için CONSTRUCTER'ının esnek olması gerekir.(Sadece bir mesaj, hem mesaj hem hata türü, vs..)
	 Fakat sonuçta işi BASE CLASS methodu yapacağı için CONSTRUCTER'lar parametrelerine uygun olan BASE CONSTRUCTOR'ları çalıştırmalı.
	 Not: CLASS'ımızı En BASE olan EXCEPTION CLASS'ından türetmeliyiz çünkü .net'in hatamızı işleyebileceği bir sınıf yok. Bu CLASS'daki varsayılan hata işleri bütün hatalar için uygun.
     [Serializable] ATTRIBUTE: Uygulamanın gerçerli ortamından dışarıdaki bir ortamda çalıştırılması veya ortama aktarılması gerekirken kullanılır.
	 Çalışması gereken nesne btye'lara çevirerek taşınır. Çalışacağı ortama ulaştığında tekrar eski haline çevirilerek çalışır.
    */

    public class _42_CustomExceptions
    {
        public static void Main()
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no  deuplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {   
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string Message) : base(Message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}