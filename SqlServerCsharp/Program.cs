using System;
using SqlServerCSharpLib;

namespace SqlServerCsharp {
	class Program {
		static void Main(string[] args) {
			string word = "fast";
			string character = Convert.ToString(word[0]);
			var ss = new SQLServer();
			var ok = ss.Connect("localhost", "sqlexpress", "EdDb");
			var students = ss.ExecuteQuery("SELECT * From Student;");
			ss.Disconnect();
		}
	}
}
