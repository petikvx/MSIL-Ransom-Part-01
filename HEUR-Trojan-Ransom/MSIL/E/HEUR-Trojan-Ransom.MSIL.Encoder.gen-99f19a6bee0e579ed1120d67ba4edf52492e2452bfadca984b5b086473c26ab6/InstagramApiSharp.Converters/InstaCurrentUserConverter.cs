using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters;

internal class InstaCurrentUserConverter : IObjectConverter<InstaCurrentUser, InstaCurrentUserResponse>
{
	public InstaCurrentUserResponse SourceObject { get; set; }

	public InstaCurrentUser Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaCurrentUser instaCurrentUser = new InstaCurrentUser(ConvertersFabric.Instance.GetUserShortConverter(SourceObject).Convert())
		{
			HasAnonymousProfilePicture = SourceObject.HasAnonymousProfilePicture,
			Biography = SourceObject.Biography,
			Birthday = SourceObject.Birthday,
			CountryCode = SourceObject.CountryCode,
			NationalNumber = SourceObject.NationalNumber,
			Email = SourceObject.Email,
			ExternalUrl = SourceObject.ExternalURL,
			ShowConversionEditEntry = SourceObject.ShowConversationEditEntry,
			Gender = (InstaGenderType)SourceObject.Gender,
			PhoneNumber = SourceObject.PhoneNumber
		};
		if (SourceObject.HDProfilePicVersions != null)
		{
			ImageResponse[] hDProfilePicVersions = SourceObject.HDProfilePicVersions;
			if (hDProfilePicVersions != null && hDProfilePicVersions.Length != 0)
			{
				ImageResponse[] hDProfilePicVersions2 = SourceObject.HDProfilePicVersions;
				foreach (ImageResponse imageResponse in hDProfilePicVersions2)
				{
					IObjectConverter<InstaImage, ImageResponse> imageConverter = ConvertersFabric.Instance.GetImageConverter(imageResponse);
					instaCurrentUser.HdProfileImages.Add(imageConverter.Convert());
				}
			}
		}
		if (SourceObject.HDProfilePicture != null)
		{
			IObjectConverter<InstaImage, ImageResponse> imageConverter2 = ConvertersFabric.Instance.GetImageConverter(SourceObject.HDProfilePicture);
			instaCurrentUser.HdProfilePicture = imageConverter2.Convert();
		}
		return instaCurrentUser;
	}
}
