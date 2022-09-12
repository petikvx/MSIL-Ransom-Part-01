using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaStoryFriendshipStatusShortConverter : IObjectConverter<InstaStoryFriendshipStatusShort, InstaStoryFriendshipStatusShortResponse>
{
	public InstaStoryFriendshipStatusShortResponse SourceObject { get; set; }

	public InstaStoryFriendshipStatusShort Convert()
	{
		return new InstaStoryFriendshipStatusShort
		{
			Following = SourceObject.Following,
			OutgoingRequest = SourceObject.OutgoingRequest.GetValueOrDefault(),
			Muting = SourceObject.Muting.GetValueOrDefault(),
			IsMutingReel = SourceObject.IsMutingReel.GetValueOrDefault()
		};
	}
}
