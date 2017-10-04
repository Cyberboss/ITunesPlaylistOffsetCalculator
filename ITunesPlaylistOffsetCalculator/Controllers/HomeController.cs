using System.Web.Mvc;

namespace ITunesPlaylistOffsetCalculator.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "You are surrounded by music and mystery...";

			return View();
		}
	}
}
