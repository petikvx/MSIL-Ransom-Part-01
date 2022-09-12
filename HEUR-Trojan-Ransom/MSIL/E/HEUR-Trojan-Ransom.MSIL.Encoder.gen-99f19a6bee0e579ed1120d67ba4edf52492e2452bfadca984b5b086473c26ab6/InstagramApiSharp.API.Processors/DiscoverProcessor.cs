using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class DiscoverProcessor : IDiscoverProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public DiscoverProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> ClearRecentSearchsAsync()
	{
		try
		{
			Uri clearSearchHistoryUri = UriCreator.GetClearSearchHistoryUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, clearSearchHistoryUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text).Status == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<bool>(exception2);
		}
	}

	public async Task<IResult<InstaUserChainingList>> GetChainingUsersAsync()
	{
		try
		{
			Uri discoverChainingUri = UriCreator.GetDiscoverChainingUri(_user.LoggedInUser.Pk);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, discoverChainingUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserChainingList>(response, text);
			}
			InstaUserChainingContainerResponse response2 = JsonConvert.DeserializeObject<InstaUserChainingContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetUserChainingListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserChainingList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserChainingList>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverRecentSearches>> GetRecentSearchesAsync()
	{
		try
		{
			Uri recentSearchUri = UriCreator.GetRecentSearchUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, recentSearchUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverRecentSearches>(response, text);
			}
			InstaDiscoverRecentSearchesResponse response2 = JsonConvert.DeserializeObject<InstaDiscoverRecentSearchesResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetDiscoverRecentSearchesConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverRecentSearches>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverRecentSearches>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverTopSearches>> GetTopSearchesAsync(string querry = "", InstaDiscoverSearchType searchType = InstaDiscoverSearchType.Users, int timezone_offset = 12600)
	{
		try
		{
			Uri topSearchUri = UriCreator.GetTopSearchUri(_user.RankToken, querry, searchType, timezone_offset);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, topSearchUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverTopSearches>(response, text);
			}
			InstaDiscoverTopSearchesResponse response2 = JsonConvert.DeserializeObject<InstaDiscoverTopSearchesResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetDiscoverTopSearchesConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverTopSearches>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverTopSearches>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverSuggestedSearches>> GetSuggestedSearchesAsync(InstaDiscoverSearchType searchType = InstaDiscoverSearchType.Users)
	{
		try
		{
			Uri suggestedSearchUri = UriCreator.GetSuggestedSearchUri(searchType);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, suggestedSearchUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverSuggestedSearches>(response, text);
			}
			InstaDiscoverSuggestedSearchesResponse response2 = JsonConvert.DeserializeObject<InstaDiscoverSuggestedSearchesResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetDiscoverSuggestedSearchesConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverSuggestedSearches>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverSuggestedSearches>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverSearchResult>> SearchPeopleAsync(string query, int count = 30)
	{
		try
		{
			Uri searchUserUri = UriCreator.GetSearchUserUri(query, count);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, searchUserUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverSearchResult>(response, text);
			}
			InstaDiscoverSearchResultResponse response2 = JsonConvert.DeserializeObject<InstaDiscoverSearchResultResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetDiscoverSearchResultConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverSearchResult>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverSearchResult>(exception2);
		}
	}

	public async Task<IResult<InstaContactUserList>> SyncContactsAsync(params InstaContact[] instaContacts)
	{
		try
		{
			InstaContactList instaContactList = new InstaContactList();
			instaContactList.AddRange(instaContacts);
			return await SyncContactsAsync(instaContactList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaContactUserList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaContactUserList>(exception2);
		}
	}

	public async Task<IResult<InstaContactUserList>> SyncContactsAsync(InstaContactList instaContacts)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri syncContactsUri = UriCreator.GetSyncContactsUri();
			string value = JsonConvert.SerializeObject(instaContacts);
			Dictionary<string, string> data = new Dictionary<string, string> { { "contacts", value } };
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, syncContactsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaContactUserList>(response, text);
			}
			InstaContactUserListResponse response2 = JsonConvert.DeserializeObject<InstaContactUserListResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetUserContactListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaContactUserList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaContactUserList>(exception2);
		}
	}

	private async Task<IResult<object>> DiscoverPeopleAsync()
	{
		try
		{
			Uri discoverPeopleUri = UriCreator.GetDiscoverPeopleUri();
			JObject data = new JObject
			{
				{
					"phone_id",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "module", "discover_people" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "paginate", "true" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, discoverPeopleUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDefaultResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaDefaultResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDefaultResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDefaultResponse>(exception2);
		}
	}
}
