using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryConverter : IObjectConverter<InstaStory, InstaStoryResponse>
{
	public InstaStoryResponse SourceObject { get; set; }

	public InstaStory Convert()
	{
		if (SourceObject == null)
		{
			return null;
		}
		InstaStory instaStory = new InstaStory
		{
			CanReply = SourceObject.CanReply,
			ExpiringAt = SourceObject.ExpiringAt.FromUnixTimeSeconds(),
			Id = SourceObject.Id,
			LatestReelMedia = SourceObject.LatestReelMedia,
			Muted = SourceObject.Muted,
			PrefetchCount = SourceObject.PrefetchCount,
			RankedPosition = SourceObject.RankedPosition,
			Seen = SourceObject.Seen.GetValueOrDefault().FromUnixTimeSeconds(),
			SeenRankedPosition = SourceObject.SeenRankedPosition,
			SocialContext = SourceObject.SocialContext,
			SourceToken = SourceObject.SourceToken,
			TakenAtUnix = SourceObject.TakenAtUnixLike,
			CanReshare = SourceObject.CanReshare,
			CanViewerSave = SourceObject.CanViewerSave,
			CaptionIsEdited = SourceObject.CaptionIsEdited,
			CaptionPosition = SourceObject.CaptionPosition,
			ClientCacheKey = SourceObject.ClientCacheKey,
			PhotoOfYou = SourceObject.PhotoOfYou,
			IsReelMedia = SourceObject.IsReelMedia,
			VideoDuration = SourceObject.VideoDuration.GetValueOrDefault(),
			SupportsReelReactions = SourceObject.SupportsReelReactions,
			HasSharedToFb = SourceObject.HasSharedToFb,
			ImportedTakenAt = SourceObject.ImportedTakenAt.FromUnixTimeSeconds()
		};
		if (SourceObject.StoryHashtags != null)
		{
			foreach (InstaReelMentionResponse storyHashtag in SourceObject.StoryHashtags)
			{
				instaStory.StoryHashtags.Add(ConvertersFabric.Instance.GetMentionConverter(storyHashtag).Convert());
			}
		}
		if (SourceObject.StoryLocation != null)
		{
			instaStory.StoryLocation = SourceObject.StoryLocation;
		}
		if (SourceObject.Owner != null)
		{
			instaStory.Owner = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.Owner).Convert();
		}
		if (SourceObject.User != null)
		{
			instaStory.User = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(SourceObject.User).Convert();
		}
		if (SourceObject.Items != null)
		{
			foreach (InstaStoryItemResponse item in SourceObject.Items)
			{
				instaStory.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item).Convert());
			}
			return instaStory;
		}
		return instaStory;
	}
}
