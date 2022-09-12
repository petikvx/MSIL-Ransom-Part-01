using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaCarouselItemConverter : IObjectConverter<InstaCarouselItem, InstaCarouselItemResponse>
{
	public InstaCarouselItemResponse SourceObject { get; set; }

	public InstaCarouselItem Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaCarouselItem instaCarouselItem = new InstaCarouselItem
		{
			CarouselParentId = SourceObject.CarouselParentId,
			Height = int.Parse(SourceObject.Height),
			Width = int.Parse(SourceObject.Width),
			MediaType = SourceObject.MediaType,
			InstaIdentifier = SourceObject.InstaIdentifier,
			Pk = SourceObject.Pk
		};
		if (SourceObject?.Images?.Candidates != null)
		{
			foreach (ImageResponse candidate in SourceObject.Images.Candidates)
			{
				instaCarouselItem.Images.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
			}
		}
		if (SourceObject?.Videos != null)
		{
			foreach (InstaVideoResponse video in SourceObject.Videos)
			{
				instaCarouselItem.Videos.Add(new InstaVideo(video.Url, int.Parse(video.Width), int.Parse(video.Height), video.Type));
			}
		}
		if (SourceObject.UserTagList?.In != null)
		{
			InstaUserTagListResponse userTagList = SourceObject.UserTagList;
			if (userTagList != null && userTagList.In?.Count > 0)
			{
				foreach (InstaUserTagResponse item in SourceObject.UserTagList.In)
				{
					instaCarouselItem.UserTags.Add(ConvertersFabric.Instance.GetUserTagConverter(item).Convert());
				}
				return instaCarouselItem;
			}
		}
		return instaCarouselItem;
	}
}
