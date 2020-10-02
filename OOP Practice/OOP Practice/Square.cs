using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice {
	class Square : Rectangle {

		public Square() { }
		public Square(uint side1) : base(side1, side1) {

		}
		public override string WhatAmI() {
			return "Square";
		}
	}
}
