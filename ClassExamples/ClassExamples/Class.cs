using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExamples {
	class Class {
		static private int NextID = 1;
		public int Id { get; private set; }
		public string Subject { get; set; }
		public int? TeacherID { get; set; }
		public int Section { get; set; }
		public static void PastID() {
			NextID--;
		}
		public void Print() {
			Console.WriteLine($"Class ID: {this.Id}, Subject: {this.Subject}, Section: {this.Section}, InstructorId: {this.TeacherID}" );
		}
		public Class(string Subject, int Section, int? TeacherID) {
			this.Id = NextID++;
			this.Subject = Subject;
			this.Section = Section;
			this.TeacherID = TeacherID;
		}
		public Class() {}

	}
}
