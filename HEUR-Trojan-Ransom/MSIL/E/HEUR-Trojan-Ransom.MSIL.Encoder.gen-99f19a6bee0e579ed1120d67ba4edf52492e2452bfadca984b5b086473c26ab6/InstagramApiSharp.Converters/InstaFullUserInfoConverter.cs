using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaFullUserInfoConverter : IObjectConverter<InstaFullUserInfo, InstaFullUserInfoResponse>
{
	public InstaFullUserInfoResponse SourceObject { get; set; }

	public InstaFullUserInfo Convert()
	{
		InstaFullUserInfo instaFullUserInfo = new InstaFullUserInfo
		{
			Status = SourceObject.Status
		};
		if (SourceObject.Feed != null)
		{
			instaFullUserInfo.Feed = new InstaFullUserInfoUserFeed
			{
				AutoLoadMoreEnabled = SourceObject.Feed.AutoLoadMoreEnabled,
				MoreAvailable = SourceObject.Feed.MoreAvailable,
				NextMaxId = (SourceObject.Feed.NextMaxId ?? string.Empty),
				NextMinId = (SourceObject.Feed.NextMinId ?? string.Empty),
				NumResults = SourceObject.Feed.NumResults
			};
			if (SourceObject.Feed.Items != null && SourceObject.Feed.Items.Any())
			{
				if (instaFullUserInfo.Feed.Items == null)
				{
					instaFullUserInfo.Feed.Items = new List<InstaMedia>();
				}
				foreach (InstaMediaItemResponse item in SourceObject.Feed.Items)
				{
					try
					{
						instaFullUserInfo.Feed.Items.Add(ConvertersFabric.Instance.GetSingleMediaConverter(item).Convert());
					}
					catch
					{
					}
				}
			}
		}
		if (SourceObject.UserDetail != null && SourceObject.UserDetail.User != null)
		{
			try
			{
				instaFullUserInfo.UserDetail = ConvertersFabric.Instance.GetUserInfoConverter(SourceObject.UserDetail).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.ReelFeed != null)
		{
			try
			{
				instaFullUserInfo.ReelFeed = new InstaFullUserInfoUserStoryReel
				{
					CanReply = SourceObject.ReelFeed.CanReply,
					CanReshare = SourceObject.ReelFeed.CanReshare,
					ExpiringAt = SourceObject.ReelFeed.ExpiringAt.FromUnixTimeSeconds(),
					HasBestiesMedia = SourceObject.ReelFeed.HasBestiesMedia,
					Id = SourceObject.ReelFeed.Id,
					LatestReelMedia = SourceObject.ReelFeed.LatestReelMedia,
					PrefetchCount = SourceObject.ReelFeed.PrefetchCount,
					ReelType = SourceObject.ReelFeed.ReelType,
					Seen = SourceObject.ReelFeed.Seen.GetValueOrDefault()
				};
				if (SourceObject.ReelFeed.User != null)
				{
					instaFullUserInfo.ReelFeed.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.ReelFeed.User).Convert();
				}
				if (SourceObject.ReelFeed.Items != null && SourceObject.ReelFeed.Items.Any())
				{
					if (instaFullUserInfo.ReelFeed.Items == null)
					{
						instaFullUserInfo.ReelFeed.Items = new List<InstaStoryItem>();
					}
					foreach (InstaStoryItemResponse item2 in SourceObject.ReelFeed.Items)
					{
						try
						{
							instaFullUserInfo.ReelFeed.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item2).Convert());
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
		}
		if (SourceObject.UserStory != null)
		{
			instaFullUserInfo.UserStory = new InstaFullUserInfoUserStory();
			if (SourceObject.UserStory.Broadcast != null)
			{
				try
				{
					instaFullUserInfo.UserStory.Broadcast = ConvertersFabric.Instance.GetBroadcastListConverter(SourceObject.UserStory.Broadcast?.Broadcasts).Convert();
				}
				catch
				{
				}
			}
			if (SourceObject.UserStory.Reel != null)
			{
				instaFullUserInfo.UserStory.Reel = new InstaFullUserInfoUserStoryReel
				{
					CanReply = SourceObject.UserStory.Reel.CanReply,
					CanReshare = SourceObject.UserStory.Reel.CanReshare,
					ExpiringAt = SourceObject.UserStory.Reel.ExpiringAt.FromUnixTimeSeconds(),
					HasBestiesMedia = SourceObject.UserStory.Reel.HasBestiesMedia,
					Id = SourceObject.UserStory.Reel.Id,
					LatestReelMedia = SourceObject.UserStory.Reel.LatestReelMedia,
					PrefetchCount = SourceObject.UserStory.Reel.PrefetchCount,
					ReelType = SourceObject.UserStory.Reel.ReelType,
					Seen = SourceObject.UserStory.Reel.Seen.GetValueOrDefault()
				};
				if (SourceObject.UserStory.Reel.User != null)
				{
					instaFullUserInfo.UserStory.Reel.User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.UserStory.Reel.User).Convert();
				}
				if (SourceObject.UserStory.Reel.Items != null && SourceObject.UserStory.Reel.Items.Any())
				{
					if (instaFullUserInfo.UserStory.Reel.Items == null)
					{
						instaFullUserInfo.UserStory.Reel.Items = new List<InstaStoryItem>();
					}
					{
						foreach (InstaStoryItemResponse item3 in SourceObject.UserStory.Reel.Items)
						{
							try
							{
								instaFullUserInfo.UserStory.Reel.Items.Add(ConvertersFabric.Instance.GetStoryItemConverter(item3).Convert());
							}
							catch
							{
							}
						}
						return instaFullUserInfo;
					}
				}
			}
		}
		return instaFullUserInfo;
	}
}
