using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SqlServerCSharpLib {
	public class SQLServer {

		public SqlConnection SqlConnection = null;
		public List<Student> ExecuteQuery(string sql) {
			var cmd = new SqlCommand(sql, SqlConnection);
			var reader = cmd.ExecuteReader();
			List<Student> students = new List<Student>();
			while(reader.Read()) {
				var student = new Student();
				student.Id = Convert.ToInt32(reader["Id"]);
				student.Firstname = Convert.ToString(reader["Firstname"]);
				student.Lastname = Convert.ToString(reader["Lastname"]);
				student.SAT = reader.IsDBNull("SAT") ? (int?)null : Convert.ToInt32(reader["SAT"]);
				student.GPA = Convert.ToDecimal(reader["GPA"]);
				student.MajorId = reader.IsDBNull("MajorId") ? (int?)null : Convert.ToInt32(reader["MajorId"]);
				students.Add(student);
			}
			reader.Close();
			return students;
		}
		public bool Connect(string server, string instance, string database) {
			var connectionString = $"server={server}\\{instance};database={database};trusted_connection=true";
			SqlConnection = new SqlConnection(connectionString);
			SqlConnection.Open();
			if(SqlConnection.State != System.Data.ConnectionState.Open) {
				throw new Exception("Cannot connect to SQL");
			}
			return true;
		}
		public void Disconnect() {
			if(SqlConnection == null) {
				return;
			}
			SqlConnection.Close();
			SqlConnection = null;
		}


	}
}
