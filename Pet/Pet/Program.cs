using System;

namespace Pet {
	class Program {
		static void Main(string[] args) {
			var dogs = new IDog[]
			{
				new Chihuahua(),
				new Boxer(),
				new Collie()
			};

			foreach(var dog in dogs) {
				dog.Bark();
			}

		}
	}
}
