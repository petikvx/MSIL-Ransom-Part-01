using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFullUserInfoResponse
{
	[JsonProperty("user_detail")]
	public InstaUserInfoContainerResponse UserDetail { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }

	[JsonProperty("feed")]
	public InstaFullUserInfoUserFeedResponse Feed { get; set; }

	[JsonProperty("reel_feed")]
	public InstaFullUserInfoUserStoryReelResponse ReelFeed { get; set; }

	[JsonProperty("user_story")]
	public InstaFullUserInfoUserStoryResponse UserStory { get; set; }
}
