using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTagFeedConverter : IObjectConverter<InstaTagFeed, InstaTagFeedResponse>
{
	public InstaTagFeedResponse SourceObject { get; set; }

	public InstaTagFeed Convert()
	{
		if (SourceObject?.Medias == null)
		{
			throw new ArgumentNullException("InstaFeedResponse or its media list");
		}
		InstaTagFeed instaTagFeed = new InstaTagFeed();
		instaTagFeed.RankedMedias.AddRange(smethod_0(SourceObject.RankedItems));
		instaTagFeed.Medias.AddRange(smethod_0(SourceObject.Medias));
		instaTagFeed.NextMaxId = SourceObject.NextMaxId;
		foreach (InstaStoryResponse story in SourceObject.Stories)
		{
			InstaStory item = ConvertersFabric.Instance.GetStoryConverter(story).Convert();
			instaTagFeed.Stories.Add(item);
		}
		return instaTagFeed;
	}

	[CompilerGenerated]
	internal static List<InstaMedia> smethod_0(List<InstaMediaItemResponse> mediasResponse)
	{
		List<InstaMedia> list = new List<InstaMedia>();
		foreach (InstaMediaItemResponse item2 in mediasResponse)
		{
			if (item2 != null && item2.Type == 0)
			{
				InstaMedia item = ConvertersFabric.Instance.GetSingleMediaConverter(item2).Convert();
				list.Add(item);
			}
		}
		return list;
	}
}
