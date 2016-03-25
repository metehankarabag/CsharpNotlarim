using System;
namespace Dersler
{
    /*Method overloading
      Method parametre ve dönüs türleri değiştirilerek yapılır.
     */
    public class _25_MethodOverloading
    {
        public static void Main()
        {

        }

        public static void Add(int fn, int sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(float fn, float sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(float fn, int sn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }

        public static void Add(int fn, int sn, int tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
        public static void Add(int fn, int sn, out int tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
            tn = fn + sn;
        }
        //public static int Add(int fn, int sn, int tn) // dönüş türünü değiştirerek methodları çogaltamayız.
        //{
        //    Console.WriteLine("Sum = {0}", fn + sn);
        //    return fn + sn + tn;
        //}
        public static void Add(int fn, int sn, params int[] tn)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }

        public static void Add(int fn, int sn, int tn, int fourthNumber)
        {
            Console.WriteLine("Sum = {0}", fn + sn);
        }
    }
}