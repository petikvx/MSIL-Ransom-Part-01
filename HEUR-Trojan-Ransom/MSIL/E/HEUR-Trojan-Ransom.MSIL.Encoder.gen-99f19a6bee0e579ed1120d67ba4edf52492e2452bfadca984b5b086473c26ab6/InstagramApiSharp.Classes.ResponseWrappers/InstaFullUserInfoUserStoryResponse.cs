using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFullUserInfoUserStoryResponse
{
	[JsonProperty("reel")]
	public InstaFullUserInfoUserStoryReelResponse Reel { get; set; }

	[JsonProperty("broadcast")]
	public InstaBroadcastSuggestedResponse Broadcast { get; set; }
}
