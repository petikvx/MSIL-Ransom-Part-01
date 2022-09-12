using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryItemConverter : IObjectConverter<InstaStoryItem, InstaStoryItemResponse>
{
	public InstaStoryItemResponse SourceObject { get; set; }

	public InstaStoryItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryItem instaStoryItem = new InstaStoryItem
		{
			CanViewerSave = SourceObject.CanViewerSave,
			CaptionIsEdited = SourceObject.CaptionIsEdited,
			CaptionPosition = SourceObject.CaptionPosition,
			Code = SourceObject.Code,
			CommentCount = SourceObject.CommentCount,
			ExpiringAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.ExpiringAt),
			FilterType = SourceObject.FilterType,
			HasAudio = SourceObject.HasAudio.GetValueOrDefault(),
			HasLiked = SourceObject.HasLiked,
			HasMoreComments = SourceObject.HasMoreComments,
			Id = SourceObject.Id,
			IsReelMedia = SourceObject.IsReelMedia,
			LikeCount = SourceObject.LikeCount,
			MaxNumVisiblePreviewComments = SourceObject.MaxNumVisiblePreviewComments,
			MediaType = SourceObject.MediaType,
			OriginalHeight = SourceObject.OriginalHeight,
			OriginalWidth = SourceObject.OriginalWidth,
			PhotoOfYou = SourceObject.PhotoOfYou,
			Pk = SourceObject.Pk,
			TakenAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.TakenAt),
			ImportedTakenAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.ImportedTakenAt.GetValueOrDefault()),
			VideoDuration = SourceObject.VideoDuration.GetValueOrDefault(),
			AdAction = SourceObject.AdAction,
			SupportsReelReactions = SourceObject.SupportsReelReactions,
			ShowOneTapTooltip = SourceObject.ShowOneTapTooltip,
			LinkText = SourceObject.LinkText,
			CanReshare = SourceObject.CanReshare,
			CommentLikesEnabled = SourceObject.CommentLikesEnabled,
			CommentThreadingEnabled = SourceObject.CommentThreadingEnabled,
			NumberOfQualities = SourceObject.NumberOfQualities.GetValueOrDefault(),
			TimezoneOffset = SourceObject.TimezoneOffset.GetValueOrDefault(),
			VideoDashManifest = SourceObject.VideoDashManifest,
			StoryIsSavedToArchive = SourceObject.StoryIsSavedToArchive.GetValueOrDefault(),
			ViewerCount = SourceObject.ViewerCount.GetValueOrDefault(),
			TotalViewerCount = SourceObject.TotalViewerCount.GetValueOrDefault(),
			ViewerCursor = SourceObject.ViewerCursor,
			HasSharedToFb = SourceObject.HasSharedToFb.GetValueOrDefault()
		};
		if (SourceObject.User != null)
		{
			instaStoryItem.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert();
		}
		if (SourceObject.Caption != null)
		{
			instaStoryItem.Caption = ConvertersFabric.Instance.GetCaptionConverter(SourceObject.Caption).Convert();
		}
		if (SourceObject.Images?.Candidates != null)
		{
			foreach (ImageResponse candidate in SourceObject.Images.Candidates)
			{
				instaStoryItem.ImageList.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
			}
		}
		if (SourceObject.VideoVersions != null && SourceObject.VideoVersions.Any())
		{
			foreach (InstaVideoResponse videoVersion in SourceObject.VideoVersions)
			{
				instaStoryItem.VideoList.Add(new InstaVideo(videoVersion.Url, int.Parse(videoVersion.Width), int.Parse(videoVersion.Height), videoVersion.Type));
			}
		}
		if (SourceObject.ReelMentions != null && SourceObject.ReelMentions.Any())
		{
			foreach (InstaReelMentionResponse reelMention in SourceObject.ReelMentions)
			{
				instaStoryItem.ReelMentions.Add(ConvertersFabric.Instance.GetMentionConverter(reelMention).Convert());
			}
		}
		if (SourceObject.StoryHashtags != null && SourceObject.StoryHashtags.Any())
		{
			foreach (InstaReelMentionResponse storyHashtag in SourceObject.StoryHashtags)
			{
				instaStoryItem.StoryHashtags.Add(ConvertersFabric.Instance.GetMentionConverter(storyHashtag).Convert());
			}
		}
		if (SourceObject.StoryLocations != null && SourceObject.StoryLocations.Any())
		{
			foreach (InstaStoryLocationResponse storyLocation in SourceObject.StoryLocations)
			{
				instaStoryItem.StoryLocations.Add(ConvertersFabric.Instance.GetStoryLocationConverter(storyLocation).Convert());
			}
		}
		if (SourceObject.StoryFeedMedia != null && SourceObject.StoryFeedMedia.Any())
		{
			foreach (InstaStoryFeedMediaResponse storyFeedMedium in SourceObject.StoryFeedMedia)
			{
				instaStoryItem.StoryFeedMedia.Add(ConvertersFabric.Instance.GetStoryFeedMediaConverter(storyFeedMedium).Convert());
			}
		}
		if (SourceObject.StoryCTA != null && SourceObject.StoryCTA.Any())
		{
			foreach (InstaStoryCTAContainerResponse storyCTum in SourceObject.StoryCTA)
			{
				if (storyCTum.Links != null && storyCTum.Links.Any())
				{
					InstaStoryCTAResponse[] links = storyCTum.Links;
					foreach (InstaStoryCTAResponse storyCta in links)
					{
						instaStoryItem.StoryCTA.Add(ConvertersFabric.Instance.GetStoryCtaConverter(storyCta).Convert());
					}
				}
			}
		}
		List<InstaStoryPollItemResponse> storyPolls = SourceObject.StoryPolls;
		if (storyPolls != null && storyPolls.Count > 0)
		{
			foreach (InstaStoryPollItemResponse storyPoll in SourceObject.StoryPolls)
			{
				instaStoryItem.StoryPolls.Add(ConvertersFabric.Instance.GetStoryPollItemConverter(storyPoll).Convert());
			}
		}
		List<InstaStorySliderItemResponse> storySliders = SourceObject.StorySliders;
		if (storySliders != null && storySliders.Count > 0)
		{
			foreach (InstaStorySliderItemResponse storySlider in SourceObject.StorySliders)
			{
				instaStoryItem.StorySliders.Add(ConvertersFabric.Instance.GetStorySliderItemConverter(storySlider).Convert());
			}
		}
		List<InstaStoryQuestionItemResponse> storyQuestions = SourceObject.StoryQuestions;
		if (storyQuestions != null && storyQuestions.Count > 0)
		{
			foreach (InstaStoryQuestionItemResponse storyQuestion in SourceObject.StoryQuestions)
			{
				instaStoryItem.StoryQuestions.Add(ConvertersFabric.Instance.GetStoryQuestionItemConverter(storyQuestion).Convert());
			}
		}
		List<InstaStoryPollVoterInfoItemResponse> storyPollVoters = SourceObject.StoryPollVoters;
		if (storyPollVoters != null && storyPollVoters.Count > 0)
		{
			foreach (InstaStoryPollVoterInfoItemResponse storyPollVoter in SourceObject.StoryPollVoters)
			{
				instaStoryItem.StoryPollVoters.Add(ConvertersFabric.Instance.GetStoryPollVoterInfoItemConverter(storyPollVoter).Convert());
			}
		}
		List<InstaUserShortResponse> viewers = SourceObject.Viewers;
		if (viewers != null && viewers.Count > 0)
		{
			foreach (InstaUserShortResponse viewer in SourceObject.Viewers)
			{
				instaStoryItem.Viewers.Add(ConvertersFabric.Instance.GetUserShortConverter(viewer).Convert());
			}
		}
		List<InstaUserShortResponse> likers = SourceObject.Likers;
		if (likers != null && likers.Count > 0)
		{
			foreach (InstaUserShortResponse liker in SourceObject.Likers)
			{
				instaStoryItem.Likers.Add(ConvertersFabric.Instance.GetUserShortConverter(liker).Convert());
			}
		}
		List<InstaCommentResponse> previewComments = SourceObject.PreviewComments;
		if (previewComments != null && previewComments.Count > 0)
		{
			foreach (InstaCommentResponse previewComment in SourceObject.PreviewComments)
			{
				instaStoryItem.PreviewComments.Add(ConvertersFabric.Instance.GetCommentConverter(previewComment).Convert());
			}
		}
		List<InstaStorySliderVoterInfoItemResponse> storySliderVoters = SourceObject.StorySliderVoters;
		if (storySliderVoters != null && storySliderVoters.Count > 0)
		{
			foreach (InstaStorySliderVoterInfoItemResponse storySliderVoter in SourceObject.StorySliderVoters)
			{
				instaStoryItem.StorySliderVoters.Add(ConvertersFabric.Instance.GetStorySliderVoterInfoItemConverter(storySliderVoter).Convert());
			}
		}
		List<InstaStoryQuestionInfoResponse> storyQuestionsResponderInfos = SourceObject.StoryQuestionsResponderInfos;
		if (storyQuestionsResponderInfos != null && storyQuestionsResponderInfos.Count > 0)
		{
			foreach (InstaStoryQuestionInfoResponse storyQuestionsResponderInfo in SourceObject.StoryQuestionsResponderInfos)
			{
				instaStoryItem.StoryQuestionsResponderInfos.Add(ConvertersFabric.Instance.GetStoryQuestionInfoConverter(storyQuestionsResponderInfo).Convert());
			}
		}
		List<InstaStoryCountdownItemResponse> countdowns = SourceObject.Countdowns;
		if (countdowns != null && countdowns.Count > 0)
		{
			foreach (InstaStoryCountdownItemResponse countdown in SourceObject.Countdowns)
			{
				instaStoryItem.Countdowns.Add(ConvertersFabric.Instance.GetStoryCountdownItemConverter(countdown).Convert());
			}
			return instaStoryItem;
		}
		return instaStoryItem;
	}
}
