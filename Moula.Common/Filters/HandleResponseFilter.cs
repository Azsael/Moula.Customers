using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Moula.Common.Foundation.Responses;
using Moula.Common.Foundation.Responses.Types;

namespace Moula.Common.Filters
{
	public class HandleResponseFilter : IResultFilter
	{
		public void OnResultExecuting(ResultExecutingContext context)
		{
			var objectResult = context.Result as ObjectResult;

			if (objectResult == null)
				return;

			var response = objectResult.Value as IResponse;

			if (response == null)
				return;

			if (!response.IsSuccessful)
			{
				var errorResponse = new StandardResponse(response);

				context.HttpContext.Response.StatusCode = (int)response.Status.GetHttpStatusCode();
				context.Result = new ObjectResult(errorResponse);
				return;
			}
		}

		public void OnResultExecuted(ResultExecutedContext context)
		{
		}
	}
}
