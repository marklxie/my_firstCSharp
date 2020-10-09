﻿using System;
using System.Collections.Generic;

namespace EntityFWLib.Models
{
    public partial class LineItem
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Request Request { get; set; }
    }
}
