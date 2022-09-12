using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaVoiceUserResponse
{
	[JsonProperty("pk")]
	public long Pk { get; set; }

	[JsonProperty("friendship_status")]
	public InstaFriendshipStatusResponse FriendshipStatus { get; set; }
}
