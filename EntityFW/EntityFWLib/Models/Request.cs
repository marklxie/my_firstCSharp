﻿using System;
using System.Collections.Generic;

namespace EntityFWLib.Models {
    public partial class Request
    {
        public Request()
        {
            LineItem = new HashSet<LineItem>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public string Justification { get; set; }
        public DateTime DateNeeded { get; set; }
        public string DeliveryMode { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
        public DateTime SubmittedDate { get; set; }
        public string ReasonForRejection { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<LineItem> LineItem { get; set; }
    }
}
