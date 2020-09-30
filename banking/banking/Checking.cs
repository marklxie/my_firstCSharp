using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace banking {

	class Checking {
		private static int NextId = 1;
		public double Balance { get; private set; }
		public int Id { get; private set; }
		public string Description { get; set; }
	}
}
