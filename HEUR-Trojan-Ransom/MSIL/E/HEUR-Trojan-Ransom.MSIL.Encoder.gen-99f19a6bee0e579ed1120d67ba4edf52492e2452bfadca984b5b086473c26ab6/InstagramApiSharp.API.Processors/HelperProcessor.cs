using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

internal class HelperProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	private readonly InstaApi _instaApi;

	private readonly HttpHelper _httpHelper;

	public HelperProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<bool>> SendVideoAsync(Action<InstaUploaderProgress> progress, bool isDirectVideo, bool isDisappearingVideo, string caption, InstaViewMode viewMode, InstaStoryType storyType, string recipients, string threadId, InstaVideoUpload video, Uri uri = null, InstaStoryUploadOptions uploadOptions = null)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.GetHashCode();
			string waterfallId = Guid.NewGuid().ToString();
			string videoEntityName = $"{uploadId}_0_{hashCode}";
			Uri videoUri = UriCreator.GetStoryUploadVideoUri(uploadId, hashCode);
			string retryContext = GetRetryContext();
			upProgress.UploadId = uploadId;
			progress?.Invoke(upProgress);
			new JObject();
			string videoUploadParams;
			HttpResponseMessage response3;
			string json;
			HttpRequestMessage defaultRequest;
			if (isDirectVideo)
			{
				JObject value = new JObject
				{
					{ "upload_media_height", "0" },
					{ "direct_v2", "1" },
					{ "upload_media_width", "0" },
					{ "upload_media_duration_ms", "0" },
					{ "upload_id", uploadId },
					{ "retry_context", retryContext },
					{ "media_type", "2" }
				};
				videoUploadParams = JsonConvert.SerializeObject(value);
				defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, videoUri, _deviceInfo);
				defaultRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
				defaultRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
				response3 = await _httpRequestProcessor.SendAsync(defaultRequest);
				json = await response3.Content.ReadAsStringAsync();
				if (response3.StatusCode != HttpStatusCode.OK)
				{
					upProgress.UploadState = InstaUploadState.Error;
					progress?.Invoke(upProgress);
					return Result.UnExpectedResponse<bool>(response3, json);
				}
			}
			else
			{
				JObject value = new JObject
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
							{
								"caption",
								caption ?? string.Empty
							},
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
				defaultRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, UriCreator.GetStoryMediaInfoUploadUri(), _deviceInfo, value);
				await (await _httpRequestProcessor.SendAsync(defaultRequest)).Content.ReadAsStringAsync();
				value = new JObject
				{
					{ "upload_media_height", "0" },
					{ "upload_media_width", "0" },
					{ "upload_media_duration_ms", "0" },
					{ "upload_id", uploadId },
					{ "retry_context", "{\"num_step_auto_retry\":0,\"num_reupload\":0,\"num_step_manual_retry\":0}" },
					{ "media_type", "2" }
				};
				if (isDisappearingVideo)
				{
					value.Add("for_direct_story", "1");
				}
				else
				{
					switch (storyType)
					{
					default:
						value.Add("for_album", "1");
						break;
					case InstaStoryType.Direct:
						value.Add("for_direct_story", "1");
						break;
					case InstaStoryType.Both:
						value.Add("for_album", "1");
						value.Add("for_direct_story", "1");
						break;
					}
				}
				videoUploadParams = JsonConvert.SerializeObject(value);
				defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, videoUri, _deviceInfo);
				defaultRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
				defaultRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
				response3 = await _httpRequestProcessor.SendAsync(defaultRequest);
				json = await response3.Content.ReadAsStringAsync();
				if (response3.StatusCode != HttpStatusCode.OK)
				{
					upProgress.UploadState = InstaUploadState.Error;
					progress?.Invoke(upProgress);
					return Result.UnExpectedResponse<bool>(response3, json);
				}
			}
			byte[] array = ((video.Video.VideoBytes != null) ? video.Video.VideoBytes : File.ReadAllBytes(video.Video.Uri));
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
			response3 = await _httpRequestProcessor.SendAsync(defaultRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			if (!isDirectVideo)
			{
				upProgress.UploadState = InstaUploadState.UploadingThumbnail;
				progress?.Invoke(upProgress);
				int hashCode2 = Path.GetFileName(video.VideoThumbnail.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
				string value2 = $"{uploadId}_0_{hashCode2}";
				Uri storyUploadPhotoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode2);
				string value3 = JsonConvert.SerializeObject(new JObject
				{
					{ "retry_context", retryContext },
					{ "media_type", "2" },
					{ "upload_id", uploadId },
					{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
				});
				byte[] array2 = ((video.VideoThumbnail.ImageBytes != null) ? video.VideoThumbnail.ImageBytes : File.ReadAllBytes(video.VideoThumbnail.Uri));
				ByteArrayContent byteArrayContent = new ByteArrayContent(array2);
				byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
				byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
				defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, storyUploadPhotoUri, _deviceInfo);
				defaultRequest.Content = byteArrayContent;
				defaultRequest.Headers.Add("X-Entity-Type", "image/jpeg");
				defaultRequest.Headers.Add("Offset", "0");
				defaultRequest.Headers.Add("X-Instagram-Rupload-Params", value3);
				defaultRequest.Headers.Add("X-Entity-Name", value2);
				defaultRequest.Headers.Add("X-Entity-Length", array2.Length.ToString());
				defaultRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
				await (await _httpRequestProcessor.SendAsync(defaultRequest)).Content.ReadAsStringAsync();
				upProgress.UploadState = InstaUploadState.ThumbnailUploaded;
				progress?.Invoke(upProgress);
			}
			return await ConfigureVideo(progress, upProgress, uploadId, isDirectVideo, isDisappearingVideo, caption, viewMode, storyType, recipients, threadId, uri, uploadOptions);
		}
		catch (Exception exception)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception);
			return Result.Fail<bool>(exception);
		}
	}

	private async Task<IResult<bool>> ConfigureVideo(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, string uploadId, bool isDirectVideo, bool isDisappearingVideo, string caption, InstaViewMode viewMode, InstaStoryType storyType, string recipients, string threadId, Uri uri, InstaStoryUploadOptions uploadOptions = null)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			UriCreator.GetDirectConfigVideoUri();
			string retryContext = GetRetryContext();
			string value = Guid.NewGuid().ToString();
			Uri directConfigVideoUri;
			HttpResponseMessage response2;
			if (isDirectVideo)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>
				{
					{ "action", "send_item" },
					{ "client_context", value },
					{ "_csrftoken", _user.CsrfToken },
					{ "video_result", "" },
					{
						"_uuid",
						_deviceInfo.DeviceGuid.ToString()
					},
					{ "upload_id", uploadId }
				};
				if (!string.IsNullOrEmpty(recipients))
				{
					dictionary.Add("recipient_users", "[[" + recipients + "]]");
				}
				else
				{
					dictionary.Add("thread_ids", "[" + threadId + "]");
				}
				directConfigVideoUri = UriCreator.GetDirectConfigVideoUri();
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, directConfigVideoUri, _deviceInfo);
				defaultRequest.Content = new FormUrlEncodedContent(dictionary);
				defaultRequest.Headers.Add("retry_context", retryContext);
				response2 = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response2.Content.ReadAsStringAsync();
				if (response2.StatusCode != HttpStatusCode.OK)
				{
					upProgress.UploadState = InstaUploadState.Error;
					progress?.Invoke(upProgress);
					return Result.UnExpectedResponse<bool>(response2, text);
				}
				InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(text);
				if (instaDefault.Status.ToLower() == "ok")
				{
					upProgress.UploadState = InstaUploadState.Configured;
					progress?.Invoke(upProgress);
				}
				else
				{
					upProgress.UploadState = InstaUploadState.Completed;
					progress?.Invoke(upProgress);
				}
				return (instaDefault.Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response2, text);
			}
			Random random = new Random();
			JObject jObject = new JObject
			{
				{ "filter_type", "0" },
				{ "timezone_offset", "16200" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"client_shared_at",
					(DateTime.UtcNow.ToUnixTime() - random.Next(25, 55)).ToString()
				},
				{
					"story_media_creation_date",
					(DateTime.UtcNow.ToUnixTime() - random.Next(50, 70)).ToString()
				},
				{ "media_folder", "Camera" },
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
				{
					"caption",
					caption ?? string.Empty
				},
				{
					"date_time_original",
					DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fffZ")
				},
				{ "capture_type", "normal" },
				{ "mas_opt_in", "NOT_PROMPTED" },
				{ "upload_id", uploadId },
				{
					"client_timestamp",
					DateTime.UtcNow.ToUnixTime()
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
			if (isDisappearingVideo)
			{
				jObject.Add("view_mode", viewMode.ToString().ToLower());
				jObject.Add("configure_mode", "2");
				jObject.Add("recipient_users", "[]");
				jObject.Add("thread_ids", "[" + threadId + "]");
			}
			else
			{
				switch (storyType)
				{
				default:
					jObject.Add("configure_mode", "1");
					break;
				case InstaStoryType.Direct:
					jObject.Add("configure_mode", "2");
					jObject.Add("view_mode", "replayable");
					jObject.Add("recipient_users", "[]");
					jObject.Add("thread_ids", "[" + threadId + "]");
					break;
				case InstaStoryType.Both:
					jObject.Add("configure_mode", "3");
					jObject.Add("view_mode", "replayable");
					jObject.Add("recipient_users", "[]");
					jObject.Add("thread_ids", "[" + threadId + "]");
					break;
				}
				if (uri != null)
				{
					JArray value2 = new JArray
					{
						new JObject { 
						{
							"webUri",
							uri.ToString()
						} }
					};
					JArray jArray = new JArray
					{
						new JObject { { "links", value2 } }
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
			}
			directConfigVideoUri = UriCreator.GetVideoStoryConfigureUri(isVideo: true);
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, directConfigVideoUri, _deviceInfo, jObject);
			signedRequest.Headers.Add("retry_context", retryContext);
			response2 = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response2.Content.ReadAsStringAsync();
			if (response2.IsSuccessStatusCode)
			{
				InstaDefault instaDefault2 = JsonConvert.DeserializeObject<InstaDefault>(text2);
				if (instaDefault2.Status.ToLower() == "ok")
				{
					upProgress.UploadState = InstaUploadState.Configured;
					progress?.Invoke(upProgress);
				}
				else
				{
					upProgress.UploadState = InstaUploadState.Completed;
					progress?.Invoke(upProgress);
				}
				return (instaDefault2.Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response2, text2);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<bool>(response2, text2);
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

	public async Task<IResult<bool>> SendPhotoAsync(Action<InstaUploaderProgress> progress, bool isDirectPhoto, bool isDisappearingPhoto, string caption, InstaViewMode viewMode, InstaStoryType storyType, string recipients, string threadId, InstaImage image)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(image.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
			string photoEntityName = $"{uploadId}_0_{hashCode}";
			Uri photoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode);
			string waterfallId = Guid.NewGuid().ToString();
			string retryContext = GetRetryContext();
			upProgress.UploadId = uploadId;
			progress?.Invoke(upProgress);
			JObject photoUploadParamsObj = new JObject
			{
				{ "retry_context", retryContext },
				{ "media_type", "1" },
				{ "upload_id", uploadId },
				{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
			};
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
						{
							"caption",
							caption ?? string.Empty
						},
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
			string value = JsonConvert.SerializeObject(photoUploadParamsObj);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, photoUri, _deviceInfo);
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", value);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<bool>(response, json);
			}
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			string value2 = JsonConvert.SerializeObject(photoUploadParamsObj);
			byte[] array = image.ImageBytes ?? File.ReadAllBytes(image.Uri);
			ByteArrayContent byteArrayContent = new ByteArrayContent(array);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, photoUri, _deviceInfo);
			signedRequest.Content = byteArrayContent;
			signedRequest.Headers.Add("X-Entity-Type", "image/jpeg");
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", value2);
			signedRequest.Headers.Add("X-Entity-Name", photoEntityName);
			signedRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync();
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			return await ConfigurePhoto(progress, upProgress, uploadId, isDirectPhoto, isDisappearingPhoto, caption, viewMode, storyType, recipients, threadId);
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

	private async Task<IResult<bool>> ConfigurePhoto(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, string uploadId, bool isDirectPhoto, bool isDisappearingPhoto, string caption, InstaViewMode viewMode, InstaStoryType storyType, string recipients, string threadId)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			UriCreator.GetDirectConfigVideoUri();
			string retryContext = GetRetryContext();
			Guid.NewGuid().ToString();
			Random random = new Random();
			JObject jObject = new JObject
			{
				{ "timezone_offset", "16200" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"client_shared_at",
					(DateTime.UtcNow.ToUnixTime() - random.Next(25, 55)).ToString()
				},
				{
					"story_media_creation_date",
					(DateTime.UtcNow.ToUnixTime() - random.Next(50, 70)).ToString()
				},
				{ "media_folder", "Camera" },
				{ "source_type", "3" },
				{ "video_result", "" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"caption",
					caption ?? string.Empty
				},
				{
					"date_time_original",
					DateTime.Now.ToString("yyyy-dd-MMTh:mm:ss-0fffZ")
				},
				{ "capture_type", "normal" },
				{ "mas_opt_in", "NOT_PROMPTED" },
				{ "upload_id", uploadId },
				{
					"client_timestamp",
					DateTime.UtcNow.ToUnixTime()
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
				{
					"extra",
					new JObject
					{
						{ "source_width", 0 },
						{ "source_height", 0 }
					}
				}
			};
			if (isDisappearingPhoto)
			{
				jObject.Add("view_mode", viewMode.ToString().ToLower());
				jObject.Add("configure_mode", "2");
				jObject.Add("recipient_users", "[]");
				jObject.Add("thread_ids", "[" + threadId + "]");
			}
			else
			{
				switch (storyType)
				{
				default:
					jObject.Add("configure_mode", "1");
					break;
				case InstaStoryType.Direct:
					jObject.Add("configure_mode", "2");
					jObject.Add("view_mode", "replayable");
					jObject.Add("recipient_users", "[]");
					jObject.Add("thread_ids", "[" + threadId + "]");
					break;
				case InstaStoryType.Both:
					jObject.Add("configure_mode", "3");
					jObject.Add("view_mode", "replayable");
					jObject.Add("recipient_users", "[]");
					jObject.Add("thread_ids", "[" + threadId + "]");
					break;
				}
			}
			Uri videoStoryConfigureUri = UriCreator.GetVideoStoryConfigureUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, videoStoryConfigureUri, _deviceInfo, jObject);
			signedRequest.Headers.Add("retry_context", retryContext);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				InstaDefault instaDefault = JsonConvert.DeserializeObject<InstaDefault>(text);
				upProgress.UploadState = InstaUploadState.Configured;
				progress?.Invoke(upProgress);
				return (instaDefault.Status.ToLower() == "ok") ? Result.Success(resValue: true) : Result.UnExpectedResponse<bool>(response, text);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<bool>(response, text);
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

	public async Task<IResult<InstaMedia>> SendMediaPhotoAsync(Action<InstaUploaderProgress> progress, InstaImageUpload image, string caption, InstaLocationShort location, bool configureAsNameTag = false)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			if (image.UserTags != null && image.UserTags.Any())
			{
				IRequestDelay currentDelay = _instaApi.GetRequestDelay();
				_instaApi.SetRequestDelay(RequestDelay.FromSeconds(1, 2));
				foreach (InstaUserTagUpload t in image.UserTags)
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
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(image.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
			string photoEntityName = $"{uploadId}_0_{hashCode}";
			Uri photoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode);
			string waterfallId = Guid.NewGuid().ToString();
			string retryContext = GetRetryContext();
			upProgress.UploadId = uploadId;
			progress?.Invoke(upProgress);
			JObject photoUploadParamsObj = new JObject
			{
				{ "retry_context", retryContext },
				{ "media_type", "1" },
				{ "upload_id", uploadId },
				{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
			};
			string value = JsonConvert.SerializeObject(photoUploadParamsObj);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, photoUri, _deviceInfo);
			defaultRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			defaultRequest.Headers.Add("X-Instagram-Rupload-Params", value);
			HttpResponseMessage response2 = await _httpRequestProcessor.SendAsync(defaultRequest);
			string json = await response2.Content.ReadAsStringAsync();
			if (response2.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response2, json);
			}
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			string value2 = JsonConvert.SerializeObject(photoUploadParamsObj);
			byte[] array = image.ImageBytes ?? File.ReadAllBytes(image.Uri);
			ByteArrayContent byteArrayContent = new ByteArrayContent(array);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, photoUri, _deviceInfo);
			defaultRequest.Content = byteArrayContent;
			defaultRequest.Headers.Add("X-Entity-Type", "image/jpeg");
			defaultRequest.Headers.Add("Offset", "0");
			defaultRequest.Headers.Add("X-Instagram-Rupload-Params", value2);
			defaultRequest.Headers.Add("X-Entity-Name", photoEntityName);
			defaultRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
			defaultRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			response2 = await _httpRequestProcessor.SendAsync(defaultRequest);
			json = await response2.Content.ReadAsStringAsync();
			if (response2.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.Uploaded;
				progress?.Invoke(upProgress);
				if (configureAsNameTag)
				{
					return await ConfigureMediaPhotoAsNametagAsync(progress, upProgress, uploadId);
				}
				return await ConfigureMediaPhotoAsync(progress, upProgress, uploadId, caption, location, image.UserTags);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaMedia>(response2, json);
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

	private async Task<IResult<InstaMedia>> ConfigureMediaPhotoAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, string uploadId, string caption, InstaLocationShort location, List<InstaUserTagUpload> userTags = null)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri mediaConfigureUri = UriCreator.GetMediaConfigureUri();
			string retryContext = GetRetryContext();
			new Random();
			JObject jObject = new JObject
			{
				{
					"date_time_digitalized",
					DateTime.UtcNow.ToString("yyyy:MM:dd+hh:mm:ss")
				},
				{
					"date_time_original",
					DateTime.UtcNow.ToString("yyyy:MM:dd+hh:mm:ss")
				},
				{ "is_suggested_venue", "false" },
				{
					"timezone_offset",
					InstaApiConstants.TIMEZONE_OFFSET.ToString()
				},
				{ "_csrftoken", _user.CsrfToken },
				{ "media_folder", "Camera" },
				{ "source_type", "3" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"caption",
					caption ?? string.Empty
				},
				{ "upload_id", uploadId },
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
				{
					"extra",
					new JObject
					{
						{ "source_width", 0 },
						{ "source_height", 0 }
					}
				}
			};
			if (location != null)
			{
				jObject.Add("location", location.GetJson());
			}
			if (userTags != null && userTags.Any())
			{
				JArray jArray = new JArray();
				foreach (InstaUserTagUpload userTag in userTags)
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, mediaConfigureUri, _deviceInfo, jObject);
			signedRequest.Headers.Add("retry_context", retryContext);
			InstaMediaItemResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaItemResponse>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync(), new JsonConverter[1]
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

	private async Task<IResult<InstaMedia>> ConfigureMediaPhotoAsNametagAsync(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, string uploadId)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri mediaNametagConfigureUri = UriCreator.GetMediaNametagConfigureUri();
			string retryContext = GetRetryContext();
			JObject data = new JObject
			{
				{ "upload_id", uploadId },
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, mediaNametagConfigureUri, _deviceInfo, data);
			signedRequest.Headers.Add("retry_context", retryContext);
			InstaMediaItemResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaItemResponse>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync(), new JsonConverter[1]
			{
				new InstaMediaDataConverter()
			});
			InstaMedia resValue = ConvertersFabric.Instance.GetSingleMediaConverter(responseMedia).Convert();
			upProgress.UploadState = InstaUploadState.Configured;
			progress?.Invoke(upProgress);
			upProgress.UploadState = InstaUploadState.Completed;
			progress?.Invoke(upProgress);
			return Result.Success(resValue);
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

	public async Task<IResult<InstaMedia>> SendIGTVVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string title, string caption)
	{
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = (caption ?? string.Empty),
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			string uploadId = ApiRequestMessage.GenerateRandomUploadId();
			int hashCode = Path.GetFileName(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.GetHashCode();
			string waterfallId = Guid.NewGuid().ToString();
			string videoEntityName = $"{uploadId}_0_{hashCode}";
			Uri videoUri = UriCreator.GetStoryUploadVideoUri(uploadId, hashCode);
			string retryContext = GetRetryContext();
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
						{
							"caption",
							caption ?? string.Empty
						},
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
			data = new JObject
			{
				{ "upload_media_height", "0" },
				{ "upload_media_width", "0" },
				{ "upload_media_duration_ms", "0" },
				{ "upload_id", uploadId },
				{ "retry_context", "{\"num_step_auto_retry\":0,\"num_reupload\":0,\"num_step_manual_retry\":0}" },
				{ "media_type", "2" },
				{ "is_igtv_video", "1" }
			};
			string videoUploadParams = JsonConvert.SerializeObject(data);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, videoUri, _deviceInfo);
			signedRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
			HttpResponseMessage response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response3, json);
			}
			byte[] array = video.Video.VideoBytes ?? File.ReadAllBytes(video.Video.Uri);
			ByteArrayContent content = new ByteArrayContent(array);
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, videoUri, _deviceInfo);
			signedRequest.Content = content;
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			if (Path.GetExtension(video.Video.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".mp4"))!.Replace(".", "").ToLower() == "mov")
			{
				signedRequest.Headers.Add("X-Entity-Type", "video/quicktime");
			}
			else
			{
				signedRequest.Headers.Add("X-Entity-Type", "video/mp4");
			}
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", videoUploadParams);
			signedRequest.Headers.Add("X-Entity-Name", videoEntityName);
			signedRequest.Headers.Add("X-Entity-Length", array.Length.ToString());
			signedRequest.Headers.Add("X_FB_VIDEO_WATERFALL_ID", waterfallId);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaMedia>(response3, json);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			int hashCode2 = Path.GetFileName(video.VideoThumbnail.Uri ?? ("C:\\" + 13.GenerateRandomString() + ".jpg"))!.GetHashCode();
			string value = $"{uploadId}_0_{hashCode2}";
			Uri storyUploadPhotoUri = UriCreator.GetStoryUploadPhotoUri(uploadId, hashCode2);
			JObject value2 = new JObject
			{
				{ "retry_context", retryContext },
				{ "media_type", "2" },
				{ "upload_id", uploadId },
				{ "image_compression", "{\"lib_name\":\"moz\",\"lib_version\":\"3.1.m\",\"quality\":\"95\"}" }
			};
			upProgress.UploadState = InstaUploadState.UploadingThumbnail;
			progress?.Invoke(upProgress);
			string value3 = JsonConvert.SerializeObject(value2);
			byte[] array2 = video.VideoThumbnail.ImageBytes ?? File.ReadAllBytes(video.VideoThumbnail.Uri);
			ByteArrayContent byteArrayContent = new ByteArrayContent(array2);
			byteArrayContent.Headers.Add("Content-Transfer-Encoding", "binary");
			byteArrayContent.Headers.Add("Content-Type", "application/octet-stream");
			signedRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, storyUploadPhotoUri, _deviceInfo);
			signedRequest.Content = byteArrayContent;
			signedRequest.Headers.Add("X-Entity-Type", "image/jpeg");
			signedRequest.Headers.Add("Offset", "0");
			signedRequest.Headers.Add("X-Instagram-Rupload-Params", value3);
			signedRequest.Headers.Add("X-Entity-Name", value);
			signedRequest.Headers.Add("X-Entity-Length", array2.Length.ToString());
			signedRequest.Headers.Add("X_FB_PHOTO_WATERFALL_ID", waterfallId);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.IsSuccessStatusCode)
			{
				upProgress.UploadState = InstaUploadState.ThumbnailUploaded;
				progress?.Invoke(upProgress);
				return await ConfigureIGTVVideo(progress, upProgress, uploadId, title, caption);
			}
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			return Result.UnExpectedResponse<InstaMedia>(response3, json);
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

	private async Task<IResult<InstaMedia>> ConfigureIGTVVideo(Action<InstaUploaderProgress> progress, InstaUploaderProgress upProgress, string uploadId, string title, string caption)
	{
		try
		{
			upProgress.UploadState = InstaUploadState.Configuring;
			progress?.Invoke(upProgress);
			Uri mediaConfigureToIGTVUri = UriCreator.GetMediaConfigureToIGTVUri();
			string retryContext = GetRetryContext();
			Guid.NewGuid().ToString();
			new Random();
			JObject data = new JObject
			{
				{ "filter_type", "0" },
				{ "_csrftoken", _user.CsrfToken },
				{ "source_type", "4" },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"caption",
					caption ?? string.Empty
				},
				{ "upload_id", uploadId },
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
				{ "poster_frame_index", 0 },
				{
					"title",
					title ?? ""
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, mediaConfigureToIGTVUri, _deviceInfo, data);
			signedRequest.Headers.Add("retry_context", retryContext);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.IsSuccessStatusCode)
			{
				InstaMediaItemResponse responseMedia = JsonConvert.DeserializeObject<InstaMediaItemResponse>(text, new JsonConverter[1]
				{
					new InstaMediaDataConverter()
				});
				IObjectConverter<InstaMedia, InstaMediaItemResponse> singleMediaConverter = ConvertersFabric.Instance.GetSingleMediaConverter(responseMedia);
				upProgress.UploadState = InstaUploadState.Configured;
				progress?.Invoke(upProgress);
				IResult<InstaMedia> result = Result.Success(singleMediaConverter.Convert());
				upProgress.UploadState = InstaUploadState.Completed;
				progress?.Invoke(upProgress);
				return result;
			}
			return Result.UnExpectedResponse<InstaMedia>(response, text);
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

	internal static string GetRetryContext()
	{
		return new JObject
		{
			{ "num_step_auto_retry", 0 },
			{ "num_reupload", 0 },
			{ "num_step_manual_retry", 0 }
		}.ToString(Formatting.None);
	}
}
