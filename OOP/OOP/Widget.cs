using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance {
	class Widget:Product {
		public string Size { get; protected set; } = "Medium";
		public string Model { get; protected set; } = "Basic";
		 
		public Widget() : base() { }
		public Widget(int id, string description, string unit, double price, string size, string model) : base(id, description, unit, price) {
			this.Size = size;
			this.Model = model;
		}
		public Widget(int id, string description, string unit, string size, string model) : base(id, description, unit) {
			this.Size = size;
			this.Model = model;
			if(size == "small") {
				if(Model == "basic") {
					this.Price = 50;
				}
				else if(Model == "Advanced") {
					this.Price = 100;
				}
				else if(Model == "Enterprise") {
					this.Price = 150;
				}
			}
			if(size == "medium") {
				if(Model == "basic") {
					this.Price = 125;
				}
				else if(Model == "Advanced") {
					this.Price = 200;
				}
				else if(Model == "Enterprise") {
					this.Price = 275;
				}
			}
			if(size == "large") {
				if(Model == "basic") {
					this.Price = 250;
				}
				else if(Model == "Advanced") {
					this.Price = 400;
				}
				else if(Model == "Enterprise") {
					this.Price = 550;
				}
			}

		}
		
	}
}

namespace OOP.Composition {
	class Widget {
		private string Size { get; set; }
		private string Model { get; set; }
		private Product Product;
		public Widget() { Product = new Product(); }
		public Widget(int id, string description, string unit, int price, string size, string model) {
			Product = new Product(id, description, unit, price);
			this.Size = size;
			this.Model = model;
		}
		public Widget(int id, string description, string unit, string size, string model) {
			this.Size = size;
			this.Model = model;
			int price = 0;
			if(size == "small") {
				if(Model == "basic") {
					price = 50;
				}
				else if(Model == "Advanced") {
					price = 100;
				}
				else if(Model == "Enterprise") {
					price = 150;
				}
			}
			if(size == "medium") {
				if(Model == "basic") {
					price = 125;
				}
				else if(Model == "Advanced") {
					price = 200;
				}
				else if(Model == "Enterprise") {
					price = 275;
				}
			}
			if(size == "large") {
				if(Model == "basic") {
					price = 250;
				}
				else if(Model == "Advanced") {
					price = 400;
				}
				else if(Model == "Enterprise") {
					price = 550;
				}
			}
			this.Product = new Product(id, description, unit, price);
		}

	}
}
