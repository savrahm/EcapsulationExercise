using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = new BankAccount();

            account1.Deposit(87.15);
            Console.WriteLine(account1.GetBalance());
        }
    }
}
