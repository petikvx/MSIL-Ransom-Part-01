using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTopLiveConverter : IObjectConverter<InstaTopLive, InstaTopLiveResponse>
{
	public InstaTopLiveResponse SourceObject { get; set; }

	public InstaTopLive Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaTopLive instaTopLive = new InstaTopLive
		{
			RankedPosition = SourceObject.RankedPosition
		};
		foreach (InstaUserShortFriendshipFullResponse broadcastOwner in SourceObject.BroadcastOwners)
		{
			InstaUserShortFriendshipFull item = ConvertersFabric.Instance.GetUserShortFriendshipFullConverter(broadcastOwner).Convert();
			instaTopLive.BroadcastOwners.Add(item);
		}
		return instaTopLive;
	}
}
