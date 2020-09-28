using System;

namespace ClassExamples {
	class Program {
		static void Main(string[] args) {
			//This declaration is similar to a declaration of a variable without giving it a value.
			//ie int i, string s, etc.
			/*var student1 = new Student();
			student1.Name = "Manami";
			student1.FavColor = "Green";
			student1.FavNumber = 1;
			student1.Print();

			var student2 = new Student();
			student2.Name = "Christian";
			student2.FavColor = "Purple";
			student2.FavNumber = 3;

			student2.Print();*/

			var business = new Major();
			business.Id = 1;
			business.Description = "General Business";
			business.SetMINSAT(800);

			//business.SetMINSAT(500);
			//Console.WriteLine(business.MinSAT);
			
			var accounting = new Major();
			accounting.Id = 2;
			accounting.Description = "Accounting";
			accounting.SetMINSAT(1000);

			var finance = new Major(3, "Finanace", 1700);

			Console.WriteLine($"Finance MinSAT is {finance.MinSAT}");
			var student1 = new Student();
			student1.Id = 1;
			student1.FirstName = "Noah";
			student1.LastName = "Phence";
			student1.SAT = 1200;
			student1.GPA = 2.7;
			student1.MajorId = business.Id;
			student1.Major = business;
			Console.WriteLine(student1.FullName());

			Console.WriteLine($"Name is {student1.FullName()} majors in {student1.Major.Description}"); 

		}
	}
}
