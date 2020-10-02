using System;
using System.Collections.Generic;
using System.Text;

namespace Pet {
	class Collie:IDog {
		public string Name { get; set; } = "Collie";
		public string Color { get; set; } = "Purple";
		public string BarkSound { get; set; } = "Blah";
		public void Bark() {
			Console.WriteLine($"Goes {BarkSound}");
		}

		public Collie() { }
	}
}
