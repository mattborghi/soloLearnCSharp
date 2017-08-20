using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    // Encapsulation
    // C# supports the following access modifiers: public, private, protected, internal, protected internal.
    class BankAccount {
        private double balance=0;
        public void Deposit(double n) {
            balance += n;
        }
        public void Withdraw(double n) {
            balance -= n;
        }
        public double GetBalance() {
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            // Balance variable can only be accesible via the GetBalance public method.
            // It can not be accesible by calling b.balance = ...;
            Console.WriteLine(b.GetBalance());
        }
    }
}