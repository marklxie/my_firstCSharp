using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;

namespace GenericCollection {
	class Program {
		static void Main(string[] args){


			var stud1 = new Student() {
				Id = 1,
				Name = "Fred",
				GPA = 2.75,
				SAT = 1200
			};

			var stud2 = new Student() {
				Id = 2,
				Name = "Alice",
				GPA = 3.25,
				SAT = 1350
			};
			var stud3 = new Student() {
				Id = 3,
				Name = "Bob",
				GPA = 2.25,
				SAT = 1000
			};

			var students = new List<Student>() { stud1, stud2, stud3 };
			foreach(var student in students) {
				student.GPA += .1;
				if(student.SAT >= 1100) {
					student.Honors = true;
					Console.WriteLine($"{student.Name} is an honors student");
				}
				Console.WriteLine($"{student.Name} GPA is {student.GPA }");
				
			}
			var studentsDictionary = new Dictionary<int, Student>();

			studentsDictionary.Add(stud1.Id,stud1);
			studentsDictionary.Add(students[1].Id, students[1]);
			studentsDictionary.Add(students[2].Id, students[2]);

			var s2 = studentsDictionary[2];

			Console.WriteLine($"S2 is {s2.Name}");
			

			List<int> numbers = new List<int>{
				286, 545, 268, 219, 324,
				711, 471, 344, 990, 732,
				542, 758, 372, 447, 497 };
			int total = 0;
			int count = 0;
			foreach(var number in numbers) {
				total += number;
				count++;
			}
			var avg = total / count;

			Dictionary<int, string> id = new Dictionary<int, string>() ;
			id.Add(1, "Fast");
			Console.WriteLine(id[1]);
			Console.WriteLine($"The total is {total}. The avg is {avg}");
		}
	}
}
