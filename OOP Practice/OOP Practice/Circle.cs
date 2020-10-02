using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace OOP_Practice {
	class Circle : IGeometricShape {

		private const double pi = 3.14;
		public double radius {get; private set;}
		public Circle() { }
		public Circle(double rad) {
			this.radius = rad;
		}
		public uint Area() {
			return Convert.ToUInt32(pi * this.radius * this.radius);
		}

		public uint Perimeter() {
			return Convert.ToUInt32(pi * 2 * this.radius);
		}
	}
}
