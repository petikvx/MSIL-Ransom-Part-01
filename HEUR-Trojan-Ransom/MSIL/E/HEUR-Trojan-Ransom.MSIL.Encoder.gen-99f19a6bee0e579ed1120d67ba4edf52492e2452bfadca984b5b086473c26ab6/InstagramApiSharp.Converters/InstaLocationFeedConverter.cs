using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaLocationFeedConverter : IObjectConverter<InstaLocationFeed, InstaLocationFeedResponse>
{
	public InstaLocationFeedResponse SourceObject { get; set; }

	public InstaLocationFeed Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		return new InstaLocationFeed
		{
			MediaCount = SourceObject.MediaCount,
			NextMaxId = SourceObject.NextMaxId,
			Medias = smethod_0(SourceObject.Items),
			RankedMedias = smethod_0(SourceObject.RankedItems),
			Location = ConvertersFabric.Instance.GetLocationConverter(SourceObject.Location).Convert(),
			Story = ConvertersFabric.Instance.GetStoryConverter(SourceObject.Story).Convert()
		};
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_0(List<InstaMediaItemResponse> mediasResponse)
	{
		InstaMediaList instaMediaList = new InstaMediaList();
		if (mediasResponse == null)
		{
			return instaMediaList;
		}
		foreach (InstaMediaItemResponse item2 in mediasResponse)
		{
			if (item2 != null && item2.Type == 0)
			{
				InstaMedia item = ConvertersFabric.Instance.GetSingleMediaConverter(item2).Convert();
				instaMediaList.Add(item);
			}
		}
		return instaMediaList;
	}
}
