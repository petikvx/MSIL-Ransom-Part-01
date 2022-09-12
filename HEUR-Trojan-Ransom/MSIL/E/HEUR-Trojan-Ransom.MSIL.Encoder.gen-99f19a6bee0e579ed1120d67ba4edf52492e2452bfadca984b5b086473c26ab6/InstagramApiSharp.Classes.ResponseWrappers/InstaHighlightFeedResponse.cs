using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaHighlightFeedResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("latest_reel_media")]
	public int LatestReelMedia { get; set; }

	[JsonProperty("seen")]
	public object Seen { get; set; }

	[JsonProperty("can_reply")]
	public bool CanReply { get; set; }

	[JsonProperty("can_reshare")]
	public object CanReshare { get; set; }

	[JsonProperty("reel_type")]
	public string ReelType { get; set; }

	[JsonProperty("cover_media")]
	public InstaHighlightCoverMediaResponse CoverMedia { get; set; }

	[JsonProperty("user")]
	public InstaUserShortResponse User { get; set; }

	[JsonProperty("ranked_position")]
	public int RankedPosition { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("seen_ranked_position")]
	public int SeenRankedPosition { get; set; }

	[JsonProperty("prefetch_count")]
	public int PrefetchCount { get; set; }

	[JsonProperty("media_count")]
	public int MediaCount { get; set; }
}
