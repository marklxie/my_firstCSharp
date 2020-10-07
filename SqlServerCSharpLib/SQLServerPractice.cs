using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SqlServerCSharpLib {

	class SQLServerPractice {
		public SqlConnection Connection = null;
		public bool Connect(string server, string instance, string database) {
			string serverConnect = $"server={server}\\{instance};database={database};trusted_connection=true";
			Connection = new SqlConnection(serverConnect);
			Connection.Open();
			if(Connection.State != System.Data.ConnectionState.Open) {
				throw new Exception("The connection didn't work");
			}
			return true;
		}
		public void SqlCommand(string sqlQuerry) {
			var command = new SqlCommand(sqlQuerry, Connection);
			var reader = command.ExecuteReader();
			Student stud = new Student();
			while(reader.Read()) {
				stud.Id = Convert.ToInt32(reader["ID"]);
				stud.Firstname = Convert.ToString(reader["Firstname"]);
				stud.Lastname = Convert.ToString(reader["Lastname"]);
				stud.MajorId = reader.IsDBNull("MajorId") ?(int?) null : Convert.ToInt32(reader["MajorId"]); 

			}
		}
	}
}
