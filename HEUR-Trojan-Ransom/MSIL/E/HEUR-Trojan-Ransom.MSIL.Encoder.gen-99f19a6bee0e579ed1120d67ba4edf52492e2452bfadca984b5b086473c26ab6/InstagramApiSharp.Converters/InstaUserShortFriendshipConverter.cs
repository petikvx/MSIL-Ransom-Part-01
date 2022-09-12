using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserShortFriendshipConverter : IObjectConverter<InstaUserShortFriendship, InstaUserShortFriendshipResponse>
{
	public InstaUserShortFriendshipResponse SourceObject { get; set; }

	public InstaUserShortFriendship Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserShortFriendship instaUserShortFriendship = new InstaUserShortFriendship
		{
			Pk = SourceObject.Pk,
			UserName = SourceObject.UserName,
			FullName = SourceObject.FullName,
			IsPrivate = SourceObject.IsPrivate,
			ProfilePicture = SourceObject.ProfilePicture,
			ProfilePictureId = SourceObject.ProfilePictureId,
			IsVerified = SourceObject.IsVerified,
			ProfilePicUrl = SourceObject.ProfilePicture
		};
		if (SourceObject.FriendshipStatus != null)
		{
			InstaFriendshipShortStatusResponse friendshipStatus = SourceObject.FriendshipStatus;
			InstaFriendshipShortStatus instaFriendshipShortStatus2 = (instaUserShortFriendship.FriendshipStatus = new InstaFriendshipShortStatus
			{
				Following = friendshipStatus.Following,
				IncomingRequest = friendshipStatus.IncomingRequest,
				IsBestie = friendshipStatus.IsBestie,
				IsPrivate = friendshipStatus.IsPrivate,
				OutgoingRequest = friendshipStatus.OutgoingRequest,
				Pk = 0L
			});
		}
		return instaUserShortFriendship;
	}
}
