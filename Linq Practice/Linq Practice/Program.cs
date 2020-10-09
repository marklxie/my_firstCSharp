using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
namespace Linq_Practice {
	class Program {

		class State {
			public int Id { get; set; }
			public string Name { get; set; }
		}

		class City {
			public string Name { get; set; }
			public int StateId { get; set; }
		}
		static void Main(string[] args) {

			var states = new List<State> {
				new State { Id = 1, Name = "Ohio" },
				new State { Id = 2, Name = "Kentucky" },
				new State { Id = 3, Name = "Indiana" }
			};
			var cities = new List<City> {
				new City { Name = "Cincinnati", StateId = 1 },
				new City { Name = "Columbus", StateId = 1 },
				new City { Name = "Cleveland", StateId = 1 },
				new City { Name = "Newport", StateId = 2 },
				new City { Name = "Covington", StateId = 2},
				new City { Name = "Indianapolis", StateId = 3 },
			};

			var cityStateOh = from s in states
							  join c in cities
							  on s.Id equals c.StateId
							  select new { City = c.Name, State = s.Name };

			foreach(var cs in cityStateOh.ToList()) {
				Console.WriteLine($"City/State is {cs.City} {cs.State}");
			}



			var ints = new int[] { 1, 3, 5, 7, 9, 11, 13, 17 };
			var max = ints.Max();
			var min = ints.Min();
			var avg = ints.Average();
			var cnt = ints.Count();

			var sumgt7 = ints.Where(i => i > 7).Sum();
			sumgt7 = (from i in ints
					 where i > 7
					 select i).Sum();
			var avglt7 = ints.Where(i => i <= 11).Average();
			avglt7 = (from i in ints
					  where i <= 11
					  select i).Average();

			var nbrs = new List<int> {
				268,876,510,365,219,299,489,390,965,993,
				419,726,282,926,681,206,263,481,501,456,
				744,976,792,201,674,595,805,360,973,203,
				913,747,356,437,897,170,151,906,684,763,
				369,332,215,660,666,366,272,127,543,803,
				175,823,119,427,963,478,553,903,384,220,
				471,164,401,236,539,845,805,489,209,273,
				944,261,529,570,206,401,157,870,266,861,
				411,487,600,702,177,829,810,371,932,262,
				286,467,834,303,842,544,659,738,431,458
			};

			var nbrsAvg = nbrs.Where(i => i >= 500).Average();
			nbrsAvg = (from i in nbrs
					   where i >= 500
					   select i).Average();

			nbrsAvg = nbrs.Where(i => (i % 3 == 0) || (i % 7 == 0)).Sum();
			Console.WriteLine(nbrsAvg);

		}
	}
}
