using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTopicalExploreClusterResponse
{
	[JsonProperty("id")]
	public string Id { get; set; }

	[JsonProperty("title")]
	public string Title { get; set; }

	[JsonProperty("context")]
	public string Context { get; set; }

	[JsonProperty("description")]
	public string Description { get; set; }

	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("name")]
	public string Name { get; set; }

	[JsonProperty("can_mute")]
	public bool? CanMute { get; set; }

	[JsonProperty("is_muted")]
	public bool? IsMuted { get; set; }

	[JsonProperty("debug_info")]
	public string DebugInfo { get; set; }

	[JsonProperty("cover_media")]
	public InstaMediaItemResponse CoverMedia { get; set; }

	[JsonProperty("ranked_position")]
	public int? RankedPosition { get; set; }
}
