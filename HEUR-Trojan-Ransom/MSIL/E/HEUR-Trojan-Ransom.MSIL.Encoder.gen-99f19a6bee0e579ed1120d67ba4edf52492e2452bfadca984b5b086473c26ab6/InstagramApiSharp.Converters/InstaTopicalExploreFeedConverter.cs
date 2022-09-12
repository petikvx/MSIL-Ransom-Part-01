using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTopicalExploreFeedConverter : IObjectConverter<InstaTopicalExploreFeed, InstaTopicalExploreFeedResponse>
{
	public InstaTopicalExploreFeedResponse SourceObject { get; set; }

	public InstaTopicalExploreFeed Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTopicalExploreFeed instaTopicalExploreFeed = new InstaTopicalExploreFeed
		{
			NextMaxId = SourceObject.NextMaxId,
			AutoLoadMoreEnabled = SourceObject.AutoLoadMoreEnabled,
			ResultsCount = SourceObject.ResultsCount,
			MoreAvailable = SourceObject.MoreAvailable,
			MaxId = SourceObject.MaxId,
			RankToken = SourceObject.RankToken,
			HasShoppingChannelContent = SourceObject.HasShoppingChannelContent.GetValueOrDefault()
		};
		List<InstaTVChannelResponse> tVChannels = SourceObject.TVChannels;
		if (tVChannels != null && tVChannels.Count > 0)
		{
			foreach (InstaTVChannelResponse tVChannel in SourceObject.TVChannels)
			{
				try
				{
					instaTopicalExploreFeed.TVChannels.Add(ConvertersFabric.Instance.GetTVChannelConverter(tVChannel).Convert());
				}
				catch
				{
				}
			}
		}
		List<InstaTopicalExploreClusterResponse> clusters = SourceObject.Clusters;
		if (clusters != null && clusters.Count > 0)
		{
			foreach (InstaTopicalExploreClusterResponse cluster in SourceObject.Clusters)
			{
				try
				{
					instaTopicalExploreFeed.Clusters.Add(ConvertersFabric.Instance.GetExploreClusterConverter(cluster).Convert());
				}
				catch
				{
				}
			}
		}
		if (SourceObject.Channel != null)
		{
			instaTopicalExploreFeed.Channel = ConvertersFabric.Instance.GetChannelConverter(SourceObject.Channel).Convert();
		}
		instaTopicalExploreFeed.Medias.AddRange(smethod_0(SourceObject.Medias));
		return instaTopicalExploreFeed;
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
