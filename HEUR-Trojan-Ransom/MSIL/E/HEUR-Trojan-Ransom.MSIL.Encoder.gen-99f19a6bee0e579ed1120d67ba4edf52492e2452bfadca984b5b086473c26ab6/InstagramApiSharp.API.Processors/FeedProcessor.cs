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
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Converters.Json;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;

namespace InstagramApiSharp.API.Processors;

internal class FeedProcessor : IFeedProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public FeedProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaExploreFeed>> GetExploreFeedAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaExploreFeed exploreFeed = new InstaExploreFeed();
		try
		{
			IResult<InstaExploreFeedResponse> feeds = await GetExploreFeed(paginationParameters);
			if (!feeds.Succeeded)
			{
				if (feeds.Value != null)
				{
					return Result.Fail(feeds.Info, smethod_0(feeds.Value));
				}
				return Result.Fail<InstaExploreFeed>(feeds.Info, null);
			}
			InstaExploreFeedResponse feedResponse = feeds.Value;
			paginationParameters.NextMaxId = feedResponse.MaxId;
			paginationParameters.RankToken = feedResponse.RankToken;
			while (feedResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaExploreFeedResponse> result = await GetExploreFeed(paginationParameters);
				if (!result.Succeeded)
				{
					return Result.Fail(result.Info, smethod_0(feeds.Value));
				}
				string text2 = (feedResponse.NextMaxId = (paginationParameters.NextMaxId = result.Value.MaxId));
				text2 = (feedResponse.RankToken = (paginationParameters.RankToken = result.Value.RankToken));
				feedResponse.MoreAvailable = result.Value.MoreAvailable;
				feedResponse.AutoLoadMoreEnabled = result.Value.AutoLoadMoreEnabled;
				feedResponse.NextMaxId = result.Value.NextMaxId;
				feedResponse.ResultsCount = result.Value.ResultsCount;
				feedResponse.Items.Channel = result.Value.Items.Channel;
				feedResponse.Items.Medias.AddRange(result.Value.Items.Medias);
				if (result.Value.Items.StoryTray == null)
				{
					feedResponse.Items.StoryTray = result.Value.Items.StoryTray;
				}
				else
				{
					feedResponse.Items.StoryTray.Id = result.Value.Items.StoryTray.Id;
					feedResponse.Items.StoryTray.IsPortrait = result.Value.Items.StoryTray.IsPortrait;
					feedResponse.Items.StoryTray.Tray.AddRange(result.Value.Items.StoryTray.Tray);
					if (result.Value.Items.StoryTray.TopLive == null)
					{
						feedResponse.Items.StoryTray.TopLive = result.Value.Items.StoryTray.TopLive;
					}
					else
					{
						feedResponse.Items.StoryTray.TopLive.RankedPosition = result.Value.Items.StoryTray.TopLive.RankedPosition;
						feedResponse.Items.StoryTray.TopLive.BroadcastOwners.AddRange(result.Value.Items.StoryTray.TopLive.BroadcastOwners);
					}
				}
				paginationParameters.PagesLoaded++;
			}
			exploreFeed = smethod_0(feedResponse);
			exploreFeed.Medias.Pages = paginationParameters.PagesLoaded;
			exploreFeed.Medias.PageSize = feedResponse.ResultsCount;
			return Result.Success(exploreFeed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaExploreFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, exploreFeed);
		}
	}

	public async Task<IResult<InstaActivityFeed>> GetFollowingRecentActivityFeedAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		Uri followingRecentActivityUri = UriCreator.GetFollowingRecentActivityUri();
		return await GetRecentActivityInternalAsync(followingRecentActivityUri, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetLikedFeedAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetAnyFeeds(UriCreator.GetUserLikeFeedUri(paginationParameters.NextMaxId));
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_1(result.Value));
				}
				return Result.Fail<InstaMediaList>(result.Info, null);
			}
			InstaMediaListResponse mediaResponse = result.Value;
			InstaMediaList mediaList = smethod_1(mediaResponse);
			string text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = mediaResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (mediaResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaMediaListResponse> result2 = await GetAnyFeeds(UriCreator.GetUserLikeFeedUri(paginationParameters.NextMaxId));
				if (result2.Succeeded)
				{
					InstaMediaList collection = smethod_1(result2.Value);
					paginationParameters.PagesLoaded++;
					text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
					mediaResponse.MoreAvailable = result2.Value.MoreAvailable;
					mediaResponse.ResultsCount += result2.Value.ResultsCount;
					mediaResponse.TotalCount += result2.Value.TotalCount;
					mediaList.AddRange(collection);
					continue;
				}
				return Result.Fail(result2.Info, mediaList);
			}
			mediaList.PageSize = mediaResponse.ResultsCount;
			mediaList.Pages = paginationParameters.PagesLoaded;
			return Result.Success(mediaList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMediaList>(exception2);
		}
	}

	public async Task<IResult<InstaActivityFeed>> GetRecentActivityFeedAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		Uri recentActivityUri = UriCreator.GetRecentActivityUri();
		return await GetRecentActivityInternalAsync(recentActivityUri, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetSavedFeedAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetAnyFeeds(UriCreator.GetSavedFeedUri(paginationParameters?.NextMaxId));
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_2(result.Value));
				}
				return Result.Fail<InstaMediaList>(result.Info, null);
			}
			InstaMediaListResponse mediaResponse = result.Value;
			paginationParameters.NextMaxId = mediaResponse.NextMaxId;
			paginationParameters.PagesLoaded++;
			while (mediaResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaMediaListResponse> result2 = await GetAnyFeeds(UriCreator.GetSavedFeedUri(paginationParameters?.NextMaxId));
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_2(mediaResponse));
				}
				string text2 = (mediaResponse.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				mediaResponse.MoreAvailable = result2.Value.MoreAvailable;
				mediaResponse.AutoLoadMoreEnabled = result2.Value.AutoLoadMoreEnabled;
				mediaResponse.ResultsCount += result2.Value.ResultsCount;
				mediaResponse.TotalCount += result2.Value.TotalCount;
				mediaResponse.Medias.AddRange(result2.Value.Medias);
				paginationParameters.PagesLoaded++;
			}
			InstaMediaList instaMediaList = smethod_2(mediaResponse);
			instaMediaList.PageSize = mediaResponse.ResultsCount;
			instaMediaList.Pages = paginationParameters.PagesLoaded;
			return Result.Success(instaMediaList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMediaList>(exception2);
		}
	}

	public async Task<IResult<InstaTagFeed>> GetTagFeedAsync(string tag, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaTagFeed tagFeed = new InstaTagFeed();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaTagFeedResponse> result = await GetTagFeed(tag, paginationParameters);
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_3(result.Value));
				}
				return Result.Fail<InstaTagFeed>(result.Info, null);
			}
			InstaTagFeedResponse feedResponse = result.Value;
			tagFeed = smethod_3(feedResponse);
			paginationParameters.NextMaxId = feedResponse.NextMaxId;
			paginationParameters.PagesLoaded++;
			while (feedResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaTagFeedResponse> result2 = await GetTagFeed(tag, paginationParameters);
				if (result2.Succeeded)
				{
					InstaTagFeed instaTagFeed = smethod_3(result2.Value);
					string text2 = (tagFeed.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
					tagFeed.Medias.AddRange(instaTagFeed.Medias);
					tagFeed.Stories.AddRange(instaTagFeed.Stories);
					feedResponse.MoreAvailable = result2.Value.MoreAvailable;
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, tagFeed);
			}
			return Result.Success(tagFeed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTagFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, tagFeed);
		}
	}

	public async Task<IResult<InstaFeed>> GetUserTimelineFeedAsync(PaginationParameters paginationParameters, string[] seenMediaIds = null, bool refreshRequest = false)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaFeed feed = new InstaFeed();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaFeedResponse> result = await GetUserTimelineFeed(paginationParameters, seenMediaIds, refreshRequest);
			if (!result.Succeeded)
			{
				return Result.Fail(result.Info, feed);
			}
			InstaFeedResponse feedResponse = result.Value;
			feed = smethod_4(feedResponse);
			paginationParameters.NextMaxId = feed.NextMaxId;
			paginationParameters.PagesLoaded++;
			while (feedResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaFeedResponse> result2 = await GetUserTimelineFeed(paginationParameters);
				if (result2.Succeeded)
				{
					InstaFeed instaFeed = smethod_4(result2.Value);
					feed.Medias.AddRange(instaFeed.Medias);
					feed.Stories.AddRange(instaFeed.Stories);
					feedResponse.MoreAvailable = result2.Value.MoreAvailable;
					paginationParameters.NextMaxId = result2.Value.NextMaxId;
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, feed);
			}
			return Result.Success(feed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, feed);
		}
	}

	public async Task<IResult<InstaTopicalExploreFeed>> GetTopicalExploreFeedAsync(PaginationParameters paginationParameters, string clusterId = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaTopicalExploreFeed topicalExploreFeed = new InstaTopicalExploreFeed();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaTopicalExploreFeedResponse> feeds = await GetTopicalExploreFeed(paginationParameters, clusterId);
			if (!feeds.Succeeded)
			{
				if (feeds.Value != null)
				{
					return Result.Fail(feeds.Info, smethod_5(feeds.Value));
				}
				return Result.Fail<InstaTopicalExploreFeed>(feeds.Info, null);
			}
			InstaTopicalExploreFeedResponse feedResponse = feeds.Value;
			paginationParameters.NextMaxId = feedResponse.MaxId;
			paginationParameters.RankToken = feedResponse.RankToken;
			while (feedResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaTopicalExploreFeedResponse> result = await GetTopicalExploreFeed(paginationParameters, clusterId);
				if (!result.Succeeded)
				{
					return Result.Fail(result.Info, smethod_5(feeds.Value));
				}
				string text2 = (feedResponse.NextMaxId = (paginationParameters.NextMaxId = result.Value.MaxId));
				text2 = (feedResponse.RankToken = (paginationParameters.RankToken = result.Value.RankToken));
				feedResponse.MoreAvailable = result.Value.MoreAvailable;
				feedResponse.AutoLoadMoreEnabled = result.Value.AutoLoadMoreEnabled;
				feedResponse.NextMaxId = result.Value.NextMaxId;
				feedResponse.ResultsCount = result.Value.ResultsCount;
				feedResponse.Channel = result.Value.Channel;
				feedResponse.Medias.AddRange(result.Value.Medias);
				feedResponse.TVChannels.AddRange(result.Value.TVChannels);
				feedResponse.Clusters.AddRange(result.Value.Clusters);
				feedResponse.MaxId = result.Value.MaxId;
				feedResponse.HasShoppingChannelContent = result.Value.HasShoppingChannelContent;
				paginationParameters.PagesLoaded++;
			}
			topicalExploreFeed = smethod_5(feedResponse);
			topicalExploreFeed.Medias.Pages = paginationParameters.PagesLoaded;
			topicalExploreFeed.Medias.PageSize = feedResponse.ResultsCount;
			return Result.Success(topicalExploreFeed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTopicalExploreFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, topicalExploreFeed);
		}
	}

	private async Task<IResult<InstaRecentActivityResponse>> GetFollowingActivityWithMaxIdAsync(string maxId)
	{
		try
		{
			Uri followingRecentActivityUri = UriCreator.GetFollowingRecentActivityUri(maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, followingRecentActivityUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaRecentActivityResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRecentActivityResponse>(text, new JsonConverter[1]
			{
				new InstagramApiSharp.Converters.Json.InstaRecentActivityConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRecentActivityResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRecentActivityResponse>(exception2);
		}
	}

	private async Task<IResult<InstaActivityFeed>> GetRecentActivityInternalAsync(Uri uri, PaginationParameters paginationParameters)
	{
		try
		{
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest, HttpCompletionOption.ResponseContentRead);
			InstaActivityFeed activityFeed = new InstaActivityFeed();
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaActivityFeed>(response, text);
			}
			InstaRecentActivityResponse feedPage = JsonConvert.DeserializeObject<InstaRecentActivityResponse>(text, new JsonConverter[1]
			{
				new InstagramApiSharp.Converters.Json.InstaRecentActivityConverter()
			});
			activityFeed.IsOwnActivity = feedPage.IsOwnActivity;
			string nextMaxId = feedPage.NextMaxId;
			activityFeed.Items.AddRange(from converter in feedPage.Stories.Select(ConvertersFabric.Instance.GetSingleRecentActivityConverter)
				select converter.Convert());
			paginationParameters.PagesLoaded++;
			string text3 = (activityFeed.NextMaxId = (paginationParameters.NextMaxId = feedPage.NextMaxId));
			while (!string.IsNullOrEmpty(nextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaRecentActivityResponse> result = await GetFollowingActivityWithMaxIdAsync(nextMaxId);
				if (result.Succeeded)
				{
					nextMaxId = result.Value.NextMaxId;
					activityFeed.Items.AddRange(from converter in feedPage.Stories.Select(ConvertersFabric.Instance.GetSingleRecentActivityConverter)
						select converter.Convert());
					paginationParameters.PagesLoaded++;
					text3 = (activityFeed.NextMaxId = (paginationParameters.NextMaxId = nextMaxId));
					continue;
				}
				return Result.Fail(result.Info, activityFeed);
			}
			return Result.Success(activityFeed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaActivityFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaActivityFeed>(exception2);
		}
	}

	private async Task<IResult<InstaExploreFeedResponse>> GetExploreFeed(PaginationParameters paginationParameters)
	{
		try
		{
			Uri exploreUri = UriCreator.GetExploreUri(paginationParameters.NextMaxId, paginationParameters.RankToken);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, exploreUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaExploreFeedResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaExploreFeedResponse>(text, new JsonConverter[1]
			{
				new InstaExploreFeedDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaExploreFeedResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaExploreFeedResponse>(exception2);
		}
	}

	private async Task<IResult<InstaFeedResponse>> GetUserTimelineFeed(PaginationParameters paginationParameters, string[] seenMediaIds = null, bool refreshRequest = false)
	{
		try
		{
			Uri userFeedUri = UriCreator.GetUserFeedUri(paginationParameters?.NextMaxId);
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "is_prefetch", "0" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{
					"phone_id",
					_deviceInfo.RankToken.ToString()
				},
				{
					"client_session_id",
					Guid.NewGuid().ToString()
				},
				{
					"timezone_offset",
					_instaApi.GetTimezoneOffset().ToString()
				},
				{ "rti_delivery_backend", "0" }
			};
			if (seenMediaIds != null)
			{
				dictionary.Add("seen_posts", seenMediaIds.EncodeList(appendQuotation: false));
			}
			if (refreshRequest)
			{
				dictionary.Add("reason", "pull_to_refresh");
				dictionary.Add("is_pull_to_refresh", "1");
			}
			else
			{
				dictionary.Add("reason", "warm_start_fetch");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, userFeedUri, _deviceInfo, dictionary);
			defaultRequest.Headers.Add("X-Ads-Opt-Out", "0");
			defaultRequest.Headers.Add("X-Google-AD-ID", _deviceInfo.GoogleAdId.ToString());
			defaultRequest.Headers.Add("X-DEVICE-ID", _deviceInfo.DeviceGuid.ToString());
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFeedResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaFeedResponse>(text, new JsonConverter[1]
			{
				new InstaFeedResponseDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFeedResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFeedResponse>(exception2, null);
		}
	}

	private async Task<IResult<InstaTagFeedResponse>> GetTagFeed(string tag, PaginationParameters paginationParameters)
	{
		try
		{
			Uri tagFeedUri = UriCreator.GetTagFeedUri(tag, paginationParameters?.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, tagFeedUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTagFeedResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaTagFeedResponse>(text, new JsonConverter[1]
			{
				new InstaTagFeedDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTagFeedResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTagFeedResponse>(exception2, null);
		}
	}

	private async Task<IResult<InstaMediaListResponse>> GetAnyFeeds(Uri instaUri)
	{
		try
		{
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, instaUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaMediaListResponse>(text, new JsonConverter[1]
			{
				new InstaMediaListDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMediaListResponse>(exception2);
		}
	}

	private async Task<IResult<InstaTopicalExploreFeedResponse>> GetTopicalExploreFeed(PaginationParameters paginationParameters, string clusterId)
	{
		try
		{
			if (string.IsNullOrEmpty(clusterId))
			{
				clusterId = "explore_all:0";
			}
			Uri topicalExploreUri = UriCreator.GetTopicalExploreUri(_deviceInfo.GoogleAdId.ToString(), paginationParameters?.NextMaxId, clusterId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, topicalExploreUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTopicalExploreFeedResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaTopicalExploreFeedResponse>(text, new JsonConverter[1]
			{
				new InstaTopicalExploreFeedDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTopicalExploreFeedResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTopicalExploreFeedResponse>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaExploreFeed smethod_0(InstaExploreFeedResponse exploreFeedResponse)
	{
		return ConvertersFabric.Instance.GetExploreFeedConverter(exploreFeedResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_1(InstaMediaListResponse mediaListResponse)
	{
		return ConvertersFabric.Instance.GetMediaListConverter(mediaListResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_2(InstaMediaListResponse mediaListResponse)
	{
		return ConvertersFabric.Instance.GetMediaListConverter(mediaListResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaTagFeed smethod_3(InstaTagFeedResponse instaTagFeedResponse)
	{
		return ConvertersFabric.Instance.GetTagFeedConverter(instaTagFeedResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaFeed smethod_4(InstaFeedResponse instaFeedResponse)
	{
		return ConvertersFabric.Instance.GetFeedConverter(instaFeedResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaTopicalExploreFeed smethod_5(InstaTopicalExploreFeedResponse topicalExploreFeedResponse)
	{
		return ConvertersFabric.Instance.GetTopicalExploreFeedConverter(topicalExploreFeedResponse).Convert();
	}
}
