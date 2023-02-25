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
	//public void OnGet()
	//{
	//	throw new System.Exception
	//		(message: "Some Error Occured!");
	//}

	public async System.Threading.Tasks.Task OnGetAsync()
	{
		if(System.DateTime.Now.Second < 60)
		{
			throw new System.Exception
				(message: "Some Error Occured!");
		}

		await System.Threading.Tasks.Task.CompletedTask;
    }
}
