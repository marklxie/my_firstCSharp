using System;
using OOP.Composition;

namespace OOP {
	class Program {
		static void Main(string[] args) {
			Inheritance.Service widget1 = new Inheritance.Service(4,"Duck", "Vandal",5.00, "Small", "Enterprise", 5, 20);
			widget1.print();
		}
	}
}
