using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.Converters;

internal class InstaUserInfoConverter : IObjectConverter<InstaUserInfo, InstaUserInfoContainerResponse>
{
	public InstaUserInfoContainerResponse SourceObject { get; set; }

	public InstaUserInfo Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaUserInfo instaUserInfo = new InstaUserInfo
		{
			Pk = SourceObject.User.Pk,
			Username = SourceObject.User.Username,
			FullName = SourceObject.User.FullName,
			IsPrivate = SourceObject.User.IsPrivate,
			ProfilePicUrl = SourceObject.User.ProfilePicUrl,
			ProfilePicId = SourceObject.User.ProfilePicId,
			IsVerified = SourceObject.User.IsVerified,
			HasAnonymousProfilePicture = SourceObject.User.HasAnonymousProfilePicture,
			MediaCount = SourceObject.User.MediaCount,
			GeoMediaCount = SourceObject.User.GeoMediaCount,
			FollowerCount = SourceObject.User.FollowerCount,
			FollowingCount = SourceObject.User.FollowingCount,
			Biography = SourceObject.User.Biography,
			CanLinkEntitiesInBio = SourceObject.User.CanLinkEntitiesInBio,
			ExternalUrl = SourceObject.User.ExternalUrl,
			ExternalLynxUrl = SourceObject.User.ExternalLynxUrl,
			HasBiographyTranslation = SourceObject.User.HasBiographyTranslation,
			CanBoostPost = SourceObject.User.CanBoostPost,
			CanSeeOrganicInsights = SourceObject.User.CanSeeOrganicInsights,
			ShowInsightsTerms = SourceObject.User.ShowInsightsTerms,
			CanConvertToBusiness = SourceObject.User.CanConvertToBusiness,
			CanCreateSponsorTags = SourceObject.User.CanCreateSponsorTags,
			CanBeTaggedAsSponsor = SourceObject.User.CanBeTaggedAsSponsor,
			TotalIGTVVideos = SourceObject.User.TotalIGTVVideos,
			TotalArEffects = SourceObject.User.TotalArEffects,
			IsProfileActionNeeded = SourceObject.User.IsProfileActionNeeded,
			UsertagReviewEnabled = SourceObject.User.UsertagReviewEnabled,
			IsNeedy = SourceObject.User.IsNeedy,
			HasRecommendAccounts = SourceObject.User.HasRecommendAccounts,
			HasPlacedOrders = SourceObject.User.HasPlacedOrders,
			CanTagProductsFromMerchants = SourceObject.User.CanTagProductsFromMerchants,
			ShowBusinessConversionIcon = SourceObject.User.ShowBusinessConversionIcon,
			ShowConversionEditEntry = SourceObject.User.ShowConversionEditEntry,
			AggregatePromoteEngagement = SourceObject.User.AggregatePromoteEngagement,
			AllowedCommenterType = SourceObject.User.AllowedCommenterType,
			IsVideoCreator = SourceObject.User.IsVideoCreator,
			HasProfileVideoFeed = SourceObject.User.HasProfileVideoFeed,
			IsEligibleToShowFBCrossSharingNux = SourceObject.User.IsEligibleToShowFBCrossSharingNux,
			PageIdForNewSumaBizAccount = SourceObject.User.PageIdForNewSumaBizAccount,
			AccountType = SourceObject.User.AccountType,
			ReelAutoArchive = SourceObject.User.ReelAutoArchive,
			UsertagsCount = SourceObject.User.UsertagsCount,
			IsFavorite = SourceObject.User.IsFavorite,
			HasChaining = SourceObject.User.HasChaining,
			ProfileContext = SourceObject.User.ProfileContext,
			ProfileContextMutualFollowIds = SourceObject.User.ProfileContextMutualFollowIds,
			IsBusiness = SourceObject.User.IsBusiness,
			IncludeDirectBlacklistStatus = SourceObject.User.IncludeDirectBlacklistStatus,
			HasUnseenBestiesMedia = SourceObject.User.HasUnseenBestiesMedia,
			AutoExpandChaining = SourceObject.User.AutoExpandChaining,
			ContactPhoneNumber = (SourceObject.User.ContactPhoneNumber ?? string.Empty),
			PublicPhoneNumber = (SourceObject.User.PublicPhoneNumber ?? string.Empty),
			PublicPhoneCountryCode = (SourceObject.User.PublicPhoneCountryCode ?? string.Empty),
			IsEligibleForSchool = SourceObject.User.IsEligibleForSchool,
			IsFavoriteForStories = SourceObject.User.IsFavoriteForStories,
			FollowingTagCount = SourceObject.User.FollowingTagCount,
			AddressStreet = SourceObject.User.AddressStreet,
			CanBeReportedAsFraud = SourceObject.User.CanBeReportedAsFraud.GetValueOrDefault(),
			Category = SourceObject.User.Category,
			CityId = SourceObject.User.CityId.GetValueOrDefault(),
			CityName = SourceObject.User.CityName,
			DirectMessaging = SourceObject.User.DirectMessaging,
			FbPageCallToActionId = SourceObject.User.FbPageCallToActionId,
			HasHighlightReels = SourceObject.User.HasHighlightReels.GetValueOrDefault(),
			HighlightReshareDisabled = SourceObject.User.HighlightReshareDisabled.GetValueOrDefault(),
			IsBestie = SourceObject.User.IsBestie.GetValueOrDefault(),
			IsCallToActionEnabled = SourceObject.User.IsCallToActionEnabled.GetValueOrDefault(),
			IsFavoriteForHighlights = SourceObject.User.IsFavoriteForHighlights.GetValueOrDefault(),
			IsInterestAccount = SourceObject.User.IsInterestAccount.GetValueOrDefault(),
			IsPotentialBusiness = SourceObject.User.IsPotentialBusiness.GetValueOrDefault(),
			Latitude = SourceObject.User.Latitude.GetValueOrDefault(),
			Longitude = SourceObject.User.Longitude.GetValueOrDefault(),
			PublicEmail = SourceObject.User.PublicEmail,
			ShoppablePostsCount = SourceObject.User.ShoppablePostsCount.GetValueOrDefault(),
			ShowAccountTransparencyDetails = SourceObject.User.ShowAccountTransparencyDetails.GetValueOrDefault(),
			ShowShoppableFeed = SourceObject.User.ShowShoppableFeed.GetValueOrDefault(),
			ZipCode = SourceObject.User.Zip,
			PageId = SourceObject.User.PageId.GetValueOrDefault(),
			PageName = SourceObject.User.PageName
		};
		if (SourceObject.User.BiographyWithEntities != null && SourceObject.User.BiographyWithEntities.Entities != null)
		{
			instaUserInfo.BiographyWithEntities = SourceObject.User.BiographyWithEntities;
		}
		if (!string.IsNullOrEmpty(SourceObject.User.BusinessContactMethod))
		{
			try
			{
				if (Enum.TryParse<InstaBusinessContactType>(SourceObject.User.BusinessContactMethod.Replace("_", ""), ignoreCase: true, out var result))
				{
					instaUserInfo.BusinessContactMethod = result;
				}
			}
			catch
			{
			}
		}
		if (SourceObject.User.HdProfilePicUrlInfo != null)
		{
			try
			{
				instaUserInfo.HdProfilePicUrlInfo = ConvertersFabric.Instance.GetImageConverter(SourceObject.User.HdProfilePicUrlInfo).Convert();
			}
			catch
			{
			}
		}
		if (SourceObject.User.HdProfilePicVersions != null && SourceObject.User.HdProfilePicVersions.Any())
		{
			try
			{
				foreach (ImageResponse hdProfilePicVersion in SourceObject.User.HdProfilePicVersions)
				{
					instaUserInfo.HdProfilePicVersions.Add(ConvertersFabric.Instance.GetImageConverter(hdProfilePicVersion).Convert());
				}
			}
			catch
			{
			}
		}
		if (SourceObject.User.ProfileContextIds != null && SourceObject.User.ProfileContextIds.Any())
		{
			foreach (InstaUserContextResponse profileContextId in SourceObject.User.ProfileContextIds)
			{
				try
				{
					InstaUserContext item = new InstaUserContext
					{
						End = profileContextId.End,
						Start = profileContextId.Start,
						Username = profileContextId.Username
					};
					instaUserInfo.ProfileContextIds.Add(item);
				}
				catch
				{
				}
			}
		}
		if (SourceObject.User.FriendshipStatus != null)
		{
			try
			{
				instaUserInfo.FriendshipStatus = ConvertersFabric.Instance.GetStoryFriendshipStatusConverter(SourceObject.User.FriendshipStatus).Convert();
				return instaUserInfo;
			}
			catch
			{
				return instaUserInfo;
			}
		}
		return instaUserInfo;
	}
}
