namespace Server.Pages.Errors;

[Microsoft.AspNetCore.Mvc.IgnoreAntiforgeryToken]

[Microsoft.AspNetCore.Mvc.ResponseCache
	(Duration = 0, Location = Microsoft.AspNetCore.Mvc.ResponseCacheLocation.None, NoStore = true)]
public class Error500Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public Error500Model() : base()
	{
	}

	public string? TraceId { get; set; }

	public void OnGet(string? traceId = null)
	{
		TraceId = traceId;
	}
}
