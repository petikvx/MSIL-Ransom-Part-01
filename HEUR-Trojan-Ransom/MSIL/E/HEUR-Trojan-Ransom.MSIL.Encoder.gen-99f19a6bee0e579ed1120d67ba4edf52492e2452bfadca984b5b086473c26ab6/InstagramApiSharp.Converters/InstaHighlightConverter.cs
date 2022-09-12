using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaHighlightConverter : IObjectConverter<InstaHighlightFeeds, InstaHighlightFeedsResponse>
{
	public InstaHighlightFeedsResponse SourceObject { get; set; }

	public InstaHighlightFeeds Convert()
	{
		InstaHighlightFeeds instaHighlightFeeds = new InstaHighlightFeeds
		{
			ShowEmptyState = SourceObject.ShowEmptyState.GetValueOrDefault(),
			Status = SourceObject.Status
		};
		List<InstaHighlightFeedResponse> items = SourceObject.Items;
		if (items != null && items.Count > 0)
		{
			foreach (InstaHighlightFeedResponse item in SourceObject.Items)
			{
				InstaHighlightFeed instaHighlightFeed = new InstaHighlightFeed
				{
					CanReply = item.CanReply,
					CanReshare = item.CanReshare,
					HighlightId = item.Id,
					LatestReelMedia = item.LatestReelMedia,
					MediaCount = item.MediaCount,
					PrefetchCount = item.PrefetchCount,
					RankedPosition = item.RankedPosition,
					ReelType = item.ReelType,
					Seen = item.Seen,
					SeenRankedPosition = item.SeenRankedPosition,
					Title = item.Title
				};
				instaHighlightFeed.CoverMedia = new InstaHighlightCoverMedia
				{
					CropRect = item.CoverMedia.CropRect,
					MediaId = item.CoverMedia.MediaId
				};
				if (item.CoverMedia.CroppedImageVersion != null)
				{
					instaHighlightFeed.CoverMedia.CroppedImage = new InstaImage(item.CoverMedia.CroppedImageVersion.Url, int.Parse(item.CoverMedia.CroppedImageVersion.Width), int.Parse(item.CoverMedia.CroppedImageVersion.Height));
				}
				if (item.CoverMedia.FullImageVersion != null)
				{
					instaHighlightFeed.CoverMedia.Image = new InstaImage(item.CoverMedia.FullImageVersion.Url, int.Parse(item.CoverMedia.FullImageVersion.Width), int.Parse(item.CoverMedia.FullImageVersion.Height));
				}
				IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(item.User);
				instaHighlightFeed.User = userShortConverter.Convert();
				instaHighlightFeeds.Items.Add(instaHighlightFeed);
			}
			return instaHighlightFeeds;
		}
		return instaHighlightFeeds;
	}
}
