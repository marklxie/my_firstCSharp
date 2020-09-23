using System;

namespace HelloWorldProject {
	class Program {
		public static void Main() {
			Console.WriteLine("Hello World!");
			Console.WriteLine("My name is Mark Xie");
			Console.WriteLine("I like Git.");
		}
	}
	class Factorial {
		public int Factor(int factor) {
			if ((factor != 1) && (factor > 0)) {
				return (factor * Factor(factor - 1));
			}
			else {
				return 1;
			}
			
		}
	}
}
