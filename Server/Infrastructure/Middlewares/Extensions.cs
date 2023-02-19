using Microsoft.AspNetCore.Builder;

namespace Infrastructure.Middlewares;

/// <summary>
/// باشد static باید کلاس
/// </summary>
public static class Extensions : object
{
	static Extensions()
	{
	}

	/// <summary>
	/// باید static باید تابع
	/// </summary>
	public static Microsoft.AspNetCore.Builder.IApplicationBuilder
		UseCustomStaticFiles(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
	{
		return app.UseMiddleware
			<CustomStaticFilesHandlerMiddleware>();
	}

	public static Microsoft.AspNetCore.Builder.IApplicationBuilder
		UseGlobalException(this Microsoft.AspNetCore.Builder.IApplicationBuilder app)
	{
		return app.UseMiddleware
			<GlobalExceptionHandlerMiddleware>();
	}
}
