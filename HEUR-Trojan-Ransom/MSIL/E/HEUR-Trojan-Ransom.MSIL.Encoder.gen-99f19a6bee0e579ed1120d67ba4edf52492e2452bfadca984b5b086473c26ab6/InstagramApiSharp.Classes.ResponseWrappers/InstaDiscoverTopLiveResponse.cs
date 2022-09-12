using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaDiscoverTopLiveResponse
{
	[JsonProperty("broadcasts")]
	public List<InstaBroadcastResponse> Broadcasts { get; set; }

	[JsonProperty("post_live_broadcasts")]
	public List<InstaBroadcastPostLiveResponse> PostLiveBroadcasts { get; set; }

	[JsonProperty("more_available")]
	public bool MoreAvailable { get; set; }

	[JsonProperty("auto_load_more_enabled")]
	public bool AutoLoadMoreEnabled { get; set; }

	[JsonProperty("next_max_id")]
	public string NextMaxId { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
