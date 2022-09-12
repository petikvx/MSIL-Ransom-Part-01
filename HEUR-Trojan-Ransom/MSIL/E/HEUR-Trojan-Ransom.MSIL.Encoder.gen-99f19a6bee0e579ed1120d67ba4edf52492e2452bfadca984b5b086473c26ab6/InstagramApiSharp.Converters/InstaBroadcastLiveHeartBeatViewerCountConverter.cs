using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastLiveHeartBeatViewerCountConverter : IObjectConverter<InstaBroadcastLiveHeartBeatViewerCount, InstaBroadcastLiveHeartBeatViewerCountResponse>
{
	public InstaBroadcastLiveHeartBeatViewerCountResponse SourceObject { get; set; }

	public InstaBroadcastLiveHeartBeatViewerCount Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastLiveHeartBeatViewerCount
		{
			BroadcastStatus = SourceObject.BroadcastStatus,
			CobroadcasterIds = SourceObject.CobroadcasterIds,
			IsTopLiveEligible = SourceObject.IsTopLiveEligible,
			OffsetToVideoStart = SourceObject.OffsetToVideoStart,
			TotalUniqueViewerCount = SourceObject.TotalUniqueViewerCount,
			ViewerCount = SourceObject.ViewerCount
		};
	}
}
