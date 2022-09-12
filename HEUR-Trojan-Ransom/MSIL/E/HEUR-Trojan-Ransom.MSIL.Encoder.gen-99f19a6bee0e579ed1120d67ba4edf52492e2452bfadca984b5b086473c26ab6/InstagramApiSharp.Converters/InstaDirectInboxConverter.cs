using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Helpers;

namespace InstagramApiSharp.Converters;

internal class InstaDirectInboxConverter : IObjectConverter<InstaDirectInboxContainer, InstaDirectInboxContainerResponse>
{
	public InstaDirectInboxContainerResponse SourceObject { get; set; }

	public InstaDirectInboxContainer Convert()
	{
		InstaDirectInboxContainer instaDirectInboxContainer = new InstaDirectInboxContainer
		{
			PendingRequestsCount = SourceObject.PendingRequestsCount,
			SeqId = SourceObject.SeqId,
			SnapshotAt = SourceObject.SnapshotAtMs.GetValueOrDefault().FromUnixTimeMiliSeconds()
		};
		if (SourceObject.Subscription != null)
		{
			IObjectConverter<InstaDirectInboxSubscription, InstaDirectInboxSubscriptionResponse> directSubscriptionConverter = ConvertersFabric.Instance.GetDirectSubscriptionConverter(SourceObject.Subscription);
			instaDirectInboxContainer.Subscription = directSubscriptionConverter.Convert();
		}
		if (SourceObject.Inbox != null)
		{
			instaDirectInboxContainer.Inbox = new InstaDirectInbox
			{
				HasOlder = SourceObject.Inbox.HasOlder,
				UnseenCount = SourceObject.Inbox.UnseenCount,
				UnseenCountTs = SourceObject.Inbox.UnseenCountTs,
				OldestCursor = SourceObject.Inbox.OldestCursor,
				BlendedInboxEnabled = SourceObject.Inbox.BlendedInboxEnabled
			};
			if (SourceObject.Inbox.Threads != null && SourceObject.Inbox.Threads.Count > 0)
			{
				instaDirectInboxContainer.Inbox.Threads = new List<InstaDirectInboxThread>();
				foreach (InstaDirectInboxThreadResponse thread in SourceObject.Inbox.Threads)
				{
					IObjectConverter<InstaDirectInboxThread, InstaDirectInboxThreadResponse> directThreadConverter = ConvertersFabric.Instance.GetDirectThreadConverter(thread);
					instaDirectInboxContainer.Inbox.Threads.Add(directThreadConverter.Convert());
				}
			}
		}
		if (SourceObject.PendingUsers != null && SourceObject.PendingUsers.Count > 0)
		{
			foreach (InstaUserShortResponse pendingUser in SourceObject.PendingUsers)
			{
				IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(pendingUser);
				instaDirectInboxContainer.PendingUsers.Add(userShortConverter.Convert());
			}
			return instaDirectInboxContainer;
		}
		return instaDirectInboxContainer;
	}
}
