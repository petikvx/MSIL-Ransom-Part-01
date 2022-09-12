using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.Models.Hashtags;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Converters.Json;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class HashtagProcessor : IHashtagProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public HashtagProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> FollowHashtagAsync(string tagname)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri followHashtagUri = UriCreator.GetFollowHashtagUri(tagname);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, followHashtagUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
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

	public async Task<IResult<InstaHashtagSearch>> GetFollowingHashtagsInfoAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaHashtagSearch tags = new InstaHashtagSearch();
		try
		{
			Uri followingTagsInfoUri = UriCreator.GetFollowingTagsInfoUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, followingTagsInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHashtagSearch>(response, text);
			}
			InstaHashtagSearchResponse response2 = JsonConvert.DeserializeObject<InstaHashtagSearchResponse>(text, new JsonConverter[1]
			{
				new InstaHashtagSuggestedDataConverter()
			});
			tags = ConvertersFabric.Instance.GetHashTagsSearchConverter(response2).Convert();
			return Result.Success(tags);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHashtagSearch>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, tags);
		}
	}

	public async Task<IResult<InstaHashtag>> GetHashtagInfoAsync(string tagname)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri tagInfoUri = UriCreator.GetTagInfoUri(tagname);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, tagInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHashtag>(response, text);
			}
			InstaHashtagResponse response2 = JsonConvert.DeserializeObject<InstaHashtagResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetHashTagConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHashtag>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHashtag>(exception2);
		}
	}

	public async Task<IResult<InstaHashtagStory>> GetHashtagStoriesAsync(string tagname)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri hashtagStoryUri = UriCreator.GetHashtagStoryUri(tagname);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, hashtagStoryUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHashtagStory>(response, text);
			}
			InstaHashtagStoryContainerResponse instaHashtagStoryContainerResponse = JsonConvert.DeserializeObject<InstaHashtagStoryContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetHashtagStoryConverter(instaHashtagStoryContainerResponse.Story).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHashtagStory>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHashtagStory>(exception2);
		}
	}

	public async Task<IResult<InstaSectionMedia>> GetRecentHashtagMediaListAsync(string tagname, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaSectionMediaListResponse> mediaResponse = await GetHashtagSection(tagname, Guid.NewGuid().ToString(), paginationParameters.NextMaxId, recent: true);
			if (!mediaResponse.Succeeded)
			{
				if (mediaResponse.Value != null)
				{
					Result.Fail(mediaResponse.Info, smethod_0(mediaResponse.Value));
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
				IResult<InstaSectionMediaListResponse> result = await GetHashtagSection(tagname, Guid.NewGuid().ToString(), paginationParameters.NextMaxId, recent: true);
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
				if (mediaResponse.Value.Sections != null && mediaResponse.Value.Sections.Any())
				{
					return Result.Success(smethod_0(mediaResponse.Value));
				}
				return Result.Fail(result.Info, smethod_0(mediaResponse.Value));
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

	public async Task<IResult<InstaHashtagSearch>> GetSuggestedHashtagsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaHashtagSearch tags = new InstaHashtagSearch();
		try
		{
			Uri suggestedTagsUri = UriCreator.GetSuggestedTagsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, suggestedTagsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHashtagSearch>(response, text);
			}
			InstaHashtagSearchResponse response2 = JsonConvert.DeserializeObject<InstaHashtagSearchResponse>(text, new JsonConverter[1]
			{
				new InstaHashtagSuggestedDataConverter()
			});
			tags = ConvertersFabric.Instance.GetHashTagsSearchConverter(response2).Convert();
			return Result.Success(tags);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHashtagSearch>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, tags);
		}
	}

	public async Task<IResult<InstaSectionMedia>> GetTopHashtagMediaListAsync(string tagname, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaSectionMediaListResponse> mediaResponse = await GetHashtagSection(tagname, Guid.NewGuid().ToString(), paginationParameters.NextMaxId);
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
				IResult<InstaSectionMediaListResponse> result = await GetHashtagSection(tagname, Guid.NewGuid().ToString(), paginationParameters.NextMaxId);
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
				if (mediaResponse.Value.Sections != null && mediaResponse.Value.Sections.Any())
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

	public async Task<IResult<InstaHashtagSearch>> SearchHashtagAsync(string query, IEnumerable<long> excludeList, string rankToken)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		HttpStatusCode RequestHeaderFieldsTooLarge = HttpStatusCode.RequestHeaderFieldsTooLarge;
		int count = 50;
		InstaHashtagSearch tags = new InstaHashtagSearch();
		try
		{
			Uri searchTagUri = UriCreator.GetSearchTagUri(query, count, excludeList, rankToken);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, searchTagUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == RequestHeaderFieldsTooLarge)
			{
				return Result.Success(tags);
			}
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHashtagSearch>(response, text);
			}
			InstaHashtagSearchResponse response2 = JsonConvert.DeserializeObject<InstaHashtagSearchResponse>(text, new JsonConverter[1]
			{
				new InstaHashtagSearchDataConverter()
			});
			tags = ConvertersFabric.Instance.GetHashTagsSearchConverter(response2).Convert();
			if (tags.Any() && excludeList != null && excludeList.Contains(tags.First().Id))
			{
				tags.RemoveAt(0);
			}
			if (!tags.Any())
			{
				tags = new InstaHashtagSearch();
			}
			return Result.Success(tags);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHashtagSearch>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, tags);
		}
	}

	public async Task<IResult<bool>> UnFollowHashtagAsync(string tagname)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri unFollowHashtagUri = UriCreator.GetUnFollowHashtagUri(tagname);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, unFollowHashtagUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
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

	private async Task<IResult<InstaSectionMediaListResponse>> GetHashtagRecentMedia(string tagname, string rankToken = null, string maxId = null, int? page = null, List<long> nextMediaIds = null)
	{
		try
		{
			Uri hashtagRecentMediaUri = UriCreator.GetHashtagRecentMediaUri(tagname, rankToken, maxId, page, nextMediaIds);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, hashtagRecentMediaUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSectionMediaListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSectionMediaListResponse>(text));
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

	private async Task<IResult<InstaSectionMediaListResponse>> GetHashtagSection(string tagname, string rankToken = null, string maxId = null, bool recent = false)
	{
		try
		{
			Uri hashtagSectionUri = UriCreator.GetHashtagSectionUri(tagname);
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"include_persistent",
					(!recent) ? "true" : "false"
				},
				{ "rank_token", rankToken }
			};
			if (recent)
			{
				dictionary.Add("tab", "recent");
			}
			else
			{
				dictionary.Add("supported_tabs", new JArray("top", "recent", "places", "discover").ToString());
			}
			if (!string.IsNullOrEmpty(maxId))
			{
				dictionary.Add("max_id", maxId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, hashtagSectionUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSectionMediaListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSectionMediaListResponse>(text));
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
	internal static InstaSectionMedia smethod_0(InstaSectionMediaListResponse hashtagMediaListResponse)
	{
		return ConvertersFabric.Instance.GetHashtagMediaListConverter(hashtagMediaListResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaSectionMedia smethod_1(InstaSectionMediaListResponse hashtagMediaListResponse)
	{
		return ConvertersFabric.Instance.GetHashtagMediaListConverter(hashtagMediaListResponse).Convert();
	}
}
