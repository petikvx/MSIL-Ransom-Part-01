using System;
using System.Collections.Generic;
using System.IO;
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
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class StoryProcessor : IStoryProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public StoryProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> AnswerToStoryQuestionAsync(string storyId, long questionId, string responseText)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storyQuestionResponseUri = UriCreator.GetStoryQuestionResponseUri(storyId, questionId);
			JObject data = new JObject
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
					"response",
					responseText ?? string.Empty
				},
				{ "type", "text" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, storyQuestionResponseUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(text);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (instaDefault.Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, instaDefault.Message, null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail(exception2, resValue: false);
		}
	}

	public async Task<IResult<bool>> AppendToHighlightFeedAsync(string highlightId, string mediaId)
	{
		return await AppendOrDeleteHighlight(highlightId, mediaId, delete: false);
	}

	public async Task<IResult<InstaHighlightFeed>> CreateHighlightFeedAsync(string mediaId, string title, float cropWidth, float cropHeight)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject jObject = new JObject();
			jObject.Add("media_id", mediaId);
			jObject.Add("crop_rect", new JArray { 0.0, cropWidth, 1.0, cropHeight }.ToString(Formatting.None));
			string text = jObject.ToString(Formatting.None);
			jObject = new JObject();
			jObject.Add("source", "self_profile");
			jObject.Add("_csrftoken", _user.CsrfToken);
			jObject.Add("_uid", _user.LoggedInUser.Pk);
			jObject.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			jObject.Add("cover", text);
			jObject.Add("title", title);
			jObject.Add("media_ids", "[" + new string[1] { mediaId }.EncodeList() + "]");
			JObject data = jObject;
			Uri highlightCreateUri = UriCreator.GetHighlightCreateUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, highlightCreateUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHighlightFeed>(response, text2);
			}
			InstaHighlightReelResponse response2 = JsonConvert.DeserializeObject<InstaHighlightReelResponse>(text2, new JsonConverter[1]
			{
				new InstaHighlightReelDataConverter()
			});
			return Result.Success(ConvertersFabric.Instance.GetHighlightReelConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHighlightFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHighlightFeed>(exception2);
		}
	}

	public async Task<IResult<bool>> DeleteHighlightFeedAsync(string highlightId, string mediaId)
	{
		return await AppendOrDeleteHighlight(highlightId, mediaId, delete: true);
	}

	public async Task<IResult<bool>> DeleteStoryAsync(string storyMediaId, InstaSharingType sharingType = InstaSharingType.Video)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteStoryMediaUri = UriCreator.GetDeleteStoryMediaUri(storyMediaId, sharingType);
			JObject data = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "media_id", storyMediaId }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, deleteStoryMediaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<DeleteResponse>(text).IsDeleted);
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

	public async Task<IResult<bool>> FollowCountdownStoryAsync(long countdownId)
	{
		return await FollowUnfollowCountdown(UriCreator.GetStoryFollowCountdownUri(countdownId));
	}

	public async Task<IResult<InstaUserShortList>> GetBlockedUsersFromStoriesAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList list = new InstaUserShortList();
		try
		{
			Uri blockedStoriesUri = UriCreator.GetBlockedStoriesUri();
			JObject data = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, blockedStoriesUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			JsonConvert.DeserializeObject<InstaDefault>(text);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			list.AddRange(from converter in instaUserListShortResponse.Items.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert());
			return Result.Success(list);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, list, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail(exception2, list);
		}
	}

	public async Task<IResult<InstaStoryCountdownList>> GetCountdownsStoriesAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storyCountdownMediaUri = UriCreator.GetStoryCountdownMediaUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, storyCountdownMediaUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryCountdownList>(response, text);
			}
			InstaStoryCountdownListResponse response2 = JsonConvert.DeserializeObject<InstaStoryCountdownListResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetStoryCountdownListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryCountdownList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryCountdownList>(exception2);
		}
	}

	public async Task<IResult<InstaHighlightFeeds>> GetHighlightFeedsAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri highlightFeedsUri = UriCreator.GetHighlightFeedsUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, highlightFeedsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHighlightFeeds>(response, text);
			}
			InstaHighlightFeedsResponse response2 = JsonConvert.DeserializeObject<InstaHighlightFeedsResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetHighlightFeedsConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHighlightFeeds>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHighlightFeeds>(exception2);
		}
	}

	public async Task<IResult<InstaHighlightShortList>> GetHighlightsArchiveAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri highlightsArchiveUri = UriCreator.GetHighlightsArchiveUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, highlightsArchiveUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHighlightShortList>(response, text);
			}
			InstaHighlightShortListResponse response2 = JsonConvert.DeserializeObject<InstaHighlightShortListResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetHighlightShortListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHighlightShortList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHighlightShortList>(exception2);
		}
	}

	public async Task<IResult<InstaHighlightSingleFeed>> GetHighlightsArchiveMediasAsync(string highlightId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(highlightId))
			{
				throw new ArgumentNullException("highlightId cannot be null or empty");
			}
			Uri reelMediaUri = UriCreator.GetReelMediaUri();
			JObject jObject = new JObject();
			jObject.Add("supported_capabilities_new", InstaApiConstants.SupportedCapabalities.ToString(Formatting.None));
			jObject.Add("source", "reel_highlights_gallery");
			jObject.Add("_csrftoken", _user.CsrfToken);
			jObject.Add("_uid", _user.LoggedInUser.Pk.ToString());
			jObject.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			jObject.Add("user_ids", new JArray(highlightId));
			JObject data = jObject;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, reelMediaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHighlightSingleFeed>(response, text);
			}
			InstaHighlightReelResponse instaHighlightReelResponse = JsonConvert.DeserializeObject<InstaHighlightReelResponse>(text, new JsonConverter[1]
			{
				new InstaHighlightReelsListDataConverter()
			});
			return (instaHighlightReelResponse?.Reel != null) ? Result.Success(ConvertersFabric.Instance.GetHighlightReelConverter(instaHighlightReelResponse).Convert()) : Result.Fail<InstaHighlightSingleFeed>("No reels found");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHighlightSingleFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHighlightSingleFeed>(exception2);
		}
	}

	public async Task<IResult<InstaHighlightSingleFeed>> GetHighlightMediasAsync(string highlightId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(highlightId))
			{
				throw new ArgumentNullException("highlightId cannot be null or empty");
			}
			Uri reelMediaUri = UriCreator.GetReelMediaUri();
			JObject jObject = new JObject();
			jObject.Add("supported_capabilities_new", InstaApiConstants.SupportedCapabalities.ToString(Formatting.None));
			jObject.Add("source", "profile");
			jObject.Add("_csrftoken", _user.CsrfToken);
			jObject.Add("_uid", _user.LoggedInUser.Pk.ToString());
			jObject.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			jObject.Add("user_ids", new JArray(highlightId));
			JObject data = jObject;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, reelMediaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaHighlightSingleFeed>(response, text);
			}
			InstaHighlightReelResponse instaHighlightReelResponse = JsonConvert.DeserializeObject<InstaHighlightReelResponse>(text, new JsonConverter[1]
			{
				new InstaHighlightReelsListDataConverter()
			});
			return (instaHighlightReelResponse?.Reel != null) ? Result.Success(ConvertersFabric.Instance.GetHighlightReelConverter(instaHighlightReelResponse).Convert()) : Result.Fail<InstaHighlightSingleFeed>("No reels found");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaHighlightSingleFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaHighlightSingleFeed>(exception2);
		}
	}

	public async Task<IResult<InstaStoryFeed>> GetStoryFeedAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storyFeedUri = UriCreator.GetStoryFeedUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, storyFeedUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryFeed>(response, text);
			}
			InstaStoryFeedResponse response2 = JsonConvert.DeserializeObject<InstaStoryFeedResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetStoryFeedConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryFeed>(exception2);
		}
	}

	public async Task<IResult<InstaReelStoryMediaViewers>> GetStoryMediaViewersAsync(string storyMediaId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaReelStoryMediaViewersResponse> result = await GetStoryMediaViewers(storyMediaId, paginationParameters?.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaReelStoryMediaViewers>(result.Info, null);
			}
			InstaReelStoryMediaViewersResponse storyMediaViewersResponse = result.Value;
			paginationParameters.NextMaxId = storyMediaViewersResponse.NextMaxId;
			while (!string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				paginationParameters.PagesLoaded++;
				IResult<InstaReelStoryMediaViewersResponse> result2 = await GetStoryMediaViewers(storyMediaId, paginationParameters.NextMaxId);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_0(result2.Value));
				}
				string text2 = (storyMediaViewersResponse.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				storyMediaViewersResponse.Users.AddRange(result2.Value.Users);
			}
			return Result.Success(smethod_0(storyMediaViewersResponse));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaReelStoryMediaViewers>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaReelStoryMediaViewers>(exception2);
		}
	}

	public async Task<IResult<InstaStoryPollVotersList>> GetStoryPollVotersAsync(string storyMediaId, string pollId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaStoryPollVotersListResponse> result = await GetStoryPollVoters(storyMediaId, pollId, paginationParameters?.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaStoryPollVotersList>(result.Info, null);
			}
			InstaStoryPollVotersListResponse votersResponse = result.Value;
			paginationParameters.NextMaxId = votersResponse.MaxId;
			while (votersResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				paginationParameters.PagesLoaded++;
				IResult<InstaStoryPollVotersListResponse> result2 = await GetStoryPollVoters(storyMediaId, pollId, paginationParameters.NextMaxId);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_1(result2.Value));
				}
				string text2 = (votersResponse.MaxId = (paginationParameters.NextMaxId = result2.Value.MaxId));
				votersResponse.Voters.AddRange(result2.Value.Voters);
				votersResponse.LatestPollVoteTime = result2.Value.LatestPollVoteTime;
				votersResponse.MoreAvailable = result2.Value.MoreAvailable;
			}
			return Result.Success(smethod_1(votersResponse));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryPollVotersList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryPollVotersList>(exception2);
		}
	}

	public async Task<IResult<InstaStory>> GetUserStoryAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userStoryUri = UriCreator.GetUserStoryUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userStoryUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				Result.UnExpectedResponse<InstaStory>(response, text);
			}
			InstaStoryResponse storyItem = JsonConvert.DeserializeObject<InstaStoryResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetStoryConverter(storyItem).Convert());
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

	public async Task<IResult<InstaReelFeed>> GetUserStoryFeedAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaReelFeed feed = new InstaReelFeed();
		try
		{
			Uri userReelFeedUri = UriCreator.GetUserReelFeedUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userReelFeedUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaReelFeed>(response, text);
			}
			InstaReelFeedResponse response2 = JsonConvert.DeserializeObject<InstaReelFeedResponse>(text);
			feed = ConvertersFabric.Instance.GetReelFeedConverter(response2).Convert();
			return Result.Success(feed);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaReelFeed>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, feed);
		}
	}

	public async Task<IResult<bool>> MarkStoryAsSeenAsync(string storyMediaId, long takenAtUnix)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri seenMediaStoryUri = UriCreator.GetSeenMediaStoryUri();
			string propertyName = storyMediaId + "_" + storyMediaId.Split(new char[1] { '_' })[1];
			long num = DateTime.UtcNow.ToUnixTime();
			JObject value = new JObject { 
			{
				propertyName,
				new JArray($"{takenAtUnix}_{num}")
			} };
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
				},
				{ "container_module", "feed_timeline" },
				{
					"live_vods_skipped",
					new JObject()
				},
				{
					"nuxes_skipped",
					new JObject()
				},
				{
					"nuxes",
					new JObject()
				},
				{ "reels", value },
				{
					"live_vods",
					new JObject()
				},
				{
					"reel_media_skipped",
					new JObject()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, seenMediaStoryUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> MarkHighlightAsSeenAsync(string mediaId, string highlightId, long takenAtUnix)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri seenMediaStoryUri = UriCreator.GetSeenMediaStoryUri();
			string propertyName = mediaId + "_" + highlightId;
			long num = DateTime.UtcNow.ToUnixTime();
			JObject value = new JObject { 
			{
				propertyName,
				new JArray($"{takenAtUnix}_{num}")
			} };
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
				},
				{ "container_module", "profile" },
				{
					"live_vods_skipped",
					new JObject()
				},
				{
					"nuxes_skipped",
					new JObject()
				},
				{
					"nuxes",
					new JObject()
				},
				{ "reels", value },
				{
					"live_vods",
					new JObject()
				},
				{
					"reel_media_skipped",
					new JObject()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, seenMediaStoryUri, _deviceInfo, data);
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

	public async Task<IResult<InstaStoryMedia>> ShareMediaAsStoryAsync(InstaImage image, InstaMediaStoryUpload mediaStoryUpload)
	{
		return await ShareMediaAsStoryAsync(null, image, mediaStoryUpload);
	}

	public async Task<IResult<InstaStoryMedia>> ShareMediaAsStoryAsync(Action<InstaUploaderProgress> progress, InstaImage image, InstaMediaStoryUpload mediaStoryUpload)
	{
		if (image == null)
		{
			return Result.Fail<InstaStoryMedia>("Image cannot be null");
		}
		if (mediaStoryUpload == null)
		{
			return Result.Fail<InstaStoryMedia>("Media story upload option cannot be null");
		}
		return await UploadStoryPhotoWithUrlAsync(progress, image, string.Empty, null, new InstaStoryUploadOptions
		{
			MediaStory = mediaStoryUpload
		});
	}

	public async Task<IResult<InstaSharing>> ShareStoryAsync(string reelId, string storyMediaId, string threadId, string text, InstaSharingType sharingType = InstaSharingType.Video)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storyShareUri = UriCreator.GetStoryShareUri(sharingType.ToString().ToLower());
			JObject data = new JObject
			{
				{ "action", "send_item" },
				{
					"thread_ids",
					"[" + threadId + "]"
				},
				{ "unified_broadcast_format", "1" },
				{ "reel_id", reelId },
				{
					"text",
					text ?? ""
				},
				{ "story_media_id", storyMediaId },
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, storyShareUri, _deviceInfo, data);
			signedRequest.Headers.Add("Host", "i.instagram.com");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSharing>(response, text2);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSharing>(text2));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSharing>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSharing>(exception2);
		}
	}

	public async Task<IResult<bool>> ReplyToStoryAsync(string storyMediaId, long userId, string text)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastReelShareUri = UriCreator.GetBroadcastReelShareUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"recipient_users",
					$"[[{userId}]]"
				},
				{ "action", "send_item" },
				{ "client_context", value },
				{ "media_id", storyMediaId },
				{ "_csrftoken", _user.CsrfToken },
				{
					"text",
					text ?? string.Empty
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, broadcastReelShareUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text2);
			}
			return (JsonConvert.DeserializeObject<InstaDefault>(text2).Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text2);
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

	public async Task<IResult<bool>> UnFollowCountdownStoryAsync(long countdownId)
	{
		return await FollowUnfollowCountdown(UriCreator.GetStoryUnFollowCountdownUri(countdownId));
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(InstaImage image, string caption, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryPhotoAsync(null, image, caption, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, string caption, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryPhotoWithUrlAsync(progress, image, caption, null, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryPhotoWithUrlAsync(InstaImage image, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryPhotoWithUrlAsync(null, image, caption, uri, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryPhotoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaImage image, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			if (uploadOptions != null && uploadOptions.Mentions?.Count > 0)
			{
				IRequestDelay currentDelay = _instaApi.GetRequestDelay();
				_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
				foreach (InstaStoryMentionUpload t in uploadOptions.Mentions)
				{
					try
					{
						bool tried = false;
						while (true)
						{
							IResult<InstaUser> result = await _instaApi.UserProcessor.GetUserAsync(t.Username);
							if (!result.Succeeded)
							{
								if (!tried)
								{
									tried = true;
									continue;
								}
								break;
							}
							t.Pk = result.Value.Pk;
							break;
						}
					}
					catch
					{
					}
				}
				_instaApi.SetRequestDelay(currentDelay);
			}
			if (uploadOptions != null && uploadOptions.Questions?.Count > 0)
			{
				try
				{
					bool tried = false;
					_ = string.Empty;
					string profilePicture;
					while (true)
					{
						IResult<InstaUser> result2 = await _instaApi.UserProcessor.GetUserAsync(_user.UserName.ToLower());
						if (!result2.Succeeded)
						{
							if (!tried)
							{
								tried = true;
								continue;
							}
							profilePicture = _user.LoggedInUser.ProfilePicture;
							break;
						}
						profilePicture = result2.Value.ProfilePicture;
						break;
					}
					foreach (InstaStoryQuestionUpload question in uploadOptions.Questions)
					{
						question.ProfilePicture = profilePicture;
					}
				}
				catch
				{
				}
			}
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(image.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
			string waterfallId = Guid.NewGuid().ToString();
			string photoEntityName = $"{uploadId}_0_{hashCode}";
			Uri photoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode);
			upProgress.UploadId = uploadId;
			progress?.Invoke(upProgress);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"media_info",
					new JObject
					{
						{ "capture_mode", "normal" },
						{ "media_type", 1 },
						{ "caption", caption },
						{
							"mentions",
							new JArray()
						},
						{
							"hashtags",
							new JArray()
						},
						{
							"locations",
							new JArray()
						},
						{
							"stickers",
							new JArray()
						}
					}
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, UriCreator.GetStoryMediaInfoUploadUri(), _deviceInfo, data);
			await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync();
			JObject value = new JObject
			{
				{ "upload_id", uploadId },
				{ "media_type", "1" },
				{ "retry_context", "{\"num_step_auto_retry\":0,\"num_reupload\":0,\"num_step_manual_retry\":0}" },
				{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
			};
			string photoUploadParams = JsonConvert.SerializeObject(value);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, photoUri, _deviceInfo);
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", photoUploadParams);
			HttpResponseMessage response2 = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response2.Content.ReadAsStringAsync();
			if (response2.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaStoryMedia>(response2, json);
			}
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			byte[] array = image.ImageBytes ?? File.ReadAllBytes(image.Uri);
			ByteArrayContent byteArrayContent = new ByteArrayContent(array);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, photoUri, _deviceInfo);
			signedRequest.Content = byteArrayContent;
			signedRequest.Headers.Add("X-Entity-Type", "image/jpeg");
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", photoUploadParams);
			signedRequest.Headers.Add("X-Entity-Name", photoEntityName);
			signedRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			response2 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response2.Content.ReadAsStringAsync();
			if (response2.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Uploaded;
				progress?.Invoke(upProgress);
				await Task.Delay(5000);
				return await ConfigureStoryPhotoAsync(progress, upProgress, image, uploadId, caption, uri, uploadOptions);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaStoryMedia>(response2, json);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryMedia>(exception2);
		}
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryVideoAsync(InstaVideoUpload video, string caption, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryVideoAsync(null, video, caption, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryVideoWithUrlAsync(progress, video, caption, null, uploadOptions);
	}

	public async Task<IResult<bool>> UploadStoryVideoAsync(InstaVideoUpload video, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(null, isDirectVideo: false, isDisappearingVideo: false, "", InstaViewMode.Replayable, storyType, null, threadIds.EncodeList(), video, null, uploadOptions);
	}

	public async Task<IResult<bool>> UploadStoryVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(progress, isDirectVideo: false, isDisappearingVideo: false, "", InstaViewMode.Replayable, storyType, null, threadIds.EncodeList(), video, null, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryVideoWithUrlAsync(InstaVideoUpload video, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		return await UploadStoryVideoWithUrlAsync(null, video, caption, uri, uploadOptions);
	}

	public async Task<IResult<InstaStoryMedia>> UploadStoryVideoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.GetHashCode();
			int hashCode2 = Path.GetFileName(video.VideoThumbnail.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
			string waterfallId = Guid.NewGuid().ToString();
			string videoEntityName = $"{uploadId}_0_{hashCode}";
			Uri videoUri = UriCreator.GetStoryUploadVideoUri(uploadId, hashCode);
			string photoEntityName = $"{uploadId}_0_{hashCode2}";
			Uri photoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode2);
			upProgress.UploadId = uploadId;
			progress?.Invoke(upProgress);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"media_info",
					new JObject
					{
						{ "capture_mode", "normal" },
						{ "media_type", 2 },
						{ "caption", caption },
						{
							"mentions",
							new JArray()
						},
						{
							"hashtags",
							new JArray()
						},
						{
							"locations",
							new JArray()
						},
						{
							"stickers",
							new JArray()
						}
					}
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, UriCreator.GetStoryMediaInfoUploadUri(), _deviceInfo, data);
			await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync();
			JObject value = new JObject
			{
				{ "upload_media_height", "0" },
				{ "upload_media_width", "0" },
				{ "upload_media_duration_ms", "46000" },
				{ "upload_id", uploadId },
				{ "for_album", "1" },
				{ "retry_context", "{\"num_step_auto_retry\":0,\"num_reupload\":0,\"num_step_manual_retry\":0}" },
				{ "media_type", "2" }
			};
			string videoUploadParams = JsonConvert.SerializeObject(value);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, videoUri, _deviceInfo);
			signedRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
			HttpResponseMessage response4 = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response4.Content.ReadAsStringAsync();
			if (response4.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaStoryMedia>(response4, json);
			}
			byte[] array = video.Video.VideoBytes ?? File.ReadAllBytes(video.Video.Uri);
			ByteArrayContent byteArrayContent = new ByteArrayContent(array);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, videoUri, _deviceInfo);
			signedRequest.Content = byteArrayContent;
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			if (Path.GetExtension(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.Replace(".", "").ToLower() == "mov")
			{
				signedRequest.Headers.Add("X-Entity-Type", "image/quicktime");
			}
			else
			{
				signedRequest.Headers.Add("X-Entity-Type", "image/mp4");
			}
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
			signedRequest.Headers.Add("X-Entity-Name", videoEntityName);
			signedRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
			signedRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
			response4 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response4.Content.ReadAsStringAsync();
			if (response4.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaStoryMedia>(response4, json);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			JObject value2 = new JObject
			{
				{ "retry_context", "{\"num_step_auto_retry\":0,\"num_reupload\":0,\"num_step_manual_retry\":0}" },
				{ "media_type", "2" },
				{ "upload_id", uploadId },
				{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
			};
			string photoUploadParams = JsonConvert.SerializeObject(value2);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, photoUri, _deviceInfo);
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", photoUploadParams);
			response4 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response4.Content.ReadAsStringAsync();
			if (response4.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaStoryMedia>(response4, json);
			}
			upProgress.UploadState = InstaUploadState.UploadingThumbnail;
			progress?.Invoke(upProgress);
			byte[] array2 = video.VideoThumbnail.ImageBytes ?? File.ReadAllBytes(video.VideoThumbnail.Uri);
			ByteArrayContent byteArrayContent2 = new ByteArrayContent(array2);
			byteArrayContent2.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent2.Headers.Add("Content-Type", "application/octet-stream");
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, photoUri, _deviceInfo);
			signedRequest.Content = byteArrayContent2;
			signedRequest.Headers.Add("X-Entity-Type", "image/jpeg");
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", photoUploadParams);
			signedRequest.Headers.Add("X-Entity-Name", photoEntityName);
			signedRequest.Headers.Add("X-Entity-Length", array2.Length.ToString());
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			response4 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response4.Content.ReadAsStringAsync();
			if (response4.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.ThumbnailUploaded;
				progress?.Invoke(upProgress);
				await Task.Delay(30000);
				return await ConfigureStoryVideoAsync(progress, upProgress, video, uploadId, caption, uri, uploadOptions);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaStoryMedia>(response4, json);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryMedia>(exception2);
		}
	}

	public async Task<IResult<bool>> UploadStoryVideoWithUrlAsync(InstaVideoUpload video, Uri uri, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(null, isDirectVideo: false, isDisappearingVideo: false, "", InstaViewMode.Replayable, storyType, null, threadIds.EncodeList(), video, uri, uploadOptions);
	}

	public async Task<IResult<bool>> UploadStoryVideoWithUrlAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, Uri uri, InstaStoryType storyType = InstaStoryType.SelfStory, InstaStoryUploadOptions uploadOptions = null, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(progress, isDirectVideo: false, isDisappearingVideo: false, "", InstaViewMode.Replayable, storyType, null, threadIds.EncodeList(), video, uri, uploadOptions);
	}

	public async Task<IResult<bool>> ValidateUrlAsync(string url)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(url))
			{
				return Result.Fail("Url cannot be null or empty.", resValue: false);
			}
			Uri validateReelLinkAddressUri = UriCreator.GetValidateReelLinkAddressUri();
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
				},
				{ "url", url }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, validateReelLinkAddressUri, _deviceInfo, data);
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

	public async Task<IResult<InstaStoryItem>> VoteStoryPollAsync(string storyMediaId, string pollId, InstaStoryPollVoteType pollVote)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storyPollVoteUri = UriCreator.GetStoryPollVoteUri(storyMediaId, pollId);
			JObject obj = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "radio_type", "wifi-none" }
			};
			int num = (int)pollVote;
			obj.Add("vote", num.ToString());
			JObject data = obj;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, storyPollVoteUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryItem>(response, text);
			}
			InstaReelStoryMediaViewersResponse response2 = JsonConvert.DeserializeObject<InstaReelStoryMediaViewersResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetReelStoryMediaViewersConverter(response2).Convert().UpdatedMedia);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryItem>(exception2);
		}
	}

	public async Task<IResult<InstaStoryItem>> VoteStorySliderAsync(string storyMediaId, string pollId, double sliderVote = 0.5)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (sliderVote > 1.0)
			{
				return Result.Fail<InstaStoryItem>("sliderVote cannot be more than 1.\r\nIt must be between 0 and 1");
			}
			if (sliderVote < 0.0)
			{
				return Result.Fail<InstaStoryItem>("sliderVote cannot be less than 0.\r\nIt must be between 0 and 1");
			}
			Uri voteStorySliderUri = UriCreator.GetVoteStorySliderUri(storyMediaId, pollId);
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
				},
				{
					"vote",
					sliderVote.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, voteStorySliderUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryItem>(response, text);
			}
			InstaReelStoryMediaViewersResponse response2 = JsonConvert.DeserializeObject<InstaReelStoryMediaViewersResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetReelStoryMediaViewersConverter(response2).Convert().UpdatedMedia);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryItem>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryItem>(exception2);
		}
	}

	private async Task<IResult<bool>> AppendOrDeleteHighlight(string highlightId, string mediaId, bool delete)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject jObject = new JObject
			{
				{ "source", "story_viewer" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			if (delete)
			{
				jObject.Add("added_media_ids", "[]");
				jObject.Add("removed_media_ids", "[" + new string[1] { mediaId }.EncodeList() + "]");
			}
			else
			{
				jObject.Add("added_media_ids", "[" + new string[1] { mediaId }.EncodeList() + "]");
				jObject.Add("removed_media_ids", "[]");
			}
			Uri highlightEditUri = UriCreator.GetHighlightEditUri(highlightId);
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, highlightEditUri, _deviceInfo, jObject);
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

	private async Task<IResult<InstaStoryMedia>> ConfigureStoryPhotoAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, InstaImage image, string uploadId, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri videoStoryConfigureUri = UriCreator.GetVideoStoryConfigureUri();
			JObject jObject = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "source_type", "3" },
				{ "caption", caption },
				{ "upload_id", uploadId },
				{
					"edits",
					new JObject()
				},
				{ "disable_comments", false },
				{ "configure_mode", 1 },
				{ "camera_position", "unknown" }
			};
			if (uri != null)
			{
				JArray value = new JArray
				{
					new JObject { 
					{
						"webUri",
						uri.ToString()
					} }
				};
				JArray jArray = new JArray
				{
					new JObject { { "links", value } }
				};
				jObject.Add("story_cta", jArray.ToString(Formatting.None));
			}
			if (uploadOptions != null)
			{
				List<InstaStoryHashtagUpload> hashtags = uploadOptions.Hashtags;
				if (hashtags != null && hashtags.Count > 0)
				{
					JArray jArray2 = new JArray();
					foreach (InstaStoryHashtagUpload hashtag in uploadOptions.Hashtags)
					{
						jArray2.Add(hashtag.ConvertToJson());
					}
					jObject.Add("story_hashtags", jArray2.ToString(Formatting.None));
				}
				List<InstaStoryLocationUpload> locations = uploadOptions.Locations;
				if (locations != null && locations.Count > 0)
				{
					JArray jArray3 = new JArray();
					foreach (InstaStoryLocationUpload location in uploadOptions.Locations)
					{
						jArray3.Add(location.ConvertToJson());
					}
					jObject.Add("story_locations", jArray3.ToString(Formatting.None));
				}
				if (uploadOptions.Slider != null)
				{
					JArray jArray4 = new JArray { uploadOptions.Slider.ConvertToJson() };
					jObject.Add("story_sliders", jArray4.ToString(Formatting.None));
					if (uploadOptions.Slider.IsSticker)
					{
						jObject.Add("story_sticker_ids", uploadOptions.Slider.Emoji ?? "");
					}
				}
				else
				{
					List<InstaStoryPollUpload> polls = uploadOptions.Polls;
					if (polls != null && polls.Count > 0)
					{
						JArray jArray5 = new JArray();
						foreach (InstaStoryPollUpload poll in uploadOptions.Polls)
						{
							jArray5.Add(poll.ConvertToJson());
						}
						jObject.Add("story_polls", jArray5.ToString(Formatting.None));
					}
					List<InstaStoryQuestionUpload> questions = uploadOptions.Questions;
					if (questions != null && questions.Count > 0)
					{
						JArray jArray6 = new JArray();
						foreach (InstaStoryQuestionUpload question in uploadOptions.Questions)
						{
							jArray6.Add(question.ConvertToJson());
						}
						jObject.Add("story_questions", jArray6.ToString(Formatting.None));
					}
				}
				if (uploadOptions.MediaStory != null)
				{
					JArray jArray7 = new JArray { uploadOptions.MediaStory.ConvertToJson() };
					jObject.Add("attached_media", jArray7.ToString(Formatting.None));
				}
				List<InstaStoryMentionUpload> mentions = uploadOptions.Mentions;
				if (mentions != null && mentions.Count > 0)
				{
					JArray jArray8 = new JArray();
					foreach (InstaStoryMentionUpload mention in uploadOptions.Mentions)
					{
						jArray8.Add(mention.ConvertToJson());
					}
					jObject.Add("reel_mentions", jArray8.ToString(Formatting.None));
				}
				if (uploadOptions.Countdown != null)
				{
					JArray jArray9 = new JArray { uploadOptions.Countdown.ConvertToJson() };
					jObject.Add("story_countdowns", jArray9.ToString(Formatting.None));
					jObject.Add("story_sticker_ids", "countdown_sticker_time");
				}
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, videoStoryConfigureUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				InstaStoryMediaResponse storyMedia = JsonConvert.DeserializeObject<InstaStoryMediaResponse>(text);
				InstaStoryMedia resValue = ConvertersFabric.Instance.GetStoryMediaConverter(storyMedia).Convert();
				upProgress.UploadState = InstaUploadState.Configured;
				progress?.Invoke(upProgress);
				upProgress.UploadState = InstaUploadState.Completed;
				progress?.Invoke(upProgress);
				return Result.Success(resValue);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaStoryMedia>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryMedia>(exception2);
		}
	}

	private async Task<IResult<InstaStoryMedia>> ConfigureStoryVideoAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, InstaVideoUpload video, string uploadId, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri videoStoryConfigureUri = UriCreator.GetVideoStoryConfigureUri();
			Random random = new Random();
			JObject jObject = new JObject
			{
				{ "filter_type", "0" },
				{ "timezone_offset", "16200" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"client_shared_at",
					(long.Parse(ApiRequestMessage.GenerateUploadId()) - random.Next(25, 55)).ToString()
				},
				{
					"story_media_creation_date",
					(long.Parse(ApiRequestMessage.GenerateUploadId()) - random.Next(50, 70)).ToString()
				},
				{ "media_folder", "Camera" },
				{ "configure_mode", "1" },
				{ "source_type", "4" },
				{ "video_result", "" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "caption", caption },
				{
					"date_time_original",
					DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fffZ")
				},
				{ "capture_type", "normal" },
				{ "mas_opt_in", "NOT_PROMPTED" },
				{ "upload_id", uploadId },
				{
					"client_timestamp",
					ApiRequestMessage.GenerateUploadId()
				},
				{
					"device",
					new JObject
					{
						{ "manufacturer", _deviceInfo.HardwareManufacturer },
						{ "model", _deviceInfo.DeviceModelIdentifier },
						{
							"android_release",
							_deviceInfo.AndroidVer.VersionNumber
						},
						{
							"android_version",
							_deviceInfo.AndroidVer.APILevel
						}
					}
				},
				{ "length", 0 },
				{
					"extra",
					new JObject
					{
						{ "source_width", 0 },
						{ "source_height", 0 }
					}
				},
				{ "audio_muted", false },
				{ "poster_frame_index", 0 }
			};
			if (uri != null)
			{
				JArray value = new JArray
				{
					new JObject { 
					{
						"webUri",
						uri.ToString()
					} }
				};
				JArray jArray = new JArray
				{
					new JObject { { "links", value } }
				};
				jObject.Add("story_cta", jArray.ToString(Formatting.None));
			}
			if (uploadOptions != null)
			{
				List<InstaStoryHashtagUpload> hashtags = uploadOptions.Hashtags;
				if (hashtags != null && hashtags.Count > 0)
				{
					JArray jArray2 = new JArray();
					foreach (InstaStoryHashtagUpload hashtag in uploadOptions.Hashtags)
					{
						jArray2.Add(hashtag.ConvertToJson());
					}
					jObject.Add("story_hashtags", jArray2.ToString(Formatting.None));
				}
				List<InstaStoryLocationUpload> locations = uploadOptions.Locations;
				if (locations != null && locations.Count > 0)
				{
					JArray jArray3 = new JArray();
					foreach (InstaStoryLocationUpload location in uploadOptions.Locations)
					{
						jArray3.Add(location.ConvertToJson());
					}
					jObject.Add("story_locations", jArray3.ToString(Formatting.None));
				}
				if (uploadOptions.Slider != null)
				{
					JArray jArray4 = new JArray { uploadOptions.Slider.ConvertToJson() };
					jObject.Add("story_sliders", jArray4.ToString(Formatting.None));
					if (uploadOptions.Slider.IsSticker)
					{
						jObject.Add("story_sticker_ids", "emoji_slider_" + uploadOptions.Slider.Emoji);
					}
				}
				else
				{
					List<InstaStoryPollUpload> polls = uploadOptions.Polls;
					if (polls != null && polls.Count > 0)
					{
						JArray jArray5 = new JArray();
						foreach (InstaStoryPollUpload poll in uploadOptions.Polls)
						{
							jArray5.Add(poll.ConvertToJson());
						}
						jObject.Add("story_polls", jArray5.ToString(Formatting.None));
					}
					List<InstaStoryQuestionUpload> questions = uploadOptions.Questions;
					if (questions != null && questions.Count > 0)
					{
						JArray jArray6 = new JArray();
						foreach (InstaStoryQuestionUpload question in uploadOptions.Questions)
						{
							jArray6.Add(question.ConvertToJson());
						}
						jObject.Add("story_questions", jArray6.ToString(Formatting.None));
					}
				}
				if (uploadOptions.Countdown != null)
				{
					JArray jArray7 = new JArray { uploadOptions.Countdown.ConvertToJson() };
					jObject.Add("story_countdowns", jArray7.ToString(Formatting.None));
					jObject.Add("story_sticker_ids", "countdown_sticker_time");
				}
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, videoStoryConfigureUri, _deviceInfo, jObject);
			string value2 = JsonConvert.SerializeObject(new JObject
			{
				{ "num_step_auto_retry", 0 },
				{ "num_reupload", 0 },
				{ "num_step_manual_retry", 0 }
			});
			signedRequest.Headers.Add("retry_context", value2);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				InstaStoryMediaResponse storyMedia = JsonConvert.DeserializeObject<InstaStoryMediaResponse>(text);
				IResult<InstaStoryMedia> result = Result.Success(ConvertersFabric.Instance.GetStoryMediaConverter(storyMedia).Convert());
				upProgress.UploadState = InstaUploadState.Configured;
				progress?.Invoke(upProgress);
				upProgress.UploadState = InstaUploadState.Completed;
				progress?.Invoke(upProgress);
				return result;
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaStoryMedia>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryMedia>(exception2);
		}
	}

	private async Task<IResult<InstaReelStoryMediaViewersResponse>> GetStoryMediaViewers(string storyMediaId, string maxId)
	{
		try
		{
			Uri storyMediaViewersUri = UriCreator.GetStoryMediaViewersUri(storyMediaId, maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, storyMediaViewersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaReelStoryMediaViewersResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaReelStoryMediaViewersResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaReelStoryMediaViewersResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaReelStoryMediaViewersResponse>(exception2);
		}
	}

	private async Task<IResult<InstaStoryPollVotersListResponse>> GetStoryPollVoters(string storyMediaId, string pollId, string maxId)
	{
		try
		{
			Uri storyPollVotersUri = UriCreator.GetStoryPollVotersUri(storyMediaId, pollId, maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, storyPollVotersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryPollVotersListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaStoryPollVotersListContainerResponse>(text).VoterInfo);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryPollVotersListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryPollVotersListResponse>(exception2);
		}
	}

	public async Task<IResult<bool>> FollowUnfollowCountdown(Uri instaUri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject data = new JObject
			{
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return JsonConvert.DeserializeObject<InstaDefaultResponse>(text).IsSucceed ? Result.Success(resValue: true) : Result.Fail<bool>("");
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

	private async Task<IResult<InstaStoryMedia>> UploadStoryPhotoWithUrlAsyncOLD(Action<InstaUploaderProgress> progress, InstaImage image, string caption, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			if (uploadOptions != null && uploadOptions.Mentions?.Count > 0)
			{
				IRequestDelay currentDelay = _instaApi.GetRequestDelay();
				_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
				foreach (InstaStoryMentionUpload t in uploadOptions.Mentions)
				{
					try
					{
						bool tried = false;
						while (true)
						{
							IResult<InstaUser> result = await _instaApi.UserProcessor.GetUserAsync(t.Username);
							if (!result.Succeeded)
							{
								if (!tried)
								{
									tried = true;
									continue;
								}
								break;
							}
							t.Pk = result.Value.Pk;
							break;
						}
					}
					catch
					{
					}
				}
				_instaApi.SetRequestDelay(currentDelay);
			}
			Uri uploadPhotoUri = UriCreator.GetUploadPhotoUri();
			string uploadId = (upProgress.UploadId = ApiRequestMessage.GenerateUploadId());
			progress?.Invoke(upProgress);
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(uploadId)
			{
				{
					new StringContent(uploadId),
					"\"upload_id\""
				},
				{
					new StringContent("{\"lib_name\":\"jt\",\"lib_version\":\"1.3.0\",\"quality\":\"87\"}"),
					"\"image_compression\""
				}
			};
			byte[] content = ((image.ImageBytes != null) ? image.ImageBytes : File.ReadAllBytes(image.Uri));
			ByteArrayContent byteArrayContent = new ByteArrayContent(content);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			multipartFormDataContent.Add(byteArrayContent, "photo", "pending_media_" + ApiRequestMessage.GenerateUploadId() + ".jpg");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uploadPhotoUri, _deviceInfo);
			defaultRequest.Content = multipartFormDataContent;
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string json = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Uploaded;
				progress?.Invoke(upProgress);
				return await ConfigureStoryPhotoAsync(progress, upProgress, image, uploadId, caption, uri, uploadOptions);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaStoryMedia>(response, json);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryMedia>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaReelStoryMediaViewers smethod_0(InstaReelStoryMediaViewersResponse reelResponse)
	{
		return ConvertersFabric.Instance.GetReelStoryMediaViewersConverter(reelResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaStoryPollVotersList smethod_1(InstaStoryPollVotersListResponse storyVotersResponse)
	{
		return ConvertersFabric.Instance.GetStoryPollVotersListConverter(storyVotersResponse).Convert();
	}
}
