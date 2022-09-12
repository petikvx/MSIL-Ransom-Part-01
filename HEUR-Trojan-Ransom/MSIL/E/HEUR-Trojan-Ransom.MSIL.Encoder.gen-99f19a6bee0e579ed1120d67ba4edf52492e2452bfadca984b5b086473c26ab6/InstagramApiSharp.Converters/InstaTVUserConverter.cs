using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaTVUserConverter : IObjectConverter<InstaTVUser, InstaTVUserResponse>
{
	public InstaTVUserResponse SourceObject { get; set; }

	public InstaTVUser Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("SourceObject");
		}
		InstaTVUser instaTVUser = new InstaTVUser
		{
			AllowedCommenterType = SourceObject.AllowedCommenterType,
			Biography = SourceObject.Biography,
			BiographyWithEntities = SourceObject.BiographyWithEntities,
			CanBoostPost = SourceObject.CanBoostPost,
			CanLinkEntitiesInBio = SourceObject.CanLinkEntitiesInBio,
			CanSeeOrganicInsights = SourceObject.CanSeeOrganicInsights,
			ExternalLynxUrl = SourceObject.ExternalLynxUrl,
			ExternalUrl = SourceObject.ExternalUrl,
			FollowerCount = SourceObject.FollowerCount,
			FollowingCount = SourceObject.FollowingCount,
			FollowingTagCount = SourceObject.FollowingTagCount,
			FullName = SourceObject.FullName,
			GeoMediaCount = SourceObject.GeoMediaCount,
			HasAnonymousProfilePicture = SourceObject.HasAnonymousProfilePicture,
			HasBiographyTranslation = SourceObject.HasBiographyTranslation,
			HasPlacedOrders = SourceObject.HasPlacedOrders,
			IsPrivate = SourceObject.IsPrivate,
			IsVerified = SourceObject.IsVerified,
			MediaCount = SourceObject.MediaCount,
			Pk = SourceObject.Pk,
			ProfilePicId = SourceObject.ProfilePicId,
			ProfilePicUrl = SourceObject.ProfilePicUrl,
			ReelAutoArchive = SourceObject.ReelAutoArchive,
			ShowInsightsTerms = SourceObject.ShowInsightsTerms,
			TotalIGTVVideosCount = SourceObject.TotalIGTVVideosCount,
			Username = SourceObject.Username
		};
		try
		{
			instaTVUser.FriendshipStatus = ConvertersFabric.Instance.GetFriendShipStatusConverter(SourceObject.FriendshipStatus).Convert();
			return instaTVUser;
		}
		catch
		{
			return instaTVUser;
		}
	}
}
