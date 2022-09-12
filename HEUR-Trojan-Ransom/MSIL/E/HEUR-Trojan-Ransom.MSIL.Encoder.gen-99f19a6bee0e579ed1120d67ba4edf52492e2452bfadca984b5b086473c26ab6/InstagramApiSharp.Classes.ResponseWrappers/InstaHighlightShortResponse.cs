using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightShortResponse
{
	[JsonProperty("timestamp")]
	public long? Timestamp { get; set; }

	[JsonProperty("media_count")]
	public int MediaCount { get; set; }

	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("reel_type")]
	public string ReelType { get; set; }

	[JsonProperty("latest_reel_media")]
	public int LatestReelMedia { get; set; }
}
