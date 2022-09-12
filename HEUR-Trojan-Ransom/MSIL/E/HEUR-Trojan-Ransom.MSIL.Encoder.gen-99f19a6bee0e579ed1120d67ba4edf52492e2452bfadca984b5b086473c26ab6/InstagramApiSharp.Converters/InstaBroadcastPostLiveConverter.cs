using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastPostLiveConverter : IObjectConverter<InstaBroadcastPostLive, InstaBroadcastPostLiveResponse>
{
	public InstaBroadcastPostLiveResponse SourceObject { get; set; }

	public InstaBroadcastPostLive Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastPostLive instaBroadcastPostLive = new InstaBroadcastPostLive
		{
			PeakViewerCount = SourceObject.PeakViewerCount,
			Pk = SourceObject.Pk
		};
		if (SourceObject.User != null)
		{
			instaBroadcastPostLive.User = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.User).Convert();
		}
		try
		{
			List<InstaBroadcastInfoResponse> broadcasts = SourceObject.Broadcasts;
			if (broadcasts != null && broadcasts.Count > 0)
			{
				foreach (InstaBroadcastInfoResponse broadcast in SourceObject.Broadcasts)
				{
					instaBroadcastPostLive.Broadcasts.Add(ConvertersFabric.Instance.GetBroadcastInfoConverter(broadcast).Convert());
				}
				return instaBroadcastPostLive;
			}
			return instaBroadcastPostLive;
		}
		catch
		{
			return instaBroadcastPostLive;
		}
	}
}
