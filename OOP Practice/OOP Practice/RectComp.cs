using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice {

	
	class RectComp {
		private Quadrilaterial quadrilaterial { get; set; }
		public RectComp() { }
		public RectComp(uint side1, uint side2) {
			this.quadrilaterial = new Quadrilaterial(side1, side2, side1, side2);
		}

		public uint Perimeter() {
			return this.quadrilaterial.Perimeter();
		}

		public uint Area() {
			return quadrilaterial.side1 * quadrilaterial.side2;
		}



	}



}
