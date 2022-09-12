using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastStatusItemConverter : IObjectConverter<InstaBroadcastStatusItem, InstaBroadcastStatusItemResponse>
{
	public InstaBroadcastStatusItemResponse SourceObject { get; set; }

	public InstaBroadcastStatusItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastStatusItem
		{
			BroadcastStatus = SourceObject.BroadcastStatus,
			CoverFrameUrl = SourceObject.CoverFrameUrl,
			HasReducedVisibility = SourceObject.HasReducedVisibility,
			Id = SourceObject.Id,
			ViewerCount = SourceObject.ViewerCount
		};
	}
}
