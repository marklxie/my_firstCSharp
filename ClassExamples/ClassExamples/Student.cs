using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples {
	class Student {
		/*public string Name { get; set; }
		public int FavNumber { get; set; }
		public string FavColor { get; set; }
		public void Print(){
			Console.WriteLine($"The student's name is {Name}, favorite number is {FavNumber} and color is {FavColor}.");*/

		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string FullName() {
			//var fullName = $"{this.FirstName} {this.LastName}";
			return FirstName + " " + LastName;
		}
		public int SAT { get; set; }
		public double GPA { get; set; }
		public int? MajorId { get; set; }
		public Major Major { get; set; }
		public Student(int Id, string FirstName, string LastName, int SAT, double GPA, int? MajorID) {
			this.Id = Id;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.SAT = SAT;
			this.GPA = GPA;
			this.MajorId = MajorID;
		}

		public Student() {
		}
	}
}
