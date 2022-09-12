using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaReelFeedConverter : IObjectConverter<InstaReelFeed, InstaReelFeedResponse>
{
	public InstaReelFeedResponse SourceObject { get; set; }

	public InstaReelFeed Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaReelFeed instaReelFeed = new InstaReelFeed
		{
			CanReply = SourceObject.CanReply,
			ExpiringAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject?.ExpiringAt ?? 0L),
			HasBestiesMedia = SourceObject.HasBestiesMedia,
			Id = SourceObject.Id,
			LatestReelMedia = SourceObject.LatestReelMedia.GetValueOrDefault(),
			PrefetchCount = SourceObject.PrefetchCount,
			Seen = SourceObject.Seen.GetValueOrDefault(),
			User = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.User).Convert()
		};
		try
		{
			if (!string.IsNullOrEmpty(SourceObject.CanReshare))
			{
				instaReelFeed.CanReshare = bool.Parse(SourceObject.CanReshare);
			}
		}
		catch
		{
		}
		if (SourceObject.Items != null && SourceObject.Items.Any())
		{
			foreach (InstaStoryItemResponse item in SourceObject.Items)
			{
				try
				{
					instaReelFeed.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaReelFeed;
		}
		return instaReelFeed;
	}
}
