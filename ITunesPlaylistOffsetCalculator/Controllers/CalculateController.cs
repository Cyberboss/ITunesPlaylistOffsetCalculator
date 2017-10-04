using System.Web.Http;

namespace ITunesPlaylistOffsetCalculator.Controllers
{
	public class CalculatorResult
	{

	}
	public class CalculateController : ApiController
	{
		// GET api/Calculate
		public CalculatorResult Get()
		{
			return new CalculatorResult();
		}
	}
}
