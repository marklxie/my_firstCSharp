using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Generics_Intro {
	class GenericG<T> {

		public T value { get; set; }
		public void Print() {
			Console.WriteLine(value);
		}
	}
}
