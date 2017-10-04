using iTunesLib;
using System.Web.Http;

namespace ITunesPlaylistOffsetCalculator.Controllers
{
	public class CalculatorResult
	{
		int PlaylistID;
		public CalculatorResult()
		{
			var res = new iTunesApp();
			PlaylistID = res.CurrentPlaylist.playlistID;
		}
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
