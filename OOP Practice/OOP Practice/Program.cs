using System;

namespace OOP_Practice {
	class Program {
		static void Main(string[] args) {

			Quadrilaterial rect = new Rectangle();
			Console.WriteLine(rect.WhatAmI());

			var quad1 = new Quadrilaterial(3, 4, 6, 5);

			Console.WriteLine($"The Perimeter of the quad is {quad1.Perimeter()}");

			var rect1 = new Rectangle(5,3);
			Console.WriteLine($"The Perimeter of the quad is {rect1.Perimeter()}");
			Console.WriteLine($"The Area of the quad is {rect1.Area()}");

			var sqr1 = new Square(4);
			Console.WriteLine($"The Perimeter of the quad is {sqr1.Perimeter()}");
			Console.WriteLine($"The Area of the quad is {sqr1.Area()}");
			Console.WriteLine($"The sqr1 is {sqr1.WhatAmI()}");
			Console.WriteLine($"The rect1 is {rect1.WhatAmI()}");
			Console.WriteLine($"The quad1 is {quad1.WhatAmI()}");
			
			var collection = new Quadrilaterial[]{
				rect, sqr1, rect1, quad1
			};

			foreach(Quadrilaterial shape in collection) {
				Console.WriteLine($"The shape is {shape.WhatAmI()}.");
			}

			var square = rect1 as Square;
			
			if(square is null) {
				Console.WriteLine("The value is null");
			}

			var rectComp = new RectComp(3, 9);
			Console.WriteLine($"The perimeter of rect comp is {rectComp.Perimeter()}");
			Console.WriteLine($"The Area of rect comp is {rectComp.Area()}");

		}
	}
}
