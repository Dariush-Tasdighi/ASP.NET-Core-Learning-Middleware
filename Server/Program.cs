// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder =
	WebApplication.CreateBuilder(args: args);

var app =
	builder.Build();

// using Microsoft.AspNetCore.Builder;
app.MapGet("/", () => "Hello World!");

app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 1
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

////app.MapGet("/", () => "Hello World!");

////app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.MapGet(pattern: "/", handler: () =>
//{
//	var result = "Hello";

//	if (1 == 1)
//	{
//		result += " World!";
//	}

//	return result;
//});

//// using Microsoft.AspNetCore.Builder;
//app.MapPost(pattern: "/", handler: () => "Hello World (Post)!");

//// using Microsoft.AspNetCore.Builder;
//app.MapPut(pattern: "/", handler: () => "Hello World (Put)!");

//// using Microsoft.AspNetCore.Builder;
//app.MapDelete(pattern: "/", handler: () => "Hello World (Delete)!");

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Documents ************************************
// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write/
//
// https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api/
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 2
// **************************************************
// Build Custom Middleware - Inline Method
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// For Every Verb (GET, POST, PUT, DELETE,...) and Any URL ( /, /Alaki, /Dari/Vari,...)

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(handler: async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync(text: "Hello World!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 3
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (1)!");
//});

//// Note: Below code does not work!

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (2)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 4
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Use() -> using Microsoft.AspNetCore.Builder;
//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	//await next();

//	// It is better!
//	await next.Invoke();
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (2)!");
//});

//// Note: Below code does not work!

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (3)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 5
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	if (System.DateTime.Now.Second % 2 == 0)
//	{
//		await next.Invoke();
//	}
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (2)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 6
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "Hello World (1)!");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "Hello World (3)!");
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World (2)!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 7
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (1)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (7)!</p>");
//});

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (2)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (6)!</p>");
//});

//app.Use(middleware: async (context, next) =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (3)!</p>");

//	await next.Invoke();

//	await context.Response.WriteAsync(text: "<p>Hello World (5)!</p>");
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<p>Hello World (4)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 8
// **************************************************
// https://localhost:6001/
// https://localhost:6001/alaki
//
// https://localhost:6001/test1
// https://localhost:6001/test2
// https://localhost:6001/test3
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// Map supports every Verbs (GET, POST, PUT, DELETE,...)

//// Map() -> using Microsoft.AspNetCore.Builder;
//app.Map(pathMatch: "/test1", configuration: Greeting1);

//app.Map(pathMatch: "/test2", configuration: Greeting2);

//app.Map(pathMatch: "/test3", configuration: (app) =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Test (3)!</p>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//void Greeting1(IApplicationBuilder app)
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Test (1)!</p>");
//	});
//}

//// OR [static]

//static void Greeting2(IApplicationBuilder app)
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response.WriteAsync(text: "<p>Test (2)!</p>");
//	});
//}

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 9
// **************************************************
// https://localhost:6001/
// https://localhost:6001/about
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// دستور ذیل کار نمی‌کند
////app.Map(pathMatch: "/", configuration: app =>
////{
////	app.Run(handler: async context =>
////	{
////		await context.Response
////			.WriteAsync(text: "<h1>Home</h1>");
////	});
////});

//// کار نمی‌کند app.Run() دستور ذیل نیز با حضور دستور
////app.MapGet(pattern: "/", handler: () =>
////{
////	var result = "Hello";

////	if (1 == 1)
////	{
////		result += " World!";
////	}

////	return result;
////});

//// دستور ذیل هم درست کار نمی‌کند، با نوشتن
//// دستور ذیل هر آدرسی که بزنیم، صفحه خانه را نشان می‌دهد
////app.Map(pathMatch: "", configuration: app =>
////{
////	app.Run(handler: async context =>
////	{
////		await context.Response
////			.WriteAsync(text: "<h1>Home</h1>");
////	});
////});

//app.Map(pathMatch: "/about", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<h1>I'm Dariush Tasdighi</h1>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 10
// **************************************************
// https://localhost:6001/
// https://localhost:6001/alaki
//
// https://localhost:6001/home/help
// https://localhost:6001/home/about
// https://localhost:6001/home/alaki
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Map(pathMatch: "/home", configuration: app =>
//{
//	app.Map(pathMatch: "/help", configuration: app =>
//	{
//		app.Run(handler: async context =>
//		{
//			await context.Response
//				.WriteAsync(text: "<p>What do you need?</p>");
//		});
//	});

//	app.Map(pathMatch: "/about", configuration: app =>
//	{
//		app.Run(handler: async context =>
//		{
//			await context.Response
//				.WriteAsync(text: "<p>I'm Dariush Tasdighi</p>");
//		});
//	});

//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - You can just use 'help' or 'about'!</h1>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 11
// **************************************************
// https://localhost:6001/
// https://localhost:6001/alaki
//
// https://localhost:6001/home/help
// https://localhost:6001/home/about
// https://localhost:6001/home/alaki
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Map(pathMatch: "/home/help", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//app.Map(pathMatch: "/home/about", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 12
// **************************************************
// https://localhost:6001/
// https://localhost:6001/?age=20
// https://localhost:6001/hitesthi
// https://localhost:6001/hitesthi?age=20
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
//app.MapWhen(predicate: context => context.Request.Query.ContainsKey(key: "age"), app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (1)!</p>");
//	});
//});

//// MapWhen() -> using Microsoft.AspNetCore.Builder;
//app.MapWhen(predicate: context =>
//{
//	if (context.Request.Path != null &&
//		context.Request.Path.Value != null &&
//		context.Request.Path.Value.Contains(value: "test"))
//	{
//		return true;
//	}
//	else
//	{
//		return false;
//	}
//},
//app =>
//{
//	app.Run(handler: async context =>
//	{
//		await context.Response
//			.WriteAsync(text: "<p>Hello World (2)!</p>");
//	});
//});

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 13
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
// https://localhost:6001/index.html
//
// Note: We can not see the index.html page!
// **************************************************
//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 14
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
//
// https://localhost:6001/index.html
//
// Note: Now, We can see the index.html page!
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 15
// **************************************************
// 1. Create [wwwroot] folder.
// 2. Create [Index.html] file in it.
// 3. Test below url in browser:
//
// https://localhost:6001/
// https://localhost:6001/index.html
// https://localhost:6001/images/Dariush.jpg
// https://localhost:6001/alaki.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.UseStaticFiles();

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************



// **************************************************
// Learn 16
// **************************************************
// استفاده نمی‌کردیم UseStaticFiles اگر از
//
// https://localhost:6001/
// https://localhost:6001/index.html
// https://localhost:6001/images/Dariush.jpg
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//var contentRootPath =
//	app.Environment.ContentRootPath;

//app.Map(pathMatch: "/index.html", configuration: app => {
//	app.Run(async context =>
//	{
//		//var physicalPathName =
//		//	$"C:\\inetpub\\Users\\IranianExperets\\wwwroot\\index.html";

//		//var physicalPathName =
//		//	$"{contentRootPath}wwwroot\\index.html";

//		var physicalPathName =
//			System.IO.Path.Combine
//			(contentRootPath, "wwwroot", "index.html");

//		if (System.IO.File.Exists(path: physicalPathName))
//		{
//			// برنامه را یک بار بدون دو دستور ذیل اجرا می‌کنیم
//			context.Response.StatusCode = 200;

//			context.Response.ContentType =
//				"text/html"; // Mime Type = Content Type = ذات یا ماهیت فایل

//			//context.Response.ContentType =
//			//	"alaki/dolaki"; // Mime Type = Content Type = ذات یا ماهیت فایل

//			// using Microsoft.AspNetCore.Http;
//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);

//			return;
//		}

//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - 'Index.html' Not Found!</h1>");
//	});
//});

//app.Map(pathMatch: "/images/Dariush.jpg", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		var physicalPathName =
//			System.IO.Path.Combine
//			(contentRootPath, "wwwroot", "images", "Dariush.jpg");

//		if (System.IO.File.Exists(path: physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "image/jpeg";

//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);

//			return;
//		}

//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - 'Dariush.jpg' Not Found!</h1>");
//	});
//});

//app.Run(async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 17
// **************************************************
// استفاده نمی‌کردیم UseStaticFiles اگر از
//
// https://localhost:6001/
// https://localhost:6001/index.html
// https://localhost:6001/images/Dariush.jpg
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//var contentRootPath =
//	app.Environment.ContentRootPath;

//// بنابر دلایل قبل، متاسفانه دستور ذیل کار نمی‌کند
////app.Map(pathMatch: "/", configuration: app => DisplayHomePage(app: app));

//app.Map(pathMatch: "/index.htm", configuration: app => DisplayHomePage(app: app));
//app.Map(pathMatch: "/index.html", configuration: app => DisplayHomePage(app: app));
//app.Map(pathMatch: "/default.htm", configuration: app => DisplayHomePage(app: app));
//app.Map(pathMatch: "/default.html", configuration: app => DisplayHomePage(app: app));

//void DisplayHomePage
//	(Microsoft.AspNetCore.Builder.IApplicationBuilder app)
//{
//	app.Run(async context =>
//	{
//		var physicalPathName =
//			System.IO.Path.Combine
//			(contentRootPath, "wwwroot", "index.html");

//		if (System.IO.File.Exists(path: physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "text/html";

//			//// using Microsoft.AspNetCore.Http;
//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);

//			return;
//		}

//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - The Home Page Not Found!</h1>");
//	});
//}

//app.Map(pathMatch: "/images/Dariush.jpg", configuration: app =>
//{
//	app.Run(handler: async context =>
//	{
//		var physicalPathName =
//			System.IO.Path.Combine
//			(contentRootPath, "wwwroot", "images", "Dariush.jpg");

//		if (System.IO.File.Exists(path: physicalPathName))
//		{
//			context.Response.StatusCode = 200;
//			context.Response.ContentType = "image/jpeg";

//			await context.Response
//				.SendFileAsync(fileName: physicalPathName);

//			return;
//		}

//		await context.Response
//			.WriteAsync(text: "<h1>Error 404 - 'Dariush.jpg' Not Found!</h1>");
//	});
//});

//app.Run(async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 18
// **************************************************
// ها بسیار اهمیت دارد Middleware تاکید مضاعف که ترتیب نوشتن
//
// https://localhost:6001/index.html
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "Hello World!");
//});

//// using Microsoft.AspNetCore.Builder;
//app.UseStaticFiles();

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 19
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// using Microsoft.AspNetCore.Builder;
//app.UseMiddleware
//	<Infrastructure.Middlewares.MyMiddlewareOld>();

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 20
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

////using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddScoped
//	<Infrastructure.Middlewares.MyMiddlewareNew>();

//var app =
//	builder.Build();

//// using Microsoft.AspNetCore.Builder;
//app.UseMiddleware
//	<Infrastructure.Middlewares.MyMiddlewareNew>();

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<p>Hello World (2)!</p>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 21
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//app.UseMiddleware<Infrastructure
//	.Middlewares.CustomStaticFilesHandlerMiddleware>();

//app.Run(handler: async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 22
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// using Infrastructure.Middlewares;
//app.UseCustomStaticFiles();

//app.Run(async context =>
//{
//	await context.Response
//		.WriteAsync(text: "<h1>Error 404 - Content Not Found!</h1>");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************



// **************************************************
// Learn 23
// **************************************************
//using Infrastructure.Middlewares;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//// using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// using Infrastructure.Middlewares;
//app.UseGlobalException();

//// using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************
