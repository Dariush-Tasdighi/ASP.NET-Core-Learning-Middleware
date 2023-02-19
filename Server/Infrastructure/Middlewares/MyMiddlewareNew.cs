using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

/// <summary>
/// از آقای مهندس مهدی جهانی پور تشکر می‌کنیم
/// </summary>
public class MyMiddlewareNew :
	object, Microsoft.AspNetCore.Http.IMiddleware
{
	public MyMiddlewareNew() : base()
	{
	}

	public async
		System.Threading.Tasks.Task InvokeAsync
		(Microsoft.AspNetCore.Http.HttpContext context,
		Microsoft.AspNetCore.Http.RequestDelegate next)
	{
		// اول اجرا می‌شود

		await context.Response
			.WriteAsync(text: "<p>Hello World (1)!</p>");

		await next(context: context);

		// بعدی اجرا می‌شود Middleware بعد از اجرای شدن

		await context.Response
			.WriteAsync(text: "<p>Hello World (3)!</p>");
	}
}
