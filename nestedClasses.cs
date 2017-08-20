using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The SavingsAccount class is nested in the BankAccount class and can be used similar to other members of the class.
// A nested class acts as a member of the class, so it can have the same access modifiers as other members (public, private, protected).

namespace SoloLearn
{
	class Program
	{
	    public abstract class BankAccount
        {
          private BankAccount() {} // prevent third-party subclassing.
          private sealed class SavingsAccount : BankAccount {  }
          private sealed class ChequingAccount : BankAccount {  }
        }
		static void Main(string[] args)
		{
			
		}
	}
}
