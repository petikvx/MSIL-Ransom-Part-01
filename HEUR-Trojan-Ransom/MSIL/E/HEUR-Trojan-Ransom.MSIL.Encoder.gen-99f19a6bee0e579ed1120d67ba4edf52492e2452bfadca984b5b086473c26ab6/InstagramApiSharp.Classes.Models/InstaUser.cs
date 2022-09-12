namespace InstagramApiSharp.Classes.Models;

public class InstaUser : InstaUserShort
{
	public bool HasAnonymousProfilePicture { get; set; }

	public int FollowersCount { get; set; }

	public string FollowersCountByLine { get; set; }

	public string SocialContext { get; set; }

	public string SearchSocialContext { get; set; }

	public int MutualFollowers { get; set; }

	public int UnseenCount { get; set; }

	public InstaFriendshipShortStatus FriendshipStatus { get; set; }

	public InstaUser(InstaUserShort instaUserShort)
	{
		base.Pk = instaUserShort.Pk;
		base.UserName = instaUserShort.UserName;
		base.FullName = instaUserShort.FullName;
		base.IsPrivate = instaUserShort.IsPrivate;
		base.ProfilePicture = instaUserShort.ProfilePicture;
		base.ProfilePictureId = instaUserShort.ProfilePictureId;
		base.IsVerified = instaUserShort.IsVerified;
	}
}
