using System.Collections.Generic;

namespace Moula.Common.Extensions
{
	public static class EnumerableExtensions
	{
		public static string JoinString(this IEnumerable<string> source, string separator)
		{
			return string.Join(separator, source);
		}
	}
}