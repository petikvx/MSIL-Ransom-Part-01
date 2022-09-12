using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastInfoConverter : IObjectConverter<InstaBroadcastInfo, InstaBroadcastInfoResponse>
{
	public InstaBroadcastInfoResponse SourceObject { get; set; }

	public InstaBroadcastInfo Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		long num = DateTime.Now.ToUnixTime();
		InstaBroadcastInfo instaBroadcastInfo = new InstaBroadcastInfo
		{
			BroadcastMessage = SourceObject.BroadcastMessage,
			BroadcastStatus = SourceObject.BroadcastStatus,
			CoverFrameUrl = SourceObject.CoverFrameUrl,
			DashManifest = SourceObject.DashManifest,
			EncodingTag = SourceObject.EncodingTag,
			Id = SourceObject.Id,
			InternalOnly = SourceObject.InternalOnly,
			MediaId = SourceObject.MediaId,
			NumberOfQualities = SourceObject.NumberOfQualities,
			OrganicTrackingToken = SourceObject.OrganicTrackingToken,
			TotalUniqueViewerCount = SourceObject.TotalUniqueViewerCount,
			ExpireAt = (SourceObject.ExpireAt ?? num).FromUnixTimeSeconds(),
			PublishedTime = (SourceObject.PublishedTime ?? num).FromUnixTimeSeconds()
		};
		if (SourceObject.BroadcastOwner != null)
		{
			instaBroadcastInfo.BroadcastOwner = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.BroadcastOwner).Convert();
		}
		return instaBroadcastInfo;
	}
}
