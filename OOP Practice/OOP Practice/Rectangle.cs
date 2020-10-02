using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice {
	class Rectangle : Quadrilaterial, IGeometricShape {
		private bool IsRectangle() {
			if(side1 != side3 || side2 != side4) {
				return false;
			}
			else
				return true;
		}

		public override string WhatAmI() {
			return "Rectangle";
		}

		public uint Area() {
			return side1 * side2;
		}

		public Rectangle(uint side1, uint side2) : base(side1,side2,side1,side2){

		}
		public Rectangle() : this(2,2) { 
			
		}
		
	}
}
