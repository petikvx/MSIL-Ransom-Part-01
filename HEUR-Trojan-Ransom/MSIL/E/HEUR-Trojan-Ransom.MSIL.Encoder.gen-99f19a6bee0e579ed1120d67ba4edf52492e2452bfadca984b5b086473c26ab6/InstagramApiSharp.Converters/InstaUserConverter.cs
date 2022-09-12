using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserConverter : IObjectConverter<InstaUser, InstaUserResponse>
{
	public InstaUserResponse SourceObject { get; set; }

	public InstaUser Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUser instaUser = new InstaUser(ConvertersFabric.Instance.GetUserShortConverter(SourceObject).Convert())
		{
			HasAnonymousProfilePicture = SourceObject.HasAnonymousProfilePicture,
			FollowersCount = SourceObject.FollowersCount,
			FollowersCountByLine = SourceObject.FollowersCountByLine,
			SearchSocialContext = SourceObject.SearchSocialContext,
			SocialContext = SourceObject.SocialContext
		};
		if (double.TryParse(SourceObject.MulualFollowersCount, out var result))
		{
			instaUser.MutualFollowers = System.Convert.ToInt16(result);
		}
		if (SourceObject.FriendshipStatus != null)
		{
			IObjectConverter<InstaFriendshipShortStatus, InstaFriendshipShortStatusResponse> singleFriendshipShortStatusConverter = ConvertersFabric.Instance.GetSingleFriendshipShortStatusConverter(SourceObject.FriendshipStatus);
			instaUser.FriendshipStatus = singleFriendshipShortStatusConverter.Convert();
		}
		return instaUser;
	}
}
