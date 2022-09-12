using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaFriendshipFullStatusContainerResponse
{
	[JsonProperty("friendship_status")]
	public InstaFriendshipFullStatusResponse FriendshipStatus { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
