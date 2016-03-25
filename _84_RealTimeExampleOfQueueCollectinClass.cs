using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dersler
{
    public class _84_RealTimeExampleOfQueueCollectinClass
    {
        static Queue<int> tokenQueue;
        static  Queue<int> tokenQueue1;
        static int pageload;

        public static void Main() { GiveNumber();}

        private static void ServerNextCustomer(int counterNumber)
        {
            if (tokenQueue.Count > 1) tokenQueue.Dequeue();

            int tokenNumberToBeServed;
            if (tokenQueue1 != null && tokenQueue1.Count > 0){
                tokenNumberToBeServed = tokenQueue1.Dequeue();
                Console.WriteLine("Token Number : {0}, please go to Counter {1}", tokenNumberToBeServed.ToString(), counterNumber.ToString());
            }
            else
                Console.WriteLine("No customers in Queue");
            GiveNumber();
        }

        private static void GiveNumber()
        {
            if (tokenQueue == null && pageload == 0) { tokenQueue = new Queue<int>(); pageload = 1; }
            Console.WriteLine("if you want to take number, please press - y");
            string c = Convert.ToString(Console.ReadLine());
            switch (c)
            {
                case "y":
                    Console.WriteLine("Numaranız {0} ", tokenQueue.Count == 0 ? 1 : (tokenQueue.Last() + 1));
                    Console.WriteLine(tokenQueue.Count == 0 ? "Bekleyen yok" : "Önünüzde {0} kişi var", tokenQueue.Count);
                    tokenQueue.Enqueue(tokenQueue.Count == 0 ? 1 : (tokenQueue.Last() + 1));
                    tokenQueue1 = new Queue<int>(tokenQueue);

                    GiveNumber();
                    break;
                case "1":
                    ServerNextCustomer(1);
                    break;

                case "2":
                    ServerNextCustomer(2);
                    break;

                case "3":
                    ServerNextCustomer(3);
                    break;
                default:
                    GiveNumber();
                    break;
            }
            Console.Clear();
        }

    }
}