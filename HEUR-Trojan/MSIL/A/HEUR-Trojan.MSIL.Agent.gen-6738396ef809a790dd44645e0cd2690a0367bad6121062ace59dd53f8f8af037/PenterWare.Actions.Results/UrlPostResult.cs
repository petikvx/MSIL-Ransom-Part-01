using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class UrlPostResult : ActionResult
{
	public class UrlPosted
	{
		public string Url { get; set; }

		public bool Success { get; set; }

		public string Data { get; set; }
	}

	public List<UrlPosted> UrlsPosted { get; set; } = new List<UrlPosted>();

}
