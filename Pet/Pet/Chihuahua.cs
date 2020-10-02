using System;
using System.Collections.Generic;
using System.Text;

namespace Pet {
	class Chihuahua:IDog {
		public string Name { get; set; } = "Chihuahua";
		public string Color { get; set; } = "Yellow";
		public string BarkSound { get; set; } = "Arf";
		public void Bark() {
			Console.WriteLine($"Goes {BarkSound}");
		}
		public Chihuahua() { }
	}
}
