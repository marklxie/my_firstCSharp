using System;
using System.Linq;
using EntityFWLib.Models;

namespace EntityFWLib {
	public class UsersController {
		private readonly PRSContext PRSContext;
		public UsersController(PRSContext context) { this.PRSContext = context; }

		/// <summary>
		/// Returns a user if the username and password are found
		/// in the userstable of the database
		/// </summary>
		/// <param name="username">The username as a string</param>
		/// <param name="password">the password as a string</param>
		/// <returns>
		/// A user instance if the username and password combination is found. Else returns null.
		/// </returns>
		public User Login(string username, string password) {
			var user = PRSContext.User.SingleOrDefault( u => u.UserName == username && u.Password == password);
			return user;
		}




	}
}
