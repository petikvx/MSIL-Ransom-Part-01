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

internal class UserProcessor : IUserProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public UserProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaFriendshipStatus>> AcceptFriendshipRequestAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri acceptFriendshipUri = UriCreator.GetAcceptFriendshipUri(userId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"user_id",
					userId.ToString()
				},
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, acceptFriendshipUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFriendshipStatus>(response, text);
			}
			InstaFriendshipStatusResponse friendshipStatusResponse = JsonConvert.DeserializeObject<InstaFriendshipStatusResponse>(text, new JsonConverter[1]
			{
				new InstaFriendShipDataConverter()
			});
			return Result.Success(ConvertersFabric.Instance.GetFriendShipStatusConverter(friendshipStatusResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaFriendshipStatus>(exception2);
		}
	}

	public async Task<IResult<InstaFriendshipShortStatusList>> AddBestFriendsAsync(params long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		if (userIds != null && userIds.Length == 0)
		{
			return Result.Fail<InstaFriendshipShortStatusList>("At least 1 user id is require");
		}
		return await AddBestFriends(userIds, null);
	}

	public async Task<IResult<InstaFriendshipShortStatusList>> DeleteBestFriendsAsync(params long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		if (userIds != null && userIds.Length == 0)
		{
			return Result.Fail<InstaFriendshipShortStatusList>("At least 1 user id is require");
		}
		return await AddBestFriends(null, userIds);
	}

	public async Task<IResult<InstaFriendshipFullStatus>> BlockUserAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await BlockUnblockUserInternal(userId, UriCreator.GetBlockUserUri(userId));
	}

	public async Task<IResult<bool>> FavoriteUserAsync(long userId)
	{
		return await FavoriteUnfavoriteUser(UriCreator.GetFavoriteUserUri(userId), userId);
	}

	public async Task<IResult<bool>> FavoriteUserStoriesAsync(long userId)
	{
		return await FavoriteUnfavoriteUser(UriCreator.GetFavoriteForUserStoriesUri(userId), userId);
	}

	public async Task<IResult<InstaFriendshipFullStatus>> FollowUserAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await FollowUnfollowUserInternal(userId, UriCreator.GetFollowUserUri(userId));
	}

	public async Task<IResult<InstaUserShortList>> GetBestFriendsAsync(PaginationParameters paginationParameters)
	{
		return await GetBesties(paginationParameters);
	}

	public async Task<IResult<InstaUserShortList>> GetBestFriendsSuggestionsAsync(PaginationParameters paginationParameters)
	{
		return await GetBesties(paginationParameters, suggested: true);
	}

	public async Task<IResult<InstaBlockedUsers>> GetBlockedUsersAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaBlockedUsersResponse> blockedUsersResponse = await GetBlockedUsers(paginationParameters?.NextMaxId);
			if (!blockedUsersResponse.Succeeded)
			{
				if (blockedUsersResponse.Value != null)
				{
					return Result.Fail(blockedUsersResponse.Info, smethod_0(blockedUsersResponse.Value));
				}
				return Result.Fail<InstaBlockedUsers>(blockedUsersResponse.Info, null);
			}
			paginationParameters.NextMaxId = blockedUsersResponse.Value.MaxId;
			paginationParameters.PagesLoaded++;
			while (!string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaBlockedUsersResponse> result = await GetBlockedUsers(paginationParameters.NextMaxId);
				if (result.Succeeded)
				{
					blockedUsersResponse.Value.BlockedList.AddRange(result.Value.BlockedList);
					blockedUsersResponse.Value.PageSize = result.Value.PageSize;
					blockedUsersResponse.Value.BigList = result.Value.BigList;
					string text2 = (blockedUsersResponse.Value.MaxId = (paginationParameters.NextMaxId = result.Value.MaxId));
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result.Info, smethod_0(blockedUsersResponse.Value));
			}
			return Result.Success(smethod_0(blockedUsersResponse.Value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBlockedUsers>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBlockedUsers>(exception2);
		}
	}

	public async Task<IResult<InstaCurrentUser>> GetCurrentUserAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri currentUserUri = UriCreator.GetCurrentUserUri();
			Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
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
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, currentUserUri, _deviceInfo);
			defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCurrentUser>(response, text);
			}
			InstaCurrentUserResponse instaCurrentUserResponse = JsonConvert.DeserializeObject<InstaCurrentUserResponse>(text, new JsonConverter[1]
			{
				new InstaCurrentUserDataConverter()
			});
			if (instaCurrentUserResponse.Pk < 1L)
			{
				Result.Fail<InstaCurrentUser>("Pk is incorrect");
			}
			return Result.Success(ConvertersFabric.Instance.GetCurrentUserConverter(instaCurrentUserResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCurrentUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCurrentUser>(exception2);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetCurrentUserFollowersAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await GetUserFollowersAsync(_user.UserName, paginationParameters, string.Empty);
	}

	public async Task<IResult<InstaActivityFeed>> GetFollowingRecentActivityFeedAsync(PaginationParameters paginationParameters)
	{
		Uri followingRecentActivityUri = UriCreator.GetFollowingRecentActivityUri(paginationParameters.NextMaxId);
		return await GetRecentActivityInternalAsync(followingRecentActivityUri, paginationParameters);
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> GetFriendshipStatusAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userFriendshipUri = UriCreator.GetUserFriendshipUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userFriendshipUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryFriendshipStatus>(response, text);
			}
			InstaStoryFriendshipStatusResponse response2 = JsonConvert.DeserializeObject<InstaStoryFriendshipStatusResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetStoryFriendshipStatusConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStoryFriendshipStatus>(exception2);
		}
	}

	public async Task<IResult<InstaFriendshipShortStatusList>> GetFriendshipStatusesAsync(params long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (userIds != null && (userIds == null || userIds.Any()))
			{
				Uri friendshipShowManyUri = UriCreator.GetFriendshipShowManyUri();
				Dictionary<string, string> data = new Dictionary<string, string>
				{
					{ "_csrftoken", _user.CsrfToken },
					{
						"user_ids",
						string.Join(",", userIds)
					},
					{
						"_uuid",
						_deviceInfo.DeviceGuid.ToString()
					}
				};
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, friendshipShowManyUri, _deviceInfo, data);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					return Result.UnExpectedResponse<InstaFriendshipShortStatusList>(response, text);
				}
				InstaFriendshipShortStatusListResponse response2 = JsonConvert.DeserializeObject<InstaFriendshipShortStatusListResponse>(text, new JsonConverter[1]
				{
					new InstaFriendShipShortDataConverter()
				});
				return Result.Success(ConvertersFabric.Instance.GetFriendshipShortStatusListConverter(response2).Convert());
			}
			throw new ArgumentException("At least one user id is require.");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipShortStatusList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFriendshipShortStatusList>(exception2);
		}
	}

	public async Task<IResult<InstaFullUserInfo>> GetFullUserInfoAsync(long userId)
	{
		try
		{
			Uri fullUserInfoUri = UriCreator.GetFullUserInfoUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, fullUserInfoUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFullUserInfo>(response, text);
			}
			InstaFullUserInfoResponse response2 = JsonConvert.DeserializeObject<InstaFullUserInfoResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetFullUserInfoConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFullUserInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFullUserInfo>(exception2);
		}
	}

	public async Task<IResult<InstaPendingRequest>> GetPendingFriendRequestsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_006f;
				}
			}
			text = string.Empty;
			goto IL_006f;
			IL_006f:
			string csrfToken = text;
			_user.CsrfToken = csrfToken;
			Uri friendshipPendingRequestsUri = UriCreator.GetFriendshipPendingRequestsUri(_user.RankToken);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, friendshipPendingRequestsUri, _deviceInfo);
			defaultRequest.Properties.Add("ig_sig_key_version", "4");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				return Result.Success(JsonConvert.DeserializeObject<InstaPendingRequest>(value));
			}
			return Result.Fail<InstaPendingRequest>(response.StatusCode.ToString());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPendingRequest>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaPendingRequest>(exception2);
		}
	}

	public async Task<IResult<InstaActivityFeed>> GetRecentActivityFeedAsync(PaginationParameters paginationParameters)
	{
		Uri recentActivityUri = UriCreator.GetRecentActivityUri();
		return await GetRecentActivityInternalAsync(recentActivityUri, paginationParameters);
	}

	public async Task<IResult<InstaSuggestionItemList>> GetSuggestionDetailsAsync(params long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (userIds != null && (userIds == null || userIds.Any()))
			{
				Uri discoverSuggestionDetailsUri = UriCreator.GetDiscoverSuggestionDetailsUri(_user.LoggedInUser.Pk, userIds.ToList());
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, discoverSuggestionDetailsUri, _deviceInfo);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					return Result.UnExpectedResponse<InstaSuggestionItemList>(response, text);
				}
				InstaSuggestionItemListResponse response2 = JsonConvert.DeserializeObject<InstaSuggestionItemListResponse>(text, new JsonConverter[1]
				{
					new InstaSuggestionUserDetailDataConverter()
				});
				return Result.Success(ConvertersFabric.Instance.GetSuggestionItemListConverter(response2).Convert());
			}
			throw new ArgumentException("At least one user id is require.");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSuggestionItemList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSuggestionItemList>(exception2);
		}
	}

	public async Task<IResult<InstaSuggestions>> GetSuggestionUsersAsync(PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaSuggestionUserContainerResponse> suggestionsResponse = await GetSuggestionUsers(paginationParameters);
			if (!suggestionsResponse.Succeeded)
			{
				if (suggestionsResponse.Value != null)
				{
					return Result.Fail(suggestionsResponse.Info, smethod_1(suggestionsResponse.Value));
				}
				return Result.Fail<InstaSuggestions>(suggestionsResponse.Info, null);
			}
			paginationParameters.NextMaxId = suggestionsResponse.Value.MaxId;
			paginationParameters.PagesLoaded++;
			while (suggestionsResponse.Value.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaSuggestionUserContainerResponse> result = await GetSuggestionUsers(paginationParameters);
				if (result.Succeeded)
				{
					suggestionsResponse.Value.NewSuggestedUsers.Suggestions.AddRange(result.Value.NewSuggestedUsers.Suggestions);
					suggestionsResponse.Value.SuggestedUsers.Suggestions.AddRange(result.Value.SuggestedUsers.Suggestions);
					suggestionsResponse.Value.MoreAvailable = result.Value.MoreAvailable;
					string text2 = (suggestionsResponse.Value.MaxId = (paginationParameters.NextMaxId = result.Value.MaxId));
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result.Info, smethod_1(suggestionsResponse.Value));
			}
			return Result.Success(smethod_1(suggestionsResponse.Value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSuggestions>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSuggestions>(exception2);
		}
	}

	public async Task<IResult<InstaUser>> GetUserAsync(string username)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userUri = UriCreator.GetUserUri(username);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userUri, _deviceInfo);
			defaultRequest.Properties.Add(new KeyValuePair<string, object>("timezone_offset", InstaApiConstants.TIMEZONE_OFFSET.ToString()));
			defaultRequest.Properties.Add(new KeyValuePair<string, object>("count", "1"));
			defaultRequest.Properties.Add(new KeyValuePair<string, object>("rank_token", _user.RankToken));
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUser>(response, text);
			}
			InstaUserResponse instaUserResponse = JsonConvert.DeserializeObject<InstaSearchUserResponse>(text).Users?.FirstOrDefault((InstaUserResponse u) => u.UserName.ToLower() == username.ToLower().Replace("@", ""));
			if (instaUserResponse == null)
			{
				string text2 = "Can't find this user: " + username;
				_logger?.LogInfo(text2);
				return Result.Fail<InstaUser>(text2);
			}
			if (instaUserResponse.Pk < 1L)
			{
				Result.Fail<InstaUser>("Pk is incorrect");
			}
			return Result.Success(ConvertersFabric.Instance.GetUserConverter(instaUserResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUser>(exception2);
		}
	}

	public async Task<IResult<InstaUser>> GetUserFromNametagAsync(InstaImage nametagImage)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri usersNametagLookupUri = UriCreator.GetUsersNametagLookupUri();
			string boundary = ApiRequestMessage.GenerateUploadId();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{ "gallery", "true" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"waterfall_id",
					Guid.NewGuid().ToString()
				}
			};
			string signature = _httpHelper.GetSignature(data);
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(boundary)
			{
				{
					new StringContent("4"),
					"ig_sig_key_version"
				},
				{
					new StringContent(signature),
					"signed_body"
				}
			};
			byte[] content = ((nametagImage.ImageBytes != null) ? nametagImage.ImageBytes : File.ReadAllBytes(nametagImage.Uri));
			ByteArrayContent byteArrayContent = new ByteArrayContent(content);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			multipartFormDataContent.Add(byteArrayContent, "photo_0", "photo_0");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, usersNametagLookupUri, _deviceInfo);
			defaultRequest.Content = multipartFormDataContent;
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.Fail<InstaUser>("User not found.");
			}
			InstaUserContainerResponse instaUserContainerResponse = JsonConvert.DeserializeObject<InstaUserContainerResponse>(value);
			return Result.Success(ConvertersFabric.Instance.GetUserConverter(instaUserContainerResponse.User).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUser>(exception2);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetUserFollowersAsync(string username, PaginationParameters paginationParameters, string searchQuery, bool mutualsfirst = false)
	{
		try
		{
			IResult<InstaUser> result = await GetUserAsync(username);
			if (result.Succeeded)
			{
				if (result.Value.FriendshipStatus.IsPrivate && result.Value.UserName != _user.LoggedInUser.UserName && !result.Value.FriendshipStatus.Following)
				{
					return Result.Fail<InstaUserShortList>("You must be a follower of private accounts to be able to get user's followers", null);
				}
				return await GetUserFollowersByIdAsync(result.Value.Pk, paginationParameters, searchQuery, mutualsfirst);
			}
			return Result.Fail<InstaUserShortList>(result.Info, null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserShortList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserShortList>(exception2, null);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetUserFollowersByIdAsync(long userId, PaginationParameters paginationParameters, string searchQuery, bool mutualsfirst = false)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList followers = new InstaUserShortList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri userFollowersUri = UriCreator.GetUserFollowersUri(userId, _user.RankToken, searchQuery, mutualsfirst, paginationParameters.NextMaxId);
			IResult<InstaUserListShortResponse> result = await GetUserListByUriAsync(userFollowersUri);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaUserShortList>(result.Info, null);
			}
			followers.AddRange((from converter in result.Value.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			string text2 = (paginationParameters.NextMaxId = (followers.NextMaxId = result.Value.NextMaxId));
			int pagesLoaded = 1;
			while (!string.IsNullOrEmpty(result.Value.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				Uri userFollowersUri2 = UriCreator.GetUserFollowersUri(userId, _user.RankToken, searchQuery, mutualsfirst, result.Value.NextMaxId);
				result = await GetUserListByUriAsync(userFollowersUri2);
				if (result.Succeeded)
				{
					followers.AddRange((from converter in result.Value.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
						select converter.Convert()));
					pagesLoaded = (paginationParameters.PagesLoaded = pagesLoaded + 1);
					text2 = (paginationParameters.NextMaxId = (followers.NextMaxId = result.Value.NextMaxId));
					continue;
				}
				return Result.Fail(result.Info, followers);
			}
			return Result.Success(followers);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, followers, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, followers);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetUserFollowingAsync(string username, PaginationParameters paginationParameters, string searchQuery)
	{
		try
		{
			IResult<InstaUser> result = await GetUserAsync(username);
			if (result.Succeeded)
			{
				if (result.Value.FriendshipStatus.IsPrivate && result.Value.UserName != _user.LoggedInUser.UserName && !result.Value.FriendshipStatus.Following)
				{
					return Result.Fail<InstaUserShortList>("You must be a follower of private accounts to be able to get user's followings", null);
				}
				return await GetUserFollowingByIdAsync(result.Value.Pk, paginationParameters, searchQuery);
			}
			return Result.Fail<InstaUserShortList>(result.Info, null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserShortList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserShortList>(exception2, null);
		}
	}

	public async Task<IResult<InstaUserShortList>> GetUserFollowingByIdAsync(long userId, PaginationParameters paginationParameters, string searchQuery)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList following = new InstaUserShortList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri userFollowingUri = UriCreator.GetUserFollowingUri(userId, _user.RankToken, searchQuery, paginationParameters.NextMaxId);
			IResult<InstaUserListShortResponse> result = await GetUserListByUriAsync(userFollowingUri);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaUserShortList>(result.Info, null);
			}
			following.AddRange(from converter in result.Value.Items.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert());
			string text2 = (paginationParameters.NextMaxId = (following.NextMaxId = result.Value.NextMaxId));
			int pages = 1;
			while (!string.IsNullOrEmpty(following.NextMaxId) && pages < paginationParameters.MaximumPagesToLoad)
			{
				Uri userFollowingUri2 = UriCreator.GetUserFollowingUri(userId, _user.RankToken, searchQuery, result.Value.NextMaxId);
				result = await GetUserListByUriAsync(userFollowingUri2);
				if (result.Succeeded)
				{
					following.AddRange(from converter in result.Value.Items.Select(ConvertersFabric.Instance.GetUserShortConverter)
						select converter.Convert());
					pages = (paginationParameters.PagesLoaded = pages + 1);
					text2 = (paginationParameters.NextMaxId = (following.NextMaxId = result.Value.NextMaxId));
					continue;
				}
				return Result.Fail(result.Info, following);
			}
			return Result.Success(following);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, following, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, following);
		}
	}

	public async Task<IResult<InstaUserInfo>> GetUserInfoByIdAsync(long pk)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userInfoByIdUri = UriCreator.GetUserInfoByIdUri(pk);
			return await GetUserInfoAsync(userInfoByIdUri);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserInfo>(exception2);
		}
	}

	public async Task<IResult<InstaUserInfo>> GetUserInfoByUsernameAsync(string username)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri userInfoByUsernameUri = UriCreator.GetUserInfoByUsernameUri(username);
			return await GetUserInfoAsync(userInfoByUsernameUri);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserInfo>(exception2);
		}
	}

	public async Task<IResult<InstaMediaList>> GetUserMediaAsync(string username, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		IResult<InstaUser> result = await GetUserAsync(username);
		if (!result.Succeeded)
		{
			return Result.Fail<InstaMediaList>("Unable to get user to load media");
		}
		return await GetUserMediaByIdAsync(result.Value.Pk, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetUserMediaByIdAsync(long userId, PaginationParameters paginationParameters)
	{
		InstaMediaList mediaList = new InstaMediaList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetUserMedia(userId, paginationParameters);
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					return Result.Fail(result.Info, smethod_2(result.Value));
				}
				return Result.Fail<InstaMediaList>(result.Info, null);
			}
			InstaMediaListResponse mediaResponse = result.Value;
			mediaList = smethod_2(mediaResponse);
			string text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = mediaResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (mediaResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaMediaListResponse> result2 = await GetUserMedia(userId, paginationParameters);
				if (result2.Succeeded)
				{
					mediaResponse.MoreAvailable = result2.Value.MoreAvailable;
					mediaResponse.ResultsCount += result2.Value.ResultsCount;
					InstaMediaList instaMediaList = mediaList;
					string text3 = (paginationParameters.NextMaxId = result2.Value.NextMaxId);
					text2 = (instaMediaList.NextMaxId = (mediaResponse.NextMaxId = text3));
					mediaList.AddRange(smethod_2(result2.Value));
					paginationParameters.PagesLoaded++;
					continue;
				}
				return Result.Fail(result2.Info, mediaList);
			}
			mediaList.Pages = paginationParameters.PagesLoaded;
			mediaList.PageSize = mediaResponse.ResultsCount;
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
			return Result.Fail(exception2, mediaList);
		}
	}

	public async Task<IResult<InstaMediaList>> GetUserShoppableMediaAsync(string username, PaginationParameters paginationParameters)
	{
		return await _instaApi.ShoppingProcessor.GetUserShoppableMediaAsync(username, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetUserTagsAsync(string username, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		IResult<InstaUser> result = await GetUserAsync(username);
		if (!result.Succeeded)
		{
			return Result.Fail<InstaMediaList>("Unable to get user " + username + " to get tags", null);
		}
		return await GetUserTagsAsync(result.Value.Pk, paginationParameters);
	}

	public async Task<IResult<InstaMediaList>> GetUserTagsAsync(long userId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaMediaList userTags = new InstaMediaList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetUserTags(userId, paginationParameters);
			if (!result.Succeeded)
			{
				if (result.Value != null)
				{
					userTags.AddRange(smethod_3(result.Value));
					return Result.Fail(result.Info, userTags);
				}
				return Result.Fail<InstaMediaList>(result.Info, null);
			}
			InstaMediaListResponse mediaResponse = result.Value;
			userTags.AddRange(smethod_3(mediaResponse));
			string text2 = (userTags.NextMaxId = (paginationParameters.NextMaxId = mediaResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (mediaResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				IResult<InstaMediaListResponse> result2 = await GetUserTags(userId, paginationParameters);
				if (result2.Succeeded)
				{
					userTags.AddRange(smethod_3(result2.Value));
					PaginationParameters paginationParameters2 = paginationParameters;
					string text3 = (mediaResponse.NextMaxId = result2.Value.NextMaxId);
					text2 = (userTags.NextMaxId = (paginationParameters2.NextMaxId = text3));
					mediaResponse.AutoLoadMoreEnabled = result2.Value.AutoLoadMoreEnabled;
					mediaResponse.MoreAvailable = result2.Value.MoreAvailable;
					mediaResponse.RankToken = result2.Value.RankToken;
					mediaResponse.TotalCount += result2.Value.TotalCount;
					mediaResponse.ResultsCount += result2.Value.ResultsCount;
					continue;
				}
				return Result.Fail(result2.Info, userTags);
			}
			userTags.PageSize = mediaResponse.ResultsCount;
			userTags.Pages = paginationParameters.PagesLoaded;
			return Result.Success(userTags);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, userTags, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, userTags);
		}
	}

	public async Task<IResult<InstaFriendshipFullStatus>> IgnoreFriendshipRequestAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri denyFriendshipUri = UriCreator.GetDenyFriendshipUri(userId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"user_id",
					userId.ToString()
				},
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, denyFriendshipUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFriendshipFullStatus>(response, text);
			}
			InstaFriendshipFullStatusContainerResponse instaFriendshipFullStatusContainerResponse = JsonConvert.DeserializeObject<InstaFriendshipFullStatusContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetFriendshipFullStatusConverter(instaFriendshipFullStatusContainerResponse.FriendshipStatus).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipFullStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaFriendshipFullStatus>(exception2);
		}
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> HideMyStoryFromUserAsync(long userId)
	{
		return await HideUnhideMyStoryFromUser(UriCreator.GetHideMyStoryFromUserUri(userId));
	}

	public async Task<IResult<bool>> MarkUserAsOverageAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri markUserOverageUri = UriCreator.GetMarkUserOverageUri(userId);
			JObject data = new JObject
			{
				{
					"user_id",
					userId.ToString()
				},
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, markUserOverageUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(await response.Content.ReadAsStringAsync());
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, instaDefault.Message, null);
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
			return Result.Fail<bool>(exception2);
		}
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> MuteFriendStoryAsync(long userId)
	{
		return await MuteUnMuteFriendStory(UriCreator.GetMuteFriendStoryUri(userId));
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> MuteUserMediaAsync(long userId, InstaMuteOption unmuteOption)
	{
		return await MuteUnMuteUserMedia(UriCreator.GetMuteUserMediaStoryUri(userId), userId, unmuteOption);
	}

	public async Task<IResult<bool>> ReportUserAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri reportUserUri = UriCreator.GetReportUserUri(userId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"user_id",
					userId.ToString()
				},
				{ "source_name", "profile" },
				{ "reason", "1" },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "is_spam", "true" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, reportUserUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response.Content.ReadAsStringAsync();
			return (response.StatusCode == HttpStatusCode.OK) ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, json);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, resValue: false);
		}
	}

	public async Task<IResult<InstaFriendshipFullStatus>> UnBlockUserAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await BlockUnblockUserInternal(userId, UriCreator.GetUnBlockUserUri(userId));
	}

	public async Task<IResult<bool>> UnFavoriteUserAsync(long userId)
	{
		return await FavoriteUnfavoriteUser(UriCreator.GetUnFavoriteUserUri(userId), userId);
	}

	public async Task<IResult<bool>> UnFavoriteUserStoriesAsync(long userId)
	{
		return await FavoriteUnfavoriteUser(UriCreator.GetUnFavoriteForUserStoriesUri(userId), userId);
	}

	public async Task<IResult<InstaFriendshipFullStatus>> UnFollowUserAsync(long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await FollowUnfollowUserInternal(userId, UriCreator.GetUnFollowUserUri(userId));
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> UnHideMyStoryFromUserAsync(long userId)
	{
		return await HideUnhideMyStoryFromUser(UriCreator.GetUnHideMyStoryFromUserUri(userId));
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> UnMuteFriendStoryAsync(long userId)
	{
		return await MuteUnMuteFriendStory(UriCreator.GetUnMuteFriendStoryUri(userId));
	}

	public async Task<IResult<InstaStoryFriendshipStatus>> UnMuteUserMediaAsync(long userId, InstaMuteOption unmuteOption)
	{
		return await MuteUnMuteUserMedia(UriCreator.GetUnMuteUserMediaStoryUri(userId), userId, unmuteOption);
	}

	public async Task<IResult<InstaFriendshipStatus>> RemoveFollowerAsync(long userId)
	{
		try
		{
			Uri removeFollowerUri = UriCreator.GetRemoveFollowerUri(userId);
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"user_id",
					userId.ToString()
				},
				{ "radio_type", "wifi-none" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, removeFollowerUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(text))
			{
				InstaFriendshipStatusResponse friendshipStatusResponse = JsonConvert.DeserializeObject<InstaFriendshipStatusResponse>(text, new JsonConverter[1]
				{
					new InstaFriendShipDataConverter()
				});
				return Result.Success(ConvertersFabric.Instance.GetFriendShipStatusConverter(friendshipStatusResponse).Convert());
			}
			return Result.UnExpectedResponse<InstaFriendshipStatus>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFriendshipStatus>(exception2);
		}
	}

	public async Task<IResult<string>> TranslateBiographyAsync(long userId)
	{
		try
		{
			Uri translateBiographyUri = UriCreator.GetTranslateBiographyUri(userId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, translateBiographyUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(text))
			{
				InstaTranslateBioResponse instaTranslateBioResponse = JsonConvert.DeserializeObject<InstaTranslateBioResponse>(text);
				return (instaTranslateBioResponse.Status.ToLower() == "ok") ? Result.Success(instaTranslateBioResponse.Translation) : Result.Fail<string>(instaTranslateBioResponse.Message);
			}
			return Result.UnExpectedResponse<string>(response, text);
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

	private async Task<IResult<InstaFriendshipShortStatusList>> AddBestFriends(long[] userIdsToAdd, long[] userIdsToRemove)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setBestFriendsUri = UriCreator.GetSetBestFriendsUri();
			JObject jObject = new JObject
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
				{ "module", "favorites_home_list" },
				{ "source", "audience_manager" }
			};
			if (userIdsToAdd != null && userIdsToAdd.Length != 0)
			{
				JArray value = new JArray { userIdsToAdd };
				jObject.Add("add", value);
				jObject.Add("remove", new JArray());
			}
			else
			{
				JArray value2 = new JArray { userIdsToRemove };
				jObject.Add("add", new JArray());
				jObject.Add("remove", value2);
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setBestFriendsUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaFriendshipShortStatusList>(response, text);
			}
			InstaFriendshipShortStatusListResponse response2 = JsonConvert.DeserializeObject<InstaFriendshipShortStatusListResponse>(text, new JsonConverter[1]
			{
				new InstaFriendShipShortDataConverter()
			});
			return Result.Success(ConvertersFabric.Instance.GetFriendshipShortStatusListConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipShortStatusList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFriendshipShortStatusList>(exception2);
		}
	}

	private async Task<IResult<InstaFriendshipFullStatus>> BlockUnblockUserInternal(long userId, Uri instaUri)
	{
		try
		{
			Dictionary<string, string> data = new Dictionary<string, string>
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
					"user_id",
					userId.ToString()
				},
				{ "radio_type", "wifi-none" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(text))
			{
				InstaFriendshipFullStatusContainerResponse instaFriendshipFullStatusContainerResponse = JsonConvert.DeserializeObject<InstaFriendshipFullStatusContainerResponse>(text);
				return Result.Success(ConvertersFabric.Instance.GetFriendshipFullStatusConverter(instaFriendshipFullStatusContainerResponse.FriendshipStatus).Convert());
			}
			return Result.UnExpectedResponse<InstaFriendshipFullStatus>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipFullStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFriendshipFullStatus>(exception2);
		}
	}

	private async Task<IResult<InstaFriendshipFullStatus>> FollowUnfollowUserInternal(long userId, Uri instaUri)
	{
		try
		{
			Dictionary<string, string> data = new Dictionary<string, string>
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
					"user_id",
					userId.ToString()
				},
				{ "radio_type", "wifi-none" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(text))
			{
				InstaFriendshipFullStatusContainerResponse instaFriendshipFullStatusContainerResponse = JsonConvert.DeserializeObject<InstaFriendshipFullStatusContainerResponse>(text);
				return Result.Success(ConvertersFabric.Instance.GetFriendshipFullStatusConverter(instaFriendshipFullStatusContainerResponse.FriendshipStatus).Convert());
			}
			return Result.UnExpectedResponse<InstaFriendshipFullStatus>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaFriendshipFullStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaFriendshipFullStatus>(exception2);
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
			while (!string.IsNullOrEmpty(nextMaxId) && paginationParameters.PagesLoaded <= paginationParameters.MaximumPagesToLoad)
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

	private async Task<IResult<InstaBlockedUsersResponse>> GetBlockedUsers(string maxId)
	{
		try
		{
			Uri blockedUsersUri = UriCreator.GetBlockedUsersUri(maxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, blockedUsersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBlockedUsersResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBlockedUsersResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBlockedUsersResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBlockedUsersResponse>(exception2);
		}
	}

	private async Task<IResult<InstaSuggestionUserContainerResponse>> GetSuggestionUsers(PaginationParameters paginationParameters)
	{
		try
		{
			Uri discoverPeopleUri = UriCreator.GetDiscoverPeopleUri();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "module", "discover_people" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "paginate", "true" }
			};
			if (paginationParameters != null && !string.IsNullOrEmpty(paginationParameters.NextMaxId))
			{
				dictionary.Add("max_id", paginationParameters.NextMaxId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, discoverPeopleUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaSuggestionUserContainerResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaSuggestionUserContainerResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaSuggestionUserContainerResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaSuggestionUserContainerResponse>(exception2);
		}
	}

	private async Task<IResult<InstaUserInfo>> GetUserInfoAsync(Uri userUri)
	{
		try
		{
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserInfo>(response, text);
			}
			InstaUserInfoContainerResponse response2 = JsonConvert.DeserializeObject<InstaUserInfoContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetUserInfoConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserInfo>(exception2);
		}
	}

	private async Task<IResult<InstaUserShortList>> GetBesties(PaginationParameters paginationParameters, bool suggested = false)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUserShortList besties = new InstaUserShortList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri uri = UriCreator.GetBestFriendsUri(paginationParameters.NextMaxId);
			if (suggested)
			{
				uri = UriCreator.GetBestiesSuggestionUri(paginationParameters.NextMaxId);
			}
			IResult<InstaUserListShortResponse> result = await GetUserListByUriAsync(uri);
			if (!result.Succeeded)
			{
				return Result.Fail<InstaUserShortList>(result.Info, null);
			}
			besties.AddRange((from converter in result.Value.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert()));
			string text2 = (paginationParameters.NextMaxId = (besties.NextMaxId = result.Value.NextMaxId));
			int pagesLoaded = 1;
			while (!string.IsNullOrEmpty(result.Value.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				Uri uri2 = UriCreator.GetBestFriendsUri(result.Value.NextMaxId);
				if (suggested)
				{
					uri2 = UriCreator.GetBestiesSuggestionUri(result.Value.NextMaxId);
				}
				result = await GetUserListByUriAsync(uri2);
				if (result.Succeeded)
				{
					besties.AddRange((from converter in result.Value.Items?.Select(ConvertersFabric.Instance.GetUserShortConverter)
						select converter.Convert()));
					pagesLoaded = (paginationParameters.PagesLoaded = pagesLoaded + 1);
					text2 = (paginationParameters.NextMaxId = (besties.NextMaxId = result.Value.NextMaxId));
					continue;
				}
				return Result.Fail(result.Info, besties);
			}
			return Result.Success(besties);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, besties, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, besties);
		}
	}

	private async Task<IResult<InstaUserListShortResponse>> GetUserListByUriAsync(Uri uri)
	{
		try
		{
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserListShortResponse>(response, text);
			}
			InstaUserListShortResponse instaUserListShortResponse = JsonConvert.DeserializeObject<InstaUserListShortResponse>(text);
			if (instaUserListShortResponse.IsOk())
			{
				return Result.Success(instaUserListShortResponse);
			}
			return Result.UnExpectedResponse<InstaUserListShortResponse>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserListShortResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserListShortResponse>(exception2);
		}
	}

	private async Task<IResult<InstaMediaListResponse>> GetUserMedia(long userId, PaginationParameters paginationParameters)
	{
		try
		{
			Uri userMediaListUri = UriCreator.GetUserMediaListUri(userId, paginationParameters.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userMediaListUri, _deviceInfo);
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
			return Result.Fail<InstaMediaListResponse>(exception2, null);
		}
	}

	private async Task<IResult<bool>> FavoriteUnfavoriteUser(Uri instaUri, long userId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject data = new JObject
			{
				{
					"user_id",
					userId.ToString()
				},
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(await response.Content.ReadAsStringAsync());
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, instaDefault.Message, null);
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
			return Result.Fail<bool>(exception2);
		}
	}

	private async Task<IResult<InstaStoryFriendshipStatus>> MuteUnMuteUserMedia(Uri instaUri, long userId, InstaMuteOption muteUnmuteOption)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject jObject = new JObject
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
			switch (muteUnmuteOption)
			{
			case InstaMuteOption.All:
				jObject.Add("target_reel_author_id", userId.ToString());
				jObject.Add("target_posts_author_id", userId.ToString());
				break;
			case InstaMuteOption.Story:
				jObject.Add("target_reel_author_id", userId.ToString());
				break;
			case InstaMuteOption.Post:
				jObject.Add("target_posts_author_id", userId.ToString());
				break;
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(value);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryFriendshipStatus>(response, instaDefault.Message, null);
			}
			InstaStoryFriendshipStatusContainerResponse instaStoryFriendshipStatusContainerResponse = JsonConvert.DeserializeObject<InstaStoryFriendshipStatusContainerResponse>(value);
			return Result.Success(ConvertersFabric.Instance.GetStoryFriendshipStatusConverter(instaStoryFriendshipStatusContainerResponse.FriendshipStatus).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaStoryFriendshipStatus>(exception2);
		}
	}

	private async Task<IResult<InstaStoryFriendshipStatus>> HideUnhideMyStoryFromUser(Uri instaUri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			JObject data = new JObject
			{
				{ "source", "profile" },
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(value);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryFriendshipStatus>(response, instaDefault.Message, null);
			}
			InstaStoryFriendshipStatusContainerResponse instaStoryFriendshipStatusContainerResponse = JsonConvert.DeserializeObject<InstaStoryFriendshipStatusContainerResponse>(value);
			return Result.Success(ConvertersFabric.Instance.GetStoryFriendshipStatusConverter(instaStoryFriendshipStatusContainerResponse.FriendshipStatus).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaStoryFriendshipStatus>(exception2);
		}
	}

	private async Task<IResult<InstaStoryFriendshipStatus>> MuteUnMuteFriendStory(Uri instaUri)
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
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(value);
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStoryFriendshipStatus>(response, instaDefault.Message, null);
			}
			InstaStoryFriendshipStatusContainerResponse instaStoryFriendshipStatusContainerResponse = JsonConvert.DeserializeObject<InstaStoryFriendshipStatusContainerResponse>(value);
			return Result.Success(ConvertersFabric.Instance.GetStoryFriendshipStatusConverter(instaStoryFriendshipStatusContainerResponse.FriendshipStatus).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStoryFriendshipStatus>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaStoryFriendshipStatus>(exception2);
		}
	}

	private async Task<IResult<InstaMediaListResponse>> GetUserTags(long userId, PaginationParameters paginationParameters)
	{
		try
		{
			Uri userTagsUri = UriCreator.GetUserTagsUri(userId, _user.RankToken, paginationParameters?.NextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, userTagsUri, _deviceInfo);
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
			return Result.Fail<InstaMediaListResponse>(exception2, null);
		}
	}

	[CompilerGenerated]
	internal static InstaBlockedUsers smethod_0(InstaBlockedUsersResponse instaBlockedUsers)
	{
		return ConvertersFabric.Instance.GetBlockedUsersConverter(instaBlockedUsers).Convert();
	}

	[CompilerGenerated]
	internal static InstaSuggestions smethod_1(InstaSuggestionUserContainerResponse suggestResponse)
	{
		return ConvertersFabric.Instance.GetSuggestionsConverter(suggestResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_2(InstaMediaListResponse mediaListResponse)
	{
		return ConvertersFabric.Instance.GetMediaListConverter(mediaListResponse).Convert();
	}

	[CompilerGenerated]
	internal static IEnumerable<InstaMedia> smethod_3(InstaMediaListResponse mediaListResponse)
	{
		return from converter in mediaListResponse.Medias.Select(ConvertersFabric.Instance.GetSingleMediaConverter)
			select converter.Convert();
	}
}
