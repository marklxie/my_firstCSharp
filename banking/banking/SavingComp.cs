using System;
using System.Collections.Generic;
using System.Text;

namespace banking {
	class SavingComp {
		public Account Account { get; private set; } = null;
		public double InterestRate { get; private set; } = 0.01;
		public SavingComp(string description) {
			Account = new Account(description);
		}

		public SavingComp(double intRate, string description) {
			Account = new Account(description);
			this.InterestRate = intRate;
		}
		public SavingComp() { Account = new Account(); }

		public double CalculateInterest(int months) {
			return Account.Balance * InterestRate / 12 * months;
		}

		public double Deposit(double deposit) {		
			return Account.Deposit(deposit);
		}

		public double Withdraw(double withdraw) {
			return Account.Withdraw(withdraw);
		}

		//public double SetBalance(double setBalance) {
		//	return this.Account.);

//		}

		public void Print() {
			Console.WriteLine($"IntRate: {InterestRate}, Desc: {Account.Description}, Bal: {Account.Balance}");
		}

		public static bool Transfer(double amount, SavingComp sc1, SavingComp sc2) {
			return Account.Transfer(amount, sc1.Account, sc2.Account);
		}

		public static bool Transfer(double amount, SavingComp FromAccount, Account ToAccount) {
			return Account.Transfer(amount, FromAccount.Account, ToAccount);
		}

		public static bool Transfer(double amount, Account FromAccount, SavingComp ToAccount) {
			return Account.Transfer(amount, FromAccount, ToAccount.Account);
		}


		public double DepositInterest(int months) {
			double interest = CalculateInterest(months);
			Account.Deposit(interest);
			return interest;
		}
	}
}

