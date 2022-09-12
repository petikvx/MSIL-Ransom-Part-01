using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastAddToPostLiveConverter : IObjectConverter<InstaBroadcastAddToPostLive, InstaBroadcastAddToPostLiveResponse>
{
	public InstaBroadcastAddToPostLiveResponse SourceObject { get; set; }

	public InstaBroadcastAddToPostLive Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastAddToPostLive instaBroadcastAddToPostLive = new InstaBroadcastAddToPostLive
		{
			CanReply = SourceObject.CanReply,
			LastSeenBroadcastTs = SourceObject.LastSeenBroadcastTs.GetValueOrDefault(),
			Pk = SourceObject.Pk
		};
		if (SourceObject.User != null)
		{
			instaBroadcastAddToPostLive.User = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.User).Convert();
		}
		List<InstaBroadcastResponse> broadcasts = SourceObject.Broadcasts;
		if (broadcasts != null && broadcasts.Count > 0)
		{
			instaBroadcastAddToPostLive.Broadcasts = ConvertersFabric.Instance.GetBroadcastListConverter(SourceObject.Broadcasts).Convert();
		}
		return instaBroadcastAddToPostLive;
	}
}
