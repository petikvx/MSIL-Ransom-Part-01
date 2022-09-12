using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFullUserInfoUserStoryReelResponse
{
	[JsonProperty("user")]
	public InstaUserShortResponse User { get; set; }

	[JsonProperty("items")]
	public List<InstaStoryItemResponse> Items { get; set; } = new List<InstaStoryItemResponse>();


	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("latest_reel_media")]
	public int? LatestReelMedia { get; set; }

	[JsonProperty("expiring_at")]
	public long ExpiringAt { get; set; }

	[JsonProperty("seen")]
	public long? Seen { get; set; }

	[JsonProperty("can_reply")]
	public bool CanReply { get; set; }

	[JsonProperty("can_reshare")]
	public bool CanReshare { get; set; }

	[JsonProperty("reel_type")]
	public string ReelType { get; set; }

	[JsonProperty("prefetch_count")]
	public int PrefetchCount { get; set; }

	[JsonProperty("has_besties_media")]
	public bool HasBestiesMedia { get; set; }
}
