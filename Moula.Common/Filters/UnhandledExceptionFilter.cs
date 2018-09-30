using System.Net;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Moula.Common.Extensions;

namespace Moula.Common.Filters
{
	public class UnhandledExceptionFilter : IExceptionFilter
	{
		private readonly IHostingEnvironment _hostingEnvironment;
		private readonly ILogger _logger;

		public UnhandledExceptionFilter(IHostingEnvironment hostingEnvironment, ILogger logger)
		{
			_hostingEnvironment = hostingEnvironment;
			_logger = logger;
		}

		public void OnException(ExceptionContext context)
		{
			var errorMessage = $"Unhandled Exception. Action: {context.ActionDescriptor.DisplayName} Url: {context.HttpContext.Request.GetAbsoluteUri()}, Method: {context.HttpContext.Request.Method}";

			_logger.LogError(context.Exception, errorMessage);

			if (_hostingEnvironment.IsDevelopment())
			{
				context.ExceptionHandled = true;
				context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
				context.Result = new ObjectResult(new
				{
					Exception = context.Exception.ToString(),
					Action = context.ActionDescriptor.DisplayName,
					Url = context.HttpContext.Request.GetAbsoluteUri(),
					Method = context.HttpContext.Request.Method
				});
			}
		}
	}
}