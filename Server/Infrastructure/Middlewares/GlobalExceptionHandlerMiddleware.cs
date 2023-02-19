using Microsoft.Extensions.Logging;
using System.Reflection.Emit;

namespace Infrastructure.Middlewares;

public class GlobalExceptionHandlerMiddleware : object
{
	public GlobalExceptionHandlerMiddleware
		(Microsoft.AspNetCore.Http.RequestDelegate next,
		Microsoft.Extensions.Logging.ILogger<GlobalExceptionHandlerMiddleware> logger) : base()
	{
		Next = next;
		Logger = logger;
	}

	private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

	private Microsoft.Extensions.Logging.ILogger<GlobalExceptionHandlerMiddleware> Logger { get; }

	public async System.Threading.Tasks.Task
		InvokeAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
	{
		try
		{
			await Next(context: httpContext);
		}
		catch (System.Exception ex)
		{
			var requestPath =
				httpContext.Request.Path;

			var traceId =
				System.Diagnostics.Activity.Current?.Id ??
				httpContext.TraceIdentifier;

			var message =
				"Request Path: {requestPath)} - Trace Id: {traceId} - Error Message: {Message}";

			// دستور ذیل خیلی جزئیات ذخیره می‌کند
			//Logger.LogError
			//	(exception: ex, message: message, requestPath, traceId);

			Logger.LogError
				(message: message, requestPath, traceId, ex.Message);

			var location =
				$"/Errors/Error500/{traceId}";

			httpContext.Response.Redirect
				(location: location, permanent: false);

			// دستور ذیل غلط است و کار نمی‌کند
			//httpContext.Response.Redirect
			//	(location: "~/Errors/Error500", permanent: false);
		}
	}
}
