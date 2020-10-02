using System;

namespace banking {
	class Program {
		static void Main(string[] args) {

			var sav1 = new Saving("My Savings");
			var sav2 = new Saving(.12, "New Account");

			sav2.Deposit(1000);
			sav2.print();
			sav2.PayInterest(1);
			sav2.print();

			var sav3 = new SavingComp(0.12, "My Composite Savings");

			sav3.Print();
			SavingComp.Transfer(500, sav2, sav3);
			sav3.Print();

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
