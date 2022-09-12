using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaInboxMediaConverter : IObjectConverter<InstaInboxMedia, InstaInboxMediaResponse>
{
	public InstaInboxMediaResponse SourceObject { get; set; }

	public InstaInboxMedia Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaInboxMedia instaInboxMedia = new InstaInboxMedia
		{
			MediaType = SourceObject.MediaType,
			OriginalHeight = SourceObject.OriginalHeight,
			OriginalWidth = SourceObject.OriginalWidth
		};
		if (SourceObject?.ImageCandidates?.Candidates == null)
		{
			return instaInboxMedia;
		}
		foreach (ImageResponse candidate in SourceObject.ImageCandidates.Candidates)
		{
			instaInboxMedia.Images.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
		}
		List<InstaVideoResponse> videos = SourceObject.Videos;
		if (videos != null && videos.Count > 0)
		{
			foreach (InstaVideoResponse video in SourceObject.Videos)
			{
				instaInboxMedia.Videos.Add(new InstaVideo(video.Url, int.Parse(video.Width), int.Parse(video.Height), video.Type));
			}
			return instaInboxMedia;
		}
		return instaInboxMedia;
	}
}
