using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastAddToPostLiveResponse
{
	[JsonProperty("pk")]
	public string Pk { get; set; }

	[JsonProperty("user")]
	public InstaUserShortFriendshipFullResponse User { get; set; }

	[JsonProperty("broadcasts")]
	public List<InstaBroadcastResponse> Broadcasts { get; set; } = new List<InstaBroadcastResponse>();


	[JsonProperty("last_seen_broadcast_ts")]
	public double? LastSeenBroadcastTs { get; set; }

	[JsonProperty("can_reply")]
	public bool CanReply { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("dash_manifest")]
	public string DashManifest { get; set; }
}
