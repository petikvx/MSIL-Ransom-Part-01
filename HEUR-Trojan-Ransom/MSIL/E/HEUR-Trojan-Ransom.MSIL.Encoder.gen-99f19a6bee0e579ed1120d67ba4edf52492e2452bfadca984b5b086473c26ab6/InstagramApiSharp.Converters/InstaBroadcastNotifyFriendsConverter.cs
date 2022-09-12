using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastNotifyFriendsConverter : IObjectConverter<InstaBroadcastNotifyFriends, InstaBroadcastNotifyFriendsResponse>
{
	public InstaBroadcastNotifyFriendsResponse SourceObject { get; set; }

	public InstaBroadcastNotifyFriends Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastNotifyFriends instaBroadcastNotifyFriends = new InstaBroadcastNotifyFriends
		{
			OnlineFriendsCount = SourceObject.OnlineFriendsCount.GetValueOrDefault(),
			Text = SourceObject.Text
		};
		try
		{
			List<InstaUserShortFriendshipFullResponse> friends = SourceObject.Friends;
			if (friends != null && friends.Count > 0)
			{
				foreach (InstaUserShortFriendshipFullResponse friend in SourceObject.Friends)
				{
					instaBroadcastNotifyFriends.Friends.Add(ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(friend).Convert());
				}
				return instaBroadcastNotifyFriends;
			}
			return instaBroadcastNotifyFriends;
		}
		catch
		{
			return instaBroadcastNotifyFriends;
		}
	}
}
