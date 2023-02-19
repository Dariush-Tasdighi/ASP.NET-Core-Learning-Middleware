namespace Server.Pages;

public class IndexModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public IndexModel() : base()
	{
	}

	/// <summary>
	/// Handler
	/// </summary>
	public void OnGet()
	{
		throw new System.Exception
			(message: "Some Error Occured!");
	}
}
