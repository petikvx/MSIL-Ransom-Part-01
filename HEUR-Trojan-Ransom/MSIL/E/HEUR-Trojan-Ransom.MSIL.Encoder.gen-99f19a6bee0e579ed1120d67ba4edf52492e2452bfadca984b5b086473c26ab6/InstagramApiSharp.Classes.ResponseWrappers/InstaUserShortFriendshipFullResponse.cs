using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaUserShortFriendshipFullResponse : InstaUserShortResponse
{
	[JsonProperty("friendship_status")]
	public InstaFriendshipFullStatusResponse FriendshipStatus { get; set; }
}
