using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaDiscoverTopLiveConverter : IObjectConverter<InstaDiscoverTopLive, InstaDiscoverTopLiveResponse>
{
	public InstaDiscoverTopLiveResponse SourceObject { get; set; }

	public InstaDiscoverTopLive Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaDiscoverTopLive instaDiscoverTopLive = new InstaDiscoverTopLive
		{
			AutoLoadMoreEnabled = SourceObject.AutoLoadMoreEnabled,
			MoreAvailable = SourceObject.MoreAvailable,
			NextMaxId = SourceObject.NextMaxId
		};
		List<InstaBroadcastResponse> broadcasts = SourceObject.Broadcasts;
		if (broadcasts != null && broadcasts.Count > 0)
		{
			instaDiscoverTopLive.Broadcasts = ConvertersFabric.Instance.GetBroadcastListConverter(SourceObject.Broadcasts).Convert();
		}
		List<InstaBroadcastPostLiveResponse> postLiveBroadcasts = SourceObject.PostLiveBroadcasts;
		if (postLiveBroadcasts != null && postLiveBroadcasts.Count > 0)
		{
			foreach (InstaBroadcastPostLiveResponse postLiveBroadcast in SourceObject.PostLiveBroadcasts)
			{
				instaDiscoverTopLive.PostLiveBroadcasts.Add(ConvertersFabric.Instance.GetBroadcastPostLiveConverter(postLiveBroadcast).Convert());
			}
			return instaDiscoverTopLive;
		}
		return instaDiscoverTopLive;
	}
}
