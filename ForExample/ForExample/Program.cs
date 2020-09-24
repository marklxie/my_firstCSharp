using System;
using System.Collections.Specialized;
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

			int[] ints = { 17, 94, 51, 51, 89, 47, 68, 40, 65, 41, 41, 63, 39, 61, 44 };
			var sumOfOdds = 0;

			for(int i = 0; i < 15; i++) {
				if(ints[i] % 2 == 1) {
					sumOfOdds += ints[i];
					Console.WriteLine(ints[i]);
				}
			}


			Console.WriteLine($"The answer is {sumOfOdds}.");

			for(int i = 0; i < 15; i++) {
				if(ints[i] % 2 == 1) {
					sumOfOdds += ints[i];
					Console.WriteLine(ints[i]);
				}
			}
			Console.WriteLine($"The answer is {sumOfOdds}.");

			int[] list = { 28, 62, 89, 67, 6, 62, 88, 43, 10, 26};
			total = 0;
			foreach(int num in list) {
				total += num;
			}
			Console.WriteLine($"\nThe answer is {total}.");

			string[] names = { "Greg", "Elena", "Manami", "Christian", "Tracy", "Mark", "Yvonne" };
			foreach(string name in names) {
				foreach(int num in list) {
					if(num >= 50)
						Console.WriteLine($"{num}{name}");
				}
			}
		}
	}
}
