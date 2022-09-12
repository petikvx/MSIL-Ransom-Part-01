using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaRecipientsConverter : IObjectConverter<InstaRecipients, IInstaRecipientsResponse>
{
	public IInstaRecipientsResponse SourceObject { get; set; }

	public InstaRecipients Convert()
	{
		InstaRecipients instaRecipients = new InstaRecipients
		{
			ExpiresIn = SourceObject.Expires,
			Filtered = SourceObject.Filtered,
			RankToken = SourceObject.RankToken,
			RequestId = SourceObject.RequestId
		};
		IInstaRecipientsResponse sourceObject = SourceObject;
		if (sourceObject != null)
		{
			int? num = sourceObject.RankedRecipients?.Length;
			int num2 = 0;
			if (num > 0)
			{
				RankedRecipientResponse[] rankedRecipients = SourceObject.RankedRecipients;
				foreach (RankedRecipientResponse rankedRecipientResponse in rankedRecipients)
				{
					if (rankedRecipientResponse == null)
					{
						continue;
					}
					if (rankedRecipientResponse.Thread != null)
					{
						InstaRankedRecipientThread instaRankedRecipientThread = new InstaRankedRecipientThread
						{
							Canonical = rankedRecipientResponse.Thread.Canonical,
							Named = rankedRecipientResponse.Thread.Named,
							Pending = rankedRecipientResponse.Thread.Pending,
							ThreadId = rankedRecipientResponse.Thread.ThreadId,
							ThreadTitle = rankedRecipientResponse.Thread.ThreadTitle,
							ThreadType = rankedRecipientResponse.Thread.ThreadType,
							ViewerId = rankedRecipientResponse.Thread.ViewerId
						};
						InstaUserShortResponse[] users = rankedRecipientResponse.Thread.Users;
						foreach (InstaUserShortResponse instaresponse in users)
						{
							instaRankedRecipientThread.Users.Add(ConvertersFabric.Instance.GetUserShortConverter(instaresponse).Convert());
						}
						instaRecipients.Threads.Add(instaRankedRecipientThread);
					}
					if (rankedRecipientResponse.User != null)
					{
						InstaUserShort item = ConvertersFabric.Instance.GetUserShortConverter(rankedRecipientResponse.User).Convert();
						instaRecipients.Users.Add(item);
					}
				}
			}
		}
		return instaRecipients;
	}
}
