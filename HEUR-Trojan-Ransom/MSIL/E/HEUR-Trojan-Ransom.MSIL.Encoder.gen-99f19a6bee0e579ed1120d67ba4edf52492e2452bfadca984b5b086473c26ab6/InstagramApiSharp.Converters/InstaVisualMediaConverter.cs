using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaVisualMediaConverter : IObjectConverter<InstaVisualMedia, InstaVisualMediaResponse>
{
	public InstaVisualMediaResponse SourceObject { get; set; }

	public InstaVisualMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaVisualMedia instaVisualMedia = new InstaVisualMedia
		{
			Height = SourceObject.Height.GetValueOrDefault(),
			InstaIdentifier = SourceObject.InstaIdentifier,
			MediaType = SourceObject.MediaType,
			MediaId = SourceObject.MediaId,
			TrackingToken = SourceObject.TrackingToken,
			Width = SourceObject.Width.GetValueOrDefault()
		};
		if (SourceObject.UrlExpireAtSecs.HasValue)
		{
			instaVisualMedia.UrlExpireAt = SourceObject.UrlExpireAtSecs.Value.FromUnixTimeSeconds();
		}
		if (SourceObject.Images?.Candidates != null)
		{
			foreach (ImageResponse candidate in SourceObject.Images.Candidates)
			{
				instaVisualMedia.Images.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
			}
		}
		List<InstaVideoResponse> videos = SourceObject.Videos;
		if (videos != null && videos.Count > 0)
		{
			foreach (InstaVideoResponse video in SourceObject.Videos)
			{
				instaVisualMedia.Videos.Add(new InstaVideo(video.Url, int.Parse(video.Width), int.Parse(video.Height), video.Type));
			}
			return instaVisualMedia;
		}
		return instaVisualMedia;
	}
}
