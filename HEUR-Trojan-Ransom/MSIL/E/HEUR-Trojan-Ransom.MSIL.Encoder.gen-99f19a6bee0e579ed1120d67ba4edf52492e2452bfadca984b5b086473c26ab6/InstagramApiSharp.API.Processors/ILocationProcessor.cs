using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramApiSharp.API.Processors;

public interface ILocationProcessor
{
	Task<IResult<InstaStory>> GetLocationStoriesAsync(long locationId);

	Task<IResult<InstaPlaceShort>> GetLocationInfoAsync(string externalIdOrFacebookPlacesId);

	Task<IResult<InstaSectionMedia>> GetRecentLocationFeedsAsync(long locationId, PaginationParameters paginationParameters);

	Task<IResult<InstaSectionMedia>> GetTopLocationFeedsAsync(long locationId, PaginationParameters paginationParameters);

	Task<IResult<InstaLocationShortList>> SearchLocationAsync(double latitude, double longitude, string query);

	Task<IResult<InstaUserSearchLocation>> SearchUserByLocationAsync(double latitude, double longitude, string desireUsername, int count = 50);

	Task<IResult<InstaPlaceList>> SearchPlacesAsync(double latitude, double longitude, PaginationParameters paginationParameters);

	Task<IResult<InstaPlaceList>> SearchPlacesAsync(double latitude, double longitude, string query, PaginationParameters paginationParameters);
}
