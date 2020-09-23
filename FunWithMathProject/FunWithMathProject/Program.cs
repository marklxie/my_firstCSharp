using System;

namespace FunWithMathProject {
	class Program {
		static void Main(string[] args) {
			int[] numbers = { 573, 595, 468, 191, 964 };
			int hold = 0;
			for (int i = 0; i < 5; i++) {
				hold = hold + numbers[i];
			}

			int avg;
			avg = hold / 5;
			Console.WriteLine(hold);
			Console.WriteLine(avg);
		}
	}
}
