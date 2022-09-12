using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaLastSeenItemResponse
{
	[JsonProperty("timestamp")]
	internal string TimestampPrivate { get; set; }

	[JsonProperty("item_id")]
	public string ItemId { get; set; }
}
