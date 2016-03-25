using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dersler
{
    
    /*
     What is a process
     Process, işletim sisteminin gerekli kaynakları sağlayarak, bir programın çalışmasını kolaylaştırmak için kullandığı bir şeydir. 
     Çalışan her programın görev yöneticisinde Process'i görünür.
     Her Process'in kendisi ile ilişkili özel bir Id si vardır.

     What is Thread (ipe dizmek, tek sıra halinde düzene sokmak) 
     Thread'ler bağlantılı olmayan iş parçacıklarını çalışabilecek uygulama kodlarını aynı anda çalıştırmak için kullanılır.
     Aynı zamanda birden fazla kod çalıştığı için program akışı hızlanır.
    
     Bir işlemin gerçek uygulama kodunu çalıştıran ve ana thread olarak adlandırılan en az bir thread'i vardır.
     Her programın bir process'i vardır ve birden fazla THREAD'i uygulama kondunu çalıştırıyor olabilir. 
     Yani THREAD'ler PROCESS'ler içinde bulunur.
     */

    /*
     * 86 MULTI THREADING
      
     MAIN thread UI(kullanıcı arayüzü) thread olarak da adlandırılır. Bu yüzden MAIN THREAD çalışırken kullancı arayüzü donar. Çünkü MAIN THREAD işlemi çalıştırmakla meşgul. İşlem sırasında FORM'da yaptıklarımız, ilk işlem bittikden sonra çalışıyor.
     */
	 
    /*
     * Part 87 Advantages and disadvantages of multithreading
     
     Avantajları
     Kullanıcı ara yüzünün cevap vermesini sağlar.
     I/O operasonlarının tamamlanması için beklerken, işlemci zamanının kullanımı verimli hale sokar.
     Birden fazla işlemcisi/çekirdeği olan bir makinede kodun aynı anda işletilmesi sağlar.
     
     Dezavantajları
     Tek işlemcili/çekirdekli bir makinede threading, performansı olumsuz etkiler. Çünkü thread'ların çalışma düzeni çok karışır.
     Aynı görevi yapmak için daha fazla kod satırı yazmak zorundayız.
     Multithreaded uygulamaları yazması, anlaması, debug'ı ve koruması zordur.
     
     Dikkat et: Multithread'i sadece yapım avantajlarının dezavantajlarından daha ağır geldiğinde kullan.
     
     */

    public class _86_Multithreading
    {
	//Burada main THREAD ile normal THREAD'in çalışma düzenini kurcalamışım.
        static string b;
        public static void Main()
        {
            Console.WriteLine("Main Thread başladı {0}", DateTime.Now.ToLongTimeString());
            b = "Thread başlamadan önceki değer";
            Thread worker = new Thread(DoTimeConsumingWork);
            worker.Start();
            
            Console.WriteLine("Main Thread devam ediyor bir tuşa bas: ");
            //DoTimeConsumingWork();
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Bastığın tuş = {0} ve cevap zamanı = {1} ", a, DateTime.Now.ToLongTimeString());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            b = "Thread Başladıktan sonraki değer";
        }

        private static void DoTimeConsumingWork()
        {
            Console.WriteLine(b);
            Console.WriteLine("Worker Thread'in 5 sn lik işi başladı {0} ve Main Thread durdu", DateTime.Now.ToLongTimeString());
            Thread.Sleep(5000);
            Console.WriteLine("Worker Thread'in 5 sn lik işi bitti {0}", DateTime.Now.ToString());
            Console.WriteLine(b);
        }
    }
}
