using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityFWLib.Models;

namespace EntityFWLib {
	public class RequestsController {
		private readonly PRSContext _context;
		public RequestsController(PRSContext context) {
			_context = context;
		}
		/// <summary>
		/// Sets the status of the request to APPROVED
		/// </summary>
		/// <param name="request">A single request</param>
		/// <returns>True if successful; else false</returns>
		public bool SetToApprove(Request request) {
			request.Status = "Approved";
			_context.SaveChanges();
			return true;
		}


		public List<Request> GetRequestsinReview() {
			return _context.Request.Where(r => r.Status == "Review").ToList();
		}

		public bool SetToReview(Request request) {
			request.Status = (request.Total > 50) ? "Review" : "Approve";
			_context.SaveChanges();
			return true;
		}

		public bool JoinTotals() {
			
		}


	}
}
