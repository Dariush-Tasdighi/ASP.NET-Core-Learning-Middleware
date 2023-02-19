using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

public class MyMiddlewareOld : object
{
	public MyMiddlewareOld
		(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
	{
		Next = next;

		//	_next = next;
	}

	private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

	//private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;

	public async System.Threading.Tasks.Task
		InvokeAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
	{
		// اول اجرا می‌شود

		await httpContext.Response
			.WriteAsync(text: "<p>Hello World (1)!</p>");

		await Next(context: httpContext);

		// بعدی اجرا می‌شود Middleware بعد از اجرای شدن

		await httpContext.Response
			.WriteAsync(text: "<p>Hello World (3)!</p>");
	}
}
