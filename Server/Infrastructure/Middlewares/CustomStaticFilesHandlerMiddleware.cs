// **************************************************
//using Microsoft.AspNetCore.Http;

//namespace Infrastructure.Middlewares;

//public class CustomStaticFilesHandlerMiddleware : object
//{
//	public CustomStaticFilesHandlerMiddleware
//		(Microsoft.AspNetCore.Http.RequestDelegate next,
//		Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment) : base()
//	{
//		Next = next;
//		HostEnvironment = hostEnvironment;
//	}

//	private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

//	private Microsoft.Extensions.Hosting.IHostEnvironment HostEnvironment { get; }

//	public async System.Threading.Tasks.Task
//		InvokeAsync(Microsoft.AspNetCore.Http.HttpContext httpContext)
//	{
//		// استفاده می‌کنیم، دستورات ذیل، دوبار اجرا می‌شوند؟ Breakpoint چرا وقتی از
//		var requestPath =
//			httpContext.Request.Path.ToString();

//		if (string.IsNullOrWhiteSpace(value: requestPath) || requestPath == "/")
//		{
//			await Next(context: httpContext);

//			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
//			return;
//		}

//		if (requestPath.StartsWith(value: "/") == false)
//		{
//			await Next(context: httpContext);

//			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
//			return;
//		}

//		// **************************************************
//		// requestPath: /index.html -> requestPath: index.html
//		//requestPath =
//		//	requestPath.Substring(startIndex: 1);

//		requestPath =
//			requestPath[1..];
//		// **************************************************

//		// **************************************************
//		// آدرس فیزیکی ریشه سایت را بدست می‌آوریم
//		var rootPath =
//			HostEnvironment.ContentRootPath;

//		// In ASP.NET WebForm and ASP.NET MVC (Classic) ->
//		// Server.MapPath("~/SomeFile.css") -> Physical Address
//		// **************************************************

//		// **************************************************
//		var physicalPathName =
//			System.IO.Path.Combine
//			(path1: rootPath, path2: "wwwroot", path3: requestPath);

//		// برای بالا بردن امنیت
//		//var physicalPathName =
//		//	System.IO.Path.Combine(contentRootPath, "wwwroot\\content", path);
//		// **************************************************

//		if (System.IO.File.Exists(path: physicalPathName) == false)
//		{
//			await Next(httpContext);

//			// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
//			return;
//		}

//		// **************************************************
//		// Reference:
//		// https://stackoverflow.com/questions/4576483/how-to-get-the-content-type-of-a-file-at-runtime
//		// **************************************************

//		// **************************************************
//		// می‌باشد string? باید دقت داشته باشیم که خروجی تابع ذیل از جنس
//		var fileExtension = System.IO.Path
//			.GetExtension(path: physicalPathName)?.ToLower();

//		switch (fileExtension)
//		{
//			case ".htm":
//			case ".html":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/html";

//				break;
//			}

//			case ".css":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/css";

//				break;
//			}

//			case ".js":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "application/x-javascript";

//				break;
//			}

//			case ".jpg":
//			case ".jpeg":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "image/jpeg";

//				break;
//			}

//			case ".txt":
//			{
//				httpContext.Response.StatusCode = 200;
//				httpContext.Response.ContentType = "text/plain";

//				break;
//			}

//			default:
//			{
//				await Next(context: httpContext);

//				// در این حالت، نوشتن دستور ذیل بسیار اهمیت دارد
//				return;
//			}
//		}
//		// **************************************************

//		// نکته مهم: آدرس فایل باید فیزیکی باشد
//		await httpContext.Response
//			.SendFileAsync(fileName: physicalPathName);
//	}
//}
// **************************************************

// **************************************************
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Middlewares;

public class CustomStaticFilesHandlerMiddleware : object
{
	public CustomStaticFilesHandlerMiddleware
		(Microsoft.AspNetCore.Http.RequestDelegate next) : base()
	{
		Next = next;
	}

	private Microsoft.AspNetCore.Http.RequestDelegate Next { get; }

	/// <summary>
	/// The 'Invoke' or 'InvokeAsync' method's first argument must be of type 'HttpContext'.
	/// </summary>
	public async System.Threading.Tasks.Task InvokeAsync(
		Microsoft.AspNetCore.Http.HttpContext httpContext,
		Microsoft.Extensions.Hosting.IHostEnvironment hostEnvironment)
	{
		var requestPath =
			httpContext.Request.Path.Value;

		if (string.IsNullOrWhiteSpace(value: requestPath) || requestPath == "/")
		{
			await Next(context: httpContext);
			return;
		}

		if (requestPath.StartsWith(value: "/") == false)
		{
			await Next(context: httpContext);
			return;
		}

		requestPath =
			requestPath[1..];

		var rootPath =
			hostEnvironment.ContentRootPath;

		var physicalPathName =
			System.IO.Path.Combine
			(path1: rootPath, path2: "wwwroot", path3: requestPath);

		if (System.IO.File.Exists(path: physicalPathName) == false)
		{
			await Next(context: httpContext);
			return;
		}

		var fileExtension = System.IO.Path
			.GetExtension(path: physicalPathName)?.ToLower();

		if (fileExtension is null)
		{
			await Next(context: httpContext);
			return;
		}

		switch (fileExtension)
		{
			case ".htm":
			case ".html":
			{
				httpContext.Response.StatusCode = 200;
				httpContext.Response.ContentType = "text/html";
				break;
			}

			case ".css":
			{
				httpContext.Response.StatusCode = 200;
				httpContext.Response.ContentType = "text/css";
				break;
			}

			case ".js":
			{
				httpContext.Response.StatusCode = 200;
				httpContext.Response.ContentType = "application/x-javascript";
				break;
			}

			case ".jpg":
			case ".jpeg":
			{
				httpContext.Response.StatusCode = 200;
				httpContext.Response.ContentType = "image/jpeg";
				break;
			}

			case ".txt":
			{
				httpContext.Response.StatusCode = 200;
				httpContext.Response.ContentType = "text/plain";
				break;
			}

			default:
			{
				await Next(context: httpContext);
				return;
			}
		}

		await httpContext.Response
			.SendFileAsync(fileName: physicalPathName);
	}
}
// **************************************************
