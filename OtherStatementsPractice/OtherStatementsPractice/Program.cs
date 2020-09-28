using System;

namespace OtherStatementsPractice {
	class Program {
		static void Main(string[] args) {

			//Continue

			for(var i = 1; i <= 10; i++) {
				if(i % 2 == 0) {
					continue;
				}
				Console.WriteLine(i);
			}
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
			int count = 0;
			for(int i = 0; i < 1000; i++) {
				count = 0;
				for(int j = 2; j < i; j++) {
					if(i % j == 0) {
						count++;
					}
					if(count > 0) {
						break;
					}
				}
				if(count < 1) {
					Console.WriteLine(i);
				}
			}
			static int add1(int nbr) {
				return nbr + 1;
			}

			Console.WriteLine(add1(6));
		}

	}
}
