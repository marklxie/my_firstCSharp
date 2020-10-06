using System;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;

namespace Generics_Intro {
	class Program {
		static void Main(string[] args) {
			//GenericG<int> gOfInt = new GenericG<int>();
			//gOfInt.value = 5;
			//gOfInt.Print();
			//GenericG<string> gOfString = new GenericG<string>();
			//gOfString.value = "1";
			//gOfString.Print();
			//Dictionary<string, string> duck = new Dictionary<string,string>();

			List<string> names = new List<string> {
				"Bo", "Keith", "Boo", "Jack"
			};
			names.Add("Elena");
			names.Add("Christian");
			names.Add("Tracy");
			names.Add("Yvonne");
			names.Add("Mark");
			names.Add("Manami");
			names.Add("Sarah");
			names.Add("Doug");
			names.Add("Fred");
			foreach(var name in names) {
				Console.WriteLine(name);
			}

			names.Sort();
			Console.WriteLine();
			names.Remove("Fred");
			foreach(var name in names) {
				Console.WriteLine(name);
			}

			var rnd = new Random();
			
			var nbr = rnd.Next(0,31);
			
			
			List<int> bowling = new List<int>();
			int totalScore = 0;
			while(totalScore < 283) {
				totalScore = 0;
				bowling.Clear();
				for(var i = 0; i < 10; i++) {
					bowling.Add(nbr);
					nbr = rnd.Next(0, 31);
				}
				foreach(var score in bowling) {
					totalScore += score;
				}
			}
			Console.WriteLine(totalScore);

			/*var diceRoll = rnd.Next(0, 7);
			totalScore = 0;
			var count = 0;
			while(totalScore < 400) {
				totalScore = 0;
				count = 0;
				diceRoll = rnd.Next(0, 7);
				while(diceRoll != 1) {
					count++;
					totalScore += diceRoll;
					diceRoll = rnd.Next(0, 7);
				}
				totalScore += diceRoll;
				count++;
			}
			Console.WriteLine(count);
			Console.WriteLine(totalScore);
			*/			
		
		}

			
	}
}
