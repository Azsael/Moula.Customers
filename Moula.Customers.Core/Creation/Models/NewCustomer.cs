using System;

namespace Moula.Customers.Core.Creation.Models
{
	public struct NewCustomer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime? DateOfBirth { get; set; }
	}
}