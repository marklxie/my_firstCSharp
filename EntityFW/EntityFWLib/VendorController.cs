using System;
using EntityFWLib.Models;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntityFWLib {
	public class VendorController {
		private PRSContext Context = null;
		public VendorController(PRSContext _context) {
			Context = _context;	
		}

		public List<Vendor> GetVendors() {
			var vendorList = Context.Vendor.ToList();
			return vendorList;
		}
		public Vendor GetVendor(int id) {
			var vendor = Context.Vendor.Find(id);
			return vendor;
		}

	}
}
