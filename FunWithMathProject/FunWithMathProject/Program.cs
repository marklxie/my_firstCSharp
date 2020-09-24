using System;

namespace FunWithMathProject {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 573, 595, 468, 191, 964 };
			int hold = 0;
			for (int i = 0; i < 5; i++) {
				hold += numbers[i];
			}

			var avg = hold / 5.0;
			int intAvg = hold / 5;
			var remainder = hold % intAvg;
			Console.WriteLine(hold);
			Console.WriteLine(avg);
			Console.WriteLine(intAvg);
			Console.WriteLine(remainder);
			

		}
	}
}
