using System;
using System.Collections.Specialized;
using System.Globalization;

namespace ForExample {
	class Program {
		static void Main(string[] args) {
			for(int i = 0; i < 10; i++) {
				Console.WriteLine($"Hello World! idx is {i}");
			}
			Console.WriteLine("Done");

			int total = 0;
			for(int j = 1; j <= 50; j++) {
				if((j % 5 == 0) || (j % 7 == 0)) {
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

			int[] list = { 28, 62, 89, 67, 6, 62, 88, 43, 10, 26 };
			total = 0;
			foreach(int num in list) {
				total += num;
			}
			Console.WriteLine($"\nThe answer is {total}.\n");

			string[] names = { "Greg", "Elena", "Manami", "Christian", "Tracy", "Mark", "Yvonne" };
			foreach(string name in names) {
				foreach(int num in list) {
					if(num >= 50)
						Console.WriteLine($"{num}{name}");
				}
			}

			int[] newNbrs = {
				754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
				187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
				460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
				690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
				435, 643, 809, 874, 906, 620, 328, 369, 426, 561
			};
			var saize = newNbrs.Length;

			int lowest = newNbrs[0];
			int highest = newNbrs[0];
			int middle = newNbrs[0];

			foreach(int nbr in newNbrs) {
				if(lowest > nbr) {
					lowest = nbr;
				}

				if(highest < nbr) {
					highest = nbr;
				}


			}
			Console.WriteLine($"Highest value is {highest}.\nLowest value is {lowest}.");


			double[] terms = { 1.2, 1.3, 1.5, 1.7, 1.9, 1.11 };
			//int product = 1;
			var answer = 0.0;
			foreach(var term in terms) {
				//product *= term;
				answer += term;
			}
			//Console.WriteLine($"Final Product {product}");
			Console.WriteLine($"Final answer {answer}");

		}
	}
}
