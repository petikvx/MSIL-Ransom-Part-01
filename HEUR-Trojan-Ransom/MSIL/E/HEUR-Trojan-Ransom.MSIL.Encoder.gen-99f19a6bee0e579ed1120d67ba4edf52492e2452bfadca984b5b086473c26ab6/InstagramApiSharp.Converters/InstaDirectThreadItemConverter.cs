using System;
using System.Collections.Generic;
using System.Linq;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaDirectThreadItemConverter : IObjectConverter<InstaDirectInboxItem, InstaDirectInboxItemResponse>
{
	public InstaDirectInboxItemResponse SourceObject { get; set; }

	public InstaDirectInboxItem Convert()
	{
		InstaDirectInboxItem instaDirectInboxItem = new InstaDirectInboxItem
		{
			ClientContext = SourceObject.ClientContext,
			ItemId = SourceObject.ItemId
		};
		instaDirectInboxItem.TimeStamp = DateTimeHelper.UnixTimestampMilisecondsToDateTime(SourceObject.TimeStamp);
		instaDirectInboxItem.UserId = SourceObject.UserId;
		if (Enum.TryParse<InstaDirectThreadItemType>(SourceObject.ItemType.Trim().Replace("_", ""), ignoreCase: true, out var result))
		{
			instaDirectInboxItem.ItemType = result;
		}
		if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Link && SourceObject.Link != null)
		{
			instaDirectInboxItem.Text = SourceObject.Link.Text;
			try
			{
				instaDirectInboxItem.LinkMedia = new InstaWebLink
				{
					Text = SourceObject.Link.Text
				};
				if (SourceObject.Link.LinkContext != null)
				{
					instaDirectInboxItem.LinkMedia.LinkContext = new InstaWebLinkContext();
					if (!string.IsNullOrEmpty(SourceObject.Link.LinkContext.LinkImageUrl))
					{
						instaDirectInboxItem.LinkMedia.LinkContext.LinkImageUrl = SourceObject.Link.LinkContext.LinkImageUrl;
					}
					if (!string.IsNullOrEmpty(SourceObject.Link.LinkContext.LinkSummary))
					{
						instaDirectInboxItem.LinkMedia.LinkContext.LinkSummary = SourceObject.Link.LinkContext.LinkSummary;
					}
					if (!string.IsNullOrEmpty(SourceObject.Link.LinkContext.LinkTitle))
					{
						instaDirectInboxItem.LinkMedia.LinkContext.LinkTitle = SourceObject.Link.LinkContext.LinkTitle;
					}
					if (!string.IsNullOrEmpty(SourceObject.Link.LinkContext.LinkUrl))
					{
						instaDirectInboxItem.LinkMedia.LinkContext.LinkUrl = SourceObject.Link.LinkContext.LinkUrl;
						return instaDirectInboxItem;
					}
					return instaDirectInboxItem;
				}
				return instaDirectInboxItem;
			}
			catch
			{
				return instaDirectInboxItem;
			}
		}
		if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Like)
		{
			instaDirectInboxItem.Text = SourceObject.Like;
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Media && SourceObject.Media != null)
		{
			IObjectConverter<InstaInboxMedia, InstaInboxMediaResponse> inboxMediaConverter = ConvertersFabric.Instance.GetInboxMediaConverter(SourceObject.Media);
			instaDirectInboxItem.Media = inboxMediaConverter.Convert();
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.MediaShare && SourceObject.MediaShare != null)
		{
			IObjectConverter<InstaMedia, InstaMediaItemResponse> singleMediaConverter = ConvertersFabric.Instance.GetSingleMediaConverter(SourceObject.MediaShare);
			instaDirectInboxItem.MediaShare = singleMediaConverter.Convert();
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.StoryShare && SourceObject.StoryShare != null)
		{
			instaDirectInboxItem.StoryShare = new InstaStoryShare
			{
				IsReelPersisted = SourceObject.StoryShare.IsReelPersisted,
				ReelType = SourceObject.StoryShare.ReelType,
				Text = SourceObject.StoryShare.Text,
				IsLinked = SourceObject.StoryShare.IsLinked,
				Message = SourceObject.StoryShare.Message,
				Title = SourceObject.StoryShare.Title
			};
			if (SourceObject.StoryShare.Media != null)
			{
				IObjectConverter<InstaMedia, InstaMediaItemResponse> singleMediaConverter2 = ConvertersFabric.Instance.GetSingleMediaConverter(SourceObject.StoryShare.Media);
				instaDirectInboxItem.StoryShare.Media = singleMediaConverter2.Convert();
			}
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Text)
		{
			instaDirectInboxItem.Text = SourceObject.Text;
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.RavenMedia && SourceObject.RavenMedia != null)
		{
			IObjectConverter<InstaVisualMedia, InstaVisualMediaResponse> visualMediaConverter = ConvertersFabric.Instance.GetVisualMediaConverter(SourceObject.RavenMedia);
			instaDirectInboxItem.RavenMedia = visualMediaConverter.Convert();
			instaDirectInboxItem.RavenSeenUserIds = SourceObject.RavenSeenUserIds;
			if (!string.IsNullOrEmpty(SourceObject.RavenViewMode))
			{
				instaDirectInboxItem.RavenViewMode = (InstaViewMode)Enum.Parse(typeof(InstaViewMode), SourceObject.RavenViewMode, ignoreCase: true);
			}
			instaDirectInboxItem.RavenReplayChainCount = SourceObject.RavenReplayChainCount.GetValueOrDefault();
			instaDirectInboxItem.RavenSeenCount = SourceObject.RavenSeenCount;
			if (SourceObject.RavenExpiringMediaActionSummary != null)
			{
				InstaRavenType type = ((!(SourceObject.RavenExpiringMediaActionSummary.Type.ToLower() == "raven_delivered")) ? InstaRavenType.Opened : InstaRavenType.Delivered);
				instaDirectInboxItem.RavenExpiringMediaActionSummary = new InstaRavenMediaActionSummary
				{
					Count = SourceObject.RavenExpiringMediaActionSummary.Count,
					Type = type
				};
				if (!string.IsNullOrEmpty(SourceObject.RavenExpiringMediaActionSummary.TimeStamp))
				{
					instaDirectInboxItem.RavenExpiringMediaActionSummary.ExpireTime = DateTimeHelper.UnixTimestampMilisecondsToDateTime(SourceObject.RavenExpiringMediaActionSummary.TimeStamp);
				}
			}
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.RavenMedia && SourceObject.VisualMedia != null)
		{
			instaDirectInboxItem.VisualMedia = ConvertersFabric.Instance.GetVisualMediaContainerConverter(SourceObject.VisualMedia).Convert();
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.ActionLog && SourceObject.ActionLogMedia != null)
		{
			instaDirectInboxItem.ActionLog = new InstaActionLog
			{
				Description = SourceObject.ActionLogMedia.Description
			};
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Profile && SourceObject.ProfileMedia != null)
		{
			IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.ProfileMedia);
			instaDirectInboxItem.ProfileMedia = userShortConverter.Convert();
			if (SourceObject.ProfileMediasPreview != null && SourceObject.ProfileMediasPreview.Any())
			{
				try
				{
					List<InstaMedia> list = new List<InstaMedia>();
					foreach (InstaMediaItemResponse item in SourceObject.ProfileMediasPreview)
					{
						list.Add(ConvertersFabric.Instance.GetSingleMediaConverter(item).Convert());
					}
					instaDirectInboxItem.ProfileMediasPreview = list;
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
		}
		else if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Placeholder && SourceObject.Placeholder != null)
		{
			instaDirectInboxItem.Placeholder = new InstaPlaceholder
			{
				IsLinked = SourceObject.Placeholder.IsLinked,
				Message = SourceObject.Placeholder.Message
			};
		}
		else
		{
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Location && SourceObject.LocationMedia != null)
			{
				try
				{
					instaDirectInboxItem.LocationMedia = new InstaLocation();
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.Address))
					{
						instaDirectInboxItem.LocationMedia.Address = SourceObject.LocationMedia.Address;
					}
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.City))
					{
						instaDirectInboxItem.LocationMedia.City = SourceObject.LocationMedia.City;
					}
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.ExternalId))
					{
						instaDirectInboxItem.LocationMedia.ExternalId = SourceObject.LocationMedia.ExternalId;
					}
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.ExternalIdSource))
					{
						instaDirectInboxItem.LocationMedia.ExternalSource = SourceObject.LocationMedia.ExternalIdSource;
					}
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.ShortName))
					{
						instaDirectInboxItem.LocationMedia.ShortName = SourceObject.LocationMedia.ShortName;
					}
					if (!string.IsNullOrEmpty(SourceObject.LocationMedia.Name))
					{
						instaDirectInboxItem.LocationMedia.Name = SourceObject.LocationMedia.Name;
					}
					instaDirectInboxItem.LocationMedia.FacebookPlacesId = SourceObject.LocationMedia.FacebookPlacesId;
					instaDirectInboxItem.LocationMedia.Lat = SourceObject.LocationMedia.Lat;
					instaDirectInboxItem.LocationMedia.Lng = SourceObject.LocationMedia.Lng;
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.FelixShare && SourceObject.FelixShareMedia != null && SourceObject.FelixShareMedia.Video != null)
			{
				try
				{
					instaDirectInboxItem.FelixShareMedia = ConvertersFabric.Instance.GetSingleMediaConverter(SourceObject.FelixShareMedia.Video).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.ReelShare && SourceObject.ReelShareMedia != null)
			{
				try
				{
					instaDirectInboxItem.ReelShareMedia = ConvertersFabric.Instance.GetReelShareConverter(SourceObject.ReelShareMedia).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.VoiceMedia && SourceObject.VoiceMedia != null)
			{
				try
				{
					instaDirectInboxItem.VoiceMedia = ConvertersFabric.Instance.GetVoiceMediaConverter(SourceObject.VoiceMedia).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.AnimatedMedia && SourceObject.AnimatedMedia != null)
			{
				try
				{
					instaDirectInboxItem.AnimatedMedia = ConvertersFabric.Instance.GetAnimatedImageConverter(SourceObject.AnimatedMedia).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.Hashtag && SourceObject.HashtagMedia != null)
			{
				try
				{
					instaDirectInboxItem.HashtagMedia = ConvertersFabric.Instance.GetDirectHashtagConverter(SourceObject.HashtagMedia).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
			if (instaDirectInboxItem.ItemType == InstaDirectThreadItemType.LiveViewerInvite && SourceObject.LiveViewerInvite != null)
			{
				try
				{
					instaDirectInboxItem.LiveViewerInvite = ConvertersFabric.Instance.GetDirectBroadcastConverter(SourceObject.LiveViewerInvite).Convert();
					return instaDirectInboxItem;
				}
				catch
				{
					return instaDirectInboxItem;
				}
			}
		}
		return instaDirectInboxItem;
	}
}
