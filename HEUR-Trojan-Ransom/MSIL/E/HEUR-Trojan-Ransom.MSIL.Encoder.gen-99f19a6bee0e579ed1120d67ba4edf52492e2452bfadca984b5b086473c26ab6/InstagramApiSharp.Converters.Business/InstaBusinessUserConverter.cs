using System;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.ResponseWrappers.Business;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters.Business;

internal class InstaBusinessUserConverter : IObjectConverter<InstaBusinessUser, InstaBusinessUserContainerResponse>
{
	public InstaBusinessUserContainerResponse SourceObject { get; set; }

	public InstaBusinessUser Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaBusinessUser instaBusinessUser = new InstaBusinessUser
		{
			Pk = SourceObject.User.Pk.GetValueOrDefault(),
			Username = SourceObject.User.Username,
			FullName = SourceObject.User.FullName,
			IsPrivate = SourceObject.User.IsPrivate.GetValueOrDefault(),
			IsVerified = SourceObject.User.IsVerified.GetValueOrDefault(),
			HasAnonymousProfilePicture = SourceObject.User.HasAnonymousProfilePicture.GetValueOrDefault(),
			Biography = SourceObject.User.Biography,
			ExternalUrl = SourceObject.User.ExternalUrl,
			ReelAutoArchive = SourceObject.User.ReelAutoArchive,
			IsBusiness = SourceObject.User.IsBusiness.GetValueOrDefault(),
			ContactPhoneNumber = (SourceObject.User.ContactPhoneNumber ?? string.Empty),
			PublicPhoneNumber = (SourceObject.User.PublicPhoneNumber ?? string.Empty),
			PublicPhoneCountryCode = (SourceObject.User.PublicPhoneCountryCode ?? string.Empty),
			ShowConversionEditEntry = SourceObject.User.ShowConversionEditEntry.GetValueOrDefault(),
			AllowedCommenterType = SourceObject.User.AllowedCommenterType,
			AddressStreet = SourceObject.User.AddressStreet,
			Category = SourceObject.User.Category,
			CityId = SourceObject.User.CityId.GetValueOrDefault(),
			CityName = SourceObject.User.CityName,
			DirectMessaging = SourceObject.User.DirectMessaging,
			FbPageCallToActionId = SourceObject.User.FbPageCallToActionId,
			IsCallToActionEnabled = SourceObject.User.IsCallToActionEnabled.GetValueOrDefault(),
			Latitude = SourceObject.User.Latitude.GetValueOrDefault(),
			Longitude = SourceObject.User.Longitude.GetValueOrDefault(),
			PublicEmail = SourceObject.User.PublicEmail,
			ZipCode = SourceObject.User.ZipCode,
			CanBoostPost = SourceObject.User.CanBoostPost.GetValueOrDefault(),
			CanClaimPage = SourceObject.User.CanClaimPage.GetValueOrDefault(),
			CanConvertToBusiness = SourceObject.User.CanConvertToBusiness.GetValueOrDefault(),
			CanCrosspostWithoutFbToken = SourceObject.User.CanCrosspostWithoutFbToken.GetValueOrDefault(),
			CanLinkEntitiesInBio = SourceObject.User.CanLinkEntitiesInBio.GetValueOrDefault(),
			CanSeeOrganicInsights = SourceObject.User.CanSeeOrganicInsights.GetValueOrDefault(),
			HasPlacedOrders = SourceObject.User.HasPlacedOrders.GetValueOrDefault(),
			ShowBusinessConversionIcon = SourceObject.User.ShowBusinessConversionIcon.GetValueOrDefault(),
			ShowInsightsTerms = SourceObject.User.ShowInsightsTerms.GetValueOrDefault(),
			FbPageCallToActionIxAppId = SourceObject.User.FbPageCallToActionIxAppId.GetValueOrDefault(),
			FbPageCallToActionIxPartner = SourceObject.User.FbPageCallToActionIxPartner,
			FbPageCallToActionIxUrl = SourceObject.User.FbPageCallToActionIxUrl,
			InstagramLocationId = SourceObject.User.InstagramLocationId,
			PageId = SourceObject.User.PageId.GetValueOrDefault(),
			PageName = SourceObject.User.PageName,
			ProfilePicId = SourceObject.User.ProfilePicId,
			ProfileVisitsCount = SourceObject.User.ProfileVisitsCount.GetValueOrDefault(),
			ProfileVisitsNumDays = SourceObject.User.ProfileVisitsNumDays.GetValueOrDefault(),
			ProfilPicUrl = SourceObject.User.ProfilPicUrl
		};
		if (SourceObject.User.BiographyWithEntities != null && SourceObject.User.BiographyWithEntities.Entities != null)
		{
			instaBusinessUser.BiographyWithEntities = SourceObject.User.BiographyWithEntities;
		}
		if (!string.IsNullOrEmpty(SourceObject.User.BusinessContactMethod))
		{
			try
			{
				if (Enum.TryParse<InstaBusinessContactType>(SourceObject.User.BusinessContactMethod.Replace("_", ""), ignoreCase: true, out var result))
				{
					instaBusinessUser.BusinessContactMethod = result;
				}
			}
			catch
			{
			}
		}
		if (SourceObject.User.FbPageCallToActionIxLabelBundle != null)
		{
			try
			{
				instaBusinessUser.FbPageCallToActionIxLabelBundle = new InstaBusinessUserFbBundle
				{
					ContactBar = SourceObject.User.FbPageCallToActionIxLabelBundle.ContactBar,
					SettingToggle = SourceObject.User.FbPageCallToActionIxLabelBundle.SettingToggle,
					SettingToggleDescription = SourceObject.User.FbPageCallToActionIxLabelBundle.SettingToggleDescription
				};
				return instaBusinessUser;
			}
			catch
			{
				return instaBusinessUser;
			}
		}
		return instaBusinessUser;
	}
}
