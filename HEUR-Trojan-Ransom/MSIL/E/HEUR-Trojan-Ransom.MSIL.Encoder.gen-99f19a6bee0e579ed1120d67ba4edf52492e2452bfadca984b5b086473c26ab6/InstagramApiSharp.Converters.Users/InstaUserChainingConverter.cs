using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters.Users;

internal class InstaUserChainingConverter : IObjectConverter<InstaUserChaining, InstaUserChainingResponse>
{
	public InstaUserChainingResponse SourceObject { get; set; }

	public InstaUserChaining Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaUserChaining instaUserChaining = new InstaUserChaining
		{
			Pk = SourceObject.Pk,
			UserName = SourceObject.UserName,
			FullName = SourceObject.FullName,
			IsPrivate = SourceObject.IsPrivate,
			ProfilePicture = SourceObject.ProfilePicture,
			ProfilePictureId = SourceObject.ProfilePictureId,
			IsVerified = SourceObject.IsVerified,
			ProfilePicUrl = SourceObject.ProfilePicture,
			ProfileChainingSecondaryLabel = SourceObject.ProfileChainingSecondaryLabel
		};
		if (SourceObject.ChainingInfo != null && !string.IsNullOrEmpty(SourceObject.ChainingInfo.Sources))
		{
			instaUserChaining.ChainingInfo = SourceObject.ChainingInfo.Sources;
		}
		return instaUserChaining;
	}
}
