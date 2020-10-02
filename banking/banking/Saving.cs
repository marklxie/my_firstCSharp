using System;
using System.Collections.Generic;
using System.Text;

namespace banking {
	class Saving:Account {
		public Saving() : base() { }
		public Saving(string description) : base(description) { }

		public Saving(double intRate, string description) : base(description) {
			this.InterestRate = intRate;
		}
		public double InterestRate { get; protected set; } = 0.01;
		public double CalculateInterest(int months) {
			return this.Balance * (this.InterestRate / 12) * months;
		}


		public double PayInterest(int months) {
			var interest = CalculateInterest(months);
			Deposit(interest);
			return interest;
		}

	}
}
