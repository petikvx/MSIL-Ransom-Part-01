using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Users;

internal class InstaUserShortFriendshipFullConverter : IObjectConverter<InstaUserShortFriendshipFull, InstaUserShortFriendshipFullResponse>
{
	public InstaUserShortFriendshipFullResponse SourceObject { get; set; }

	public InstaUserShortFriendshipFull Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserShortFriendshipFull instaUserShortFriendshipFull = new InstaUserShortFriendshipFull
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
			instaUserShortFriendshipFull.FriendshipStatus = ConvertersFabric.Instance.GetFriendshipFullStatusConverter(SourceObject.FriendshipStatus).Convert();
		}
		return instaUserShortFriendshipFull;
	}
}
