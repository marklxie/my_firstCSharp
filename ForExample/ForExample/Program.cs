using System;
using System.Globalization;

namespace ForExample {
	class Program {
		static void Main(string[] args) {
			for (int i = 0; i < 10; i++) {
				Console.WriteLine($"Hello World! idx is {i}");
			}
			Console.WriteLine("Done");

			int total = 0;
			for (int j = 1; j <= 50; j++) {
				if ((j % 5 == 0) || (j % 7 == 0)) {
					total += j;
					//Console.WriteLine(j);
				}
			}

			Console.WriteLine($"The answer is {total}.");
		}
	}
}
