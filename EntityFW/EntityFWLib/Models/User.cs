using System;
using System.Collections.Generic;

namespace EntityFWLib.Models{
    public partial class User
    {
        public User()
        {
            Request = new HashSet<Request>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
