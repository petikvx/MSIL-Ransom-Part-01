using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaExploreFeedConverter : IObjectConverter<InstaExploreFeed, InstaExploreFeedResponse>
{
	public InstaExploreFeedResponse SourceObject { get; set; }

	public InstaExploreFeed Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaExploreFeed instaExploreFeed = new InstaExploreFeed
		{
			NextMaxId = SourceObject.NextMaxId,
			AutoLoadMoreEnabled = SourceObject.AutoLoadMoreEnabled,
			ResultsCount = SourceObject.ResultsCount,
			MoreAvailable = SourceObject.MoreAvailable,
			MaxId = SourceObject.MaxId,
			RankToken = SourceObject.RankToken
		};
		if (SourceObject.Items?.StoryTray != null)
		{
			instaExploreFeed.StoryTray = ConvertersFabric.Instance.GetStoryTrayConverter(SourceObject.Items.StoryTray).Convert();
		}
		if (SourceObject.Items?.Channel != null)
		{
			instaExploreFeed.Channel = ConvertersFabric.Instance.GetChannelConverter(SourceObject.Items.Channel).Convert();
		}
		instaExploreFeed.Medias.AddRange(smethod_0(SourceObject.Items?.Medias));
		return instaExploreFeed;
	}

	[CompilerGenerated]
	internal static List<InstaMedia> smethod_0(List<InstaMediaItemResponse> mediasResponse)
	{
		List<InstaMedia> list = new List<InstaMedia>();
		if (mediasResponse == null)
		{
			return list;
		}
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
