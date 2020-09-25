using System;
using System.Threading;

namespace WhileExample {
	class Program {
		static void Main(string[] args) {
			var num = 1;
			var cube = 0;
			while(num <= 25) {
				cube = num * num * num;
				/*if(num % 2 == 1) {
					Console.WriteLine($"The odd number {num} cubed is {cube}.");
				}*/
				Console.WriteLine($"The odd number {num} cubed is {cube}.");
				num++;
				num++;
			}

			num = 1;
			int product = 1;
			while(product < 500) {
				product *= num;
				num++;
				Console.WriteLine(product);
			}

			Console.WriteLine($"The final product is {product}.");

		}
	}
}
