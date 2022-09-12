using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastAddToPostLiveContainerResponse
{
	[JsonProperty("post_live_items")]
	public List<InstaBroadcastAddToPostLiveResponse> PostLiveItems { get; set; }
}
