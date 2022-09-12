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

internal class MediaProcessor : IMediaProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public MediaProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> ArchiveMediaAsync(string mediaId)
	{
		return await LikeUnlikeArchiveUnArchiveMediaInternal(mediaId, UriCreator.GetArchiveMediaUri(mediaId));
	}

	public async Task<IResult<bool>> DeleteMediaAsync(string mediaId, InstaMediaType mediaType)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri deleteMediaUri = UriCreator.GetDeleteMediaUri(mediaId, mediaType);
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
				{ "media_id", mediaId }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, deleteMediaUri, _deviceInfo, data);
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

	public async Task<IResult<InstaMedia>> EditMediaAsync(string mediaId, string caption, InstaLocationShort location = null, InstaUserTagUpload[] userTags = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri editMediaUri = UriCreator.GetEditMediaUri(mediaId);
			IResult<InstaMedia> result = await GetMediaByIdAsync(mediaId);
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
				{
					"caption_text",
					caption ?? string.Empty
				}
			};
			if (location != null)
			{
				data.Add("location", location.GetJson());
			}
			JArray removeArr = new JArray();
			if (result.Succeeded)
			{
				InstaMedia value = result.Value;
				if (value != null && value.UserTags?.Count > 0)
				{
					foreach (InstaUserTag userTag in result.Value.UserTags)
					{
						removeArr.Add(userTag.User.Pk.ToString());
					}
				}
			}
			if (userTags != null && userTags.Length != 0)
			{
				IRequestDelay currentDelay = _instaApi.GetRequestDelay();
				_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
				JArray tagArr = new JArray();
				foreach (InstaUserTagUpload tag in userTags)
				{
					try
					{
						bool tried = false;
						while (true)
						{
							IResult<InstaUser> result2 = await _instaApi.UserProcessor.GetUserAsync(tag.Username);
							if (!result2.Succeeded)
							{
								if (!tried)
								{
									tried = true;
									continue;
								}
								break;
							}
							JArray value2 = new JArray(tag.X, tag.Y);
							JObject item = new JObject
							{
								{
									"user_id",
									result2.Value.Pk
								},
								{ "position", value2 }
							};
							tagArr.Add(item);
							break;
						}
					}
					catch
					{
					}
				}
				_instaApi.SetRequestDelay(currentDelay);
				JObject jObject = new JObject { { "in", tagArr } };
				if (removeArr.Any())
				{
					jObject.Add("removed", removeArr);
				}
				data.Add("usertags", jObject.ToString(Formatting.None));
			}
			else if (removeArr.Any())
			{
				JObject jObject2 = new JObject { { "removed", removeArr } };
				data.Add("usertags", jObject2.ToString(Formatting.None));
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, editMediaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value3 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				InstaMediaItemResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaItemResponse>(value3, new JsonConverter[1]
				{
					new InstaMediaDataConverter()
				});
				return Result.Success(ConvertersFabric.Instance.GetSingleMediaConverter(responseMedia).Convert());
			}
			return Result.Fail<InstaMedia>(JsonConvert.DeserializeObject<BadStatusResponse>(value3).Message, null);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	public async Task<IResult<InstaMediaList>> GetArchivedMediaAsync(PaginationParameters paginationParameters)
	{
		InstaMediaList mediaList = new InstaMediaList();
		try
		{
			if (paginationParameters == null)
			{
				paginationParameters = PaginationParameters.MaxPagesToLoad(1);
			}
			IResult<InstaMediaListResponse> result = await GetArchivedMedia(paginationParameters?.NextMaxId);
			if (!result.Succeeded)
			{
				return Result.Fail(result.Info, mediaList);
			}
			InstaMediaListResponse archivedResponse = result.Value;
			mediaList = smethod_0(archivedResponse);
			string text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = archivedResponse.NextMaxId));
			paginationParameters.PagesLoaded++;
			while (archivedResponse.MoreAvailable && !string.IsNullOrEmpty(paginationParameters.NextMaxId) && paginationParameters.PagesLoaded < paginationParameters.MaximumPagesToLoad)
			{
				paginationParameters.PagesLoaded++;
				IResult<InstaMediaListResponse> result2 = await GetArchivedMedia(paginationParameters.NextMaxId);
				if (!result2.Succeeded)
				{
					return Result.Fail(result2.Info, mediaList);
				}
				text2 = (mediaList.NextMaxId = (paginationParameters.NextMaxId = result2.Value.NextMaxId));
				archivedResponse.MoreAvailable = result2.Value.MoreAvailable;
				archivedResponse.ResultsCount += result2.Value.ResultsCount;
				mediaList.AddRange(smethod_0(result2.Value));
				paginationParameters.PagesLoaded++;
			}
			mediaList.Pages = paginationParameters.PagesLoaded;
			mediaList.PageSize = archivedResponse.ResultsCount;
			return Result.Success(mediaList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, mediaList, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, mediaList);
		}
	}

	public async Task<IResult<InstaMediaIdList>> GetBlockedMediasAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaMediaIdList mediaIds = new InstaMediaIdList();
		try
		{
			Uri blockedMediaUri = UriCreator.GetBlockedMediaUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, blockedMediaUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaIdList>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaMediaIdsResponse>(text).MediaIds);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, mediaIds, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, mediaIds);
		}
	}

	public async Task<IResult<InstaMediaList>> GetMediaByIdsAsync(params string[] mediaIds)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaMediaList mediaList = new InstaMediaList();
		try
		{
			if (mediaIds != null && mediaIds.Length == 0)
			{
				throw new ArgumentNullException("At least one media id is required");
			}
			Uri mediaInfoByMultipleMediaIdsUri = UriCreator.GetMediaInfoByMultipleMediaIdsUri(mediaIds, _deviceInfo.DeviceGuid.ToString(), _user.CsrfToken);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaInfoByMultipleMediaIdsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaList>(response, text);
			}
			InstaMediaListResponse mediaResponse = JsonConvert.DeserializeObject<InstaMediaListResponse>(text, new JsonConverter[1]
			{
				new InstaMediaListDataConverter()
			});
			mediaList = ConvertersFabric.Instance.GetMediaListConverter(mediaResponse).Convert();
			return Result.Success(mediaList);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, mediaList, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail(exception2, mediaList);
		}
	}

	public async Task<IResult<InstaMedia>> GetMediaByIdAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri mediaUri = UriCreator.GetMediaUri(mediaId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMedia>(response, text);
			}
			InstaMediaListResponse instaMediaListResponse = JsonConvert.DeserializeObject<InstaMediaListResponse>(text, new JsonConverter[1]
			{
				new InstaMediaListDataConverter()
			});
			List<InstaMediaItemResponse> medias = instaMediaListResponse.Medias;
			if (medias != null && medias.Count > 1)
			{
				string text2 = "Got wrong media count for request with media id=" + mediaId;
				_logger?.LogInfo(text2);
				return Result.Fail<InstaMedia>(text2);
			}
			return Result.Success(ConvertersFabric.Instance.GetSingleMediaConverter(instaMediaListResponse.Medias.FirstOrDefault()).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	public async Task<IResult<string>> GetMediaIdFromUrlAsync(Uri uri)
	{
		try
		{
			Uri mediaIdFromUrlUri = UriCreator.GetMediaIdFromUrlUri(uri);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaIdFromUrlUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<string>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaOembedUrlResponse>(text).MediaId);
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

	public async Task<IResult<InstaLikersList>> GetMediaLikersAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			InstaLikersList likers = new InstaLikersList();
			Uri mediaLikersUri = UriCreator.GetMediaLikersUri(mediaId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, mediaLikersUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaLikersList>(response, text);
			}
			InstaMediaLikersResponse instaMediaLikersResponse = JsonConvert.DeserializeObject<InstaMediaLikersResponse>(text);
			likers.UsersCount = instaMediaLikersResponse.UsersCount;
			if (instaMediaLikersResponse.UsersCount < 1)
			{
				return Result.Success(likers);
			}
			likers.AddRange(from converter in instaMediaLikersResponse.Users.Select(ConvertersFabric.Instance.GetUserShortConverter)
				select converter.Convert());
			return Result.Success(likers);
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

	public async Task<IResult<Uri>> GetShareLinkFromMediaIdAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri shareLinkFromMediaId = UriCreator.GetShareLinkFromMediaId(mediaId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, shareLinkFromMediaId, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<Uri>(response, text);
			}
			return Result.Success(new Uri(JsonConvert.DeserializeObject<InstaPermalinkResponse>(text).Permalink));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<Uri>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<Uri>(exception2);
		}
	}

	public async Task<IResult<bool>> LikeMediaAsync(string mediaId)
	{
		return await LikeUnlikeArchiveUnArchiveMediaInternal(mediaId, UriCreator.GetLikeMediaUri(mediaId));
	}

	public async Task<IResult<bool>> ReportMediaAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri reportMediaUri = UriCreator.GetReportMediaUri(mediaId);
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "media_id", mediaId },
				{ "reason", "1" },
				{ "source_name", "photo_view_profile" },
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, reportMediaUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> SaveMediaAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri saveMediaUri = UriCreator.GetSaveMediaUri(mediaId);
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, saveMediaUri, _deviceInfo, data);
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

	public async Task<IResult<bool>> UnArchiveMediaAsync(string mediaId)
	{
		return await LikeUnlikeArchiveUnArchiveMediaInternal(mediaId, UriCreator.GetUnArchiveMediaUri(mediaId));
	}

	public async Task<IResult<bool>> UnLikeMediaAsync(string mediaId)
	{
		return await LikeUnlikeArchiveUnArchiveMediaInternal(mediaId, UriCreator.GetUnLikeMediaUri(mediaId));
	}

	public async Task<IResult<bool>> UnSaveMediaAsync(string mediaId)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri unSaveMediaUri = UriCreator.GetUnSaveMediaUri(mediaId);
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, unSaveMediaUri, _deviceInfo, data);
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

	public async Task<IResult<InstaMedia>> UploadAlbumAsync(InstaImageUpload[] images, InstaVideoUpload[] videos, string caption, InstaLocationShort location = null)
	{
		return await UploadAlbumAsync(null, images, videos, caption, location);
	}

	public async Task<IResult<InstaMedia>> UploadAlbumAsync(Action<InstaUploaderProgress> progress, InstaImageUpload[] images, InstaVideoUpload[] videos, string caption, InstaLocationShort location = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			upProgress.Name = "Album upload";
			progress?.Invoke(upProgress);
			Dictionary<string, InstaImageUpload> imagesUploadIds = new Dictionary<string, InstaImageUpload>();
			int index = 1;
			if (images != null && images.Length != 0)
			{
				InstaImageUpload[] array = images;
				foreach (InstaImageUpload instaImageUpload in array)
				{
					List<InstaUserTagUpload> userTags = instaImageUpload.UserTags;
					if (userTags == null || userTags.Count <= 0)
					{
						continue;
					}
					IRequestDelay currentDelay2 = _instaApi.GetRequestDelay();
					_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
					foreach (InstaUserTagUpload t2 in instaImageUpload.UserTags)
					{
						try
						{
							bool tried2 = false;
							while (true)
							{
								IResult<InstaUser> result = await _instaApi.UserProcessor.GetUserAsync(t2.Username);
								if (!result.Succeeded)
								{
									if (!tried2)
									{
										tried2 = true;
										continue;
									}
									break;
								}
								t2.Pk = result.Value.Pk;
								break;
							}
						}
						catch
						{
						}
					}
					_instaApi.SetRequestDelay(currentDelay2);
				}
				array = images;
				foreach (InstaImageUpload image in array)
				{
					upProgress.Name = $"[Album] Photo uploading {index}/{images.Length}";
					upProgress.UploadState = InstaUploadState.Uploading;
					progress?.Invoke(upProgress);
					upProgress.UploadState = InstaUploadState.Uploading;
					progress?.Invoke(upProgress);
					IResult<string> result2 = await UploadSinglePhoto(progress, image, upProgress);
					if (result2.Succeeded)
					{
						upProgress.UploadState = InstaUploadState.Uploaded;
						progress?.Invoke(upProgress);
						imagesUploadIds.Add(result2.Value, image);
						continue;
					}
					upProgress.UploadState = InstaUploadState.Error;
					progress?.Invoke(upProgress);
					return Result.Fail<InstaMedia>(result2.Info.Message);
				}
			}
			Dictionary<string, InstaVideoUpload> videosDic = new Dictionary<string, InstaVideoUpload>();
			int vidIndex = 1;
			if (videos != null && videos.Length != 0)
			{
				InstaVideoUpload[] array2 = videos;
				foreach (InstaVideoUpload instaVideoUpload in array2)
				{
					foreach (InstaUserTagVideoUpload t in instaVideoUpload.UserTags)
					{
						IRequestDelay currentDelay2 = _instaApi.GetRequestDelay();
						_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
						if (t.Pk <= 0L)
						{
							try
							{
								bool tried2 = false;
								while (true)
								{
									IResult<InstaUser> result3 = await _instaApi.UserProcessor.GetUserAsync(t.Username);
									if (!result3.Succeeded)
									{
										if (!tried2)
										{
											tried2 = true;
											continue;
										}
										break;
									}
									t.Pk = result3.Value.Pk;
									break;
								}
							}
							catch
							{
							}
						}
						_instaApi.SetRequestDelay(currentDelay2);
					}
				}
				array2 = videos;
				foreach (InstaVideoUpload video in array2)
				{
					upProgress.Name = $"[Album] Video uploading {vidIndex}/{videos.Length}";
					upProgress.UploadState = InstaUploadState.Uploading;
					progress?.Invoke(upProgress);
					IResult<string> uploadId = await UploadSingleVideo(progress, video, upProgress);
					await UploadSinglePhoto(progress, video.VideoThumbnail.ConvertToImageUpload(), upProgress, uploadId.Value);
					videosDic.Add(uploadId.Value, video);
					upProgress.UploadState = InstaUploadState.Uploaded;
					progress?.Invoke(upProgress);
					vidIndex++;
				}
			}
			return await ConfigureAlbumAsync(progress, upProgress, imagesUploadIds, videosDic, caption, location);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	public async Task<IResult<InstaMedia>> UploadAlbumAsync(InstaAlbumUpload[] album, string caption, InstaLocationShort location = null)
	{
		return await UploadAlbumAsync(null, album, caption, location);
	}

	public async Task<IResult<InstaMedia>> UploadAlbumAsync(Action<InstaUploaderProgress> progress, InstaAlbumUpload[] album, string caption, InstaLocationShort location = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			upProgress.Name = "Album upload";
			progress?.Invoke(upProgress);
			Dictionary<string, InstaAlbumUpload> uploadIds = new Dictionary<string, InstaAlbumUpload>();
			int index = 1;
			InstaAlbumUpload[] array = album;
			foreach (InstaAlbumUpload instaAlbumUpload in array)
			{
				if (instaAlbumUpload.IsImage)
				{
					InstaImageUpload imageToUpload = instaAlbumUpload.ImageToUpload;
					List<InstaUserTagUpload> userTags = imageToUpload.UserTags;
					if (userTags == null || userTags.Count <= 0)
					{
						continue;
					}
					IRequestDelay currentDelay2 = _instaApi.GetRequestDelay();
					_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
					foreach (InstaUserTagUpload t2 in imageToUpload.UserTags)
					{
						if (t2.Pk > 0L)
						{
							continue;
						}
						try
						{
							bool tried2 = false;
							while (true)
							{
								IResult<InstaUser> result = await _instaApi.UserProcessor.GetUserAsync(t2.Username);
								if (!result.Succeeded)
								{
									if (!tried2)
									{
										tried2 = true;
										continue;
									}
									break;
								}
								t2.Pk = result.Value.Pk;
								break;
							}
						}
						catch
						{
						}
					}
					_instaApi.SetRequestDelay(currentDelay2);
				}
				else
				{
					if (!instaAlbumUpload.IsVideo)
					{
						continue;
					}
					InstaVideoUpload videoToUpload = instaAlbumUpload.VideoToUpload;
					List<InstaUserTagVideoUpload> userTags2 = videoToUpload.UserTags;
					if (userTags2 == null || userTags2.Count <= 0)
					{
						continue;
					}
					IRequestDelay currentDelay2 = _instaApi.GetRequestDelay();
					_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
					foreach (InstaUserTagVideoUpload t in videoToUpload.UserTags)
					{
						if (t.Pk > 0L)
						{
							continue;
						}
						try
						{
							bool tried2 = false;
							while (true)
							{
								IResult<InstaUser> result2 = await _instaApi.UserProcessor.GetUserAsync(t.Username);
								if (!result2.Succeeded)
								{
									if (!tried2)
									{
										tried2 = true;
										continue;
									}
									break;
								}
								t.Pk = result2.Value.Pk;
								break;
							}
						}
						catch
						{
						}
					}
					_instaApi.SetRequestDelay(currentDelay2);
				}
			}
			array = album;
			foreach (InstaAlbumUpload al in array)
			{
				if (al.IsImage)
				{
					upProgress.Name = $"[Album] uploading {index}/{album.Length}";
					upProgress.UploadState = InstaUploadState.Uploading;
					progress?.Invoke(upProgress);
					IResult<string> result3 = await UploadSinglePhoto(progress, al.ImageToUpload, upProgress);
					if (result3.Succeeded)
					{
						uploadIds.Add(result3.Value, al);
					}
				}
				else if (al.IsVideo)
				{
					upProgress.Name = $"[Album] uploading {index}/{album.Length}";
					upProgress.UploadState = InstaUploadState.Uploading;
					progress?.Invoke(upProgress);
					IResult<string> video = await UploadSingleVideo(progress, al.VideoToUpload, upProgress);
					if (video.Succeeded)
					{
						await UploadSinglePhoto(progress, al.VideoToUpload.VideoThumbnail.ConvertToImageUpload(), upProgress, video.Value);
						uploadIds.Add(video.Value, al);
					}
				}
				index++;
			}
			return await ConfigureAlbumAsync(progress, upProgress, uploadIds, caption, location);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	private async Task<IResult<string>> UploadSinglePhoto(Action<InstaUploaderProgress> progress, InstaImageUpload image, InstaUploaderProgress upProgress, string uploadId = null, bool album = true)
	{
		if (string.IsNullOrEmpty(uploadId))
		{
			uploadId = ApiRequestMessage.GenerateUploadId();
		}
		int hashCode = Path.GetFileName(image.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
		string value = $"{uploadId}_0_{hashCode}";
		Uri storyUploadPhotoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode);
		JObject jObject = new JObject
		{
			{ "upload_id", uploadId },
			{ "media_type", "1" },
			{
				"retry_context",
				HelperProcessor.GetRetryContext()
			},
			{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" },
			{ "xsharing_user_ids", "[]" }
		};
		if (album)
		{
			jObject.Add("is_sidecar", "1");
		}
		upProgress.UploadState = InstaUploadState.UploadingThumbnail;
		progress?.Invoke(upProgress);
		string value2 = JsonConvert.SerializeObject(jObject);
		byte[] array = image.ImageBytes ?? File.ReadAllBytes(image.Uri);
		ByteArrayContent byteArrayContent = new ByteArrayContent(array);
		byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
		byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
		HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, storyUploadPhotoUri, _deviceInfo);
		defaultRequest.Content = byteArrayContent;
		defaultRequest.Headers.Add("X-Entity-Type", "image/jpeg");
		defaultRequest.Headers.Add("Offset", "0");
		defaultRequest.Headers.Add("X-Instagram-Rupload-Params", value2);
		defaultRequest.Headers.Add("X-Entity-Name", value);
		defaultRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
		defaultRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", Guid.NewGuid().ToString());
		HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
		await response.Content.ReadAsStringAsync();
		if (response.IsSuccessStatusCode)
		{
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			return Result.Success(uploadId);
		}
		upProgress.UploadState = InstaUploadState.Error;
		progress?.Invoke(upProgress);
		return Result.Fail<string>("NO UPLOAD ID");
	}

	private async Task<IResult<string>> UploadSingleVideo(Action<InstaUploaderProgress> progress, InstaVideoUpload video, InstaUploaderProgress upProgress, bool album = true)
	{
		string uploadId = ApiRequestMessage.GenerateRandomUploadId();
		int hashCode = Path.GetFileName(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.GetHashCode();
		string waterfallId = Guid.NewGuid().ToString();
		string videoEntityName = $"{uploadId}_0_{hashCode}";
		Uri videoUri = UriCreator.GetStoryUploadVideoUri(uploadId, hashCode);
		string retryContext = HelperProcessor.GetRetryContext();
		JObject jObject = new JObject
		{
			{ "upload_media_height", "0" },
			{ "upload_media_width", "0" },
			{ "upload_media_duration_ms", "0" },
			{ "upload_id", uploadId },
			{ "retry_context", retryContext },
			{ "media_type", "2" },
			{ "xsharing_user_ids", "[]" }
		};
		if (album)
		{
			jObject.Add("is_sidecar", "1");
		}
		string videoUploadParams = JsonConvert.SerializeObject(jObject);
		HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, videoUri, _deviceInfo);
		defaultRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
		defaultRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
		HttpResponseMessage response2 = await _httpRequestProcessor.SendAsync(defaultRequest);
		string json = await response2.Content.ReadAsStringAsync();
		if (response2.StatusCode != HttpStatusCode.OK)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<string>(response2, json);
		}
		byte[] array = video.Video.VideoBytes ?? File.ReadAllBytes(video.Video.Uri);
		ByteArrayContent content = new ByteArrayContent(array);
		defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, videoUri, _deviceInfo);
		defaultRequest.Content = content;
		upProgress.UploadState = InstaUploadState.Uploading;
		progress?.Invoke(upProgress);
		if (Path.GetExtension(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.Replace(".", "").ToLower() == "mov")
		{
			defaultRequest.Headers.Add("X-Entity-Type", "video/quicktime");
		}
		else
		{
			defaultRequest.Headers.Add("X-Entity-Type", "video/mp4");
		}
		defaultRequest.Headers.Add("Offset", "0");
		defaultRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
		defaultRequest.Headers.Add("X-Entity-Name", videoEntityName);
		defaultRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
		defaultRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
		response2 = await _httpRequestProcessor.SendAsync(defaultRequest);
		json = await response2.Content.ReadAsStringAsync();
		if (response2.StatusCode != HttpStatusCode.OK)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<string>(response2, json);
		}
		return Result.Success(uploadId);
	}

	private async Task<IResult<InstaMedia>> ConfigureAlbumAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, Dictionary<string, InstaAlbumUpload> album, string caption, InstaLocationShort location)
	{
		try
		{
			upProgress.Name = "Album upload";
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri mediaAlbumConfigureUri = UriCreator.GetMediaAlbumConfigureUri();
			string text = ApiRequestMessage.GenerateUploadId();
			JArray jArray = new JArray();
			foreach (KeyValuePair<string, InstaAlbumUpload> item in album)
			{
				if (item.Value.IsImage)
				{
					jArray.Add(GetImageConfigure(item.Key, item.Value.ImageToUpload));
				}
				else if (item.Value.IsVideo)
				{
					jArray.Add(GetVideoConfigure(item.Key, item.Value.VideoToUpload));
				}
			}
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
				{ "_csrftoken", _user.CsrfToken },
				{ "caption", caption },
				{ "client_sidecar_id", text },
				{ "upload_id", text },
				{
					"timezone_offset",
					InstaApiConstants.TIMEZONE_OFFSET.ToString()
				},
				{ "source_type", "4" },
				{ "device_id", _deviceInfo.DeviceId },
				{
					"creation_logger_session_id",
					Guid.NewGuid().ToString()
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
				{ "children_metadata", jArray }
			};
			if (location != null)
			{
				jObject.Add("location", location.GetJson());
				jObject.Add("date_time_digitalized", DateTime.Now.ToString("yyyy:dd:MM+h:mm:ss"));
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, mediaAlbumConfigureUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (!response.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response, text2);
			}
			InstaMediaAlbumResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaAlbumResponse>(text2);
			IObjectConverter<InstaMedia, InstaMediaAlbumResponse> singleMediaFromAlbumConverter = ConvertersFabric.Instance.GetSingleMediaFromAlbumConverter(responseMedia);
			InstaMedia obj = singleMediaFromAlbumConverter.Convert();
			if (obj.Caption == null && !string.IsNullOrEmpty(caption))
			{
				IResult<InstaMedia> result = await _instaApi.MediaProcessor.EditMediaAsync(obj.InstaIdentifier, caption, location);
				if (result.Succeeded)
				{
					upProgress.UploadState = InstaUploadState.Configured;
					progress?.Invoke(upProgress);
					upProgress.UploadState = InstaUploadState.Completed;
					progress?.Invoke(upProgress);
					return Result.Success(result.Value);
				}
			}
			upProgress.UploadState = InstaUploadState.Configured;
			progress?.Invoke(upProgress);
			upProgress.UploadState = InstaUploadState.Completed;
			progress?.Invoke(upProgress);
			return Result.Success(obj);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	public async Task<IResult<InstaMedia>> UploadPhotoAsync(InstaImageUpload image, string caption, InstaLocationShort location = null)
	{
		return await UploadPhotoAsync(null, image, caption, location);
	}

	public async Task<IResult<InstaMedia>> UploadPhotoAsync(Action<InstaUploaderProgress> progress, InstaImageUpload image, string caption, InstaLocationShort location = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendMediaPhotoAsync(progress, image, caption, location);
	}

	public async Task<IResult<InstaMedia>> UploadVideoAsync(InstaVideoUpload video, string caption, InstaLocationShort location = null)
	{
		return await UploadVideoAsync(null, video, caption, location);
	}

	public async Task<IResult<InstaMedia>> UploadVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string caption, InstaLocationShort location = null)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			if (video != null && video.UserTags?.Count > 0)
			{
				IRequestDelay currentDelay = _instaApi.GetRequestDelay();
				_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
				foreach (InstaUserTagVideoUpload t in video.UserTags)
				{
					if (t.Pk > 0L)
					{
						continue;
					}
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
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			IResult<string> uploadVideo = await UploadSingleVideo(progress, video, upProgress, album: false);
			if (!uploadVideo.Succeeded)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.Fail<InstaMedia>(uploadVideo.Info.Message);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			upProgress.UploadState = InstaUploadState.UploadingThumbnail;
			progress?.Invoke(upProgress);
			IResult<string> result2 = await UploadSinglePhoto(progress, video.VideoThumbnail.ConvertToImageUpload(), upProgress, uploadVideo.Value, album: false);
			if (result2.Succeeded)
			{
				upProgress.UploadState = InstaUploadState.ThumbnailUploaded;
				progress?.Invoke(upProgress);
				return await ConfigureVideoAsync(progress, upProgress, video, uploadVideo.Value, caption, location);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.Fail<InstaMedia>(result2.Value);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	private async Task<IResult<InstaMedia>> ConfigureAlbumAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, Dictionary<string, InstaImageUpload> imagesUploadIds, Dictionary<string, InstaVideoUpload> videos, string caption, InstaLocationShort location)
	{
		try
		{
			upProgress.Name = "Album upload";
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri mediaAlbumConfigureUri = UriCreator.GetMediaAlbumConfigureUri();
			string text = ApiRequestMessage.GenerateUploadId();
			JArray jArray = new JArray();
			if (imagesUploadIds != null && imagesUploadIds.Any())
			{
				foreach (KeyValuePair<string, InstaImageUpload> imagesUploadId in imagesUploadIds)
				{
					jArray.Add(GetImageConfigure(imagesUploadId.Key, imagesUploadId.Value));
				}
			}
			if (videos != null && videos.Any())
			{
				foreach (KeyValuePair<string, InstaVideoUpload> video in videos)
				{
					jArray.Add(GetVideoConfigure(video.Key, video.Value));
				}
			}
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
				{ "caption", caption },
				{ "client_sidecar_id", text },
				{ "upload_id", text },
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
				{ "children_metadata", jArray }
			};
			if (location != null)
			{
				jObject.Add("location", location.GetJson());
				jObject.Add("date_time_digitalized", DateTime.Now.ToString("yyyy:dd:MM+h:mm:ss"));
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, mediaAlbumConfigureUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (!response.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response, text2);
			}
			InstaMediaAlbumResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaAlbumResponse>(text2);
			IObjectConverter<InstaMedia, InstaMediaAlbumResponse> singleMediaFromAlbumConverter = ConvertersFabric.Instance.GetSingleMediaFromAlbumConverter(responseMedia);
			InstaMedia obj = singleMediaFromAlbumConverter.Convert();
			if (obj.Caption == null && !string.IsNullOrEmpty(caption))
			{
				IResult<InstaMedia> result = await _instaApi.MediaProcessor.EditMediaAsync(obj.InstaIdentifier, caption, location);
				if (result.Succeeded)
				{
					upProgress.UploadState = InstaUploadState.Configured;
					progress?.Invoke(upProgress);
					upProgress.UploadState = InstaUploadState.Completed;
					progress?.Invoke(upProgress);
					return Result.Success(result.Value);
				}
			}
			upProgress.UploadState = InstaUploadState.Configured;
			progress?.Invoke(upProgress);
			upProgress.UploadState = InstaUploadState.Completed;
			progress?.Invoke(upProgress);
			return Result.Success(obj);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	private async Task<IResult<InstaMedia>> ConfigureVideoAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, InstaVideoUpload video, string uploadId, string caption, InstaLocationShort location)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri instaUri = UriCreator.GetMediaConfigureUri(video: true);
			JObject data = new JObject
			{
				{
					"caption",
					caption ?? string.Empty
				},
				{ "upload_id", uploadId },
				{ "source_type", "4" },
				{ "camera_position", "unknown" },
				{
					"creation_logger_session_id",
					Guid.NewGuid().ToString()
				},
				{
					"timezone_offset",
					InstaApiConstants.TIMEZONE_OFFSET.ToString()
				},
				{
					"date_time_original",
					DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fffZ")
				},
				{
					"extra",
					new JObject
					{
						{ "source_width", 0 },
						{ "source_height", 0 }
					}
				},
				{
					"clips",
					new JArray
					{
						new JObject
						{
							{ "length", 0 },
							{
								"creation_date",
								DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fff")
							},
							{ "source_type", "3" },
							{ "camera_position", "back" }
						}
					}
				},
				{ "poster_frame_index", 0 },
				{ "audio_muted", false },
				{ "filter_type", "0" },
				{ "video_result", "" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.UserName
				}
			};
			if (location != null)
			{
				data.Add("location", location.GetJson());
				data.Add("date_time_digitalized", DateTime.Now.ToString("yyyy:dd:MM+h:mm:ss"));
			}
			List<InstaUserTagVideoUpload> userTags = video.UserTags;
			if (userTags != null && userTags.Count > 0)
			{
				JArray jArray = new JArray();
				foreach (InstaUserTagVideoUpload userTag in video.UserTags)
				{
					if (userTag.Pk != -1L)
					{
						JArray value = new JArray(0.0, 0.0);
						JObject item = new JObject
						{
							{ "user_id", userTag.Pk },
							{ "position", value }
						};
						jArray.Add(item);
					}
				}
				JObject jObject = new JObject { { "in", jArray } };
				data.Add("usertags", jObject.ToString(Formatting.None));
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, UriCreator.GetMediaUploadFinishUri(), _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync();
			signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			signedRequest.Headers.Host = "i.instagram.com";
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (!response.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response, text);
			}
			upProgress.UploadState = InstaUploadState.Configured;
			progress?.Invoke(upProgress);
			InstaMediaItemResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaItemResponse>(text, new JsonConverter[1]
			{
				new InstaMediaDataConverter()
			});
			IObjectConverter<InstaMedia, InstaMediaItemResponse> singleMediaConverter = ConvertersFabric.Instance.GetSingleMediaConverter(responseMedia);
			InstaMedia obj = singleMediaConverter.Convert();
			if (obj.Caption == null && !string.IsNullOrEmpty(caption))
			{
				IResult<InstaMedia> result = await _instaApi.MediaProcessor.EditMediaAsync(obj.InstaIdentifier, caption, location);
				if (result.Succeeded)
				{
					return Result.Success(result.Value);
				}
			}
			return Result.Success(obj);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMedia>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaMedia>(exception2);
		}
	}

	private async Task<IResult<bool>> LikeUnlikeArchiveUnArchiveMediaInternal(string mediaId, Uri instaUri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
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
				{ "media_id", mediaId },
				{ "radio_type", "wifi-none" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
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
			return Result.Fail<bool>(exception2);
		}
	}

	private async Task<IResult<bool>> UploadVideoThumbnailAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, InstaImage image, string uploadId)
	{
		try
		{
			Uri uploadPhotoUri = UriCreator.GetUploadPhotoUri();
			upProgress.UploadState = InstaUploadState.UploadingThumbnail;
			progress?.Invoke(upProgress);
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(uploadId)
			{
				{
					new StringContent(uploadId),
					"\"upload_id\""
				},
				{
					new StringContent(_deviceInfo.DeviceGuid.ToString()),
					"\"_uuid\""
				},
				{
					new StringContent(_user.CsrfToken),
					"\"_csrftoken\""
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
			multipartFormDataContent.Add(byteArrayContent, "photo", "pending_media_" + uploadId + ".jpg");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uploadPhotoUri, _deviceInfo);
			defaultRequest.Content = multipartFormDataContent;
			if (JsonConvert.DeserializeObject<ImageThumbnailResponse>(await (await _httpRequestProcessor.SendAsync(defaultRequest)).Content.ReadAsStringAsync()).Status.ToLower() == "ok")
			{
				upProgress.UploadState = InstaUploadState.ThumbnailUploaded;
				progress?.Invoke(upProgress);
				return Result.Success(resValue: true);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.Fail<bool>("Could not upload thumbnail");
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

	private async Task<IResult<InstaMediaListResponse>> GetArchivedMedia(string nextMaxId)
	{
		new InstaMediaList();
		try
		{
			Uri archivedMediaFeedsListUri = UriCreator.GetArchivedMediaFeedsListUri(nextMaxId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, archivedMediaFeedsListUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaMediaListResponse>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaMediaListResponse>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaMediaListResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaMediaListResponse>(exception2);
		}
	}

	private JObject GetImageConfigure(string uploadId, InstaImageUpload image)
	{
		JObject jObject = new JObject
		{
			{
				"timezone_offset",
				InstaApiConstants.TIMEZONE_OFFSET.ToString()
			},
			{ "source_type", "4" },
			{ "upload_id", uploadId },
			{ "caption", "" },
			{
				"extra",
				JsonConvert.SerializeObject(new JObject
				{
					{ "source_width", 0 },
					{ "source_height", 0 }
				})
			},
			{
				"device",
				JsonConvert.SerializeObject(new JObject
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
				})
			}
		};
		List<InstaUserTagUpload> userTags = image.UserTags;
		if (userTags != null && userTags.Count > 0)
		{
			JArray jArray = new JArray();
			foreach (InstaUserTagUpload userTag in image.UserTags)
			{
				if (userTag.Pk != -1L)
				{
					JArray value = new JArray(userTag.X, userTag.Y);
					JObject item = new JObject
					{
						{ "user_id", userTag.Pk },
						{ "position", value }
					};
					jArray.Add(item);
				}
			}
			JObject jObject2 = new JObject { { "in", jArray } };
			jObject.Add("usertags", jObject2.ToString(Formatting.None));
		}
		return jObject;
	}

	private JObject GetVideoConfigure(string uploadId, InstaVideoUpload video)
	{
		JObject jObject = new JObject
		{
			{
				"timezone_offset",
				InstaApiConstants.TIMEZONE_OFFSET.ToString()
			},
			{ "caption", "" },
			{ "upload_id", uploadId },
			{
				"date_time_original",
				DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fffZ")
			},
			{ "source_type", "4" },
			{
				"extra",
				JsonConvert.SerializeObject(new JObject
				{
					{ "source_width", 0 },
					{ "source_height", 0 }
				})
			},
			{
				"clips",
				JsonConvert.SerializeObject(new JArray
				{
					new JObject
					{
						{
							"length",
							video.Video.Length
						},
						{ "source_type", "4" }
					}
				})
			},
			{
				"device",
				JsonConvert.SerializeObject(new JObject
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
				})
			},
			{
				"length",
				video.Video.Length.ToString()
			},
			{ "poster_frame_index", "0" },
			{ "audio_muted", "false" },
			{ "filter_type", "0" },
			{ "video_result", "" }
		};
		List<InstaUserTagVideoUpload> userTags = video.UserTags;
		if (userTags != null && userTags.Count > 0)
		{
			JArray jArray = new JArray();
			foreach (InstaUserTagVideoUpload userTag in video.UserTags)
			{
				if (userTag.Pk != -1L)
				{
					JArray value = new JArray(0.0, 0.0);
					JObject item = new JObject
					{
						{ "user_id", userTag.Pk },
						{ "position", value }
					};
					jArray.Add(item);
				}
			}
			JObject jObject2 = new JObject { { "in", jArray } };
			jObject.Add("usertags", jObject2.ToString(Formatting.None));
		}
		return jObject;
	}

	[CompilerGenerated]
	internal static InstaMediaList smethod_0(InstaMediaListResponse instaMediaListResponse)
	{
		return ConvertersFabric.Instance.GetMediaListConverter(instaMediaListResponse).Convert();
	}
}
