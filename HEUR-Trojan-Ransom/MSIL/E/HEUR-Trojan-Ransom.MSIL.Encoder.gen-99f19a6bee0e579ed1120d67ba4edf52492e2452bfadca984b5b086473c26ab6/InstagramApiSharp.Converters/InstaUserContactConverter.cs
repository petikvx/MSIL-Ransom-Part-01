using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaUserContactConverter : IObjectConverter<InstaUserContact, InstaUserContactResponse>
{
	public InstaUserContactResponse SourceObject { get; set; }

	public InstaUserContact Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaUserContact
		{
			Pk = SourceObject.Pk,
			UserName = SourceObject.UserName,
			FullName = SourceObject.FullName,
			IsPrivate = SourceObject.IsPrivate,
			ProfilePicture = SourceObject.ProfilePicture,
			ProfilePictureId = SourceObject.ProfilePictureId,
			IsVerified = SourceObject.IsVerified,
			ExtraDisplayName = SourceObject.ExtraDisplayName,
			ProfilePicUrl = SourceObject.ProfilePicture
		};
	}
}
