using System;

namespace OtherStatementsPractice {
	class Program {
		static void Main(string[] args) {
			
			//Ternary Operator
			bool isnotBlack = true;
			string color;

			if(isnotBlack == true) {
				color = "There is color";
			}
			else {
				color = "It's Black";
			}

			Console.WriteLine(color);

			var todayisMonday = false;
			var dayofWeek = "";

			dayofWeek = (todayisMonday == true) ? "Monday" : "Not Monday";

			Console.WriteLine(dayofWeek);
			
		}
	}
}
