using System;

namespace banking {
	class Program {
		static void Main(string[] args) {
			var acct1 = new Account();
			acct1.print();
			var acct2 = new Account("My checking");
			acct2.print();
			acct2.Deposit(1000);
			acct2.print();
			acct2.Withdraw(50);
			acct2.print();
			try {
				acct2.Withdraw(-200);
				acct2.print();
				acct2.Deposit(-200);
			}
			catch(DivideByZeroException) {
				Console.WriteLine("Attempted to divide by zero");
			}
			catch(Exception ex) {
				Console.WriteLine(ex.Message);
			}
			var success = Account.Transfer(200, acct2, acct1);

			if(success) {
				Console.WriteLine("the transfer worked!");
			}
			else {
				Console.WriteLine("The transfer failed!");
			}
		}
	}
}
