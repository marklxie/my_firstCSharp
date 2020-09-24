using System;

namespace OddOrEven {
	class Program {
		static void Main(string[] args) {
			
			Console.Write("Enter an integer: ");
			var response = Console.ReadLine();
			//Console.Write(response);
			var nbr = Convert.ToInt32(response);

			if ((nbr % 2) == 0) {
				Console.WriteLine($"The number {response} is even.");
			}
			else {
				Console.WriteLine($"The number {response} is odd.");
			}
		}
	}
}
