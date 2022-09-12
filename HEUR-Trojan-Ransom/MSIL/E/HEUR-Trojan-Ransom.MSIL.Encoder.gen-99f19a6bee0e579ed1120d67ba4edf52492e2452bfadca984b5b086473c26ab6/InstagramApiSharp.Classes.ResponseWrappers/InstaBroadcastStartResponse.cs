using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

internal class InstaBroadcastStartResponse
{
	[JsonProperty("media_id")]
	public string MediaId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
