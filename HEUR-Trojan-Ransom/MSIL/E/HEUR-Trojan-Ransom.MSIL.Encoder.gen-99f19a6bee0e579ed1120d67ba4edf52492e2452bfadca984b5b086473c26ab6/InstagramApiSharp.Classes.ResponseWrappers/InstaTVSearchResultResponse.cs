using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaTVSearchResultResponse
{
	[JsonProperty("type")]
	public string Type { get; set; }

	[JsonProperty("user")]
	public InstaUserShortFriendshipResponse User { get; set; }

	[JsonProperty("channel")]
	public InstaTVChannelResponse Channel { get; set; }
}
