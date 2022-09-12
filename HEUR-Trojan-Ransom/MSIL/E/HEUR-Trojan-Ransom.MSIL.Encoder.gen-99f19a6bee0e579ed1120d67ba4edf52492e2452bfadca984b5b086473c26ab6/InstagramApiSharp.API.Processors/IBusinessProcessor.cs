using System;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Business;
using InstagramApiSharp.Enums;

namespace InstagramApiSharp.API.Processors;

public interface IBusinessProcessor
{
	Task<IResult<InstaBusinessUser>> AddOrChangeBusinessButtonAsync(InstaBusinessPartner businessPartner, Uri uri);

	Task<IResult<InstaBrandedContent>> AddUserToBrandedWhiteListAsync(params long[] userIdsToAdd);

	Task<IResult<InstaBrandedContent>> DisbaleBrandedContentApprovalAsync();

	Task<IResult<InstaBrandedContent>> EnableBrandedContentApprovalAsync();

	Task<IResult<InstaBusinessUser>> ChangeBusinessCategoryAsync(string subCategoryId);

	Task<IResult<InstaAccountDetails>> GetAccountDetailsAsync(long userId);

	Task<IResult<InstaUserInfo>> GetBusinessAccountInformationAsync();

	Task<IResult<InstaBusinessPartnersList>> GetBusinessPartnersButtonsAsync();

	Task<IResult<InstaBusinessCategoryList>> GetCategoriesAsync();

	Task<IResult<InstaFullMediaInsights>> GetFullMediaInsightsAsync(string mediaId);

	Task<IResult<InstaMediaInsights>> GetMediaInsightsAsync(string mediaPk);

	Task<IResult<InstaMediaList>> GetPromotableMediaFeedsAsync();

	Task<IResult<InstaStatistics>> GetStatisticsAsync();

	Task<IResult<InstaBusinessCategoryList>> GetSubCategoriesAsync(string categoryId);

	Task<IResult<InstaBusinessSuggestedCategoryList>> GetSuggestedCategoriesAsync();

	Task<IResult<InstaBrandedContent>> GetBrandedContentApprovalAsync();

	Task<IResult<InstaBusinessUser>> RemoveBusinessButtonAsync();

	Task<IResult<InstaBusinessUser>> RemoveBusinessLocationAsync();

	Task<IResult<InstaBusinessCityLocationList>> SearchCityLocationAsync(string cityOrTown);

	Task<IResult<InstaDiscoverSearchResult>> SearchBrandedUsersAsync(string query, int count = 85);

	Task<IResult<bool>> StarDirectThreadAsync(string threadId);

	Task<IResult<bool>> UnStarDirectThreadAsync(string threadId);

	Task<IResult<InstaBrandedContent>> RemoveUserFromBrandedWhiteListAsync(params long[] userIdsToRemove);

	Task<IResult<InstaBusinessUser>> UpdateBusinessInfoAsync(string phoneNumberWithCountryCode, InstaBusinessCityLocation cityLocation, string streetAddress, string zipCode, InstaBusinessContactType? businessContactType);

	Task<IResult<bool>> ValidateUrlAsync(InstaBusinessPartner desirePartner, Uri uri);
}
