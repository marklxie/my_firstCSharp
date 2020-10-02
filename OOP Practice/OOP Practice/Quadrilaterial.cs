using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice {
	class Quadrilaterial {
		public uint side1 { get; private set; }
		public uint side2 { get; private set; }
		public uint side3 { get; private set; }
		public uint side4 { get; private set; }
		public uint Perimeter() {
			return side1 + side2 + side3 + side4;
		}

		public virtual string WhatAmI() {
			return "Quadrillateral";
		}
		public Quadrilaterial(uint side1, uint side2, uint side3, uint side4) {
			this.side1 = side1;
			this.side2 = side2;
			this.side3 = side3;
			this.side4 = side4;
		}


		public Quadrilaterial() {  }



	}
}
