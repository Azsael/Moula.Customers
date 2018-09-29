using System;

namespace Moula.Customers.Core.List.Models
{
	public struct CustomerVM
	{
		public long CustomerId { get; set; }
		public string CustomerCode { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public DateTime? DateOfBirth { get; set; }
	}
}