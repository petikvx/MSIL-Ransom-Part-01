using System.Collections.Generic;

namespace PenterWare.Actions.Results;

internal class DNSPostResult : ActionResult
{
	public class DNSPosted
	{
		public string Dns { get; set; }

		public bool Success { get; set; }
	}

	public List<DNSPosted> DNSsPosted { get; set; } = new List<DNSPosted>();

}
