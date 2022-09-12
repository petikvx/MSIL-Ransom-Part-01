using System.Collections.Generic;
using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.ResponseWrappers;

public class InstaBroadcastNotifyFriendsResponse
{
	[JsonProperty("text")]
	public string Text { get; set; }

	[JsonProperty("friends")]
	public List<InstaUserShortFriendshipFullResponse> Friends { get; set; }

	[JsonProperty("online_friends_count")]
	public int? OnlineFriendsCount { get; set; }

	[JsonProperty("status")]
	public string Status { get; set; }
}
