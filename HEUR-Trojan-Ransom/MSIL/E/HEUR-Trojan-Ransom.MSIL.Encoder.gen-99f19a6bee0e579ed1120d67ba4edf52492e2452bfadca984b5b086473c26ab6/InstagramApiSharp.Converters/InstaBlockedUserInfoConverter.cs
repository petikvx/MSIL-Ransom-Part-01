using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBlockedUserInfoConverter : IObjectConverter<InstaBlockedUserInfo, InstaBlockedUserInfoResponse>
{
	public InstaBlockedUserInfoResponse SourceObject { get; set; }

	public InstaBlockedUserInfo Convert()
	{
		return new InstaBlockedUserInfo
		{
			BlockedAt = SourceObject.BlockedAt,
			FullName = SourceObject.FullName,
			IsPrivate = SourceObject.IsPrivate,
			Pk = SourceObject.Pk,
			ProfilePicture = SourceObject.ProfilePicture,
			UserName = SourceObject.UserName
		};
	}
}
