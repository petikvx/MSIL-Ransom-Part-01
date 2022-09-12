using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;

namespace InstagramApiSharp.API.Processors;

internal class LocationProcessor : ILocationProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public LocationProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaStory>> GetLocationStoriesAsync(long locationId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri locationFeedUri = UriCreator.GetLocationFeedUri(locationId.ToString());
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, locationFeedUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStory>(response, text);
			}
			InstaLocationFeedResponse response2 = JsonConvert.DeserializeObject<InstaLocationFeedResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetLocationFeedConverter(response2).Convert().Story);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStory>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStory>(exception2);
		}
	}

	public async Task<IResult<InstaPlaceShort>> GetLocationInfoAsync(string externalIdOrFacebookPlacesId)
	{
		try
		{
			Uri locationInfoUri = UriCreator.GetLocationInfoUri(externalIdOrFacebookPlacesId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, locationInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaPlaceShort>(response, text);
			}
			InstaPlaceResponse instaPlaceResponse = JsonConvert.DeserializeObject<InstaPlaceResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetPlaceShortConverter(instaPlaceResponse.Location).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPlaceShort>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaPlaceShort>(exception2);
		}
	}

	public async Task<IResult<InstaSectionMedia>> GetRecentLocationFeedsAsync(long locationId, PaginationParameters paginationParameters)
	{
		return await GetSectionAsync(locationId, paginationParameters, InstaSectionType.Recent);
	}

	public async Task<IResult<InstaSectionMedia>> GetTopLocationFeedsAsync(long locationId, PaginationParameters paginationParameters)
	{
		return await GetSectionAsync(locationId, paginationParameters, InstaSectionType.Ranked);
	}

	public async Task<IResult<InstaLocationShortList>> SearchLocationAsync(double latitude, double longitude, string query)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri locationSearchUri = UriCreator.GetLocationSearchUri();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{
					"latitude",
					latitude.ToString(CultureInfo.InvariantCulture)
				},
				{
					"longitude",
					longitude.ToString(CultureInfo.InvariantCulture)
				},
				{ "rank_token", _user.RankToken }
			};
			if (!string.IsNullOrEmpty(query))
			{
				dictionary.Add("search_query", query);
			}
			else
			{
				dictionary.Add("timestamp", DateTimeHelper.GetUnixTimestampSeconds().ToString());
			}
			if (!Uri.TryCreate(locationSearchUri, dictionary.AsQueryString(), out var result))
			{
				return Result.Fail<InstaLocationShortList>("Unable to create uri for location search");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, result, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaLocationShortList>(response, text);
			}
			InstaLocationSearchResponse response2 = JsonConvert.DeserializeObject<InstaLocationSearchResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetLocationsSearchConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaLocationShortList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaLocationShortList>(exception2);
		}
	}

	public async Task<IResult<InstaUserSearchLocation>> SearchUserByLocationAsync(double latitude, double longitude, string desireUsername, int count = 50)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userSearchByLocationUri = UriCreator.GetUserSearchByLocationUri();
			if (count <= 0)
			{
				count = 30;
			}
			Dictionary<string, string> parameters = new Dictionary<string, string>
			{
				{
					"timezone_offset",
					InstaApiConstants.TIMEZONE_OFFSET.ToString()
				},
				{
					"lat",
					latitude.ToString(CultureInfo.InvariantCulture)
				},
				{
					"lng",
					longitude.ToString(CultureInfo.InvariantCulture)
				},
				{
					"count",
					count.ToString()
				},
				{ "query", desireUsername },
				{ "context", "blended" },
				{ "rank_token", _user.RankToken }
			};
			if (!Uri.TryCreate(userSearchByLocationUri, parameters.AsQueryString(), out var result))
			{
				return Result.Fail<InstaUserSearchLocation>("Unable to create uri for user search by location");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, result, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserSearchLocation>(response, text);
			}
			InstaUserSearchLocation instaUserSearchLocation = JsonConvert.DeserializeObject<InstaUserSearchLocation>(text);
			return (instaUserSearchLocation.Status.ToLower() == "ok") ? Result.Success(instaUserSearchLocation) : Result.UnExpectedResponse<InstaUserSearchLocation>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserSearchLocation>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserSearchLocation>(exception2);
		}
	}

	public async Task<IResult<InstaPlaceList>> SearchPlacesAsync(double latitude, double longitude, PaginationParameters paginationParameters)
	{
		return await SearchPlacesAsync(latitude, longitude, null, paginationParameters);
	}

	public async Task<IResult<InstaPlaceList>> SearchPlacesAsync(double latitude, double longitude, string query, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaPlaceListResponse> result = await SearchPlaces(latitude, longitude, query, paginationParameters);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaPlaceList>(result.Info, null);
			}
			InstaPlaceListResponse placesResponse = result.Value;
			paginationParameters.NextMaxId = placesResponse.RankToken;
			paginationParameters.ExcludeList = placesResponse.ExcludeList;
			int pagesLoaded = 1;
			while (placesResponse.HasMore.HasValue && placesResponse.HasMore.Value && !string.IsNullOrEmpty(placesResponse.RankToken) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaPlaceListResponse> result2 = await SearchPlaces(latitude, longitude, query, paginationParameters);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_0(result2.Value));
				}
				string text2 = (placesResponse.RankToken = (paginationParameters.NextMaxId = result2.Value.RankToken));
				placesResponse.HasMore = result2.Value.HasMore;
				placesResponse.Items.AddRange(result2.Value.Items);
				placesResponse.Status = result2.Value.Status;
				paginationParameters.ExcludeList = result2.Value.ExcludeList;
				pagesLoaded++;
			}
			return Result.Success(ConvertersFabric.Instance.GetPlaceListConverter(placesResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPlaceList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaPlaceList>(exception2);
		}
	}

	private async Task<IResult<InstaPlaceListResponse>> SearchPlaces(double latitude, double longitude, string query, PaginationParameters paginationParameters)
	{
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri searchPlacesUri = UriCreator.GetSearchPlacesUri(InstaApiConstants.TIMEZONE_OFFSET, latitude, longitude, query, paginationParameters.NextMaxId, paginationParameters.ExcludeList);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, searchPlacesUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			InstaPlaceListResponse instaPlaceListResponse = JsonConvert.DeserializeObject<InstaPlaceListResponse>(text);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaPlaceListResponse>(response, text);
			}
			List<InstaPlaceResponse> items = instaPlaceListResponse.Items;
			if (items != null && items.Count > 0)
			{
				foreach (InstaPlaceResponse item in instaPlaceListResponse.Items)
				{
					instaPlaceListResponse.ExcludeList.Add(item.Location.Pk);
				}
			}
			return Result.Success(instaPlaceListResponse);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPlaceListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaPlaceListResponse>(exception2);
		}
	}

	private async Task<IResult<InstaSectionMedia>> GetSectionAsync(long locationId, PaginationParameters paginationParameters, InstaSectionType sectionType)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaSectionMediaListResponse> mediaResponse = await GetSectionMedia(sectionType, locationId, paginationParameters.NextMaxId, paginationParameters.NextPage, paginationParameters.NextMediaIds);
			if (!mediaResponse.Succeeded)
			{
				if (mediaResponse.Value != null)
				{
					Result.Fail(mediaResponse.Info, smethod_1(mediaResponse.Value));
				}
				else
				{
					Result.Fail<InstaSectionMedia>(mediaResponse.Info, null);
				}
			}
			paginationParameters.NextMediaIds = mediaResponse.Value.NextMediaIds;
			paginationParameters.NextPage = mediaResponse.Value.NextPage;
			paginationParameters.NextMaxId = mediaResponse.Value.NextMaxId;
			while (mediaResponse.Value.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaSectionMediaListResponse> result = await GetSectionMedia(sectionType, locationId, paginationParameters.NextMaxId, mediaResponse.Value.NextPage, mediaResponse.Value.NextMediaIds);
				if (result.Succeeded)
				{
					mediaResponse.Value.MoreAvailable = result.Value.MoreAvailable;
					string text2 = (mediaResponse.Value.NextMaxId = (paginationParameters.NextMaxId = result.Value.NextMaxId));
					mediaResponse.Value.AutoLoadMoreEnabled = result.Value.AutoLoadMoreEnabled;
					List<long> list2 = (mediaResponse.Value.NextMediaIds = (paginationParameters.NextMediaIds = result.Value.NextMediaIds));
					int? num2 = (mediaResponse.Value.NextPage = (paginationParameters.NextPage = result.Value.NextPage));
					mediaResponse.Value.Sections.AddRange(result.Value.Sections);
					paginationParameters.PagesLoaded++;
					continue;
				}
				List<InstaSectionMediaResponse> sections = mediaResponse.Value.Sections;
				if (sections != null && sections.Count > 0)
				{
					return Result.Success(smethod_1(mediaResponse.Value));
				}
				return Result.Fail(result.Info, smethod_1(mediaResponse.Value));
			}
			return Result.Success(ConvertersFabric.Instance.GetHashtagMediaListConverter(mediaResponse.Value).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSectionMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSectionMedia>(exception2);
		}
	}

	private async Task<IResult<InstaSectionMediaListResponse>> GetSectionMedia(InstaSectionType sectionType, long locationId, string maxId = null, int? page = null, List<long> nextMediaIds = null)
	{
		try
		{
			Uri locationSectionUri = UriCreator.GetLocationSectionUri(locationId.ToString());
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"rank_token",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{
					"session_id",
					Guid.NewGuid().ToString()
				},
				{
					"tab",
					sectionType.ToString().ToLower()
				}
			};
			if (!string.IsNullOrEmpty(maxId))
			{
				dictionary.Add("max_id", maxId);
			}
			if (page.HasValue && page > 0)
			{
				dictionary.Add("page", page.ToString());
			}
			if (nextMediaIds != null && nextMediaIds.Count > 0)
			{
				string text = "[" + string.Join(",", nextMediaIds) + "]";
				if (sectionType == InstaSectionType.Ranked)
				{
					dictionary.Add("next_media_ids", text.EncodeUri());
				}
				else
				{
					dictionary.Add("next_media_ids", text);
				}
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, locationSectionUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSectionMediaListResponse>(response, text2);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSectionMediaListResponse>(text2));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSectionMediaListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSectionMediaListResponse>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaPlaceList smethod_0(InstaPlaceListResponse placelistResponse)
	{
		return ConvertersFabric.Instance.GetPlaceListConverter(placelistResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaSectionMedia smethod_1(InstaSectionMediaListResponse sectionMediaListResponse)
	{
		return ConvertersFabric.Instance.GetHashtagMediaListConverter(sectionMediaListResponse).Convert();
	}
}
