using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaReelStoryMediaViewersConverter : IObjectConverter<InstaReelStoryMediaViewers, InstaReelStoryMediaViewersResponse>
{
	public InstaReelStoryMediaViewersResponse SourceObject { get; set; }

	public InstaReelStoryMediaViewers Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaReelStoryMediaViewers instaReelStoryMediaViewers = new InstaReelStoryMediaViewers
		{
			NextMaxId = SourceObject.NextMaxId,
			TotalScreenshotCount = (int)SourceObject.TotalScreenshotCount.GetValueOrDefault(),
			TotalViewerCount = (int)SourceObject.TotalViewerCount.GetValueOrDefault(),
			UserCount = (int)SourceObject.UserCount.GetValueOrDefault()
		};
		List<InstaUserShortResponse> users = SourceObject.Users;
		if (users != null && users.Count > 0)
		{
			foreach (InstaUserShortResponse user in SourceObject.Users)
			{
				instaReelStoryMediaViewers.Users.Add(ConvertersFabric.Instance.GetUserShortConverter(user).Convert());
			}
		}
		if (SourceObject.UpdatedMedia != null)
		{
			instaReelStoryMediaViewers.UpdatedMedia = ConvertersFabric.Instance.GetStoryItemConverter(SourceObject.UpdatedMedia).Convert();
		}
		return instaReelStoryMediaViewers;
	}
}
