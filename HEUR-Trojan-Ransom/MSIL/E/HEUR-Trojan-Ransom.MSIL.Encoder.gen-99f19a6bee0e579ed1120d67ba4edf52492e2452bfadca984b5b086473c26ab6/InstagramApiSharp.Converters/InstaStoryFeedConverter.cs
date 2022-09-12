using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters;

internal class InstaStoryFeedConverter : IObjectConverter<InstaStoryFeed, InstaStoryFeedResponse>
{
	public InstaStoryFeedResponse SourceObject { get; set; }

	public InstaStoryFeed Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaStoryFeed instaStoryFeed = new InstaStoryFeed
		{
			FaceFilterNuxVersion = SourceObject.FaceFilterNuxVersion,
			HasNewNuxStory = SourceObject.HasNewNuxStory,
			StickerVersion = SourceObject.StickerVersion,
			StoryRankingToken = SourceObject.StoryRankingToken
		};
		if (SourceObject.Tray != null && SourceObject.Tray.Any())
		{
			foreach (JToken item in SourceObject.Tray)
			{
				InstaReelFeedResponse instaReelFeedResponse = item.ToObject<InstaReelFeedResponse>();
				if (instaReelFeedResponse.Id.ToLower().StartsWith("tag:"))
				{
					instaStoryFeed.HashtagStories.Add(ConvertersFabric.Instance.GetHashtagStoryConverter(item.ToObject<InstaHashtagStoryResponse>()).Convert());
				}
				else
				{
					instaStoryFeed.Items.Add(ConvertersFabric.Instance.GetReelFeedConverter(instaReelFeedResponse).Convert());
				}
			}
		}
		List<InstaBroadcastResponse> broadcasts = SourceObject.Broadcasts;
		if (broadcasts != null && broadcasts.Count > 0)
		{
			foreach (InstaBroadcastResponse broadcast in SourceObject.Broadcasts)
			{
				instaStoryFeed.Broadcasts.Add(ConvertersFabric.Instance.GetBroadcastConverter(broadcast).Convert());
			}
		}
		InstaBroadcastAddToPostLiveContainerResponse postLives = SourceObject.PostLives;
		if (postLives != null && postLives.PostLiveItems?.Count > 0)
		{
			foreach (InstaBroadcastAddToPostLiveResponse postLiveItem in SourceObject.PostLives.PostLiveItems)
			{
				instaStoryFeed.PostLives.Add(ConvertersFabric.Instance.GetAddToPostLiveConverter(postLiveItem).Convert());
			}
			return instaStoryFeed;
		}
		return instaStoryFeed;
	}
}
