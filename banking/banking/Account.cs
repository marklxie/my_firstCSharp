using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace banking {
	class Account {
		private static int NextId = 1;
		protected bool CheckAmountGreaterThanZero(double amount) {
			bool GTZ = true;
			if(amount <= 0) {
				throw new Exception("Amount must be greater than 0 dude");
			//	GTZ = false;
			}
			return GTZ;
		}
		protected void SetBalance(double FixedBalance) { this.Balance = FixedBalance; }
		public static bool Transfer(double amount, Account FromAccount, Account ToAccount) {
			
			if(amount <= 0) {
				return false;
			}
			if(FromAccount is null || ToAccount is null) {
				return false;
			}
			var beforeBalance = FromAccount.Balance;
			var afterBalance = FromAccount.Withdraw(amount);

			if(beforeBalance != afterBalance + amount) {
				FromAccount.SetBalance(beforeBalance);
				return false;
			}
			ToAccount.Deposit(amount);
			return true;
		}

		public  double Balance { get; private set; } = 0;
		public int Id { get; private set; }
		public string Description { get; set; }
		public Account() : this("New Account") { }
		public Account(string Description) {
			this.Id = NextId++;
			this.Description = Description;
		}
		public void print() {
			Console.WriteLine($"Account ID: {Id}, Balance: {Balance}, Description: {Description}");
		}



		public double Deposit(double amount) {
			if(!CheckAmountGreaterThanZero(amount)) {
				Console.WriteLine("Amount must be greater than zero");
				return Balance;
			}
			Balance = Balance + amount;
			return Balance;
		}

		public double Withdraw(double amount) {
			if(!CheckAmountGreaterThanZero(amount)) {
				Console.WriteLine("Amount must be greater than zero");
				return Balance;
			}
			if(amount <= Balance) {
				Balance -= amount;
			}
			else {
				Console.WriteLine("The amount specified is greater than the balance");	
			}
			return Balance;
		}
	}
}
