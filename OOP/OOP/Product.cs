using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance{
	class Product {
		protected int ID { get; set; }
		public string Description { get; set; }
		public string Unit { get; protected set; }
		public double Price { get; protected set; }
		public Product() { }
		public Product(int id, string description, string unit, double price) {
			this.ID = id;
			this.Description = description;
			this.Unit = unit;
			this.Price = price;		
		}
		public Product(int id, string description, string unit) {
			this.ID = id;
			this.Description = description;
			this.Unit = unit;
		}

	}
}

namespace OOP.Composition {
	class Product {
		public int ID { get; set; }
		public string Description { get; set; }
		public string Unit { get; set; }
		public double Price { get; set; }
		public Product() { }
		public Product(int id, string description, string unit, double price) {
			this.ID = id;
			this.Description = description;
			this.Unit = unit;
			this.Price = price;
		}
		public Product(int id, string description, string unit) {
			this.ID = id;
			this.Description = description;
			this.Unit = unit;
		}

	}
}