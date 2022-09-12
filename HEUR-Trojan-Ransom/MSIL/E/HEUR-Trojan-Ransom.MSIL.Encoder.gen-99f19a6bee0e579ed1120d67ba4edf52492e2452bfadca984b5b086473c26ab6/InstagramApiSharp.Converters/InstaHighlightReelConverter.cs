using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaHighlightReelConverter : IObjectConverter<InstaHighlightSingleFeed, InstaHighlightReelResponse>
{
	public InstaHighlightReelResponse SourceObject { get; set; }

	public InstaHighlightSingleFeed Convert()
	{
		if (SourceObject.Reel == null)
		{
			return null;
		}
		InstaHighlightSingleFeed instaHighlightSingleFeed = new InstaHighlightSingleFeed
		{
			CanReply = SourceObject.Reel.CanReply,
			CanReshare = SourceObject.Reel.CanReshare,
			HighlightId = SourceObject.Reel.Id,
			LatestReelMedia = SourceObject.Reel.LatestReelMedia,
			MediaCount = SourceObject.Reel.MediaCount,
			PrefetchCount = SourceObject.Reel.PrefetchCount,
			RankedPosition = SourceObject.Reel.RankedPosition,
			ReelType = SourceObject.Reel.ReelType,
			Seen = SourceObject.Reel.Seen,
			SeenRankedPosition = SourceObject.Reel.SeenRankedPosition,
			Title = SourceObject.Reel.Title
		};
		instaHighlightSingleFeed.CoverMedia = new InstaHighlightCoverMedia
		{
			CropRect = SourceObject.Reel.CoverMedia.CropRect,
			MediaId = SourceObject.Reel.CoverMedia.MediaId
		};
		if (SourceObject.Reel.CoverMedia.CroppedImageVersion != null)
		{
			instaHighlightSingleFeed.CoverMedia.CroppedImage = new InstaImage(SourceObject.Reel.CoverMedia.CroppedImageVersion.Url, int.Parse(SourceObject.Reel.CoverMedia.CroppedImageVersion.Width), int.Parse(SourceObject.Reel.CoverMedia.CroppedImageVersion.Height));
		}
		if (SourceObject.Reel.CoverMedia.FullImageVersion != null)
		{
			instaHighlightSingleFeed.CoverMedia.Image = new InstaImage(SourceObject.Reel.CoverMedia.FullImageVersion.Url, int.Parse(SourceObject.Reel.CoverMedia.FullImageVersion.Width), int.Parse(SourceObject.Reel.CoverMedia.FullImageVersion.Height));
		}
		IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.Reel.User);
		instaHighlightSingleFeed.User = userShortConverter.Convert();
		instaHighlightSingleFeed.Items = new List<InstaStoryItem>();
		if (SourceObject.Reel.Items != null)
		{
			foreach (InstaStoryItemResponse item in SourceObject.Reel.Items)
			{
				instaHighlightSingleFeed.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item).Convert());
			}
			return instaHighlightSingleFeed;
		}
		return instaHighlightSingleFeed;
	}
}
