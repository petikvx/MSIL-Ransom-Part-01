using System;
using InstagramApiSharp.Classes.Models.Hashtags;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters.Hashtags;

internal class InstaHashtagStoryConverter : IObjectConverter<InstaHashtagStory, InstaHashtagStoryResponse>
{
	public InstaHashtagStoryResponse SourceObject { get; set; }

	public InstaHashtagStory Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaHashtagStory instaHashtagStory = new InstaHashtagStory
		{
			CanReply = SourceObject.CanReply,
			CanReshare = SourceObject.CanReshare,
			ExpiringAt = SourceObject.ExpiringAt.FromUnixTimeSeconds(),
			Id = SourceObject.Id,
			LatestReelMedia = SourceObject.LatestReelMedia,
			Muted = SourceObject.Muted,
			PrefetchCount = SourceObject.PrefetchCount,
			ReelType = SourceObject.ReelType,
			UniqueIntegerReelId = SourceObject.UniqueIntegerReelId,
			Owner = ConvertersFabric.Instance.GetHashtagOwnerConverter(SourceObject.Owner).Convert()
		};
		try
		{
			foreach (InstaStoryItemResponse item in SourceObject.Items)
			{
				try
				{
					instaHashtagStory.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item).Convert());
				}
				catch
				{
				}
			}
			return instaHashtagStory;
		}
		catch
		{
			return instaHashtagStory;
		}
	}
}
