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

internal class CommentProcessor : ICommentProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public CommentProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> BlockUserCommentingAsync(params long[] userIds)
	{
		return await BlockUnblockCommenting(block: true, userIds);
	}

	public async Task<IResult<InstaComment>> CommentMediaAsync(string mediaId, string text)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri postCommetUri = UriCreator.GetPostCommetUri(mediaId);
			string commentBreadCrumbEncoded = CryptoHelper.GetCommentBreadCrumbEncoded(text);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "user_breadcrumb", commentBreadCrumbEncoded },
				{
					"idempotence_token",
					Guid.NewGuid().ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "comment_text", text },
				{ "containermodule", "comments_feed_timeline" },
				{ "radio_type", "wifi-none" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, postCommetUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaComment>(response, text2);
			}
			InstaCommentResponse comment = JsonConvert.DeserializeObject<InstaCommentResponse>(text2, new JsonConverter[1]
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

	public async Task<IResult<bool>> DeleteCommentAsync(string mediaId, string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteCommentUri = UriCreator.GetDeleteCommentUri(mediaId, commentId);
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
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, deleteCommentUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> DeleteMultipleCommentsAsync(string mediaId, params string[] commentIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteMultipleCommentsUri = UriCreator.GetDeleteMultipleCommentsUri(mediaId);
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
					"comment_ids_to_delete",
					commentIds.EncodeList(appendQuotation: false)
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, deleteMultipleCommentsUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> DisableMediaCommentAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri disableMediaCommetsUri = UriCreator.GetDisableMediaCommetsUri(mediaId);
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
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, disableMediaCommetsUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> EnableMediaCommentAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri allowMediaCommetsUri = UriCreator.GetAllowMediaCommetsUri(mediaId);
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
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, allowMediaCommetsUri, _deviceInfo, data);
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

	public async Task<IResult<InstaUserShortList>> GetBlockedCommentersAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri blockedCommentersUri = UriCreator.GetBlockedCommentersUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, blockedCommentersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShortList>(response, text);
			}
			InstaBlockedCommentersResponse response2 = JsonConvert.DeserializeObject<InstaBlockedCommentersResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBlockedCommentersConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserShortList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserShortList>(exception2);
		}
	}

	public async Task<IResult<InstaLikersList>> GetMediaCommentLikersAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri mediaCommetLikersUri = UriCreator.GetMediaCommetLikersUri(mediaId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaCommetLikersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaLikersList>(response, text);
			}
			InstaLikersList instaLikersList = new InstaLikersList();
			InstaMediaLikersResponse instaMediaLikersResponse = JsonConvert.DeserializeObject<InstaMediaLikersResponse>(text);
			instaLikersList.UsersCount = instaMediaLikersResponse.UsersCount;
			instaLikersList.AddRange(from converter in instaMediaLikersResponse.Users.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert());
			return Result.Success(instaLikersList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaLikersList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaLikersList>(exception2);
		}
	}

	public async Task<IResult<InstaCommentList>> GetMediaCommentsAsync(string mediaId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri uri = UriCreator.GetMediaCommentsUri(mediaId, paginationParameters.NextMaxId);
			if (!string.IsNullOrEmpty(paginationParameters.NextMinId))
			{
				uri = UriCreator.GetMediaCommentsMinIdUri(mediaId, paginationParameters.NextMinId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCommentList>(response, text);
			}
			InstaCommentListResponse commentListResponse = JsonConvert.DeserializeObject<InstaCommentListResponse>(text);
			for (int pagesLoaded = 1; (commentListResponse.MoreCommentsAvailable && !string.IsNullOrEmpty(commentListResponse.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad) || (commentListResponse.MoreHeadLoadAvailable && !string.IsNullOrEmpty(commentListResponse.NextMinId) && pagesLoaded < paginationParameters.MaximumPagesToLoad); pagesLoaded++)
			{
				IResult<InstaCommentListResponse> result = (string.IsNullOrEmpty(commentListResponse.NextMaxId) ? (await GetCommentListWithMaxIdAsync(mediaId, null, commentListResponse.NextMinId)) : (await GetCommentListWithMaxIdAsync(mediaId, commentListResponse.NextMaxId, null)));
				if (result.Succeeded)
				{
					commentListResponse.NextMaxId = result.Value.NextMaxId;
					commentListResponse.NextMinId = result.Value.NextMinId;
					commentListResponse.MoreCommentsAvailable = result.Value.MoreCommentsAvailable;
					commentListResponse.MoreHeadLoadAvailable = result.Value.MoreHeadLoadAvailable;
					commentListResponse.Comments.AddRange(result.Value.Comments);
					paginationParameters.NextMaxId = result.Value.NextMaxId;
					paginationParameters.NextMinId = result.Value.NextMinId;
					continue;
				}
				return Result.Fail(result.Info, smethod_0(commentListResponse));
			}
			paginationParameters.NextMaxId = commentListResponse.NextMaxId;
			paginationParameters.NextMinId = commentListResponse.NextMinId;
			return Result.Success(ConvertersFabric.Instance.GetCommentListConverter(commentListResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCommentList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCommentList>(exception2);
		}
	}

	public async Task<IResult<InstaInlineCommentList>> GetMediaRepliesCommentsAsync(string mediaId, string targetCommentId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			Uri uri = UriCreator.GetMediaInlineCommentsUri(mediaId, targetCommentId, paginationParameters.NextMaxId);
			if (!string.IsNullOrEmpty(paginationParameters.NextMinId))
			{
				uri = UriCreator.GetMediaInlineCommentsWithMinIdUri(mediaId, targetCommentId, paginationParameters.NextMinId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaInlineCommentList>(response, text);
			}
			InstaInlineCommentListResponse commentListResponse = JsonConvert.DeserializeObject<InstaInlineCommentListResponse>(text);
			for (int pagesLoaded = 1; (commentListResponse.HasMoreTailChildComments && !string.IsNullOrEmpty(commentListResponse.NextMaxId) && pagesLoaded < paginationParameters.MaximumPagesToLoad) || (commentListResponse.HasMoreHeadChildComments && !string.IsNullOrEmpty(commentListResponse.NextMinId) && pagesLoaded < paginationParameters.MaximumPagesToLoad); pagesLoaded++)
			{
				IResult<InstaInlineCommentListResponse> result = (string.IsNullOrEmpty(commentListResponse.NextMaxId) ? (await GetInlineCommentListWithMaxIdAsync(mediaId, targetCommentId, null, commentListResponse.NextMinId)) : (await GetInlineCommentListWithMaxIdAsync(mediaId, targetCommentId, commentListResponse.NextMaxId, null)));
				if (result.Succeeded)
				{
					commentListResponse.NextMaxId = result.Value.NextMaxId;
					commentListResponse.NextMinId = result.Value.NextMinId;
					commentListResponse.HasMoreHeadChildComments = result.Value.HasMoreHeadChildComments;
					commentListResponse.HasMoreTailChildComments = result.Value.HasMoreTailChildComments;
					commentListResponse.ChildComments.AddRange(result.Value.ChildComments);
					paginationParameters.NextMaxId = result.Value.NextMaxId;
					paginationParameters.NextMinId = result.Value.NextMinId;
					continue;
				}
				return Result.Fail(result.Info, smethod_1(commentListResponse));
			}
			paginationParameters.NextMaxId = commentListResponse.NextMaxId;
			paginationParameters.NextMinId = commentListResponse.NextMinId;
			return Result.Success(ConvertersFabric.Instance.GetInlineCommentsConverter(commentListResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaInlineCommentList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaInlineCommentList>(exception2);
		}
	}

	public async Task<IResult<bool>> LikeCommentAsync(string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri likeCommentUri = UriCreator.GetLikeCommentUri(commentId);
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
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, likeCommentUri, _deviceInfo, data);
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

	public async Task<IResult<InstaComment>> ReplyCommentMediaAsync(string mediaId, string targetCommentId, string text)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri postCommetUri = UriCreator.GetPostCommetUri(mediaId);
			string commentBreadCrumbEncoded = CryptoHelper.GetCommentBreadCrumbEncoded(text);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "user_breadcrumb", commentBreadCrumbEncoded },
				{
					"idempotence_token",
					Guid.NewGuid().ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "replied_to_comment_id", targetCommentId },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "comment_text", text },
				{ "containermodule", "comments_feed_timeline" },
				{ "radio_type", "wifi-none" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, postCommetUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaComment>(response, text2);
			}
			InstaCommentResponse comment = JsonConvert.DeserializeObject<InstaCommentResponse>(text2, new JsonConverter[1]
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

	public async Task<IResult<bool>> ReportCommentAsync(string mediaId, string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri reportCommetUri = UriCreator.GetReportCommetUri(mediaId, commentId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "media_id", mediaId },
				{ "comment_id", commentId },
				{ "reason", "1" },
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, reportCommetUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> UnblockUserCommentingAsync(params long[] userIds)
	{
		return await BlockUnblockCommenting(block: false, userIds);
	}

	public async Task<IResult<bool>> UnlikeCommentAsync(string commentId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri unLikeCommentUri = UriCreator.GetUnLikeCommentUri(commentId);
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
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, unLikeCommentUri, _deviceInfo, data);
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

	public async Task<IResult<InstaTranslateList>> TranslateCommentAsync(params long[] commentIds)
	{
		try
		{
			if (commentIds != null && (commentIds == null || commentIds.Any()))
			{
				Uri translateCommentsUri = UriCreator.GetTranslateCommentsUri(string.Join(",", commentIds));
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, translateCommentsUri, _deviceInfo);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK && !string.IsNullOrEmpty(text))
				{
					InstaTranslateContainerResponse response2 = JsonConvert.DeserializeObject<InstaTranslateContainerResponse>(text);
					return Result.Success(ConvertersFabric.Instance.GetTranslateContainerConverter(response2).Convert());
				}
				return Result.UnExpectedResponse<InstaTranslateList>(response, text);
			}
			throw new ArgumentException("At least one comment id require");
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTranslateList>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTranslateList>(exception2);
		}
	}

	private async Task<IResult<InstaCommentListResponse>> GetCommentListWithMaxIdAsync(string mediaId, string nextMaxId, string nextMinId)
	{
		try
		{
			Uri uri = UriCreator.GetMediaCommentsUri(mediaId, nextMaxId);
			if (!string.IsNullOrEmpty(nextMinId))
			{
				uri = UriCreator.GetMediaCommentsMinIdUri(mediaId, nextMinId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaCommentListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaCommentListResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCommentListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCommentListResponse>(exception2);
		}
	}

	private async Task<IResult<InstaInlineCommentListResponse>> GetInlineCommentListWithMaxIdAsync(string mediaId, string targetCommandId, string nextMaxId, string nextMinId)
	{
		try
		{
			Uri uri = UriCreator.GetMediaInlineCommentsUri(mediaId, targetCommandId, nextMaxId);
			if (!string.IsNullOrEmpty(nextMinId))
			{
				uri = UriCreator.GetMediaInlineCommentsWithMinIdUri(mediaId, targetCommandId, nextMinId);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaInlineCommentListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaInlineCommentListResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaInlineCommentListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaInlineCommentListResponse>(exception2);
		}
	}

	private async Task<IResult<bool>> BlockUnblockCommenting(bool block, long[] userIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (userIds != null)
			{
				if (userIds == null || userIds.Length != 0)
				{
					goto IL_0051;
				}
			}
			Result.Fail<bool>("At least one user id (pk) is require");
			goto IL_0051;
			IL_0051:
			Uri setBlockedCommentersUri = UriCreator.GetSetBlockedCommentersUri();
			JObject jObject = new JObject();
			if (block)
			{
				jObject.Add("block", new JArray(userIds));
				jObject.Add("unblock", new JArray());
			}
			else
			{
				jObject.Add("block", new JArray());
				jObject.Add("unblock", new JArray(userIds));
			}
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
				{ "commenter_block_status", jObject }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setBlockedCommentersUri, _deviceInfo, data);
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

	[CompilerGenerated]
	internal static InstaCommentList smethod_0(InstaCommentListResponse commentsResponse)
	{
		return ConvertersFabric.Instance.GetCommentListConverter(commentsResponse).Convert();
	}

	[CompilerGenerated]
	internal static InstaInlineCommentList smethod_1(InstaInlineCommentListResponse commentsResponse)
	{
		return ConvertersFabric.Instance.GetInlineCommentsConverter(commentsResponse).Convert();
	}
}
