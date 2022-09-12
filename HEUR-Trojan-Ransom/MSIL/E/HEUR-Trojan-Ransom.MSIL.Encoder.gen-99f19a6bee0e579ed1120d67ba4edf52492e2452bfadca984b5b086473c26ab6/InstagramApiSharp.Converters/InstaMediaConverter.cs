using System;
using System.Collections.Generic;
using System.Globalization;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaMediaConverter : IObjectConverter<InstaMedia, InstaMediaItemResponse>
{
	public InstaMediaItemResponse SourceObject { get; set; }

	public InstaMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaMedia instaMedia = new InstaMedia
		{
			InstaIdentifier = SourceObject.InstaIdentifier,
			Code = SourceObject.Code,
			Pk = SourceObject.Pk,
			ClientCacheKey = SourceObject.ClientCacheKey,
			CommentsCount = SourceObject.CommentsCount,
			HasLiked = SourceObject.HasLiked,
			PhotoOfYou = SourceObject.PhotoOfYou,
			TrackingToken = SourceObject.TrackingToken,
			TakenAtUnix = long.Parse(string.IsNullOrEmpty(SourceObject.TakenAtUnixLike) ? "0" : SourceObject.TakenAtUnixLike),
			Height = SourceObject.Height,
			LikesCount = SourceObject.LikesCount,
			MediaType = SourceObject.MediaType,
			FilterType = SourceObject.FilterType,
			Width = SourceObject.Width,
			HasAudio = SourceObject.HasAudio,
			ViewCount = int.Parse(SourceObject.ViewCount.ToString(CultureInfo.InvariantCulture)),
			IsCommentsDisabled = SourceObject.IsCommentsDisabled,
			CanViewerReshare = SourceObject.CanViewerReshare,
			CanViewerSave = SourceObject.CanViewerSave,
			CanViewMorePreviewComments = SourceObject.CanViewMorePreviewComments,
			CommentLikesEnabled = SourceObject.CommentLikesEnabled,
			MaxNumVisiblePreviewComments = SourceObject.MaxNumVisiblePreviewComments,
			HasMoreComments = SourceObject.HasMoreComments,
			CommentThreadingEnabled = SourceObject.CommentThreadingEnabled,
			Title = SourceObject.Title,
			ProductType = SourceObject.ProductType,
			NearlyCompleteCopyrightMatch = SourceObject.NearlyCompleteCopyrightMatch.GetValueOrDefault(),
			NumberOfQualities = SourceObject.NumberOfQualities.GetValueOrDefault(),
			VideoDuration = SourceObject.VideoDuration.GetValueOrDefault(),
			HasViewerSaved = SourceObject.HasViewerSaved,
			DirectReplyToAuthorEnabled = SourceObject.DirectReplyToAuthorEnabled.GetValueOrDefault()
		};
		if (!string.IsNullOrEmpty(SourceObject.TakenAtUnixLike))
		{
			instaMedia.TakenAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.TakenAtUnixLike);
		}
		if (!string.IsNullOrEmpty(SourceObject.DeviceTimeStampUnixLike))
		{
			instaMedia.DeviceTimeStamp = DateTimeHelper.UnixTimestampToDateTime(SourceObject.DeviceTimeStampUnixLike);
		}
		if (SourceObject.CarouselMedia != null)
		{
			instaMedia.Carousel = ConvertersFabric.Instance.GetCarouselConverter(SourceObject.CarouselMedia).Convert();
		}
		if (SourceObject.User != null)
		{
			instaMedia.User = ConvertersFabric.Instance.GetUserConverter(SourceObject.User).Convert();
		}
		if (SourceObject.Caption != null)
		{
			instaMedia.Caption = ConvertersFabric.Instance.GetCaptionConverter(SourceObject.Caption).Convert();
		}
		if (SourceObject.NextMaxId != null)
		{
			instaMedia.NextMaxId = SourceObject.NextMaxId;
		}
		List<InstaUserShortResponse> likers = SourceObject.Likers;
		if (likers != null && likers.Count > 0)
		{
			foreach (InstaUserShortResponse liker in SourceObject.Likers)
			{
				instaMedia.Likers.Add(ConvertersFabric.Instance.GetUserShortConverter(liker).Convert());
			}
		}
		InstaUserTagListResponse userTagList = SourceObject.UserTagList;
		if (userTagList != null && userTagList.In?.Count > 0)
		{
			foreach (InstaUserTagResponse item in SourceObject.UserTagList.In)
			{
				instaMedia.UserTags.Add(ConvertersFabric.Instance.GetUserTagConverter(item).Convert());
			}
		}
		InstaProductTagsContainerResponse productTags = SourceObject.ProductTags;
		if (productTags != null && productTags.In?.Count > 0)
		{
			foreach (InstaProductContainerResponse item2 in SourceObject.ProductTags.In)
			{
				instaMedia.ProductTags.Add(ConvertersFabric.Instance.GetProductTagContainerConverter(item2).Convert());
			}
		}
		List<InstaCommentResponse> previewComments = SourceObject.PreviewComments;
		if (previewComments != null && previewComments.Count > 0)
		{
			foreach (InstaCommentResponse previewComment in SourceObject.PreviewComments)
			{
				instaMedia.PreviewComments.Add(ConvertersFabric.Instance.GetCommentConverter(previewComment).Convert());
			}
		}
		if (SourceObject.Location != null)
		{
			instaMedia.Location = ConvertersFabric.Instance.GetLocationConverter(SourceObject.Location).Convert();
		}
		if (SourceObject.Images?.Candidates == null)
		{
			return instaMedia;
		}
		foreach (ImageResponse candidate in SourceObject.Images.Candidates)
		{
			instaMedia.Images.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
		}
		if (SourceObject.Videos == null)
		{
			return instaMedia;
		}
		foreach (InstaVideoResponse video in SourceObject.Videos)
		{
			instaMedia.Videos.Add(new InstaVideo(video.Url, int.Parse(video.Width), int.Parse(video.Height), video.Type));
		}
		return instaMedia;
	}
}
