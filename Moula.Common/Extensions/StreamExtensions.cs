using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Moula.Common.Extensions
{
	public static class StreamExtensions
	{
		public static async Task<string> ReadAsStringAsync(this Stream stream)
		{
			using (var reader = new StreamReader(stream, Encoding.UTF8, true, 1024, true))
			{
				return await reader.ReadToEndAsync();
			}
		}
	}
}