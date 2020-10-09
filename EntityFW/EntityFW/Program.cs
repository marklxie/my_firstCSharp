using System;
using System.Linq;
using EntityFWLib;

namespace EntityFW {
	class Program {
		static void Main(string[] args) {
			var _context = new PRSContext();
			var users = _context.User.ToList();
			var user1 = _context.User.Find(1);
			user1.PhoneNumber = "513-555-1212";
			_context.SaveChanges();
			var control = new UsersController(_context);
			var user = control.Login("Steve", "SteveSteve");
			var user2 = control.Login("Stevebob", "SteveSteve");
			var ReqCtrl = new RequestsController(_context);
			var changeApprove = ReqCtrl.SetToApprove(_context.Request.Find(1));
			var VendorCtrl = new VendorController(_context);
			var vendorList = VendorCtrl.GetVendors();
		}
	}
}
