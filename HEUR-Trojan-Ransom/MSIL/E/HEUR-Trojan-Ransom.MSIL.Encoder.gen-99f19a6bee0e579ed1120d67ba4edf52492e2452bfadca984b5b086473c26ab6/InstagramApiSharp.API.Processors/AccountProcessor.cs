using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Classes.ResponseWrappers.Business;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Converters.Json;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class AccountProcessor : IAccountProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	private readonly InstaApi _instaApi;

	private readonly HttpHelper _httpHelper;

	public AccountProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaUserShort>> SetAccountPrivateAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri uriSetAccountPrivate = UriCreator.GetUriSetAccountPrivate();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
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
			string text = CryptoHelper.CalculateHash(_httpHelper._apiVersion.SignatureKey, JsonConvert.SerializeObject(dictionary));
			string stringToEscape = JsonConvert.SerializeObject(dictionary);
			string value = text + "." + Uri.EscapeDataString(stringToEscape);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uriSetAccountPrivate, _deviceInfo);
			defaultRequest.Content = new FormUrlEncodedContent(dictionary);
			defaultRequest.Properties.Add("signed_body", value);
			defaultRequest.Properties.Add("ig_sig_key_version", "4");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserShort>(response, text2);
			}
			InstaUserShortResponse instaUserShortResponse = JsonConvert.DeserializeObject<InstaUserShortResponse>(text2, new JsonConverter[1]
			{
				new InstaUserShortDataConverter()
			});
			if (instaUserShortResponse.Pk < 1L)
			{
				return Result.Fail<InstaUserShort>("Pk is null or empty");
			}
			return Result.Success(ConvertersFabric.Instance.GetUserShortConverter(instaUserShortResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserShort>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserShort>(exception2);
		}
	}

	public async Task<IResult<InstaUserShort>> SetAccountPublicAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri uriSetAccountPublic = UriCreator.GetUriSetAccountPublic();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
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
			string text = CryptoHelper.CalculateHash(_httpHelper._apiVersion.SignatureKey, JsonConvert.SerializeObject(dictionary));
			string stringToEscape = JsonConvert.SerializeObject(dictionary);
			string value = text + "." + Uri.EscapeDataString(stringToEscape);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uriSetAccountPublic, _deviceInfo);
			defaultRequest.Content = new FormUrlEncodedContent(dictionary);
			defaultRequest.Properties.Add("signed_body", value);
			defaultRequest.Properties.Add("ig_sig_key_version", "4");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode == HttpStatusCode.OK)
			{
				InstaUserShortResponse instaUserShortResponse = JsonConvert.DeserializeObject<InstaUserShortResponse>(text2, new JsonConverter[1]
				{
					new InstaUserShortDataConverter()
				});
				if (instaUserShortResponse.Pk < 1L)
				{
					return Result.Fail<InstaUserShort>("Pk is incorrect");
				}
				return Result.Success(ConvertersFabric.Instance.GetUserShortConverter(instaUserShortResponse).Convert());
			}
			return Result.UnExpectedResponse<InstaUserShort>(response, text2);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserShort>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserShort>(exception2);
		}
	}

	public async Task<IResult<bool>> ChangePasswordAsync(string oldPassword, string newPassword)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		if (!(oldPassword == newPassword))
		{
			try
			{
				Uri changePasswordUri = UriCreator.GetChangePasswordUri();
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
					{ "old_password", oldPassword },
					{ "new_password1", newPassword },
					{ "new_password2", newPassword }
				};
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Get, changePasswordUri, _deviceInfo, data);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string value = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					return Result.Success(resValue: true);
				}
				BadStatusErrorsResponse badStatusErrorsResponse = JsonConvert.DeserializeObject<BadStatusErrorsResponse>(value);
				string errors = "";
				badStatusErrorsResponse.Message.Errors.ForEach(delegate(string errorContent)
				{
					errors = errors + errorContent + "\n";
				});
				return Result.Fail(errors, resValue: false);
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
		return Result.Fail("The old password should not the same of the new password", resValue: false);
	}

	public async Task<IResult<InstaUserEdit>> EditProfileAsync(string name, string biography, string url, string email, string phone, InstaGenderType? gender, string newUsername = null)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			IResult<InstaUserEdit> result = await GetRequestForEditProfileAsync();
			if (!result.Succeeded)
			{
				return Result.Fail<InstaUserEdit>("Edit request returns badrequest", null);
			}
			string username = result.Value.Username;
			if (string.IsNullOrEmpty(newUsername))
			{
				newUsername = username;
			}
			if (name == null)
			{
				name = result.Value.FullName;
			}
			if (biography == null)
			{
				biography = result.Value.Biography;
			}
			if (url == null)
			{
				url = result.Value.ExternalUrl;
			}
			if (email == null)
			{
				email = result.Value.Email;
			}
			if (phone == null)
			{
				phone = result.Value.PhoneNumber;
			}
			if (!gender.HasValue)
			{
				gender = result.Value.Gender;
			}
			Uri editProfileUri = UriCreator.GetEditProfileUri();
			JObject data = new JObject
			{
				{ "external_url", url },
				{
					"gender",
					((int)gender.Value).ToString()
				},
				{ "phone_number", phone },
				{ "_csrftoken", _user.CsrfToken },
				{ "username", newUsername },
				{ "first_name", name },
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "biography", biography },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "email", email }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, editProfileUri, _deviceInfo, data);
			signedRequest.Headers.Add("Host", "i.instagram.com");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserEdit>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaUserEditContainer>(text).User);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserEdit>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserEdit>(exception2);
		}
	}

	public async Task<IResult<InstaBiography>> SetBiographyAsync(string bio)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (!(await GetRequestForEditProfileAsync()).Succeeded)
			{
				return Result.Fail<InstaBiography>("Edit request returns badrequest.\r\nPlease try again.", null);
			}
			Uri setBiographyUri = UriCreator.GetSetBiographyUri();
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
				{ "raw_text", bio }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setBiographyUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBiography>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaBiography>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBiography>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBiography>(exception2);
		}
	}

	public async Task<IResult<InstaUserEdit>> GetRequestForEditProfileAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri requestForEditProfileUri = UriCreator.GetRequestForEditProfileUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, requestForEditProfileUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserEdit>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaUserEditContainer>(text).User);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserEdit>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserEdit>(exception2);
		}
	}

	public async Task<IResult<bool>> SetNameAndPhoneNumberAsync(string name, string phoneNumber = "")
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri profileSetPhoneAndNameUri = UriCreator.GetProfileSetPhoneAndNameUri();
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
				{ "first_name", name },
				{ "phone_number", phoneNumber }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, profileSetPhoneAndNameUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaDefaultResponse>(text).Status.ToLower() == "ok")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<InstaUserEdit>> RemoveProfilePictureAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri removeProfilePictureUri = UriCreator.GetRemoveProfilePictureUri();
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, removeProfilePictureUri, _deviceInfo, data);
			signedRequest.Headers.Add("Host", "i.instagram.com");
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUserEdit>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaUserEditContainer>(text).User);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserEdit>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserEdit>(exception2);
		}
	}

	public async Task<IResult<InstaUserEdit>> ChangeProfilePictureAsync(byte[] pictureBytes)
	{
		return await ChangeProfilePictureAsync(null, pictureBytes);
	}

	public async Task<IResult<InstaUserEdit>> ChangeProfilePictureAsync(Action<InstaUploaderProgress> progress, byte[] pictureBytes)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		InstaUploaderProgress upProgress = new InstaUploaderProgress
		{
			Caption = string.Empty,
			UploadState = InstaUploadState.Preparing
		};
		try
		{
			Uri changeProfilePictureUri = UriCreator.GetChangeProfilePictureUri();
			string boundary = (upProgress.UploadId = ApiRequestMessage.GenerateUploadId());
			progress?.Invoke(upProgress);
			MultipartFormDataContent multipartFormDataContent = new MultipartFormDataContent(boundary)
			{
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
			ByteArrayContent content = new ByteArrayContent(pictureBytes);
			multipartFormDataContent.Add(content, "profile_pic", "r" + ApiRequestMessage.GenerateUploadId() + ".jpg");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, changeProfilePictureUri, _deviceInfo);
			defaultRequest.Content = multipartFormDataContent;
			upProgress.UploadState = InstaUploadState.Uploading;
			progress?.Invoke(upProgress);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				upProgress.UploadState = InstaUploadState.Error;
				progress?.Invoke(upProgress);
				return Result.UnExpectedResponse<InstaUserEdit>(response, text2);
			}
			upProgress.UploadState = InstaUploadState.Uploaded;
			progress?.Invoke(upProgress);
			InstaUserEditContainer instaUserEditContainer = JsonConvert.DeserializeObject<InstaUserEditContainer>(text2);
			upProgress.UploadState = InstaUploadState.Completed;
			progress?.Invoke(upProgress);
			return Result.Success(instaUserEditContainer.User);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserEdit>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			upProgress.UploadState = InstaUploadState.Error;
			progress?.Invoke(upProgress);
			_logger?.LogException(exception2);
			return Result.Fail<InstaUserEdit>(exception2);
		}
	}

	public async Task<IResult<InstaRequestDownloadData>> GetRequestForDownloadAccountDataAsync(string email)
	{
		return await GetRequestForDownloadAccountDataAsync(email, null);
	}

	public async Task<IResult<InstaRequestDownloadData>> GetRequestForDownloadAccountDataAsync(string email, string password)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (string.IsNullOrEmpty(password))
			{
				password = _user.Password;
			}
			Uri requestForDownloadDataUri = UriCreator.GetRequestForDownloadDataUri();
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
				{ "email", email },
				{ "password", password }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, requestForDownloadDataUri, _deviceInfo, data);
			return Result.Success(JsonConvert.DeserializeObject<InstaRequestDownloadData>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync()));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRequestDownloadData>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRequestDownloadData>(exception2);
		}
	}

	public async Task<IResult<InstaMedia>> UploadNametagAsync(InstaImage nametagImage)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendMediaPhotoAsync(null, nametagImage.ConvertToImageUpload(), null, null, configureAsNameTag: true);
	}

	public async Task<IResult<InstaStorySettings>> GetStorySettingsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri storySettingsUri = UriCreator.GetStorySettingsUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, storySettingsUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaStorySettings>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaStorySettings>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaStorySettings>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaStorySettings>(exception2);
		}
	}

	public async Task<IResult<bool>> EnableSaveStoryToGalleryAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
					"save_to_camera_roll",
					1.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<bool>> DisableSaveStoryToGalleryAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
					"save_to_camera_roll",
					0.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<bool>> EnableSaveStoryToArchiveAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
				{ "reel_auto_archive", "on" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaAccountArchiveStory>(text).ReelAutoArchive.ToLower() == "on")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<bool>> DisableSaveStoryToArchiveAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
				{ "check_pending_archive", "1" },
				{ "reel_auto_archive", "off" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaAccountArchiveStory>(text).ReelAutoArchive.ToLower() == "off")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<bool>> AllowStorySharingAsync(bool allow = true)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
				}
			};
			if (allow)
			{
				jObject.Add("allow_story_reshare", "1");
			}
			else
			{
				jObject.Add("allow_story_reshare", "0");
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaAccountArchiveStory>(text).Status.ToLower() == "off")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<bool>> AllowStoryMessageRepliesAsync(InstaMessageRepliesType repliesType)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri setReelSettingsUri = UriCreator.GetSetReelSettingsUri();
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
					"message_prefs",
					repliesType.ToString().ToLower()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, setReelSettingsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			InstaAccountArchiveStory instaAccountArchiveStory = JsonConvert.DeserializeObject<InstaAccountArchiveStory>(text);
			if (instaAccountArchiveStory.MessagePrefs.ToLower() == "anyone" && repliesType == InstaMessageRepliesType.Everyone)
			{
				return Result.Success(resValue: true);
			}
			if (instaAccountArchiveStory.MessagePrefs.ToLower() == "following" && repliesType == InstaMessageRepliesType.Following)
			{
				return Result.Success(resValue: true);
			}
			if (instaAccountArchiveStory.MessagePrefs.ToLower() == "off" && repliesType == InstaMessageRepliesType.Off)
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<InstaAccountCheck>> CheckUsernameAsync(string desiredUsername)
	{
		try
		{
			Uri checkUsernameUri = UriCreator.GetCheckUsernameUri();
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
				{ "username", desiredUsername }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, checkUsernameUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountCheck>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountCheck>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountCheck>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountCheck>(exception2);
		}
	}

	public async Task<IResult<InstaAccountSecuritySettings>> GetSecuritySettingsInfoAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountSecurityInfoUri = UriCreator.GetAccountSecurityInfoUri();
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountSecurityInfoUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountSecuritySettings>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountSecuritySettings>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountSecuritySettings>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountSecuritySettings>(exception2);
		}
	}

	public async Task<IResult<bool>> DisableTwoFactorAuthenticationAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri disableSmsTwoFactorUri = UriCreator.GetDisableSmsTwoFactorUri();
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, disableSmsTwoFactorUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<InstaDefault>(text).Status.ToLower() == "ok")
			{
				return Result.Success(resValue: true);
			}
			return Result.Success(resValue: false);
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

	public async Task<IResult<InstaAccountTwoFactorSms>> SendTwoFactorEnableSmsAsync(string phoneNumber)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri sendTwoFactorEnableSmsUri = UriCreator.GetSendTwoFactorEnableSmsUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "phone_number", phoneNumber }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, sendTwoFactorEnableSmsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountTwoFactorSms>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountTwoFactorSms>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountTwoFactorSms>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountTwoFactorSms>(exception2);
		}
	}

	public async Task<IResult<InstaAccountTwoFactor>> TwoFactorEnableAsync(string phoneNumber, string verificationCode)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri enableSmsTwoFactorUri = UriCreator.GetEnableSmsTwoFactorUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "phone_number", phoneNumber },
				{ "verification_code", verificationCode }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, enableSmsTwoFactorUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountTwoFactor>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountTwoFactor>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountTwoFactor>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountTwoFactor>(exception2);
		}
	}

	public async Task<IResult<InstaAccountConfirmEmail>> SendConfirmEmailAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountSendConfirmEmailUri = UriCreator.GetAccountSendConfirmEmailUri();
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
				{ "send_source", "edit_profile" }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountSendConfirmEmailUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountConfirmEmail>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountConfirmEmail>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountConfirmEmail>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountConfirmEmail>(exception2);
		}
	}

	public async Task<IResult<InstaAccountSendSms>> SendSmsCodeAsync(string phoneNumber)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountSendSmsCodeUri = UriCreator.GetAccountSendSmsCodeUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "phone_number", phoneNumber }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountSendSmsCodeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountSendSms>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountSendSms>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountSendSms>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountSendSms>(exception2);
		}
	}

	public async Task<IResult<bool>> VerifyEmailByVerificationUriAsync(Uri verificationUri)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			if (verificationUri == null)
			{
				throw new ArgumentNullException("Verification uri cannot be null");
			}
			Uri verifyEmailUri = UriCreator.GetVerifyEmailUri(verificationUri);
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, verifyEmailUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			InstaAccountConfirmEmail instaAccountConfirmEmail = JsonConvert.DeserializeObject<InstaAccountConfirmEmail>(await response.Content.ReadAsStringAsync());
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, instaAccountConfirmEmail.Body, null);
			}
			return (instaAccountConfirmEmail.Title.ToLower() == "thanks") ? Result.Success(resValue: true) : Result.Fail(instaAccountConfirmEmail.Body, resValue: false);
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

	public async Task<IResult<InstaAccountVerifySms>> VerifySmsCodeAsync(string phoneNumber, string verificationCode)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountVerifySmsCodeUri = UriCreator.GetAccountVerifySmsCodeUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uid",
					_user.LoggedInUser.Pk.ToString()
				},
				{ "phone_number", phoneNumber },
				{ "verification_code", verificationCode }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountVerifySmsCodeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountVerifySms>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountVerifySms>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountVerifySms>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountVerifySms>(exception2);
		}
	}

	public async Task<IResult<TwoFactorRegenBackupCodes>> RegenerateTwoFactorBackupCodesAsync()
	{
		try
		{
			Uri regenerateTwoFactorBackUpCodeUri = UriCreator.GetRegenerateTwoFactorBackUpCodeUri();
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, regenerateTwoFactorBackUpCodeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<TwoFactorRegenBackupCodes>(response, text);
			}
			TwoFactorRegenBackupCodes twoFactorRegenBackupCodes = JsonConvert.DeserializeObject<TwoFactorRegenBackupCodes>(text);
			return (twoFactorRegenBackupCodes.Status.ToLower() == "ok") ? Result.Success(twoFactorRegenBackupCodes) : Result.UnExpectedResponse<TwoFactorRegenBackupCodes>(response, text);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<TwoFactorRegenBackupCodes>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<TwoFactorRegenBackupCodes>(exception2);
		}
	}

	public async Task<IResult<bool>> EnablePresenceAsync()
	{
		return await EnableDisablePresenceAsync(enable: true);
	}

	public async Task<IResult<bool>> DisablePresenceAsync()
	{
		return await EnableDisablePresenceAsync(enable: false);
	}

	public async Task<IResult<InstaPresence>> GetPresenceOptionsAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri presenceUri = UriCreator.GetPresenceUri(_httpHelper._apiVersion.SignatureKey);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, presenceUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaPresence>(response, text);
			}
			InstaPresenceResponse response2 = JsonConvert.DeserializeObject<InstaPresenceResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetPresenceConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPresence>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaPresence>(exception2);
		}
	}

	public async Task<IResult<InstaUser>> SwitchToPersonalAccountAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri convertToPersonalAccountUri = UriCreator.GetConvertToPersonalAccountUri();
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
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, convertToPersonalAccountUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaUser>(response, text);
			}
			InstaUserContainerResponse instaUserContainerResponse = JsonConvert.DeserializeObject<InstaUserContainerResponse>(text);
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

	public async Task<IResult<InstaBusinessUser>> SwitchToBusinessAccountAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri convertToBusinessAccountUri = UriCreator.GetConvertToBusinessAccountUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, convertToBusinessAccountUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	public async Task<IResult<InstaBusinessUser>> SetBusinessInfoAsync(string categoryId, string phoneNumber, string email)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri instaUri = UriCreator.GetCreateBusinessInfoUri();
			JObject publicPhoneContact = new JObject
			{
				{ "public_phone_number", phoneNumber },
				{ "business_contact_method", "CALL" }
			};
			bool isPrivate = (await GetRequestForEditProfileAsync()).Value.IsPrivate;
			JObject jObject = new JObject();
			jObject.Add("set_public", isPrivate.ToString().ToLower());
			jObject.Add("entry_point", "setting");
			jObject.Add("_csrftoken", _user.CsrfToken);
			jObject.Add("public_phone_contact", publicPhoneContact.ToString(Formatting.None));
			jObject.Add("_uid", _user.LoggedInUser.Pk.ToString());
			jObject.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			jObject.Add("public_email", email ?? string.Empty);
			jObject.Add("category_id", categoryId);
			JObject data = jObject;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaBusinessUser>(response, text);
			}
			InstaBusinessUserContainerResponse response2 = JsonConvert.DeserializeObject<InstaBusinessUserContainerResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetBusinessUserConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaBusinessUser>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaBusinessUser>(exception2);
		}
	}

	private async Task<IResult<bool>> EnableDisablePresenceAsync(bool enable)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri accountSetPresenseDisabledUri = UriCreator.GetAccountSetPresenseDisabledUri();
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
				{
					"disabled",
					enable ? "0" : "1"
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountSetPresenseDisabledUri, _deviceInfo, data);
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

	private async Task<IResult<object>> GetCommentFilterAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri uri = new Uri("https://i.instagram.com/api/v1/accounts/get_comment_filter/");
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uri, _deviceInfo);
			await (await _httpRequestProcessor.SendAsync(defaultRequest)).Content.ReadAsStringAsync();
			return null;
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
}
