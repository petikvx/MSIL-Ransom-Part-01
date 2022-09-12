using System;
using System.Collections.Generic;
using System.Globalization;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaMediaAlbumConverter : IObjectConverter<InstaMedia, InstaMediaAlbumResponse>
{
	public InstaMediaAlbumResponse SourceObject { get; set; }

	public InstaMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaMedia instaMedia = new InstaMedia
		{
			InstaIdentifier = SourceObject.Media.InstaIdentifier,
			Code = SourceObject.Media.Code,
			Pk = SourceObject.Media.Pk,
			ClientCacheKey = SourceObject.Media.ClientCacheKey,
			CommentsCount = SourceObject.Media.CommentsCount,
			DeviceTimeStamp = DateTimeHelper.UnixTimestampToDateTime(SourceObject.Media.DeviceTimeStampUnixLike),
			HasLiked = SourceObject.Media.HasLiked,
			PhotoOfYou = SourceObject.Media.PhotoOfYou,
			TrackingToken = SourceObject.Media.TrackingToken,
			TakenAt = DateTimeHelper.UnixTimestampToDateTime(SourceObject.Media.TakenAtUnixLike),
			Height = SourceObject.Media.Height,
			LikesCount = SourceObject.Media.LikesCount,
			MediaType = SourceObject.Media.MediaType,
			FilterType = SourceObject.Media.FilterType,
			Width = SourceObject.Media.Width,
			HasAudio = SourceObject.Media.HasAudio,
			ViewCount = int.Parse(SourceObject.Media.ViewCount.ToString(CultureInfo.InvariantCulture)),
			IsCommentsDisabled = SourceObject.Media.IsCommentsDisabled
		};
		if (SourceObject.Media.CarouselMedia != null)
		{
			instaMedia.Carousel = ConvertersFabric.Instance.GetCarouselConverter(SourceObject.Media.CarouselMedia).Convert();
		}
		if (SourceObject.Media.User != null)
		{
			instaMedia.User = ConvertersFabric.Instance.GetUserConverter(SourceObject.Media.User).Convert();
		}
		if (SourceObject.Media.Caption != null)
		{
			instaMedia.Caption = ConvertersFabric.Instance.GetCaptionConverter(SourceObject.Media.Caption).Convert();
		}
		if (SourceObject.Media.NextMaxId != null)
		{
			instaMedia.NextMaxId = SourceObject.Media.NextMaxId;
		}
		if (SourceObject.Media.Likers != null)
		{
			List<InstaUserShortResponse> likers = SourceObject.Media.Likers;
			if (likers != null && likers.Count > 0)
			{
				foreach (InstaUserShortResponse liker in SourceObject.Media.Likers)
				{
					instaMedia.Likers.Add(ConvertersFabric.Instance.GetUserShortConverter(liker).Convert());
				}
			}
		}
		if (SourceObject.Media.UserTagList?.In != null)
		{
			InstaUserTagListResponse userTagList = SourceObject.Media.UserTagList;
			if (userTagList != null && userTagList.In?.Count > 0)
			{
				foreach (InstaUserTagResponse item in SourceObject.Media.UserTagList.In)
				{
					instaMedia.UserTags.Add(ConvertersFabric.Instance.GetUserTagConverter(item).Convert());
				}
			}
		}
		if (SourceObject.Media.PreviewComments != null)
		{
			foreach (InstaCommentResponse previewComment in SourceObject.Media.PreviewComments)
			{
				instaMedia.PreviewComments.Add(ConvertersFabric.Instance.GetCommentConverter(previewComment).Convert());
			}
		}
		if (SourceObject.Media.Location != null)
		{
			instaMedia.Location = ConvertersFabric.Instance.GetLocationConverter(SourceObject.Media.Location).Convert();
		}
		if (SourceObject.Media.Images?.Candidates == null)
		{
			return instaMedia;
		}
		foreach (ImageResponse candidate in SourceObject.Media.Images.Candidates)
		{
			instaMedia.Images.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
		}
		if (SourceObject.Media.Videos == null)
		{
			return instaMedia;
		}
		foreach (InstaVideoResponse video in SourceObject.Media.Videos)
		{
			instaMedia.Videos.Add(new InstaVideo(video.Url, int.Parse(video.Width), int.Parse(video.Height), video.Type));
		}
		return instaMedia;
	}
}
