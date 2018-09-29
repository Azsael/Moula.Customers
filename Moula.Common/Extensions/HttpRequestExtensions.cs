using Microsoft.AspNetCore.Http;

namespace Moula.Common.Extensions
{
	public static class HttpRequestExtensions
	{
		public static string GetAbsoluteUri(this HttpRequest request)
		{
			return $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
		}
	}
}