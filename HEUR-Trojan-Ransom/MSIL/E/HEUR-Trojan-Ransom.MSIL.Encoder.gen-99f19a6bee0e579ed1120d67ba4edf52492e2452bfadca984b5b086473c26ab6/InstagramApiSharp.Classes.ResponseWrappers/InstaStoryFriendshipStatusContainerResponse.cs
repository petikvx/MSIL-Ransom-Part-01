using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaStoryFriendshipStatusContainerResponse
{
	[JsonProperty("friendship_status")]
	public InstaStoryFriendshipStatusResponse FriendshipStatus { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
