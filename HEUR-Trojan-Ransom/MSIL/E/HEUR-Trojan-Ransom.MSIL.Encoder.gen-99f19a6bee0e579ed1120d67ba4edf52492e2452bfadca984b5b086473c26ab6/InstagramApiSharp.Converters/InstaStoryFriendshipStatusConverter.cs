using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryFriendshipStatusConverter : IObjectConverter<InstaStoryFriendshipStatus, InstaStoryFriendshipStatusResponse>
{
	public InstaStoryFriendshipStatusResponse SourceObject { get; set; }

	public InstaStoryFriendshipStatus Convert()
	{
		return new InstaStoryFriendshipStatus
		{
			Following = SourceObject.Following,
			Blocking = SourceObject.Blocking.GetValueOrDefault(),
			FollowedBy = SourceObject.FollowedBy,
			OutgoingRequest = SourceObject.OutgoingRequest.GetValueOrDefault(),
			IsBestie = SourceObject.IsBestie.GetValueOrDefault(),
			Muting = SourceObject.Muting.GetValueOrDefault(),
			IncomingRequest = SourceObject.IncomingRequest.GetValueOrDefault(),
			IsBlockingReel = SourceObject.IsBlockingReel.GetValueOrDefault(),
			IsMutingReel = SourceObject.IsMutingReel.GetValueOrDefault(),
			IsPrivate = SourceObject.IsPrivate
		};
	}
}
