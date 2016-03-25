using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Desler
{
    /* 
      Geçen dersler de birden fazla alanda kullanılabilen bir field'ın çalışma sorununu field'ı alana referans olarak çekerek çözdük.
      Bu işe yaradı çünkü tüm THREAD'ler aynı alan üzerinde çalışıyordu.
      Buradaki sorun da bu lock bir alanı alan üzerinde çalışan THREAD ile birlikte kilitler.
      İç içe lock kullandığımızda içeri ilk lock'a 2 alan girdiğinde, THREAD'lar iç lock için bir birlerin alanları üzerine çalışma isterse program kilitlenir.
      Tahminim - VALUE TYPE'lari ile çalışırken sorun olmayacaktır.
     */
    class _95_DeadlockInaMultithreadedProgram
    {
        public static void Main()
        {
            Console.WriteLine("Main Started");
            _95_Account accountA = new _95_Account(101, 5000);
            _95_Account accountB = new _95_Account(102, 3000);

            _95_AccountManager accountManagerA = new _95_AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            _95_AccountManager accountManagerB = new _95_AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main Completed");
        }
    }

    public class _95_Account
    {
        double _balance;
        int _id;

        public _95_Account(int id, double balance) { this._id = id; this._balance = balance; }
        public int ID { get { return _id; } }
        public void Withdraw(double amount) { _balance -= amount; }
        public void Deposit(double amount) { _balance += amount; }
    }

    public class _95_AccountManager
    {
        _95_Account _fromAccount;
        _95_Account _toAccount;
        double _amountToTransfer;

        public _95_AccountManager(_95_Account fromAccount,_95_Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccount.ID.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccount.ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + _toAccount.ID.ToString());
                lock (_toAccount)
                {
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}
