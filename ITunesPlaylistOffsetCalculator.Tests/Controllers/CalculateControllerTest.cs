using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITunesPlaylistOffsetCalculator.Controllers;

namespace ITunesPlaylistOffsetCalculator.Tests.Controllers
{
	[TestClass]
	public class CalculateControllerTest
	{
		[TestMethod]
		public void Get()
		{
			// Arrange
			CalculateController controller = new CalculateController();

			// Act
			var result = controller.Get();

			// Assert
			Assert.IsNotNull(result);
		}
	}
}
