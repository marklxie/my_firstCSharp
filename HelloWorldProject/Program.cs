using System;

namespace HelloWorldProject {
	class Program {
		public static void Main() {
			Console.WriteLine("Hello World!");

			int v = Factorial.Factor(5);
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
