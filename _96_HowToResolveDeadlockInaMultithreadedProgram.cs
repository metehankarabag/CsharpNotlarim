using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Desler
{
    /*How To Resolve Deadlock
      Lock içinde Lock kullandığımızda, THREAD'lerin kullandığı RESOURCE'lar sürekli bir düzen içinde LOCK'a geliyorsa, DEAD LOCK'a girmeyiz.
      Bir düzen içinde gelmiyorsa, LOCK'a ilk giren THREAD'in çıkmasını beklemeliyiz.
      Yani RESOURCE'ları bir düzene sokmalıyız. Bu tamamen programlama mantığı ile oluyor.
       
      Aşağıda 2 nesne oluşturduk bu nesnelere lockların kullanacağı veriyi atıp lock içinde oluşturduğumuz nesneleri kullanacağız.
      If ile yaptığımız iş oluşturduğumuz nesne değişkenlerine alınan verinin düzenini sağlıyor.
      ilk gelen THREAD hangi veriyi almışsa, hemen peşinden gelen THREAD'de o veriyi alıyor.
      Böylece ilk THREAD tam olarak işini bitirmeden 2. THREAD işleme giremiyor.
     */
    class _96_HowToResolveDeadlockInaMultithreadedProgram
    {
        public static void Main()
        {
            Console.WriteLine("Main Started");
            _96_Account accountA = new _96_Account(101, 5000);
            _96_Account accountB = new _96_Account(102, 3000);

            _96_AccountManager accountManagerA = new _96_AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            _96_AccountManager accountManagerB = new _96_AccountManager(accountB, accountA, 2000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main Completed");
        }
    }

    public class _96_Account
    {
        double _balance;
        int _id;

        public _96_Account(int id, double balance) { this._id = id; this._balance = balance; }

        public int ID { get { return _id; } }

        public void Withdraw(double amount) { _balance -= amount; }
        public void Deposit(double amount) { _balance += amount; }
    }

    public class _96_AccountManager
    {
        _96_Account _fromAccount;
        _96_Account _toAccount;
        double _amountToTransfer;

        public _96_AccountManager(_96_Account fromAccount, _96_Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }

        public void Transfer()
        {
            object _lock1, _lock2;

            if (_fromAccount.ID < _toAccount.ID) { _lock1 = _fromAccount; _lock2 = _toAccount; }
            else                                 { _lock1 = _toAccount; _lock2 = _fromAccount; }

            Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((_96_Account)_lock1).ID.ToString());

            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((_96_Account)_lock1).ID.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + " suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + " back in action and trying to acquire lock on " + ((_96_Account)_lock2).ID.ToString());

                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((_96_Account)_lock2).ID.ToString());

                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);

                    Console.WriteLine(Thread.CurrentThread.Name + " Transfered " + _amountToTransfer.ToString() + " from " +                                           _fromAccount.ID.ToString() + " to " + _toAccount.ID.ToString());
                }
            }
        }
    }
}