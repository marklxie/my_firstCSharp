using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance {
	class Service:Widget {
		public int WidgetID { get; protected set; }
		public int ServiceYears { get; protected set; } = 1;
		public Service():base() { }
		public Service(int id, string description, string unit, double price, string size, string model, int widgetID, int serviceYears) : base(id, description, unit, price, size, model) {
			this.WidgetID = widgetID;
			this.ServiceYears = serviceYears;
		}
		public void print() {
			Console.WriteLine($"The product is {Description} in {Unit}. The price is {Price} for {Size} and {Model}. Serviceable for {ServiceYears}"  );
		}

	}
}

namespace OOP.Composition {
	class Service {
		private Widget Widget { get; set; }
		public int WidgetID { get; set; }
		public int ServiceYears {get; set;}
		Service() { Widget = new Widget(); }
		public Service(int id, string description, string unit, double price, string size, string model, int widgetID, int serviceYears) {
			Widget = new Widget(id, description, unit, size, model);
			this.WidgetID = widgetID;
			this.ServiceYears = serviceYears;
		}

	}
}
