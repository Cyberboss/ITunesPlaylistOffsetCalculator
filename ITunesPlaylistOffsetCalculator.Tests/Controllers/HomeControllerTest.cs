using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITunesPlaylistOffsetCalculator;
using ITunesPlaylistOffsetCalculator.Controllers;

namespace ITunesPlaylistOffsetCalculator.Tests.Controllers
{
	[TestClass]
	public class HomeControllerTest
	{
		[TestMethod]
		public void Index()
		{
			// Arrange
			HomeController controller = new HomeController();

			// Act
			ViewResult result = controller.Index() as ViewResult;

			// Assert
			Assert.IsNotNull(result);
			Assert.AreEqual("You are surrounded by music and mystery...", result.ViewBag.Title);
		}
	}
}
