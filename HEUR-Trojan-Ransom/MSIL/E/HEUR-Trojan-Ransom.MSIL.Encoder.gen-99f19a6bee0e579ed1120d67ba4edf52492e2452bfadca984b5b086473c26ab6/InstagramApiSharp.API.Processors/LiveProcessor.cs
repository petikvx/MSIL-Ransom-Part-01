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
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class LiveProcessor : ILiveProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public LiveProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaBroadcastAddToPostLive>> AddToPostLiveAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastAddToPostLiveUri = UriCreator.GetBroadcastAddToPostLiveUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastAddToPostLiveUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastAddToPostLive>(response, text);
			}
			InstaBroadcastAddToPostLiveResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastAddToPostLiveResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetAddToPostLiveConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastAddToPostLive>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastAddToPostLive>(exception2);
		}
	}

	public async Task<IResult<InstaComment>> CommentAsync(string broadcastId, string commentText)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastPostCommentUri = UriCreator.GetBroadcastPostCommentUri(broadcastId);
			CryptoHelper.GetCommentBreadCrumbEncoded(commentText);
			JObject data = new JObject
			{
				{ "user_breadcrumb", commentText },
				{
					"idempotence_token",
					Guid.NewGuid().ToString()
				},
				{ "comment_text", commentText },
				{ "live_or_vod", "1" },
				{ "offset_to_video_start", " 0" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastPostCommentUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaComment>(response, text);
			}
			InstaCommentResponse comment = JsonConvert.DeserializeObject<InstaCommentResponse>(text, new JsonConverter[1]
			{
				new InstaCommentDataConverter()
			});
			return Result.Success(ConvertersFabric.Instance.GetCommentConverter(comment).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaComment>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaComment>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastCreate>> CreateAsync(int previewWidth = 720, int previewHeight = 1184, string broadcastMessage = "")
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastCreateUri = UriCreator.GetBroadcastCreateUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "preview_height", previewHeight },
				{ "preview_width", previewWidth },
				{ "broadcast_message", broadcastMessage },
				{ "broadcast_type", "RTMP" },
				{ "internal_only", 0 }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastCreateUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastCreate>(response, text);
			}
			InstaBroadcastCreateResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastCreateResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastCreateConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastCreate>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastCreate>(exception2);
		}
	}

	public async Task<IResult<bool>> DeletePostLiveAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastDeletePostLiveUri = UriCreator.GetBroadcastDeletePostLiveUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastDeletePostLiveUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
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

	public async Task<IResult<InstaBroadcastCommentEnableDisable>> DisableCommentsAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastDisableCommenstUri = UriCreator.GetBroadcastDisableCommenstUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastDisableCommenstUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastCommentEnableDisable>(response, text);
			}
			InstaBroadcastCommentEnableDisableResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastCommentEnableDisableResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastCommentEnableDisableConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastCommentEnableDisable>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastCommentEnableDisable>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastCommentEnableDisable>> EnableCommentsAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastEnableCommenstUri = UriCreator.GetBroadcastEnableCommenstUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastEnableCommenstUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastCommentEnableDisable>(response, text);
			}
			InstaBroadcastCommentEnableDisableResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastCommentEnableDisableResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastCommentEnableDisableConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastCommentEnableDisable>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastCommentEnableDisable>(exception2);
		}
	}

	public async Task<IResult<bool>> EndAsync(string broadcastId, bool endAfterCopyrightWarning = false)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastEndUri = UriCreator.GetBroadcastEndUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.UserName
				},
				{
					"end_after_copyright_warning",
					endAfterCopyrightWarning.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastEndUri, _deviceInfo, data);
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

	public async Task<IResult<InstaBroadcastCommentList>> GetCommentsAsync(string broadcastId, string lastCommentTs = "", int commentsRequested = 4)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastCommentUri = UriCreator.GetBroadcastCommentUri(broadcastId, lastCommentTs);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastCommentUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastCommentList>(response, text);
			}
			InstaBroadcastCommentListResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastCommentListResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastCommentListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastCommentList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastCommentList>(exception2);
		}
	}

	public async Task<IResult<InstaDiscoverTopLive>> GetDiscoverTopLiveAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaDiscoverTopLive topLive = new InstaDiscoverTopLive();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaDiscoverTopLiveResponse> result = await GetDiscoverTopLive(paginationParameters.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail(result.Info, topLive);
			}
			InstaDiscoverTopLiveResponse topLiveResponse = result.Value;
			topLive = smethod_0(topLiveResponse);
			string text2 = (topLive.NextMaxId = (paginationParameters.NextMaxId = topLiveResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (topLiveResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				paginationParameters.PagesLoaded++;
				IResult<InstaDiscoverTopLiveResponse> result2 = await GetDiscoverTopLive(paginationParameters.NextMaxId);
				if (result2.Succeeded)
				{
					InstaDiscoverTopLive instaDiscoverTopLive = smethod_0(result2.Value);
					text2 = (topLive.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
					InstaDiscoverTopLive instaDiscoverTopLive2 = topLive;
					bool moreAvailable2 = (topLiveResponse.MoreAvailable = result2.Value.MoreAvailable);
					instaDiscoverTopLive2.MoreAvailable = moreAvailable2;
					topLive.AutoLoadMoreEnabled = result2.Value.AutoLoadMoreEnabled;
					topLive.Broadcasts.AddRange(instaDiscoverTopLive.Broadcasts);
					topLive.PostLiveBroadcasts.AddRange(instaDiscoverTopLive.PostLiveBroadcasts);
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, topLive);
			}
			return Result.Success(topLive);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, topLive, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, topLive);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetFinalViewerListAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList viewers = new InstaUserShortList();
		try
		{
			Uri liveFinalViewerListUri = UriCreator.GetLiveFinalViewerListUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, liveFinalViewerListUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			viewers.AddRange((from converter in instaUserListShortResponse.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			return Result.Success(viewers);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, viewers, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, viewers);
		}
	}

	public async Task<IResult<InstaBroadcastLiveHeartBeatViewerCount>> GetHeartBeatAndViewerCountAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri liveHeartbeatAndViewerCountUri = UriCreator.GetLiveHeartbeatAndViewerCountUri(broadcastId);
			MultipartFormDataContent content = new MultipartFormDataContent(ApiRequestMessage.GenerateUploadId())
			{
				{
					new StringContent(_user.CsrfToken),
					"\"_csrftoken\""
				},
				{
					new StringContent(_deviceInfo.DeviceGuid.ToString()),
					"\"_uuid\""
				},
				{
					new StringContent("offset_to_video_start"),
					"30"
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, liveHeartbeatAndViewerCountUri, _deviceInfo);
			defaultRequest.Content = content;
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastLiveHeartBeatViewerCount>(response, text);
			}
			InstaBroadcastLiveHeartBeatViewerCountResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastLiveHeartBeatViewerCountResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastLiveHeartBeatViewerCountConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastLiveHeartBeatViewerCount>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastLiveHeartBeatViewerCount>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastInfo>> GetInfoAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastInfoUri = UriCreator.GetBroadcastInfoUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastInfo>(response, text);
			}
			InstaBroadcastInfoResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastInfoResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastInfoConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastInfo>(exception2);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetJoinRequestsAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList viewers = new InstaUserShortList();
		try
		{
			Uri broadcastJoinRequestsUri = UriCreator.GetBroadcastJoinRequestsUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastJoinRequestsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			viewers.AddRange((from converter in instaUserListShortResponse.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			return Result.Success(viewers);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, viewers, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, viewers);
		}
	}

	public async Task<IResult<InstaBroadcastLike>> GetLikeCountAsync(string broadcastId, int likeTs = 0)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri liveLikeCountUri = UriCreator.GetLiveLikeCountUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, liveLikeCountUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastLike>(response, text);
			}
			InstaBroadcastLikeResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastLikeResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastLikeConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastLike>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastLike>(exception2);
		}
	}

	public async Task<IResult<object>> GetPostLiveCommentsAsync(string broadcastId, int startingOffset = 0, string encodingTag = "instagram_dash_remuxed")
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastPostLiveCommentUri = UriCreator.GetBroadcastPostLiveCommentUri(broadcastId, startingOffset, encodingTag);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastPostLiveCommentUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<object>(response, text);
			}
			JsonConvert.DeserializeObject<object>(text);
			return Result.Success(text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<string>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<string>(exception2);
		}
	}

	public async Task<IResult<object>> GetPostLiveLikesAsync(string broadcastId, int startingOffset = 0, string encodingTag = "instagram_dash_remuxed")
	{
		try
		{
			Uri broadcastPostLiveLikesUri = UriCreator.GetBroadcastPostLiveLikesUri(broadcastId, startingOffset, encodingTag);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastPostLiveLikesUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<object>(response, text);
			}
			JsonConvert.DeserializeObject<object>(text);
			return Result.Success(text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<string>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<string>(exception2);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetPostLiveViewerListAsync(string broadcastId, int? maxId = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList viewers = new InstaUserShortList();
		try
		{
			Uri postLiveViewersListUri = UriCreator.GetPostLiveViewersListUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, postLiveViewersListUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			viewers.AddRange((from converter in instaUserListShortResponse.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			return Result.Success(viewers);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, viewers, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, viewers);
		}
	}

	public async Task<IResult<InstaBroadcastList>> GetSuggestedBroadcastsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri suggestedBroadcastsUri = UriCreator.GetSuggestedBroadcastsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, suggestedBroadcastsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastList>(response, text);
			}
			InstaBroadcastSuggestedResponse instaBroadcastSuggestedResponse = JsonConvert.DeserializeObject<InstaBroadcastSuggestedResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastListConverter(instaBroadcastSuggestedResponse?.Broadcasts).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastList>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastTopLiveStatusList>> GetTopLiveStatusAsync(params string[] broadcastIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		if (broadcastIds != null)
		{
			try
			{
				Uri discoverTopLiveStatusUri = UriCreator.GetDiscoverTopLiveStatusUri();
				JObject jObject = new JObject();
				jObject.Add("broadcast_ids", new JArray(broadcastIds));
				JObject data = jObject;
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, discoverTopLiveStatusUri, _deviceInfo, data);
				signedRequest.Headers.Host = "i.instagram.com";
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					return Result.UnExpectedResponse<InstaBroadcastTopLiveStatusList>(response, text);
				}
				InstaBroadcastTopLiveStatusResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastTopLiveStatusResponse>(text);
				return Result.Success(ConvertersFabric.Instance.GetBroadcastTopLiveStatusListConverter(response2).Convert());
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail<InstaBroadcastTopLiveStatusList>(exception, null, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				_logger?.LogException(exception2);
				return Result.Fail<InstaBroadcastTopLiveStatusList>(exception2);
			}
		}
		return Result.Fail<InstaBroadcastTopLiveStatusList>("broadcast ids must be set");
	}

	public async Task<IResult<InstaUserShortList>> GetViewerListAsync(string broadcastId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList viewers = new InstaUserShortList();
		try
		{
			Uri broadcastViewerListUri = UriCreator.GetBroadcastViewerListUri(broadcastId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, broadcastViewerListUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			viewers.AddRange((from converter in instaUserListShortResponse.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			return Result.Success(viewers);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, viewers, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, viewers);
		}
	}

	public async Task<IResult<InstaBroadcastLike>> LikeAsync(string broadcastId, int likeCount = 1)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri likeLiveUri = UriCreator.GetLikeLiveUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "user_like_count", likeCount }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, likeLiveUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastLike>(response, text);
			}
			InstaBroadcastLikeResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastLikeResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastLikeConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastLike>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastLike>(exception2);
		}
	}

	public async Task<IResult<object>> NotifyToFriendsAsync()
	{
		try
		{
			Uri liveNotifyToFriendsUri = UriCreator.GetLiveNotifyToFriendsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, liveNotifyToFriendsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<object>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<object>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<object>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<object>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastPinUnpin>> PinCommentAsync(string broadcastId, string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastPinCommentUri = UriCreator.GetBroadcastPinCommentUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "comment_id", commentId },
				{ "offset_to_video_start", 0 }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastPinCommentUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastPinUnpin>(response, text);
			}
			InstaBroadcastPinUnpinResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastPinUnpinResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastPinUnpinConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastPinUnpin>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastPinUnpin>(exception2);
		}
	}

	public async Task<IResult<object>> SeenBroadcastAsync(string broadcastId, string pk)
	{
		try
		{
			Uri uri = new Uri("https://i.instagram.com/api/v1/media/seen/?reel=1&live_vod=0");
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
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
				{
					"reels",
					new JObject { 
					{
						broadcastId,
						new JArray(pk)
					} }
				},
				{
					"live_vods",
					new JObject()
				},
				{
					"reel_media_skipped",
					new JObject()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, uri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<object>(response, text);
			}
			return Result.Success(text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastLiveHeartBeatViewerCountResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastLiveHeartBeatViewerCountResponse>(exception2);
		}
	}

	public async Task<IResult<InstaBroadcastStart>> StartAsync(string broadcastId, bool sendNotifications)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastStartUri = UriCreator.GetBroadcastStartUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "should_send_notifications", sendNotifications }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastStartUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			InstaBroadcastStartResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastStartResponse>(text);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastStart>(response, text);
			}
			return Result.Success(ConvertersFabric.Instance.GetBroadcastStartConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastStart>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastStart>(exception2);
		}
	}

	public async Task<IResult<bool>> ShareLiveToDirectThreadAsync(string text, string broadcastId, params string[] threadIds)
	{
		return await ShareLiveToDirectThreadAsync(text, broadcastId, threadIds, null);
	}

	public async Task<IResult<bool>> ShareLiveToDirectThreadAsync(string text, string broadcastId, string[] threadIds, string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri shareLiveToDirectUri = UriCreator.GetShareLiveToDirectUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"text",
					text ?? string.Empty
				},
				{ "broadcast_id", broadcastId },
				{ "action", "send_item" },
				{ "client_context", value },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			if (threadIds != null && threadIds.Length != 0)
			{
				dictionary.Add("thread_ids", "[" + threadIds.EncodeList(appendQuotation: false) + "]");
			}
			if (recipients != null && recipients.Length != 0)
			{
				dictionary.Add("recipient_users", "[[" + recipients.EncodeList(appendQuotation: false) + "]]");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, shareLiveToDirectUri, _deviceInfo, dictionary);
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

	public async Task<IResult<bool>> ShareLiveToDirectRecipientAsync(string text, string broadcastId, params string[] recipients)
	{
		return await ShareLiveToDirectThreadAsync(text, broadcastId, null, recipients);
	}

	public async Task<IResult<InstaBroadcastPinUnpin>> UnPinCommentAsync(string broadcastId, string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri broadcastUnPinCommentUri = UriCreator.GetBroadcastUnPinCommentUri(broadcastId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "comment_id", commentId },
				{ "offset_to_video_start", 0 }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, broadcastUnPinCommentUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBroadcastPinUnpin>(response, text);
			}
			InstaBroadcastPinUnpinResponse response2 = JsonConvert.DeserializeObject<InstaBroadcastPinUnpinResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBroadcastPinUnpinConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBroadcastPinUnpin>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBroadcastPinUnpin>(exception2);
		}
	}

	private async Task<IResult<InstaDiscoverTopLiveResponse>> GetDiscoverTopLive(string maxId)
	{
		try
		{
			Uri discoverTopLiveUri = UriCreator.GetDiscoverTopLiveUri(maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, discoverTopLiveUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDiscoverTopLiveResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaDiscoverTopLiveResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDiscoverTopLiveResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDiscoverTopLiveResponse>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaDiscoverTopLive smethod_0(InstaDiscoverTopLiveResponse instaDiscoverTop)
	{
		return ConvertersFabric.Instance.GetDiscoverTopLiveConverter(instaDiscoverTop).Convert();
	}
}
