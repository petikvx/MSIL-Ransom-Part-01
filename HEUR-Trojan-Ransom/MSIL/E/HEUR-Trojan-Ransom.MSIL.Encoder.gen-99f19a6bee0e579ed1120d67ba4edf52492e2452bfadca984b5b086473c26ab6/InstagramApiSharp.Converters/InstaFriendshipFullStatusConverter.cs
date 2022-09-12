using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaFriendshipFullStatusConverter : IObjectConverter<InstaFriendshipFullStatus, InstaFriendshipFullStatusResponse>
{
	public InstaFriendshipFullStatusResponse SourceObject { get; set; }

	public InstaFriendshipFullStatus Convert()
	{
		return new InstaFriendshipFullStatus
		{
			Following = SourceObject.Following.GetValueOrDefault(),
			Blocking = SourceObject.Blocking.GetValueOrDefault(),
			FollowedBy = SourceObject.FollowedBy.GetValueOrDefault(),
			OutgoingRequest = SourceObject.OutgoingRequest.GetValueOrDefault(),
			IsBestie = SourceObject.IsBestie.GetValueOrDefault(),
			Muting = SourceObject.Muting.GetValueOrDefault(),
			IncomingRequest = SourceObject.IncomingRequest.GetValueOrDefault(),
			IsPrivate = SourceObject.IsPrivate.GetValueOrDefault()
		};
	}
}
