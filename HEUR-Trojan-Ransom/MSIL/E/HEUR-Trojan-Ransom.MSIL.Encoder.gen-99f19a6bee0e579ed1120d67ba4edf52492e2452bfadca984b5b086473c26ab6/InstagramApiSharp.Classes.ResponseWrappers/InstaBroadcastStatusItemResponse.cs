using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastStatusItemResponse
{
	[JsonProperty("id")]
	public long Id { get; set; }

	[JsonProperty("broadcast_status")]
	public string BroadcastStatus { get; set; }

	[JsonProperty("viewer_count")]
	public float ViewerCount { get; set; }

	[JsonProperty("has_reduced_visibility")]
	public bool HasReducedVisibility { get; set; }

	[JsonProperty("cover_frame_url")]
	public string CoverFrameUrl { get; set; }
}
