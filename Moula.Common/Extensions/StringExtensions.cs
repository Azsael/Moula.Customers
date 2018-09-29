using System;
using System.Collections.Generic;

namespace Moula.Common.Extensions
{
	public static class StringExtensions
	{
		public static bool IsNullOrEmpty(this string someString)
		{
			return string.IsNullOrEmpty(someString);
		}
		public static bool IsNullOrWhiteSpace(this string someString)
		{
			return string.IsNullOrWhiteSpace(someString);
		}
		public static bool IsNotNullOrEmpty(this string someString)
		{
			return !string.IsNullOrEmpty(someString);
		}
		public static bool IsNotNullOrWhiteSpace(this string someString)
		{
			return !string.IsNullOrWhiteSpace(someString);
		}
	}
}
