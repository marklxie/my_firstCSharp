using System;
using System.Collections.Generic;
using System.Text;

namespace Pet {
	class Boxer:IDog {
		public string Name { get; set; } = "Boxer";
		public string Color { get; set; } = "Black";
		public string BarkSound { get; set; } = "Pawn";
		public void Bark() {
			Console.WriteLine($"Goes {BarkSound}");
		}

		public Boxer() { }
	}
}
