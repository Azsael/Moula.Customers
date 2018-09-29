using System;

namespace Moula.Customers.Entities.Models
{
	public class Customer
	{
		public long Id { get; set; }
		public string Code => $"{FullName}{DateOfBirth?.ToString("yyyyMMdd")}".ToLower().Replace(" ", "");

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName => $"{FirstName} {LastName}";
		public string Email { get; set; }
		public DateTime? DateOfBirth { get; set; }
	}
}