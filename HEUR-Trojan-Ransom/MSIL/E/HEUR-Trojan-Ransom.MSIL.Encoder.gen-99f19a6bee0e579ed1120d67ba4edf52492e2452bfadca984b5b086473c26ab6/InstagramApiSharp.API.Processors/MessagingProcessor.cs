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

namespace InstagramApiSharp.API.Processors;

internal class MessagingProcessor : IMessagingProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public MessagingProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaDirectInboxThread>> AddUserToGroupThreadAsync(string threadId, params long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (userIds != null && (userIds == null || userIds.Any()))
			{
				Uri addUserToDirectThreadUri = UriCreator.GetAddUserToDirectThreadUri(threadId);
				Dictionary<string, string> data = new Dictionary<string, string>
				{
					{ "use_unified_inbox", "true" },
					{
						"user_ids",
						"[" + userIds.EncodeList() + "]"
					},
					{ "_csrftoken", _user.CsrfToken },
					{
						"_uuid",
						_deviceInfo.DeviceGuid.ToString()
					}
				};
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, addUserToDirectThreadUri, _deviceInfo, data);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					return Result.UnExpectedResponse<InstaDirectInboxThread>(response, text);
				}
				InstaDirectInboxThreadResponse instaDirectInboxThreadResponse = JsonConvert.DeserializeObject<InstaDirectInboxThreadResponse>(text, new JsonConverter[1]
				{
					new InstaThreadDataConverter()
				});
				instaDirectInboxThreadResponse.Items.Reverse();
				return Result.Success(ConvertersFabric.Instance.GetDirectThreadConverter(instaDirectInboxThreadResponse).Convert());
			}
			throw new ArgumentException("UserIds cannot be null or empty.\nAt least one user id require.");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxThread>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxThread>(exception2);
		}
	}

	public async Task<IResult<bool>> ApproveDirectPendingRequestAsync(params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			Uri uri;
			if (threadIds.Length == 1)
			{
				uri = UriCreator.GetApprovePendingDirectRequestUri(threadIds.FirstOrDefault());
			}
			else
			{
				uri = UriCreator.GetApprovePendingMultipleDirectRequestUri();
				dictionary.Add("thread_ids", threadIds.EncodeList(appendQuotation: false));
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaDefaultResponse>(text).IsSucceed)
			{
				return Result.Success(resValue: true);
			}
			return Result.UnExpectedResponse<bool>(response, text);
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

	public async Task<IResult<bool>> DeclineAllDirectPendingRequestsAsync()
	{
		return await DeclineDirectPendingRequests(true);
	}

	public async Task<IResult<bool>> DeclineDirectPendingRequestsAsync(params string[] threadIds)
	{
		return await DeclineDirectPendingRequests(all: false, threadIds);
	}

	public async Task<IResult<bool>> DeleteDirectThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri hideDirectThreadUri = UriCreator.GetHideDirectThreadUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "use_unified_inbox", "true" }
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, hideDirectThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> DeleteSelfMessageAsync(string threadId, string itemId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteDirectMessageUri = UriCreator.GetDeleteDirectMessageUri(threadId, itemId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, deleteDirectMessageUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<InstaDirectInboxContainer>> GetDirectInboxAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaDirectInboxContainerResponse> result = await GetDirectInbox(paginationParameters.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaDirectInboxContainer>(result.Info, null);
			}
			InstaDirectInboxContainerResponse inboxResponse = result.Value;
			paginationParameters.NextMaxId = inboxResponse.Inbox.OldestCursor;
			int pagesLoaded = 1;
			while (inboxResponse.Inbox.HasOlder && !string.IsNullOrEmpty(inboxResponse.Inbox.OldestCursor) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaDirectInboxContainerResponse> result2 = await GetDirectInbox(inboxResponse.Inbox.OldestCursor);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_0(result2.Value));
				}
				string text2 = (inboxResponse.Inbox.OldestCursor = (paginationParameters.NextMaxId = result2.Value.Inbox.OldestCursor));
				inboxResponse.Inbox.HasOlder = result2.Value.Inbox.HasOlder;
				inboxResponse.Inbox.BlendedInboxEnabled = result2.Value.Inbox.BlendedInboxEnabled;
				inboxResponse.Inbox.UnseenCount = result2.Value.Inbox.UnseenCount;
				inboxResponse.Inbox.UnseenCountTs = result2.Value.Inbox.UnseenCountTs;
				inboxResponse.Inbox.Threads.AddRange(result2.Value.Inbox.Threads);
				pagesLoaded++;
			}
			return Result.Success(ConvertersFabric.Instance.GetDirectInboxConverter(inboxResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxContainer>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxContainer>(exception2);
		}
	}

	public async Task<IResult<InstaDirectInboxThread>> GetDirectInboxThreadAsync(string threadId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaDirectInboxThreadResponse> result = await GetDirectInboxThread(threadId, paginationParameters.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaDirectInboxThread>(result.Info, null);
			}
			InstaDirectInboxThreadResponse threadResponse = result.Value;
			paginationParameters.NextMaxId = threadResponse.OldestCursor;
			int pagesLoaded = 1;
			while (threadResponse.HasOlder && !string.IsNullOrEmpty(threadResponse.OldestCursor) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaDirectInboxThreadResponse> result2 = await GetDirectInboxThread(threadId, threadResponse.OldestCursor);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_1(result2.Value));
				}
				string text2 = (threadResponse.OldestCursor = (paginationParameters.NextMaxId = result2.Value.OldestCursor));
				threadResponse.HasOlder = result2.Value.HasOlder;
				threadResponse.Canonical = result2.Value.Canonical;
				threadResponse.ExpiringMediaReceiveCount = result2.Value.ExpiringMediaReceiveCount;
				threadResponse.ExpiringMediaSendCount = result2.Value.ExpiringMediaSendCount;
				threadResponse.HasNewer = result2.Value.HasNewer;
				threadResponse.LastActivity = result2.Value.LastActivity;
				threadResponse.LastSeenAt = result2.Value.LastSeenAt;
				threadResponse.ReshareReceiveCount = result2.Value.ReshareReceiveCount;
				threadResponse.ReshareSendCount = result2.Value.ReshareSendCount;
				threadResponse.Status = result2.Value.Status;
				threadResponse.Title = result2.Value.Title;
				threadResponse.IsGroup = result2.Value.IsGroup;
				threadResponse.IsSpam = result2.Value.IsSpam;
				threadResponse.IsPin = result2.Value.IsPin;
				threadResponse.Muted = result2.Value.Muted;
				threadResponse.PendingScore = result2.Value.PendingScore;
				threadResponse.Pending = result2.Value.Pending;
				threadResponse.Users = result2.Value.Users;
				threadResponse.ValuedRequest = result2.Value.ValuedRequest;
				threadResponse.VCMuted = result2.Value.VCMuted;
				threadResponse.VieweId = result2.Value.VieweId;
				threadResponse.Items.AddRange(result2.Value.Items);
				pagesLoaded++;
			}
			threadResponse.Items.Reverse();
			return Result.Success(ConvertersFabric.Instance.GetDirectThreadConverter(threadResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxThread>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxThread>(exception2);
		}
	}

	public async Task<IResult<InstaDirectInboxContainer>> GetPendingDirectAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaDirectInboxContainerResponse> result = await GetPendingDirect(paginationParameters.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaDirectInboxContainer>(result.Info, null);
			}
			InstaDirectInboxContainerResponse inboxResponse = result.Value;
			paginationParameters.NextMaxId = inboxResponse.Inbox.OldestCursor;
			int pagesLoaded = 1;
			while (inboxResponse.Inbox.HasOlder && !string.IsNullOrEmpty(inboxResponse.Inbox.OldestCursor) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaDirectInboxContainerResponse> result2 = await GetPendingDirect(inboxResponse.Inbox.OldestCursor);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, smethod_2(result2.Value));
				}
				string text2 = (inboxResponse.Inbox.OldestCursor = (paginationParameters.NextMaxId = result2.Value.Inbox.OldestCursor));
				inboxResponse.Inbox.HasOlder = result2.Value.Inbox.HasOlder;
				inboxResponse.Inbox.Threads.AddRange(result2.Value.Inbox.Threads);
				inboxResponse.Inbox.BlendedInboxEnabled = result2.Value.Inbox.BlendedInboxEnabled;
				inboxResponse.Inbox.UnseenCount = result2.Value.Inbox.UnseenCount;
				inboxResponse.Inbox.UnseenCountTs = result2.Value.Inbox.UnseenCountTs;
				pagesLoaded++;
			}
			return Result.Success(ConvertersFabric.Instance.GetDirectInboxConverter(inboxResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxContainer>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxContainer>(exception2);
		}
	}

	public async Task<IResult<InstaRecipients>> GetRankedRecipientsAsync()
	{
		return await GetRankedRecipientsByUsernameAsync(null);
	}

	public async Task<IResult<InstaRecipients>> GetRankedRecipientsByUsernameAsync(string username)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri uri = ((!string.IsNullOrEmpty(username)) ? UriCreator.GetRankRecipientsByUserUri(username) : UriCreator.GetRankedRecipientsUri());
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaRecipients>(response, text);
			}
			InstaRankedRecipientsResponse recipients = JsonConvert.DeserializeObject<InstaRankedRecipientsResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetRecipientsConverter(recipients).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRecipients>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRecipients>(exception2);
		}
	}

	public async Task<IResult<InstaRecipients>> GetRecentRecipientsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri recentRecipientsUri = UriCreator.GetRecentRecipientsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, recentRecipientsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaRecipients>(response, text);
			}
			InstaRecentRecipientsResponse recipients = JsonConvert.DeserializeObject<InstaRecentRecipientsResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetRecipientsConverter(recipients).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRecipients>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRecipients>(exception2);
		}
	}

	public async Task<IResult<InstaUserPresenceList>> GetUsersPresenceAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri directPresenceUri = UriCreator.GetDirectPresenceUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, directPresenceUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserPresenceList>(response, text);
			}
			InstaUserPresenceContainerResponse response2 = JsonConvert.DeserializeObject<InstaUserPresenceContainerResponse>(text, new JsonConverter[1]
			{
				new InstaUserPresenceContainerDataConverter()
			});
			return Result.Success(ConvertersFabric.Instance.GetUserPresenceListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserPresenceList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserPresenceList>(exception2);
		}
	}

	public async Task<IResult<bool>> LeaveGroupThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri leaveThreadUri = UriCreator.GetLeaveThreadUri(threadId);
			Guid.NewGuid().ToString();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, leaveThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> LikeThreadMessageAsync(string threadId, string itemId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri likeUnlikeDirectMessageUri = UriCreator.GetLikeUnlikeDirectMessageUri();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "item_type", "reaction" },
				{ "reaction_type", "like" },
				{ "action", "send_item" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"thread_ids",
					"[" + threadId + "]"
				},
				{
					"client_context",
					Guid.NewGuid().ToString()
				},
				{ "node_type", "item" },
				{ "reaction_status", "created" },
				{ "item_id", itemId }
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, likeUnlikeDirectMessageUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> MarkDirectThreadAsSeenAsync(string threadId, string itemId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri directThreadSeenUri = UriCreator.GetDirectThreadSeenUri(threadId, itemId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "thread_id", threadId },
				{ "action", "mark_seen" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "item_id", itemId },
				{ "use_unified_inbox", "true" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, directThreadSeenUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> MuteDirectThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri muteDirectThreadUri = UriCreator.GetMuteDirectThreadUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, muteDirectThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> SendDirectDisappearingPhotoAsync(InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds)
	{
		return await SendDirectDisappearingPhotoAsync(null, image, viewMode, threadIds);
	}

	public async Task<IResult<bool>> SendDirectDisappearingPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendPhotoAsync(progress, isDirectPhoto: false, isDisappearingPhoto: true, "", viewMode, InstaStoryType.Direct, null, threadIds.EncodeList(), image);
	}

	public async Task<IResult<bool>> SendDirectDisappearingVideoAsync(InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds)
	{
		return await SendDirectDisappearingVideoAsync(null, video, viewMode, threadIds);
	}

	public async Task<IResult<bool>> SendDirectDisappearingVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaViewMode viewMode = InstaViewMode.Replayable, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(progress, isDirectVideo: false, isDisappearingVideo: true, "", viewMode, InstaStoryType.Direct, null, threadIds.EncodeList(), video);
	}

	public async Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, params string[] threadIds)
	{
		return await SendDirectHashtagAsync(text, hashtag, threadIds, null);
	}

	public async Task<IResult<bool>> SendDirectHashtagToRecipientsAsync(string text, string hashtag, params string[] recipients)
	{
		return await SendDirectHashtagAsync(text, hashtag, null, recipients);
	}

	public async Task<IResult<bool>> SendDirectHashtagAsync(string text, string hashtag, string[] threadIds, string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendDirectHashtagUri = UriCreator.GetSendDirectHashtagUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"text",
					text ?? string.Empty
				},
				{ "hashtag", hashtag },
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
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, sendDirectHashtagUri, _deviceInfo, dictionary);
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

	public async Task<IResult<bool>> SendDirectLinkAsync(string text, string link, params string[] threadIds)
	{
		return await SendDirectLinkAsync(text, link, threadIds, null);
	}

	public async Task<IResult<bool>> SendDirectLinkToRecipientsAsync(string text, string link, params string[] recipients)
	{
		return await SendDirectLinkAsync(text, link, null, recipients);
	}

	public async Task<IResult<bool>> SendDirectLinkAsync(string text, string link, string[] threadIds, string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendDirectLinkUri = UriCreator.GetSendDirectLinkUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("link_text", text ?? string.Empty);
			dictionary.Add("link_urls", "[" + new string[1] { link }.EncodeList() + "]");
			dictionary.Add("action", "send_item");
			dictionary.Add("client_context", value);
			dictionary.Add("_csrftoken", _user.CsrfToken);
			dictionary.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			Dictionary<string, string> dictionary2 = dictionary;
			if (threadIds != null && threadIds.Length != 0)
			{
				dictionary2.Add("thread_ids", "[" + threadIds.EncodeList(appendQuotation: false) + "]");
			}
			if (recipients != null && recipients.Length != 0)
			{
				dictionary2.Add("recipient_users", "[[" + recipients.EncodeList(appendQuotation: false) + "]]");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, sendDirectLinkUri, _deviceInfo, dictionary2);
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

	public async Task<IResult<bool>> SendDirectLocationAsync(string externalId, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendDirectLocationUri = UriCreator.GetSendDirectLocationUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "venue_id", externalId },
				{ "action", "send_item" },
				{
					"thread_ids",
					"[" + threadIds.EncodeList(appendQuotation: false) + "]"
				},
				{ "client_context", value },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, sendDirectLocationUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> SendDirectPhotoAsync(InstaImage image, string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await SendDirectPhotoAsync(null, image, threadId);
	}

	public async Task<IResult<bool>> SendDirectPhotoAsync(Action<InstaUploaderProgress> progress, InstaImage image, string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await SendDirectPhoto(progress, null, threadId, image);
	}

	public async Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(InstaImage image, params string[] recipients)
	{
		return await SendDirectPhotoToRecipientsAsync(null, image, recipients);
	}

	public async Task<IResult<bool>> SendDirectPhotoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaImage image, params string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await SendDirectPhoto(progress, string.Join(",", recipients), null, image);
	}

	public async Task<IResult<bool>> SendDirectProfileAsync(long userIdToSend, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendDirectProfileUri = UriCreator.GetSendDirectProfileUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"profile_user_id",
					userIdToSend.ToString()
				},
				{ "action", "send_item" },
				{
					"thread_ids",
					"[" + threadIds.EncodeList(appendQuotation: false) + "]"
				},
				{ "client_context", value },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, sendDirectProfileUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> SendDirectProfileToRecipientsAsync(long userIdToSend, string recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendDirectProfileUri = UriCreator.GetSendDirectProfileUri();
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"profile_user_id",
					userIdToSend.ToString()
				},
				{ "action", "send_item" },
				{
					"recipient_users",
					"[[" + recipients + "]]"
				},
				{ "client_context", value },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, sendDirectProfileUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<InstaDirectInboxThreadList>> SendDirectTextAsync(string recipients, string threadIds, string text)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaDirectInboxThreadList threads = new InstaDirectInboxThreadList();
		try
		{
			Uri directSendMessageUri = UriCreator.GetDirectSendMessageUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, directSendMessageUri, _deviceInfo);
			Dictionary<string, string> dictionary = new Dictionary<string, string> { { "text", text } };
			if (!string.IsNullOrEmpty(recipients))
			{
				dictionary.Add("recipient_users", "[[" + recipients + "]]");
			}
			else
			{
				dictionary.Add("recipient_users", "[]");
			}
			if (!string.IsNullOrEmpty(threadIds))
			{
				dictionary.Add("thread_ids", "[" + threadIds + "]");
			}
			defaultRequest.Content = new FormUrlEncodedContent(dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDirectInboxThreadList>(response, text2);
			}
			InstaSendDirectMessageResponse instaSendDirectMessageResponse = JsonConvert.DeserializeObject<InstaSendDirectMessageResponse>(text2);
			if (!instaSendDirectMessageResponse.IsOk())
			{
				return Result.Fail<InstaDirectInboxThreadList>(instaSendDirectMessageResponse.Status);
			}
			threads.AddRange(instaSendDirectMessageResponse.Threads.Select((InstaDirectInboxThreadResponse thread) => ConvertersFabric.Instance.GetDirectThreadConverter(thread).Convert()));
			return Result.Success(threads);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxThreadList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxThreadList>(exception2);
		}
	}

	public async Task<IResult<bool>> SendDirectVideoAsync(InstaVideoUpload video, string threadId)
	{
		return await SendDirectVideoAsync(null, video, threadId);
	}

	public async Task<IResult<bool>> SendDirectVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(progress, isDirectVideo: true, isDisappearingVideo: false, "", InstaViewMode.Replayable, InstaStoryType.Both, null, threadId, video);
	}

	public async Task<IResult<bool>> SendDirectVideoToRecipientsAsync(InstaVideoUpload video, params string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await SendDirectVideoToRecipientsAsync(null, video, recipients);
	}

	public async Task<IResult<bool>> SendDirectVideoToRecipientsAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, params string[] recipients)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendVideoAsync(progress, isDirectVideo: true, isDisappearingVideo: false, "", InstaViewMode.Replayable, InstaStoryType.Both, recipients.EncodeList(appendQuotation: false), null, video);
	}

	public async Task<IResult<bool>> ShareMediaToThreadAsync(string mediaId, InstaMediaType mediaType, string text, params string[] threadIds)
	{
		try
		{
			if (threadIds == null || (threadIds != null && !threadIds.Any()))
			{
				throw new ArgumentException("At least one thread id required");
			}
			return await ShareMedia(mediaId, mediaType, text, threadIds, null);
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

	public async Task<IResult<bool>> ShareMediaToUserAsync(string mediaId, InstaMediaType mediaType, string text, params long[] userIds)
	{
		try
		{
			if (userIds == null || (userIds != null && !userIds.Any()))
			{
				throw new ArgumentException("At least one user id required");
			}
			return await ShareMedia(mediaId, mediaType, text, null, userIds);
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

	private async Task<IResult<bool>> ShareMedia(string mediaId, InstaMediaType mediaType, string text, string[] threadIds, long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri mediaShareUri = UriCreator.GetMediaShareUri(mediaType);
			string value = Guid.NewGuid().ToString();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "action", "send_item" },
				{ "client_context", value },
				{ "media_id", mediaId },
				{ "_csrftoken", _user.CsrfToken },
				{ "unified_broadcast_format", "1" },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"text",
					text ?? string.Empty
				}
			};
			if (threadIds != null)
			{
				dictionary.Add("thread_ids", "[" + threadIds.EncodeList(appendQuotation: false) + "]");
			}
			else
			{
				dictionary.Add("recipient_users", "[" + userIds.EncodeRecipients() + "]");
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, mediaShareUri, _deviceInfo, dictionary);
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

	public async Task<IResult<InstaSharing>> ShareUserAsync(string userIdToSend, string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri shareUserUri = UriCreator.GetShareUserUri();
			MultipartFormDataContent content = new MultipartFormDataContent(ApiRequestMessage.GenerateUploadId())
			{
				{
					new StringContent(userIdToSend),
					"\"profile_user_id\""
				},
				{
					new StringContent("1"),
					"\"unified_broadcast_format\""
				},
				{
					new StringContent("send_item"),
					"\"action\""
				},
				{
					new StringContent("[" + threadId + "]"),
					"\"thread_ids\""
				},
				{
					new StringContent(_deviceInfo.DeviceGuid.ToString()),
					"\"_uuid\""
				},
				{
					new StringContent(_user.LoggedInUser.Pk.ToString()),
					"\"_uid\""
				},
				{
					new StringContent(_user.CsrfToken),
					"\"_csrftoken\""
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, shareUserUri, _deviceInfo);
			defaultRequest.Content = content;
			defaultRequest.Headers.Add("Host", "i.instagram.com");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSharing>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSharing>(text));
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

	public async Task<IResult<bool>> UnLikeThreadMessageAsync(string threadId, string itemId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri likeUnlikeDirectMessageUri = UriCreator.GetLikeUnlikeDirectMessageUri();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "item_type", "reaction" },
				{ "reaction_type", "like" },
				{ "action", "send_item" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"thread_ids",
					"[" + threadId + "]"
				},
				{
					"client_context",
					Guid.NewGuid().ToString()
				},
				{ "node_type", "item" },
				{ "reaction_status", "deleted" },
				{ "item_id", itemId }
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, likeUnlikeDirectMessageUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> UnMuteDirectThreadAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri unMuteDirectThreadUri = UriCreator.GetUnMuteDirectThreadUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, unMuteDirectThreadUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	public async Task<IResult<bool>> UpdateDirectThreadTitleAsync(string threadId, string title)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri directThreadUpdateTitleUri = UriCreator.GetDirectThreadUpdateTitleUri(threadId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "title", title }
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, directThreadUpdateTitleUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	private async Task<IResult<bool>> DeclineDirectPendingRequests(bool all, params string[] threadIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri uri = UriCreator.GetDeclineAllPendingDirectRequestsUri();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			if (!all)
			{
				if (threadIds.Length == 1)
				{
					uri = UriCreator.GetDeclinePendingDirectRequestUri(threadIds.FirstOrDefault());
				}
				else
				{
					uri = UriCreator.GetDeclineMultplePendingDirectRequestsUri();
					dictionary.Add("thread_ids", threadIds.EncodeList(appendQuotation: false));
				}
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			InstaDefaultResponse instaDefaultResponse = JsonConvert.DeserializeObject<InstaDefaultResponse>(text);
			if (instaDefaultResponse.IsSucceed)
			{
				return Result.Success(resValue: true);
			}
			return Result.Fail("Error: " + instaDefaultResponse.Message, resValue: false);
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

	public async Task<IResult<bool>> SendDirectLikeAsync(string threadId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri directThreadBroadcastLikeUri = UriCreator.GetDirectThreadBroadcastLikeUri();
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "action", "send_item" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"thread_id",
					threadId ?? ""
				},
				{
					"client_context",
					Guid.NewGuid().ToString()
				}
			};
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, directThreadBroadcastLikeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
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

	private async Task<IResult<bool>> SendDirectPhoto(Action<InstaUploaderProgress> progress, string recipients, string threadId, InstaImage image)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = string.Empty,
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			Uri directSendPhotoUri = UriCreator.GetDirectSendPhotoUri();
			string text = ApiRequestMessage.GenerateRandomUploadId();
			Guid guid = Guid.NewGuid();
			upProgress.UploadId = text;
			progress?.Invoke(upProgress);
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(text)
			{
				{
					new StringContent("send_item"),
					"\"action\""
				},
				{
					new StringContent(guid.ToString()),
					"\"client_context\""
				},
				{
					new StringContent(_user.CsrfToken),
					"\"_csrftoken\""
				},
				{
					new StringContent(_deviceInfo.DeviceGuid.ToString()),
					"\"_uuid\""
				}
			};
			if (!string.IsNullOrEmpty(recipients))
			{
				multipartFormDataContent.Add(new StringContent("[[" + recipients + "]]"), "recipient_users");
			}
			else
			{
				multipartFormDataContent.Add(new StringContent("[" + threadId + "]"), "thread_ids");
			}
			byte[] content = ((image.ImageBytes != null) ? image.ImageBytes : File.ReadAllBytes(image.Uri));
			ByteArrayContent byteArrayContent = new ByteArrayContent(content);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			multipartFormDataContent.Add(byteArrayContent, "photo", "direct_temp_photo_" + ApiRequestMessage.GenerateUploadId() + ".jpg");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, directSendPhotoUri, _deviceInfo);
			defaultRequest.Content = multipartFormDataContent;
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<bool>(response, text2);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			if (JsonConvert.DeserializeObject<InstaDefault>(text2).Status.ToLower() == "ok")
			{
				upProgress.UploadState = InstaUploadState.Completed;
				progress?.Invoke(upProgress);
				return Result.Success(resValue: true);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<bool>(response, text2);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<bool>(exception2);
		}
	}

	private async Task<IResult<InstaDirectInboxContainerResponse>> GetDirectInbox(string maxId = null)
	{
		try
		{
			Uri directInboxUri = UriCreator.GetDirectInboxUri(maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, directInboxUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDirectInboxContainerResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaDirectInboxContainerResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxContainerResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxContainerResponse>(exception2);
		}
	}

	private async Task<IResult<InstaDirectInboxThreadResponse>> GetDirectInboxThread(string threadId, string maxId = null)
	{
		try
		{
			Uri directInboxThreadUri = UriCreator.GetDirectInboxThreadUri(threadId, maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, directInboxThreadUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDirectInboxThreadResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaDirectInboxThreadResponse>(text, new JsonConverter[1]
			{
				new InstaThreadDataConverter()
			}));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxThreadResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxThreadResponse>(exception2);
		}
	}

	private async Task<IResult<InstaDirectInboxContainerResponse>> GetPendingDirect(string maxId = null)
	{
		try
		{
			Uri directPendingInboxUri = UriCreator.GetDirectPendingInboxUri(maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, directPendingInboxUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaDirectInboxContainerResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaDirectInboxContainerResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaDirectInboxContainerResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaDirectInboxContainerResponse>(exception2);
		}
	}

	[CompilerGenerated]
	internal static InstaDirectInboxContainer smethod_0(InstaDirectInboxContainerResponse inboxContainerResponse)
	{
		return ConvertersFabric.Instance.GetDirectInboxConverter(inboxContainerResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaDirectInboxThread smethod_1(InstaDirectInboxThreadResponse inboxThreadResponse)
	{
		return ConvertersFabric.Instance.GetDirectThreadConverter(inboxThreadResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaDirectInboxContainer smethod_2(InstaDirectInboxContainerResponse inboxContainerResponse)
	{
		return ConvertersFabric.Instance.GetDirectInboxConverter(inboxContainerResponse).Convert();
	}
}
