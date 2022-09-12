using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryVoterItemResponse
{
	[JsonProperty("user")]
	public InstaUserShortFriendshipResponse User { get; set; }

	[JsonProperty("vote")]
	public double? Vote { get; set; }

	[JsonProperty("ts")]
	public long Ts { get; set; }
}
