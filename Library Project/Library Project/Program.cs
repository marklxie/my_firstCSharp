using System;
using Education.DB;
using UtilityLibrary;

namespace Library_Project {
	class Program {
		static void Main(string[] args) {
			var stud1 = new Student() {
				Id =1, Name = "Fred", SAT = 1000, GPA = 2.5
			};

			var about = Utility.About();
			Console.WriteLine($"About is {about}");

		}

		

	}
}
