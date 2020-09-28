using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples {
	class Major {
		public int Id { get; set; }
		public string Description { get; set; }
		public int MinSAT { get; private set; }
		public void SetMINSAT(int minSAT) {
			if(minSAT >= 400 && minSAT <= 1600) {
				this.MinSAT = minSAT;
			}
			else {
				Console.WriteLine("That is not a proper SAT score.");
			}
		}
		public Major() {
			this.Id = 0;
			this.Description = "No Description";

		}
		public Major(int ID, string description, int minSAT) {
			this.Id = ID;
			this.Description = description;
			this.MinSAT = 400;
			this.SetMINSAT(minSAT);
		}
	}
}

