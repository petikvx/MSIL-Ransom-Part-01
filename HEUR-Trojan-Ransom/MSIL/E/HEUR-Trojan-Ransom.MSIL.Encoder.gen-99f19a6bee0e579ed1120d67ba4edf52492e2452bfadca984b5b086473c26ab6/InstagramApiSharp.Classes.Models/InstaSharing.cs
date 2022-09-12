using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaSharing
{
	[JsonProperty("action")]
	public string Action { get; set; }

	[JsonProperty("status_code")]
	public string StatusCode { get; set; }

	[JsonProperty("payload")]
	public InstaSharingPayload[] Payload { get; set; }

	[JsonProperty("status")]
	internal string Status { get; set; }
}
