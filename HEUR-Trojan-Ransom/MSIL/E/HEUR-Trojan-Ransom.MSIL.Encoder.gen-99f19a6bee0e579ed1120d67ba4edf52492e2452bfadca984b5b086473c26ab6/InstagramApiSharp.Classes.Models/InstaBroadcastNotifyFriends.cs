using System.Collections.Generic;

namespace InstagramApiSharp.Classes.Models;

public class InstaBroadcastNotifyFriends
{
	public string Text { get; set; }

	public List<InstaUserShortFriendshipFull> Friends { get; set; } = new List<InstaUserShortFriendshipFull>();


	public int OnlineFriendsCount { get; set; }
}
