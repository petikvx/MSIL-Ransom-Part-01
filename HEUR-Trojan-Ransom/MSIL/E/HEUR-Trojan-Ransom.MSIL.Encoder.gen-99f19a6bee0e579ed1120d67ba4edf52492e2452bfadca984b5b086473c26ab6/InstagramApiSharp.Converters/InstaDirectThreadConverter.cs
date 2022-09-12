using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Converters;

internal class InstaDirectThreadConverter : IObjectConverter<InstaDirectInboxThread, InstaDirectInboxThreadResponse>
{
	public InstaDirectInboxThreadResponse SourceObject { get; set; }

	public InstaDirectInboxThread Convert()
	{
		InstaDirectInboxThread instaDirectInboxThread = new InstaDirectInboxThread
		{
			Canonical = SourceObject.Canonical,
			HasNewer = SourceObject.HasNewer,
			HasOlder = SourceObject.HasOlder,
			IsSpam = SourceObject.IsSpam,
			Muted = SourceObject.Muted,
			Named = SourceObject.Named,
			Pending = SourceObject.Pending,
			VieweId = SourceObject.VieweId,
			LastActivity = DateTimeHelper.UnixTimestampMilisecondsToDateTime(SourceObject.LastActivity),
			ThreadId = SourceObject.ThreadId,
			OldestCursor = SourceObject.OldestCursor,
			IsGroup = SourceObject.IsGroup,
			IsPin = SourceObject.IsPin,
			ValuedRequest = SourceObject.ValuedRequest,
			PendingScore = SourceObject.PendingScore.GetValueOrDefault(),
			VCMuted = SourceObject.VCMuted,
			ReshareReceiveCount = SourceObject.ReshareReceiveCount,
			ReshareSendCount = SourceObject.ReshareSendCount,
			ExpiringMediaReceiveCount = SourceObject.ExpiringMediaReceiveCount,
			ExpiringMediaSendCount = SourceObject.ExpiringMediaSendCount,
			NewestCursor = SourceObject.NewestCursor,
			ThreadType = SourceObject.ThreadType,
			Title = SourceObject.Title,
			MentionsMuted = SourceObject.MentionsMuted.GetValueOrDefault()
		};
		if (SourceObject.Inviter != null)
		{
			IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.Inviter);
			instaDirectInboxThread.Inviter = userShortConverter.Convert();
		}
		if (SourceObject.Items != null && SourceObject.Items.Count > 0)
		{
			instaDirectInboxThread.Items = new List<InstaDirectInboxItem>();
			foreach (InstaDirectInboxItemResponse item in SourceObject.Items)
			{
				IObjectConverter<InstaDirectInboxItem, InstaDirectInboxItemResponse> directThreadItemConverter = ConvertersFabric.Instance.GetDirectThreadItemConverter(item);
				instaDirectInboxThread.Items.Add(directThreadItemConverter.Convert());
			}
		}
		if (SourceObject.LastPermanentItem != null)
		{
			IObjectConverter<InstaDirectInboxItem, InstaDirectInboxItemResponse> directThreadItemConverter2 = ConvertersFabric.Instance.GetDirectThreadItemConverter(SourceObject.LastPermanentItem);
			instaDirectInboxThread.LastPermanentItem = directThreadItemConverter2.Convert();
		}
		if (SourceObject.Users != null && SourceObject.Users.Count > 0)
		{
			foreach (InstaUserShortFriendshipResponse user in SourceObject.Users)
			{
				IObjectConverter<InstaUserShortFriendship, InstaUserShortFriendshipResponse> userShortFriendshipConverter = ConvertersFabric.Instance.GetUserShortFriendshipConverter(user);
				instaDirectInboxThread.Users.Add(userShortFriendshipConverter.Convert());
			}
		}
		if (SourceObject.LeftUsers != null && SourceObject.LeftUsers.Count > 0)
		{
			foreach (InstaUserShortFriendshipResponse leftUser in SourceObject.LeftUsers)
			{
				IObjectConverter<InstaUserShortFriendship, InstaUserShortFriendshipResponse> userShortFriendshipConverter2 = ConvertersFabric.Instance.GetUserShortFriendshipConverter(leftUser);
				instaDirectInboxThread.LeftUsers.Add(userShortFriendshipConverter2.Convert());
			}
		}
		if (SourceObject.LastSeenAt != null && SourceObject.LastSeenAt != null)
		{
			try
			{
				InstaLastSeenAtResponse instaLastSeenAtResponse = JsonConvert.DeserializeObject<InstaLastSeenAtResponse>(System.Convert.ToString(SourceObject.LastSeenAt));
				instaDirectInboxThread.LastSeenAt = new List<InstaLastSeen>();
				foreach (KeyValuePair<string, JToken> extra in instaLastSeenAtResponse.Extras)
				{
					InstaLastSeenItemResponse instaLastSeenItemResponse = JsonConvert.DeserializeObject<InstaLastSeenItemResponse>(extra.Value.ToString(Formatting.None));
					InstaLastSeen instaLastSeen = new InstaLastSeen
					{
						PK = long.Parse(extra.Key),
						ItemId = instaLastSeenItemResponse.ItemId
					};
					if (instaLastSeenItemResponse.TimestampPrivate != null)
					{
						instaLastSeen.SeenTime = DateTimeHelper.UnixTimestampMilisecondsToDateTime(instaLastSeenItemResponse.TimestampPrivate);
					}
					instaDirectInboxThread.LastSeenAt.Add(instaLastSeen);
				}
			}
			catch
			{
			}
		}
		try
		{
			if (instaDirectInboxThread.LastActivity > instaDirectInboxThread.LastSeenAt[0].SeenTime)
			{
				instaDirectInboxThread.HasUnreadMessage = true;
				return instaDirectInboxThread;
			}
			return instaDirectInboxThread;
		}
		catch
		{
			instaDirectInboxThread.HasUnreadMessage = false;
			return instaDirectInboxThread;
		}
	}
}
