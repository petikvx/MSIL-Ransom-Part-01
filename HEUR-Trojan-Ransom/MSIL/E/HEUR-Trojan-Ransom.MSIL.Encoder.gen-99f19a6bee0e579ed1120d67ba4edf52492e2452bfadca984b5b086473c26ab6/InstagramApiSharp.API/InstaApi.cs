using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramApiSharp.API.Processors;
using InstagramApiSharp.API.Versions;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Classes.ResponseWrappers.BaseResponse;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API;

internal class InstaApi : IInstaApi
{
	private IRequestDelay _delay = RequestDelay.Empty();

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly IInstaLogger _logger;

	private InstaApiVersionType _apiVersionType;

	private InstaApiVersion _apiVersion;

	private AndroidDevice _deviceInfo;

	private InstaTwoFactorLoginInfo _twoFactorInfo;

	private InstaChallengeLoginInfo _challengeinfo;

	private UserSessionData _userSession;

	private UserAuthValidate _userAuthValidate;

	private bool IsCustomDeviceSet;

	private string _waterfallIdReg = "";

	private string _deviceIdReg = "";

	private string _phoneIdReg = "";

	private string _guidReg = "";

	private InstaAccountRegistrationPhoneNumber _signUpPhoneNumberInfo;

	private bool _isUserAuthenticated;

	private ISessionHandler _sessionHandler;

	private ICollectionProcessor _collectionProcessor;

	private ICommentProcessor _commentProcessor;

	private IFeedProcessor _feedProcessor;

	private IHashtagProcessor _hashtagProcessor;

	private ILocationProcessor _locationProcessor;

	private IMediaProcessor _mediaProcessor;

	private IMessagingProcessor _messagingProcessor;

	private IStoryProcessor _storyProcessor;

	private IUserProcessor _userProcessor;

	private ILiveProcessor _liveProcessor;

	private IDiscoverProcessor _discoverProcessor;

	private IAccountProcessor _accountProcessor;

	private ITVProcessor _tvProcessor;

	private HelperProcessor _helperProcessor;

	private IBusinessProcessor _businessProcessor;

	private IShoppingProcessor _shoppingProcessor;

	private IWebProcessor _webProcessor;

	private string _facebookAccessToken;

	private HttpHelper _httpHelper { get; set; }

	private UserSessionData _user
	{
		get
		{
			return _userSession;
		}
		set
		{
			_userSession = value;
			_userAuthValidate.User = value;
		}
	}

	public bool IsUserAuthenticated
	{
		get
		{
			return _isUserAuthenticated;
		}
		internal set
		{
			_isUserAuthenticated = value;
			_userAuthValidate.IsUserAuthenticated = value;
		}
	}

	public HttpClient HttpClient => _httpRequestProcessor.Client;

	public IHttpRequestProcessor HttpRequestProcessor => _httpRequestProcessor;

	public ISessionHandler SessionHandler
	{
		get
		{
			return _sessionHandler;
		}
		set
		{
			_sessionHandler = value;
		}
	}

	public ILiveProcessor LiveProcessor => _liveProcessor;

	public IDiscoverProcessor DiscoverProcessor => _discoverProcessor;

	public IAccountProcessor AccountProcessor => _accountProcessor;

	public ICommentProcessor CommentProcessor => _commentProcessor;

	public IStoryProcessor StoryProcessor => _storyProcessor;

	public IMediaProcessor MediaProcessor => _mediaProcessor;

	public IMessagingProcessor MessagingProcessor => _messagingProcessor;

	public IFeedProcessor FeedProcessor => _feedProcessor;

	public ICollectionProcessor CollectionProcessor => _collectionProcessor;

	public ILocationProcessor LocationProcessor => _locationProcessor;

	public IHashtagProcessor HashtagProcessor => _hashtagProcessor;

	public IUserProcessor UserProcessor => _userProcessor;

	internal HelperProcessor HelperProcessor => _helperProcessor;

	public ITVProcessor TVProcessor => _tvProcessor;

	public IBusinessProcessor BusinessProcessor => _businessProcessor;

	public IShoppingProcessor ShoppingProcessor => _shoppingProcessor;

	public IWebProcessor WebProcessor => _webProcessor;

	public InstaApi(UserSessionData user, IInstaLogger logger, AndroidDevice deviceInfo, IHttpRequestProcessor httpRequestProcessor, InstaApiVersionType apiVersionType)
	{
		_userAuthValidate = new UserAuthValidate();
		_user = user;
		_logger = logger;
		_deviceInfo = deviceInfo;
		_httpRequestProcessor = httpRequestProcessor;
		_apiVersionType = apiVersionType;
		_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(apiVersionType);
		_httpHelper = new HttpHelper(_apiVersion);
	}

	public async Task<IResult<InstaCheckEmailRegistration>> CheckEmailAsync(string email)
	{
		return await CheckEmail(email);
	}

	private async Task<IResult<InstaCheckEmailRegistration>> CheckEmail(string email, bool useNewWaterfall = true)
	{
		try
		{
			if (_waterfallIdReg == null || useNewWaterfall)
			{
				_waterfallIdReg = Guid.NewGuid().ToString();
			}
			await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_0105;
				}
			}
			text = string.Empty;
			goto IL_0105;
			IL_0105:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", text2 },
				{ "login_nonces", "[]" },
				{ "email", email },
				{
					"qe_id",
					Guid.NewGuid().ToString()
				},
				{ "waterfall_id", _waterfallIdReg }
			};
			Uri checkEmailUri = UriCreator.GetCheckEmailUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, checkEmailUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text3 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaCheckEmailRegistration instaCheckEmailRegistration = JsonConvert.DeserializeObject<InstaCheckEmailRegistration>(text3);
				if (instaCheckEmailRegistration.ErrorType == "fail")
				{
					return Result.UnExpectedResponse<InstaCheckEmailRegistration>(response, text3);
				}
				if (instaCheckEmailRegistration.ErrorType == "email_is_taken")
				{
					return Result.Fail<InstaCheckEmailRegistration>("Email is taken.", null);
				}
				if (instaCheckEmailRegistration.ErrorType == "invalid_email")
				{
					return Result.Fail<InstaCheckEmailRegistration>("Please enter a valid email address.", null);
				}
				return Result.UnExpectedResponse<InstaCheckEmailRegistration>(response, text3);
			}
			InstaCheckEmailRegistration instaCheckEmailRegistration2 = JsonConvert.DeserializeObject<InstaCheckEmailRegistration>(text3);
			if (instaCheckEmailRegistration2.ErrorType == "fail")
			{
				return Result.UnExpectedResponse<InstaCheckEmailRegistration>(response, text3);
			}
			if (instaCheckEmailRegistration2.ErrorType == "email_is_taken")
			{
				return Result.Fail<InstaCheckEmailRegistration>("Email is taken.", null);
			}
			if (instaCheckEmailRegistration2.ErrorType == "invalid_email")
			{
				return Result.Fail<InstaCheckEmailRegistration>("Please enter a valid email address.", null);
			}
			return Result.Success(instaCheckEmailRegistration2);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaCheckEmailRegistration>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaCheckEmailRegistration>(exception2);
		}
	}

	public async Task<IResult<bool>> CheckPhoneNumberAsync(string phoneNumber)
	{
		try
		{
			_deviceIdReg = ApiRequestMessage.GenerateDeviceId();
			await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_00e4;
				}
			}
			text = string.Empty;
			goto IL_00e4;
			IL_00e4:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "_csrftoken", text2 },
				{ "login_nonces", "[]" },
				{ "phone_number", phoneNumber },
				{ "device_id", _deviceInfo.DeviceId }
			};
			Uri checkPhoneNumberUri = UriCreator.GetCheckPhoneNumberUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, checkPhoneNumberUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, json);
			}
			return Result.Success(resValue: true);
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

	public async Task<IResult<InstaAccountCheck>> CheckUsernameAsync(string username)
	{
		try
		{
			Uri checkUsernameUri = UriCreator.GetCheckUsernameUri();
			JObject data = new JObject
			{
				{ "_csrftoken", _user.CsrfToken },
				{ "username", username }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, checkUsernameUri, _deviceInfo, data);
			return Result.Success(JsonConvert.DeserializeObject<InstaAccountCheck>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync()));
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

	public async Task<IResult<bool>> SendSignUpSmsCodeAsync(string phoneNumber)
	{
		try
		{
			if (string.IsNullOrEmpty(_waterfallIdReg))
			{
				_waterfallIdReg = Guid.NewGuid().ToString();
			}
			await CheckPhoneNumberAsync(phoneNumber);
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_00f1;
				}
			}
			text = string.Empty;
			goto IL_00f1;
			IL_00f1:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "phone_number", phoneNumber },
				{ "_csrftoken", text2 },
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{ "waterfall_id", _waterfallIdReg }
			};
			Uri signUpSMSCodeUri = UriCreator.GetSignUpSMSCodeUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, signUpSMSCodeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text3 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountRegistrationPhoneNumber instaAccountRegistrationPhoneNumber = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumber>(text3);
				InstaAccountRegistrationPhoneNumberMessage message = instaAccountRegistrationPhoneNumber.Message;
				object message2;
				if (message == null)
				{
					message2 = null;
				}
				else
				{
					string[] errors = message.Errors;
					message2 = ((errors != null) ? errors[0] : null);
				}
				return Result.UnExpectedResponse<bool>(response, (string)message2, text3);
			}
			_signUpPhoneNumberInfo = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumber>(text3);
			return Result.Success(resValue: true);
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

	public async Task<IResult<InstaPhoneNumberRegistration>> VerifySignUpSmsCodeAsync(string phoneNumber, string verificationCode)
	{
		try
		{
			if (string.IsNullOrEmpty(_waterfallIdReg))
			{
				throw new ArgumentException("You should call SendSignUpSmsCodeAsync function first.");
			}
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_007d;
				}
			}
			text = string.Empty;
			goto IL_007d;
			IL_007d:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "verification_code", verificationCode },
				{ "phone_number", phoneNumber },
				{ "_csrftoken", text2 },
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{ "waterfall_id", _waterfallIdReg }
			};
			Uri validateSignUpSMSCodeUri = UriCreator.GetValidateSignUpSMSCodeUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, validateSignUpSMSCodeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountRegistrationVerifyPhoneNumberErrors errors = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumberVerifySms>(json).Errors;
				object errMsg;
				if (errors == null)
				{
					errMsg = null;
				}
				else
				{
					string[] nonce = errors.Nonce;
					errMsg = ((nonce != null) ? nonce[0] : null);
				}
				return Result.Fail<InstaPhoneNumberRegistration>((string)errMsg, null);
			}
			InstaAccountRegistrationPhoneNumberVerifySms instaAccountRegistrationPhoneNumberVerifySms = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumberVerifySms>(json);
			if (instaAccountRegistrationPhoneNumberVerifySms.ErrorType == "invalid_nonce")
			{
				InstaAccountRegistrationVerifyPhoneNumberErrors errors2 = instaAccountRegistrationPhoneNumberVerifySms.Errors;
				object errMsg2;
				if (errors2 == null)
				{
					errMsg2 = null;
				}
				else
				{
					string[] nonce2 = errors2.Nonce;
					errMsg2 = ((nonce2 != null) ? nonce2[0] : null);
				}
				return Result.Fail<InstaPhoneNumberRegistration>((string)errMsg2, null);
			}
			await GetRegistrationStepsAsync();
			return Result.Success(JsonConvert.DeserializeObject<InstaPhoneNumberRegistration>(json));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaPhoneNumberRegistration>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaPhoneNumberRegistration>(exception2);
		}
	}

	public async Task<IResult<InstaRegistrationSuggestionResponse>> GetUsernameSuggestionsAsync(string name)
	{
		return await GetUsernameSuggestions(name);
	}

	public async Task<IResult<InstaRegistrationSuggestionResponse>> GetUsernameSuggestions(string name, bool useNewIds = true)
	{
		try
		{
			if (string.IsNullOrEmpty(_deviceIdReg))
			{
				_deviceIdReg = ApiRequestMessage.GenerateDeviceId();
			}
			if (useNewIds)
			{
				_phoneIdReg = Guid.NewGuid().ToString();
				_waterfallIdReg = Guid.NewGuid().ToString();
				_guidReg = Guid.NewGuid().ToString();
			}
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_00ce;
				}
			}
			text = string.Empty;
			goto IL_00ce;
			IL_00ce:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "name", name },
				{ "_csrftoken", text2 },
				{ "email", "" }
			};
			if (useNewIds)
			{
				dictionary.Add("phone_id", _phoneIdReg);
				dictionary.Add("guid", _guidReg);
				dictionary.Add("device_id", _deviceIdReg);
				dictionary.Add("waterfall_id", _waterfallIdReg);
			}
			else
			{
				dictionary.Add("phone_id", _deviceInfo.PhoneGuid.ToString());
				dictionary.Add("guid", _deviceInfo.DeviceGuid.ToString());
				dictionary.Add("device_id", _deviceInfo.DeviceId.ToString());
				dictionary.Add("waterfall_id", _waterfallIdReg ?? Guid.NewGuid().ToString());
			}
			Uri usernameSuggestionsUri = UriCreator.GetUsernameSuggestionsUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, usernameSuggestionsUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountRegistrationPhoneNumberMessage message = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumber>(value).Message;
				object errMsg;
				if (message == null)
				{
					errMsg = null;
				}
				else
				{
					string[] errors = message.Errors;
					errMsg = ((errors != null) ? errors[0] : null);
				}
				return Result.Fail<InstaRegistrationSuggestionResponse>((string)errMsg, null);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRegistrationSuggestionResponse>(value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception2);
		}
	}

	public async Task<IResult<InstaAccountCreation>> ValidateNewAccountWithPhoneNumberAsync(string phoneNumber, string verificationCode, string username, string password, string firstName)
	{
		try
		{
			string text;
			if (!string.IsNullOrEmpty(_waterfallIdReg) && _signUpPhoneNumberInfo != null)
			{
				if (_signUpPhoneNumberInfo.GdprRequired)
				{
					IResult<bool> result = await AcceptConsentRequiredAsync(null, phoneNumber);
					if (!result.Succeeded)
					{
						return Result.Fail<InstaAccountCreation>(result.Info.Message, null);
					}
				}
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				Cookie? cookie = cookies["csrftoken"];
				if (cookie != null)
				{
					text = cookie!.Value;
					if (text != null)
					{
						goto IL_0120;
					}
				}
				text = string.Empty;
				goto IL_0120;
			}
			throw new ArgumentException("You should call SendSignUpSmsCodeAsync function first.");
			IL_0120:
			string csrftoken = text;
			_user.CsrfToken = csrftoken;
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "allow_contacts_sync", "true" },
				{ "verification_code", verificationCode },
				{ "sn_result", "API_ERROR:+null" },
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "phone_number", phoneNumber },
				{ "_csrftoken", csrftoken },
				{ "username", username },
				{ "first_name", firstName },
				{
					"adid",
					Guid.NewGuid().ToString()
				},
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{ "sn_nonce", "" },
				{ "force_sign_up_code", "" },
				{ "waterfall_id", _waterfallIdReg },
				{ "qs_stamp", "" },
				{ "password", password },
				{ "has_sms_consent", "true" }
			};
			if (_signUpPhoneNumberInfo.GdprRequired)
			{
				dictionary.Add("gdpr_s", "[0,2,0,null]");
			}
			Uri createValidatedUri = UriCreator.GetCreateValidatedUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, createValidatedUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountCreationErrors errors = JsonConvert.DeserializeObject<InstaAccountCreationResponse>(value).Errors;
				object errMsg;
				if (errors == null)
				{
					errMsg = null;
				}
				else
				{
					string[] username2 = errors.Username;
					errMsg = ((username2 != null) ? username2[0] : null);
				}
				return Result.Fail<InstaAccountCreation>((string)errMsg, null);
			}
			InstaAccountCreationResponse instaAccountCreationResponse = JsonConvert.DeserializeObject<InstaAccountCreationResponse>(value);
			if (instaAccountCreationResponse.ErrorType == "username_is_taken")
			{
				InstaAccountCreationErrors errors2 = instaAccountCreationResponse.Errors;
				object errMsg2;
				if (errors2 == null)
				{
					errMsg2 = null;
				}
				else
				{
					string[] username3 = errors2.Username;
					errMsg2 = ((username3 != null) ? username3[0] : null);
				}
				return Result.Fail<InstaAccountCreation>((string)errMsg2, null);
			}
			InstaAccountCreation instaAccountCreation = JsonConvert.DeserializeObject<InstaAccountCreation>(value);
			if (instaAccountCreation.AccountCreated && instaAccountCreation.CreatedUser != null)
			{
				ValidateUserAsync(instaAccountCreation.CreatedUser, csrftoken, validateExtra: true, password);
			}
			return Result.Success(instaAccountCreation);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountCreation>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountCreation>(exception2);
		}
	}

	private async Task<IResult<object>> GetRegistrationStepsAsync()
	{
		try
		{
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_0060;
				}
			}
			text = string.Empty;
			goto IL_0060;
			IL_0060:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "fb_connected", "false" },
				{ "seen_steps", "[]" },
				{ "phone_id", _phoneIdReg },
				{ "fb_installed", "false" },
				{ "locale", "en_US" },
				{ "timezone_offset", "16200" },
				{ "network_type", "WIFI-UNKNOWN" },
				{ "_csrftoken", text2 },
				{ "guid", _guidReg },
				{ "is_ci", "false" },
				{ "android_id", _deviceIdReg },
				{ "reg_flow_taken", "phone" },
				{ "tos_accepted", "false" }
			};
			Uri onboardingStepsUri = UriCreator.GetOnboardingStepsUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, onboardingStepsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountRegistrationPhoneNumberMessage message = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumber>(value).Message;
				object errMsg;
				if (message == null)
				{
					errMsg = null;
				}
				else
				{
					string[] errors = message.Errors;
					errMsg = ((errors != null) ? errors[0] : null);
				}
				return Result.Fail<InstaRegistrationSuggestionResponse>((string)errMsg, null);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRegistrationSuggestionResponse>(value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception2);
		}
	}

	private async Task<IResult<InstaAccountCreation>> CreateNewAccountAsync(string username, string password, string email, string firstName = "", TimeSpan? delay = null)
	{
		new InstaAccountCreation();
		try
		{
			if (!delay.HasValue)
			{
				delay = TimeSpan.FromSeconds(2.5);
			}
			await (await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress)).Content.ReadAsStringAsync();
			CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
			Cookie? cookie = cookies["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_019f;
				}
			}
			text = string.Empty;
			goto IL_019f;
			IL_019f:
			string csrftoken = text;
			IResult<InstaCheckEmailRegistration> checkEmail = await CheckEmail(email, useNewWaterfall: false);
			if (!checkEmail.Succeeded)
			{
				return Result.Fail<InstaAccountCreation>(checkEmail.Info.Message, null);
			}
			await Task.Delay((int)delay.Value.TotalMilliseconds);
			if (checkEmail.Value.GdprRequired)
			{
				IResult<bool> result = await AcceptConsentRequiredAsync(email);
				if (!result.Succeeded)
				{
					return Result.Fail<InstaAccountCreation>(result.Info.Message, null);
				}
			}
			await Task.Delay((int)delay.Value.TotalMilliseconds);
			if (username.Length <= 6)
			{
				await GetUsernameSuggestions(username, useNewIds: false);
				await Task.Delay(1000);
				await GetUsernameSuggestions(username, useNewIds: false);
			}
			else
			{
				await GetUsernameSuggestions(username.Substring(0, 4), useNewIds: false);
				await Task.Delay(1000);
				await GetUsernameSuggestions(username.Substring(0, 5), useNewIds: false);
			}
			await Task.Delay((int)delay.Value.TotalMilliseconds);
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "allow_contacts_sync", "true" },
				{ "sn_result", "API_ERROR:+null" },
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "_csrftoken", csrftoken },
				{ "username", username },
				{ "first_name", firstName },
				{
					"adid",
					Guid.NewGuid().ToString()
				},
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"device_id",
					_deviceInfo.DeviceId.ToString()
				},
				{ "email", email },
				{ "sn_nonce", "" },
				{ "force_sign_up_code", "" },
				{
					"waterfall_id",
					_waterfallIdReg ?? Guid.NewGuid().ToString()
				},
				{ "qs_stamp", "" },
				{ "password", password }
			};
			if (checkEmail.Value.GdprRequired)
			{
				dictionary.Add("gdpr_s", "[0,2,0,null]");
			}
			Uri createAccountUri = UriCreator.GetCreateAccountUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, createAccountUri, _deviceInfo, dictionary);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountCreation>(response, text2);
			}
			InstaAccountCreation instaAccountCreation = JsonConvert.DeserializeObject<InstaAccountCreation>(text2);
			if (instaAccountCreation.AccountCreated && instaAccountCreation.CreatedUser != null)
			{
				ValidateUserAsync(instaAccountCreation.CreatedUser, csrftoken, validateExtra: true, password);
			}
			return Result.Success(instaAccountCreation);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountCreation>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountCreation>(exception2);
		}
	}

	public async Task<IResult<InstaAccountCreation>> CreateNewAccountAsync(string username, string password, string email, string firstName)
	{
		new InstaAccountCreation();
		try
		{
			string _deviceIdReg = ApiRequestMessage.GenerateDeviceId();
			string _phoneIdReg = Guid.NewGuid().ToString();
			string _waterfallIdReg = Guid.NewGuid().ToString();
			string _guidReg = Guid.NewGuid().ToString();
			await (await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress)).Content.ReadAsStringAsync();
			CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
			Cookie? cookie = cookies["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_01a5;
				}
			}
			text = string.Empty;
			goto IL_01a5;
			IL_01a5:
			string csrftoken = text;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "allow_contacts_sync", "true" },
				{ "sn_result", "API_ERROR:+null" },
				{ "phone_id", _phoneIdReg },
				{ "_csrftoken", csrftoken },
				{ "username", username },
				{ "first_name", firstName },
				{
					"adid",
					Guid.NewGuid().ToString()
				},
				{ "guid", _guidReg },
				{ "device_id", _deviceIdReg },
				{ "email", email },
				{ "sn_nonce", "" },
				{ "force_sign_up_code", "" },
				{ "waterfall_id", _waterfallIdReg },
				{ "qs_stamp", "" },
				{ "password", password }
			};
			Uri createAccountUri = UriCreator.GetCreateAccountUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, createAccountUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaAccountCreation>(response, text2);
			}
			InstaAccountCreation instaAccountCreation = JsonConvert.DeserializeObject<InstaAccountCreation>(text2);
			if (instaAccountCreation.AccountCreated && instaAccountCreation.CreatedUser != null)
			{
				ValidateUserAsync(instaAccountCreation.CreatedUser, csrftoken, validateExtra: true, password);
			}
			return Result.Success(instaAccountCreation);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaAccountCreation>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaAccountCreation>(exception2);
		}
	}

	private async Task<IResult<bool>> AcceptConsentRequiredAsync(string email, string phone = null)
	{
		try
		{
			TimeSpan delay = TimeSpan.FromSeconds(2.0);
			await Task.Delay((int)delay.TotalMilliseconds);
			Uri instaUri2 = UriCreator.GetConsentNewUserFlowBeginsUri();
			JObject data = new JObject
			{
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			HttpResponseMessage response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			await Task.Delay((int)delay.TotalMilliseconds);
			instaUri2 = UriCreator.GetConsentNewUserFlowUri();
			data = new JObject
			{
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "gdpr_s", "" },
				{ "_csrftoken", _user.CsrfToken },
				{ "guid", _deviceInfo.DeviceGuid },
				{ "device_id", _deviceInfo.DeviceId }
			};
			if (email != null)
			{
				data.Add("email", email);
			}
			else
			{
				if (phone != null && !phone.StartsWith("+"))
				{
					phone = "+" + phone;
				}
				if (phone == null)
				{
					phone = string.Empty;
				}
				data.Add("phone", phone);
			}
			signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			await Task.Delay((int)delay.TotalMilliseconds);
			data = new JObject
			{
				{ "current_screen_key", "age_consent_two_button" },
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "gdpr_s", "[0,0,0,null]" },
				{ "_csrftoken", _user.CsrfToken },
				{ "updates", "{\"age_consent_state\":\"2\"}" },
				{ "guid", _deviceInfo.DeviceGuid },
				{ "device_id", _deviceInfo.DeviceId }
			};
			signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			return Result.Success(resValue: true);
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

	public async Task<IResult<InstaLoginResult>> LoginAsync(bool isNewLogin = true)
	{
		ValidateUser();
		ValidateRequestMessage();
		try
		{
			bool needsRelogin = false;
			string text2;
			while (true)
			{
				if (isNewLogin)
				{
					HttpResponseMessage firstResponse = await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
					await firstResponse.Content.ReadAsStringAsync();
					_logger?.LogResponse(firstResponse);
				}
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				Cookie? cookie = cookies["csrftoken"];
				string text;
				if (cookie != null)
				{
					text = cookie!.Value;
					if (text != null)
					{
						goto IL_0243;
					}
				}
				text = string.Empty;
				goto IL_0243;
				IL_0243:
				string csrfToken = text;
				_user.CsrfToken = csrfToken;
				Uri loginUri = UriCreator.GetLoginUri();
				_ = string.Empty;
				string deviceid = string.Empty;
				string value = ((!isNewLogin) ? (_httpRequestProcessor.RequestMessage.GenerateChallengeSignature(_apiVersion, _apiVersion.SignatureKey, csrfToken, out deviceid) + "." + _httpRequestProcessor.RequestMessage.GetChallengeMessageString(csrfToken)) : (_httpRequestProcessor.RequestMessage.GenerateSignature(_apiVersion, _apiVersion.SignatureKey, out deviceid) + "." + _httpRequestProcessor.RequestMessage.GetMessageString()));
				_deviceInfo.DeviceId = deviceid;
				Dictionary<string, string> data = new Dictionary<string, string>
				{
					{ "signed_body", value },
					{ "ig_sig_key_version", "4" }
				};
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, loginUri, _deviceInfo, data);
				defaultRequest.Headers.Add("Host", "i.instagram.com");
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				text2 = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					break;
				}
				InstaLoginBaseResponse instaLoginBaseResponse = JsonConvert.DeserializeObject<InstaLoginBaseResponse>(text2);
				if (!instaLoginBaseResponse.InvalidCredentials)
				{
					if (!instaLoginBaseResponse.TwoFactorRequired)
					{
						if (!(instaLoginBaseResponse.ErrorType == "checkpoint_challenge_required"))
						{
							if (!(instaLoginBaseResponse.ErrorType == "rate_limit_error"))
							{
								if (!(instaLoginBaseResponse.ErrorType == "inactive user") && !(instaLoginBaseResponse.ErrorType == "inactive_user"))
								{
									if (instaLoginBaseResponse.ErrorType == "checkpoint_logged_out")
									{
										if (!needsRelogin)
										{
											needsRelogin = true;
											continue;
										}
										return Result.Fail(instaLoginBaseResponse.ErrorType + " " + instaLoginBaseResponse.CheckpointUrl, InstaLoginResult.CheckpointLoggedOut);
									}
									return Result.UnExpectedResponse<InstaLoginResult>(response, text2);
								}
								return Result.Fail(instaLoginBaseResponse.Message + "\r\nHelp url: " + instaLoginBaseResponse.HelpUrl, InstaLoginResult.InactiveUser);
							}
							return Result.Fail("Please wait a few minutes before you try again.", InstaLoginResult.LimitError);
						}
						_challengeinfo = instaLoginBaseResponse.Challenge;
						return Result.Fail("Challenge is required", InstaLoginResult.ChallengeRequired);
					}
					if (instaLoginBaseResponse.TwoFactorLoginInfo != null)
					{
						_httpRequestProcessor.RequestMessage.Username = instaLoginBaseResponse.TwoFactorLoginInfo.Username;
					}
					_twoFactorInfo = instaLoginBaseResponse.TwoFactorLoginInfo;
					return Result.Fail("Two Factor Authentication is required", InstaLoginResult.TwoFactorRequired);
				}
				return Result.Fail("Invalid Credentials", (instaLoginBaseResponse.ErrorType == "bad_password") ? InstaLoginResult.BadPassword : InstaLoginResult.InvalidUser);
			}
			InstaLoginResponse instaLoginResponse = JsonConvert.DeserializeObject<InstaLoginResponse>(text2);
			_user.UserName = instaLoginResponse.User?.UserName;
			IsUserAuthenticated = instaLoginResponse.User != null;
			if (instaLoginResponse.User != null)
			{
				_httpRequestProcessor.RequestMessage.Username = instaLoginResponse.User.UserName;
			}
			IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(instaLoginResponse.User);
			_user.LoggedInUser = userShortConverter.Convert();
			_user.RankToken = $"{_user.LoggedInUser.Pk}_{_httpRequestProcessor.RequestMessage.PhoneId}";
			UserSessionData user;
			string text3;
			if (string.IsNullOrEmpty(_user.CsrfToken))
			{
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				user = _user;
				Cookie? cookie2 = cookies["csrftoken"];
				if (cookie2 != null)
				{
					text3 = cookie2!.Value;
					if (text3 != null)
					{
						goto IL_066a;
					}
				}
				text3 = string.Empty;
				goto IL_066a;
			}
			goto IL_066f;
			IL_066a:
			user.CsrfToken = text3;
			goto IL_066f;
			IL_066f:
			return Result.Success(InstaLoginResult.Success);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, InstaLoginResult.Exception, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			LogException(exception2);
			return Result.Fail(exception2, InstaLoginResult.Exception);
		}
		finally
		{
			InvalidateProcessors();
		}
	}

	public async Task<IResult<bool>> LoginWithCookiesAsync(string cookies)
	{
		try
		{
			if (cookies.Contains("Cookie:"))
			{
				cookies = cookies.Substring(8);
			}
			var source = from xx in cookies.Split(new char[1] { ';' })
				where xx.Contains("=")
				select xx.Trim().Split(new char[1] { '=' }) into xx
				select new
				{
					Name = xx.First(),
					Value = xx.Last()
				};
			string text = source.FirstOrDefault(u => u.Name.ToLower() == "ds_user")?.Value?.ToLower();
			string text2 = source.FirstOrDefault(u => u.Name.ToLower() == "ds_user_id")?.Value;
			string text3 = source.FirstOrDefault(u => u.Name.ToLower() == "csrftoken")?.Value;
			if (string.IsNullOrEmpty(text3))
			{
				return Result.Fail<bool>("Cannot find 'csrftoken' in cookies!");
			}
			if (string.IsNullOrEmpty(text2))
			{
				return Result.Fail<bool>("Cannot find 'ds_user_id' in cookies!");
			}
			Uri uri = new Uri("https://i.instagram.com");
			cookies = cookies.Replace(';', ',');
			_httpRequestProcessor.HttpHandler.CookieContainer.SetCookies(uri, cookies);
			_user = UserSessionData.Empty;
			text = text ?? "AlakiMasalan";
			string text6 = (_user.UserName = (_httpRequestProcessor.RequestMessage.Username = text));
			_user.Password = "AlakiMasalan";
			_user.LoggedInUser = new InstaUserShort
			{
				UserName = text
			};
			try
			{
				_user.LoggedInUser.Pk = long.Parse(text2);
			}
			catch
			{
			}
			_user.CsrfToken = text3;
			_user.RankToken = $"{_deviceInfo.RankToken}_{text2}";
			IsUserAuthenticated = true;
			InvalidateProcessors();
			IResult<InstaUserInfo> result = await UserProcessor.GetUserInfoByIdAsync(long.Parse(text2));
			if (!result.Succeeded)
			{
				IsUserAuthenticated = false;
				return Result.Fail(result.Info, resValue: false);
			}
			UserSessionData user = _user;
			ApiRequestMessage requestMessage = _httpRequestProcessor.RequestMessage;
			string text7 = (_user.LoggedInUser.UserName = result.Value.Username);
			text6 = (user.UserName = (requestMessage.Username = text7));
			_user.LoggedInUser.FullName = result.Value.FullName;
			_user.LoggedInUser.IsPrivate = result.Value.IsPrivate;
			_user.LoggedInUser.IsVerified = result.Value.IsVerified;
			_user.LoggedInUser.ProfilePicture = result.Value.ProfilePicUrl;
			_user.LoggedInUser.ProfilePicUrl = result.Value.ProfilePicUrl;
			return Result.Success(resValue: true);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			LogException(exception2);
			return Result.Fail(exception2, resValue: false);
		}
	}

	public async Task<IResult<InstaLoginTwoFactorResult>> TwoFactorLoginAsync(string verificationCode)
	{
		if (_twoFactorInfo != null)
		{
			try
			{
				ApiTwoFactorRequestMessage apiTwoFactorRequestMessage = new ApiTwoFactorRequestMessage(verificationCode, _httpRequestProcessor.RequestMessage.Username, _httpRequestProcessor.RequestMessage.DeviceId, _twoFactorInfo.TwoFactorIdentifier);
				Uri twoFactorLoginUri = UriCreator.GetTwoFactorLoginUri();
				string value = apiTwoFactorRequestMessage.GenerateSignature(_apiVersion, _apiVersion.SignatureKey) + "." + apiTwoFactorRequestMessage.GetMessageString();
				Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
				{
					{ "signed_body", value },
					{ "ig_sig_key_version", "4" }
				};
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, twoFactorLoginUri, _deviceInfo);
				defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
				defaultRequest.Properties.Add("signed_body", value);
				defaultRequest.Properties.Add("ig_sig_key_version", "4");
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string value2 = await response.Content.ReadAsStringAsync();
				if (response.StatusCode == HttpStatusCode.OK)
				{
					InstaLoginResponse instaLoginResponse = JsonConvert.DeserializeObject<InstaLoginResponse>(value2);
					_user.UserName = instaLoginResponse.User?.UserName;
					IsUserAuthenticated = instaLoginResponse.User != null;
					_httpRequestProcessor.RequestMessage.Username = instaLoginResponse.User?.UserName;
					IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(instaLoginResponse.User);
					_user.LoggedInUser = userShortConverter.Convert();
					_user.RankToken = $"{_user.LoggedInUser.Pk}_{_httpRequestProcessor.RequestMessage.PhoneId}";
					return Result.Success(InstaLoginTwoFactorResult.Success);
				}
				InstaLoginTwoFactorBaseResponse instaLoginTwoFactorBaseResponse = JsonConvert.DeserializeObject<InstaLoginTwoFactorBaseResponse>(value2);
				if (instaLoginTwoFactorBaseResponse.ErrorType == "sms_code_validation_code_invalid")
				{
					return Result.Fail("Please check the security code.", InstaLoginTwoFactorResult.InvalidCode);
				}
				if (instaLoginTwoFactorBaseResponse.Message.ToLower().Contains("challenge"))
				{
					_challengeinfo = instaLoginTwoFactorBaseResponse.Challenge;
					return Result.Fail("Challenge is required", InstaLoginTwoFactorResult.ChallengeRequired);
				}
				return Result.Fail("This code is no longer valid, please, call LoginAsync again to request a new one", InstaLoginTwoFactorResult.CodeExpired);
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail(exception, InstaLoginTwoFactorResult.Success, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				LogException(exception2);
				return Result.Fail(exception2, InstaLoginTwoFactorResult.Exception);
			}
		}
		return Result.Fail<InstaLoginTwoFactorResult>("Run LoginAsync first");
	}

	public async Task<IResult<InstaTwoFactorLoginInfo>> GetTwoFactorInfoAsync()
	{
		return await Task.Run(() => (_twoFactorInfo == null) ? Result.Fail<InstaTwoFactorLoginInfo>("No Two Factor info available.") : Result.Success(_twoFactorInfo));
	}

	public async Task<IResult<bool>> LogoutAsync()
	{
		ValidateUser();
		ValidateLoggedIn();
		try
		{
			Uri logoutUri = UriCreator.GetLogoutUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, logoutUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			if (JsonConvert.DeserializeObject<BaseStatusResponse>(text).Status == "ok")
			{
				IsUserAuthenticated = false;
			}
			return Result.Success(!IsUserAuthenticated);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, resValue: false, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			LogException(exception2);
			return Result.Fail(exception2, resValue: false);
		}
	}

	public async Task<IResult<InstaUserLookup>> GetRecoveryOptionsAsync(string usernameOrEmailOrPhoneNumber)
	{
		try
		{
			string text;
			if (!string.IsNullOrEmpty(_user.CsrfToken))
			{
				text = _user.CsrfToken;
				goto IL_0117;
			}
			HttpResponseMessage response2 = await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
			CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
			_logger?.LogResponse(response2);
			Cookie? cookie = cookies["csrftoken"];
			string text2;
			if (cookie != null)
			{
				text2 = cookie!.Value;
				if (text2 != null)
				{
					goto IL_0116;
				}
			}
			text2 = string.Empty;
			goto IL_0116;
			IL_0116:
			text = text2;
			goto IL_0117;
			IL_0117:
			JObject data = new JObject
			{
				{ "_csrftoken", text },
				{ "q", usernameOrEmailOrPhoneNumber },
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{ "directly_sign_in", "true" }
			};
			Uri usersLookupUri = UriCreator.GetUsersLookupUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, usersLookupUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			InstaUserLookupResponse instaUserLookupResponse = JsonConvert.DeserializeObject<InstaUserLookupResponse>(await response.Content.ReadAsStringAsync());
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.Fail<InstaUserLookup>(instaUserLookupResponse.Message);
			}
			return Result.Success(ConvertersFabric.Instance.GetUserLookupConverter(instaUserLookupResponse).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaUserLookup>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaUserLookup>(exception2);
		}
	}

	public async Task<IResult<InstaRecovery>> SendRecoveryByUsernameAsync(string username)
	{
		return await SendRecoveryByEmailAsync(username);
	}

	public async Task<IResult<InstaRecovery>> SendRecoveryByEmailAsync(string email)
	{
		try
		{
			string text;
			if (!string.IsNullOrEmpty(_user.CsrfToken))
			{
				text = _user.CsrfToken;
				goto IL_0117;
			}
			HttpResponseMessage response2 = await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
			CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
			_logger?.LogResponse(response2);
			Cookie? cookie = cookies["csrftoken"];
			string text2;
			if (cookie != null)
			{
				text2 = cookie!.Value;
				if (text2 != null)
				{
					goto IL_0116;
				}
			}
			text2 = string.Empty;
			goto IL_0116;
			IL_0116:
			text = text2;
			goto IL_0117;
			IL_0117:
			JObject data = new JObject
			{
				{ "query", email },
				{ "adid", _deviceInfo.GoogleAdId },
				{
					"device_id",
					ApiRequestMessage.GenerateDeviceId()
				},
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "_csrftoken", text }
			};
			Uri accountRecoveryEmailUri = UriCreator.GetAccountRecoveryEmailUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountRecoveryEmailUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.Fail<InstaRecovery>(JsonConvert.DeserializeObject<MessageErrorsResponseRecoveryEmail>(value).Message);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRecovery>(value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRecovery>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaRecovery>(exception2);
		}
	}

	public async Task<IResult<InstaRecovery>> SendRecoveryByPhoneAsync(string phone)
	{
		try
		{
			if (!string.IsNullOrEmpty(_user.CsrfToken))
			{
				_ = _user.CsrfToken;
			}
			else
			{
				HttpResponseMessage response2 = await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress);
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				_logger?.LogResponse(response2);
				if (cookies["csrftoken"]?.Value == null)
				{
				}
			}
			JObject data = new JObject
			{
				{ "query", phone },
				{ "_csrftoken", _user.CsrfToken }
			};
			Uri accountRecoverPhoneUri = UriCreator.GetAccountRecoverPhoneUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, accountRecoverPhoneUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				BadStatusErrorsResponse badStatusErrorsResponse = JsonConvert.DeserializeObject<BadStatusErrorsResponse>(text);
				string errors2 = "";
				badStatusErrorsResponse.Message.Errors.ForEach(delegate(string errorContent)
				{
					errors2 = errors2 + errorContent + "\n";
				});
				return Result.Fail<InstaRecovery>(errors2);
			}
			if (text.Contains("errors"))
			{
				BadStatusErrorsResponseRecovery badStatusErrorsResponseRecovery = JsonConvert.DeserializeObject<BadStatusErrorsResponseRecovery>(text);
				string errors = "";
				badStatusErrorsResponseRecovery.PhoneNumber.Errors.ForEach(delegate(string errorContent)
				{
					errors = errors + errorContent + "\n";
				});
				return Result.Fail<InstaRecovery>(errors);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRecovery>(text));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRecovery>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaRecovery>(exception2);
		}
	}

	public async Task<IResult<TwoFactorLoginSMS>> SendTwoFactorLoginSMSAsync()
	{
		try
		{
			if (_twoFactorInfo == null)
			{
				return Result.Fail<TwoFactorLoginSMS>("Run LoginAsync first");
			}
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "two_factor_identifier", _twoFactorInfo.TwoFactorIdentifier },
				{
					"username",
					_httpRequestProcessor.RequestMessage.Username
				},
				{
					"device_id",
					_httpRequestProcessor.RequestMessage.DeviceId
				},
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "_csrftoken", _user.CsrfToken }
			};
			Uri account2FALoginAgainUri = UriCreator.GetAccount2FALoginAgainUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, account2FALoginAgainUri, _deviceInfo, data);
			TwoFactorLoginSMS twoFactorLoginSMS = JsonConvert.DeserializeObject<TwoFactorLoginSMS>(await (await _httpRequestProcessor.SendAsync(signedRequest)).Content.ReadAsStringAsync());
			if (!string.IsNullOrEmpty(twoFactorLoginSMS.TwoFactorInfo.TwoFactorIdentifier))
			{
				_twoFactorInfo.TwoFactorIdentifier = twoFactorLoginSMS.TwoFactorInfo.TwoFactorIdentifier;
			}
			return Result.Success(twoFactorLoginSMS);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<TwoFactorLoginSMS>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<TwoFactorLoginSMS>(exception2);
		}
	}

	public async Task<IResult<InstaLoggedInChallengeDataInfo>> GetLoggedInChallengeDataInfoAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri challengeRequireFirstUri = UriCreator.GetChallengeRequireFirstUri("/challenge/", _deviceInfo.DeviceGuid.ToString(), _deviceInfo.DeviceId);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, challengeRequireFirstUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaLoggedInChallengeDataInfo>(response, text);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaLoggedInChallengeDataInfoContainer>(text)?.StepData);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaLoggedInChallengeDataInfo>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			return Result.Fail<InstaLoggedInChallengeDataInfo>(exception2, null);
		}
	}

	public async Task<IResult<bool>> AcceptChallengeAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri challengeUri = UriCreator.GetChallengeUri();
			JObject data = new JObject
			{
				{ "choice", "0" },
				{ "_csrftoken", _user.CsrfToken },
				{
					"_uid",
					_user.LoggedInUser.Pk
				},
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				}
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, challengeUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response, text);
			}
			return (JsonConvert.DeserializeObject<InstaChallengeRequireVerifyCode>(text).Action.ToLower() == "close") ? Result.Success(resValue: true) : Result.Success(resValue: false);
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

	public async Task<IResult<InstaChallengeRequireVerifyMethod>> GetChallengeRequireVerifyMethodAsync()
	{
		if (_challengeinfo != null)
		{
			try
			{
				Uri challengeRequireFirstUri = UriCreator.GetChallengeRequireFirstUri(_challengeinfo.ApiPath, _deviceInfo.DeviceGuid.ToString(), _deviceInfo.DeviceId);
				HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, challengeRequireFirstUri, _deviceInfo);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					return Result.UnExpectedResponse<InstaChallengeRequireVerifyMethod>(response, text);
				}
				return Result.Success(JsonConvert.DeserializeObject<InstaChallengeRequireVerifyMethod>(text));
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail<InstaChallengeRequireVerifyMethod>(exception, null, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				return Result.Fail<InstaChallengeRequireVerifyMethod>(exception2, null);
			}
		}
		return Result.Fail<InstaChallengeRequireVerifyMethod>("challenge require info is empty.\r\ntry to call LoginAsync function first.", null);
	}

	public async Task<IResult<InstaChallengeRequireVerifyMethod>> ResetChallengeRequireVerifyMethodAsync()
	{
		if (_challengeinfo != null)
		{
			try
			{
				Uri resetChallengeRequireUri = UriCreator.GetResetChallengeRequireUri(_challengeinfo.ApiPath);
				JObject data = new JObject
				{
					{ "_csrftoken", _user.CsrfToken },
					{
						"guid",
						_deviceInfo.DeviceGuid.ToString()
					},
					{ "device_id", _deviceInfo.DeviceId }
				};
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, resetChallengeRequireUri, _deviceInfo, data);
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string text = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					try
					{
						_ = JsonConvert.DeserializeObject<InstaChallengeRequireVerifyMethod>(text).Message;
					}
					catch
					{
					}
					return Result.UnExpectedResponse<InstaChallengeRequireVerifyMethod>(response, text);
				}
				return Result.Success(JsonConvert.DeserializeObject<InstaChallengeRequireVerifyMethod>(text));
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail<InstaChallengeRequireVerifyMethod>(exception, null, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				return Result.Fail<InstaChallengeRequireVerifyMethod>(exception2, null);
			}
		}
		return Result.Fail<InstaChallengeRequireVerifyMethod>("challenge require info is empty.\r\ntry to call LoginAsync function first.", null);
	}

	public async Task<IResult<InstaChallengeRequireSMSVerify>> RequestVerifyCodeToSMSForChallengeRequireAsync(bool replayChallenge)
	{
		return await RequestVerifyCodeToSMSForChallengeRequire(replayChallenge);
	}

	public async Task<IResult<InstaChallengeRequireSMSVerify>> SubmitPhoneNumberForChallengeRequireAsync(string phoneNumber, bool replayChallenge)
	{
		return await RequestVerifyCodeToSMSForChallengeRequire(replayChallenge, phoneNumber);
	}

	private async Task<IResult<InstaChallengeRequireSMSVerify>> RequestVerifyCodeToSMSForChallengeRequire(bool replayChallenge, string phoneNumber = null)
	{
		if (_challengeinfo != null)
		{
			try
			{
				Uri uri = ((!replayChallenge) ? UriCreator.GetChallengeRequireUri(_challengeinfo.ApiPath) : UriCreator.GetChallengeReplayUri(_challengeinfo.ApiPath));
				JObject jObject = new JObject
				{
					{ "_csrftoken", _user.CsrfToken },
					{
						"guid",
						_deviceInfo.DeviceGuid.ToString()
					},
					{ "device_id", _deviceInfo.DeviceId }
				};
				if (!string.IsNullOrEmpty(phoneNumber))
				{
					jObject.Add("phone_number", phoneNumber);
				}
				else
				{
					jObject.Add("choice", "0");
				}
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, uri, _deviceInfo, jObject);
				signedRequest.Headers.Add("Host", "i.instagram.com");
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string value = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					string errMsg = "";
					try
					{
						errMsg = JsonConvert.DeserializeObject<InstaChallengeRequireSMSVerify>(value).Message;
					}
					catch
					{
					}
					return Result.Fail<InstaChallengeRequireSMSVerify>(errMsg, null);
				}
				return Result.Success(JsonConvert.DeserializeObject<InstaChallengeRequireSMSVerify>(value));
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail<InstaChallengeRequireSMSVerify>(exception, null, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				return Result.Fail<InstaChallengeRequireSMSVerify>(exception2, null);
			}
		}
		return Result.Fail<InstaChallengeRequireSMSVerify>("challenge require info is empty.\r\ntry to call LoginAsync function first.", null);
	}

	public async Task<IResult<InstaChallengeRequireEmailVerify>> RequestVerifyCodeToEmailForChallengeRequireAsync(bool replayChallenge)
	{
		if (_challengeinfo != null)
		{
			try
			{
				Uri uri = ((!replayChallenge) ? UriCreator.GetChallengeRequireUri(_challengeinfo.ApiPath) : UriCreator.GetChallengeReplayUri(_challengeinfo.ApiPath));
				JObject data = new JObject
				{
					{ "choice", "1" },
					{ "_csrftoken", _user.CsrfToken },
					{
						"guid",
						_deviceInfo.DeviceGuid.ToString()
					},
					{ "device_id", _deviceInfo.DeviceId }
				};
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, uri, _deviceInfo, data);
				signedRequest.Headers.Add("Host", "i.instagram.com");
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string value = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					string errMsg = "";
					try
					{
						errMsg = JsonConvert.DeserializeObject<InstaChallengeRequireEmailVerify>(value).Message;
					}
					catch
					{
					}
					return Result.Fail<InstaChallengeRequireEmailVerify>(errMsg, null);
				}
				return Result.Success(JsonConvert.DeserializeObject<InstaChallengeRequireEmailVerify>(value));
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail<InstaChallengeRequireEmailVerify>(exception, null, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				return Result.Fail<InstaChallengeRequireEmailVerify>(exception2, null);
			}
		}
		return Result.Fail<InstaChallengeRequireEmailVerify>("challenge require info is empty.\r\ntry to call LoginAsync function first.", null);
	}

	public async Task<IResult<InstaLoginResult>> VerifyCodeForChallengeRequireAsync(string verifyCode)
	{
		if (_challengeinfo == null)
		{
			return Result.Fail("challenge require info is empty.\r\ntry to call LoginAsync function first.", InstaLoginResult.Exception);
		}
		if (verifyCode.Length == 6)
		{
			try
			{
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				Cookie? cookie = cookies["csrftoken"];
				string text;
				if (cookie != null)
				{
					text = cookie!.Value;
					if (text != null)
					{
						goto IL_00a8;
					}
				}
				text = string.Empty;
				goto IL_00a8;
				IL_00a8:
				string csrftoken = text;
				_user.CsrfToken = csrftoken;
				Uri challengeRequireUri = UriCreator.GetChallengeRequireUri(_challengeinfo.ApiPath);
				JObject data = new JObject
				{
					{ "security_code", verifyCode },
					{ "_csrftoken", _user.CsrfToken },
					{
						"guid",
						_deviceInfo.DeviceGuid.ToString()
					},
					{ "device_id", _deviceInfo.DeviceId }
				};
				HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, challengeRequireUri, _deviceInfo, data);
				signedRequest.Headers.Add("Host", "i.instagram.com");
				HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
				string value = await response.Content.ReadAsStringAsync();
				if (response.StatusCode != HttpStatusCode.OK)
				{
					string errMsg = "";
					try
					{
						errMsg = JsonConvert.DeserializeObject<InstaChallengeRequireVerifyCode>(value).Message;
					}
					catch
					{
					}
					return Result.Fail(errMsg, InstaLoginResult.Exception);
				}
				InstaChallengeRequireVerifyCode instaChallengeRequireVerifyCode = JsonConvert.DeserializeObject<InstaChallengeRequireVerifyCode>(value);
				if (instaChallengeRequireVerifyCode != null)
				{
					if (instaChallengeRequireVerifyCode.LoggedInUser != null)
					{
						ValidateUserAsync(instaChallengeRequireVerifyCode.LoggedInUser, csrftoken);
						await Task.Delay(3000);
						await _messagingProcessor.GetDirectInboxAsync(PaginationParameters.MaxPagesToLoad(1));
						await _feedProcessor.GetRecentActivityFeedAsync(PaginationParameters.MaxPagesToLoad(1));
						return Result.Success(InstaLoginResult.Success);
					}
					if (!string.IsNullOrEmpty(instaChallengeRequireVerifyCode.Action))
					{
						await Task.Delay(15000);
						return await LoginAsync(isNewLogin: false);
					}
				}
				return Result.Fail(instaChallengeRequireVerifyCode?.Message, InstaLoginResult.Exception);
			}
			catch (HttpRequestException exception)
			{
				_logger?.LogException(exception);
				return Result.Fail(exception, InstaLoginResult.Success, ResponseType.NetworkProblem);
			}
			catch (Exception exception2)
			{
				LogException(exception2);
				return Result.Fail(exception2, InstaLoginResult.Exception);
			}
		}
		return Result.Fail("Verify code must be an 6 digit number.", InstaLoginResult.Exception);
	}

	public async Task<IResult<InstaLoginResult>> LoginWithFacebookAsync(string fbAccessToken, string cookiesContainer)
	{
		return await LoginWithFacebookAsync(fbAccessToken, cookiesContainer, dryrun: true, null, null, null, newToken: true);
	}

	public async Task<IResult<InstaLoginResult>> LoginWithFacebookAsync(string fbAccessToken, string cookiesContainer, bool dryrun = true, string username = null, string waterfallId = null, string adId = null, bool newToken = true)
	{
		try
		{
			_facebookAccessToken = null;
			if (newToken)
			{
				await (await _httpRequestProcessor.GetAsync(_httpRequestProcessor.Client.BaseAddress)).Content.ReadAsStringAsync();
			}
			CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
			Cookie? cookie = cookies["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_0164;
				}
			}
			text = string.Empty;
			goto IL_0164;
			IL_0164:
			string csrftoken = text;
			Uri uri = new Uri("https://i.instagram.com");
			cookiesContainer = cookiesContainer.Replace(';', ',');
			_httpRequestProcessor.HttpHandler.CookieContainer.SetCookies(uri, cookiesContainer);
			if (adId.IsEmpty())
			{
				adId = Guid.NewGuid().ToString();
			}
			if (waterfallId.IsEmpty())
			{
				waterfallId = Guid.NewGuid().ToString();
			}
			Uri facebookSignUpUri = UriCreator.GetFacebookSignUpUri();
			JObject jObject = new JObject
			{
				{
					"dryrun",
					dryrun.ToString().ToLower()
				},
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "_csrftoken", csrftoken },
				{ "adid", adId },
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "device_id", _deviceInfo.DeviceId },
				{ "waterfall_id", waterfallId },
				{ "fb_access_token", fbAccessToken }
			};
			if (username.IsNotEmpty())
			{
				jObject.Add("username", username);
			}
			_facebookAccessToken = fbAccessToken;
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, facebookSignUpUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text2 = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaLoginBaseResponse instaLoginBaseResponse = JsonConvert.DeserializeObject<InstaLoginBaseResponse>(text2);
				if (instaLoginBaseResponse.InvalidCredentials)
				{
					return Result.Fail("Invalid Credentials", (instaLoginBaseResponse.ErrorType == "bad_password") ? InstaLoginResult.BadPassword : InstaLoginResult.InvalidUser);
				}
				if (instaLoginBaseResponse.TwoFactorRequired)
				{
					_twoFactorInfo = instaLoginBaseResponse.TwoFactorLoginInfo;
					_httpRequestProcessor.RequestMessage.Username = _twoFactorInfo.Username;
					_httpRequestProcessor.RequestMessage.DeviceId = _deviceInfo.DeviceId;
					return Result.Fail("Two Factor Authentication is required", InstaLoginResult.TwoFactorRequired);
				}
				if (instaLoginBaseResponse.ErrorType == "checkpoint_challenge_required")
				{
					_challengeinfo = instaLoginBaseResponse.Challenge;
					return Result.Fail("Challenge is required", InstaLoginResult.ChallengeRequired);
				}
				if (instaLoginBaseResponse.ErrorType == "rate_limit_error")
				{
					return Result.Fail("Please wait a few minutes before you try again.", InstaLoginResult.LimitError);
				}
				if (!(instaLoginBaseResponse.ErrorType == "inactive user") && !(instaLoginBaseResponse.ErrorType == "inactive_user"))
				{
					if (instaLoginBaseResponse.ErrorType == "checkpoint_logged_out")
					{
						return Result.Fail(instaLoginBaseResponse.ErrorType + " " + instaLoginBaseResponse.CheckpointUrl, InstaLoginResult.CheckpointLoggedOut);
					}
					return Result.UnExpectedResponse<InstaLoginResult>(response, text2);
				}
				return Result.Fail(instaLoginBaseResponse.Message + "\r\nHelp url: " + instaLoginBaseResponse.HelpUrl, InstaLoginResult.InactiveUser);
			}
			string facebookUserId = string.Empty;
			InstaUserShortResponse instaUserShortResponse = null;
			if (text2.Contains("\"account_created\""))
			{
				InstaFacebookRegistrationResponse instaFacebookRegistrationResponse = JsonConvert.DeserializeObject<InstaFacebookRegistrationResponse>(text2);
				if (instaFacebookRegistrationResponse != null && instaFacebookRegistrationResponse.AccountCreated.HasValue)
				{
					facebookUserId = instaFacebookRegistrationResponse?.FbUserId;
					if (!instaFacebookRegistrationResponse.AccountCreated.Value)
					{
						string desireUsername = instaFacebookRegistrationResponse?.UsernameSuggestionsWithMetadata?.Suggestions?.LastOrDefault()?.Username;
						await Task.Delay(4500);
						await GetFacebookOnboardingStepsAsync();
						await Task.Delay(12000);
						return await LoginWithFacebookAsync(fbAccessToken, cookiesContainer, dryrun: false, desireUsername, waterfallId, adId, newToken: false);
					}
					instaUserShortResponse = JsonConvert.DeserializeObject<InstaFacebookLoginResponse>(text2)?.CreatedUser;
				}
			}
			if (instaUserShortResponse == null)
			{
				InstaFacebookLoginResponse instaFacebookLoginResponse = JsonConvert.DeserializeObject<InstaFacebookLoginResponse>(text2);
				facebookUserId = instaFacebookLoginResponse?.FbUserId;
				instaUserShortResponse = instaFacebookLoginResponse?.LoggedInUser;
			}
			IsUserAuthenticated = true;
			IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(instaUserShortResponse);
			_user.LoggedInUser = userShortConverter.Convert();
			_user.RankToken = $"{_user.LoggedInUser.Pk}_{_httpRequestProcessor.RequestMessage.PhoneId}";
			_user.CsrfToken = csrftoken;
			_user.FacebookUserId = facebookUserId;
			_user.UserName = _user.LoggedInUser.UserName;
			_user.FacebookAccessToken = fbAccessToken;
			_user.Password = "ALAKIMASALAN";
			InvalidateProcessors();
			_user.RankToken = $"{_user.LoggedInUser.Pk}_{_httpRequestProcessor.RequestMessage.PhoneId}";
			UserSessionData user;
			string text3;
			if (string.IsNullOrEmpty(_user.CsrfToken))
			{
				cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				user = _user;
				Cookie? cookie2 = cookies["csrftoken"];
				if (cookie2 != null)
				{
					text3 = cookie2!.Value;
					if (text3 != null)
					{
						goto IL_0840;
					}
				}
				text3 = string.Empty;
				goto IL_0840;
			}
			goto IL_0845;
			IL_0840:
			user.CsrfToken = text3;
			goto IL_0845;
			IL_0845:
			return Result.Success(InstaLoginResult.Success);
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail(exception, InstaLoginResult.Exception, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			LogException(exception2);
			return Result.Fail(exception2, InstaLoginResult.Exception);
		}
	}

	private async Task<IResult<object>> GetFacebookOnboardingStepsAsync()
	{
		try
		{
			Cookie? cookie = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress)["csrftoken"];
			string text;
			if (cookie != null)
			{
				text = cookie!.Value;
				if (text != null)
				{
					goto IL_0060;
				}
			}
			text = string.Empty;
			goto IL_0060;
			IL_0060:
			string text2 = text;
			_user.CsrfToken = text2;
			Dictionary<string, string> data = new Dictionary<string, string>
			{
				{ "fb_connected", "true" },
				{ "seen_steps", "[]" },
				{
					"phone_id",
					_deviceInfo.PhoneGuid.ToString()
				},
				{ "fb_installed", "false" },
				{
					"locale",
					InstaApiConstants.ACCEPT_LANGUAGE.Replace("-", "_")
				},
				{
					"timezone_offset",
					InstaApiConstants.TIMEZONE_OFFSET.ToString()
				},
				{ "_csrftoken", text2 },
				{ "network_type", "WIFI-UNKNOWN" },
				{
					"guid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{
					"_uuid",
					_deviceInfo.DeviceGuid.ToString()
				},
				{ "is_ci", "false" },
				{ "android_id", _deviceInfo.DeviceId },
				{ "reg_flow_taken", "facebook" },
				{ "tos_accepted", "false" }
			};
			Uri onboardingStepsUri = UriCreator.GetOnboardingStepsUri();
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, onboardingStepsUri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string value = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				InstaAccountRegistrationPhoneNumberMessage message = JsonConvert.DeserializeObject<InstaAccountRegistrationPhoneNumber>(value).Message;
				object errMsg;
				if (message == null)
				{
					errMsg = null;
				}
				else
				{
					string[] errors = message.Errors;
					errMsg = ((errors != null) ? errors[0] : null);
				}
				return Result.Fail<InstaRegistrationSuggestionResponse>((string)errMsg, null);
			}
			return Result.Success(JsonConvert.DeserializeObject<InstaRegistrationSuggestionResponse>(value));
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaRegistrationSuggestionResponse>(exception2);
		}
	}

	private async Task<IResult<bool>> AcceptFacebookConsentRequiredAsync(string email, string phone = null)
	{
		try
		{
			TimeSpan delay = TimeSpan.FromSeconds(2.0);
			await Task.Delay((int)delay.TotalMilliseconds);
			Uri instaUri2 = UriCreator.GetConsentNewUserFlowBeginsUri();
			JObject data = new JObject
			{
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "_csrftoken", _user.CsrfToken }
			};
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			HttpResponseMessage response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			string json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			await Task.Delay((int)delay.TotalMilliseconds);
			instaUri2 = UriCreator.GetConsentNewUserFlowUri();
			data = new JObject
			{
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "gdpr_s", "" },
				{ "_csrftoken", _user.CsrfToken },
				{ "guid", _deviceInfo.DeviceGuid },
				{ "device_id", _deviceInfo.DeviceId }
			};
			if (email != null)
			{
				data.Add("email", email);
			}
			else
			{
				if (phone != null && !phone.StartsWith("+"))
				{
					phone = "+" + phone;
				}
				if (phone == null)
				{
					phone = string.Empty;
				}
				data.Add("phone", phone);
			}
			signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			await Task.Delay((int)delay.TotalMilliseconds);
			data = new JObject
			{
				{ "current_screen_key", "age_consent_two_button" },
				{ "phone_id", _deviceInfo.PhoneGuid },
				{ "gdpr_s", "[0,0,0,null]" },
				{ "_csrftoken", _user.CsrfToken },
				{ "updates", "{\"age_consent_state\":\"2\"}" },
				{ "guid", _deviceInfo.DeviceGuid },
				{ "device_id", _deviceInfo.DeviceId }
			};
			signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, instaUri2, _deviceInfo, data);
			response3 = await _httpRequestProcessor.SendAsync(signedRequest);
			json = await response3.Content.ReadAsStringAsync();
			if (response3.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<bool>(response3, json);
			}
			return Result.Success(resValue: true);
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

	public InstaApiVersion GetApiVersionInfo()
	{
		return _apiVersion;
	}

	public string GetUserAgent()
	{
		return _deviceInfo.GenerateUserAgent(_apiVersion);
	}

	public void SetTimeout(TimeSpan timeout)
	{
		HttpClient.Timeout = timeout;
	}

	public void UseHttpClientHandler(HttpClientHandler handler)
	{
		_httpRequestProcessor.SetHttpClientHandler(handler);
	}

	public void SetUser(string username, string password)
	{
		_user.UserName = username;
		_user.Password = password;
		_httpRequestProcessor.RequestMessage.Username = username;
		_httpRequestProcessor.RequestMessage.Password = password;
	}

	public void SetUser(UserSessionData user)
	{
		SetUser(user.UserName, user.Password);
	}

	public AndroidDevice GetCurrentDevice()
	{
		return _deviceInfo;
	}

	public UserSessionData GetLoggedUser()
	{
		return _user;
	}

	public async Task<IResult<InstaCurrentUser>> GetCurrentUserAsync()
	{
		ValidateUser();
		ValidateLoggedIn();
		return await _userProcessor.GetCurrentUserAsync();
	}

	public string GetAcceptLanguage()
	{
		try
		{
			return InstaApiConstants.ACCEPT_LANGUAGE;
		}
		catch (Exception exception)
		{
			return Result.Fail<string>(exception).Value;
		}
	}

	public string GetTimezone()
	{
		return InstaApiConstants.TIMEZONE;
	}

	public int GetTimezoneOffset()
	{
		return InstaApiConstants.TIMEZONE_OFFSET;
	}

	public void SetRequestDelay(IRequestDelay delay)
	{
		if (delay == null)
		{
			delay = RequestDelay.Empty();
		}
		_delay = delay;
		_httpRequestProcessor.Delay = _delay;
	}

	internal IRequestDelay GetRequestDelay()
	{
		return _delay;
	}

	public void SetApiVersion(InstaApiVersionType apiVersion)
	{
		_apiVersionType = apiVersion;
		_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(apiVersion);
		_httpHelper._apiVersion = _apiVersion;
	}

	public void SetDevice(AndroidDevice device)
	{
		IsCustomDeviceSet = false;
		if (device != null)
		{
			_deviceInfo = device;
			IsCustomDeviceSet = true;
		}
	}

	public bool SetAcceptLanguage(string languageCodeAndCountryCode)
	{
		try
		{
			InstaApiConstants.ACCEPT_LANGUAGE = languageCodeAndCountryCode;
			return true;
		}
		catch (Exception exception)
		{
			return Result.Fail<bool>(exception).Value;
		}
	}

	public void SetTimezone(string timezone)
	{
		if (!string.IsNullOrEmpty(timezone))
		{
			InstaApiConstants.TIMEZONE = timezone;
		}
	}

	public void SetTimezoneOffset(int timezoneOffset)
	{
		InstaApiConstants.TIMEZONE_OFFSET = timezoneOffset;
	}

	public async Task<IResult<string>> SendGetRequestAsync(Uri uri)
	{
		try
		{
			if (uri == null)
			{
				return Result.Fail<string>("Uri cannot be null!", null);
			}
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, uri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<string>(response, text);
			}
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
			return Result.Fail<string>(exception2, null);
		}
	}

	public async Task<IResult<string>> SendSignedPostRequestAsync(Uri uri, Dictionary<string, string> data)
	{
		return await SendSignedPostRequest(uri, null, data);
	}

	public async Task<IResult<string>> SendSignedPostRequestAsync(Uri uri, JObject data)
	{
		return await SendSignedPostRequest(uri, data, null);
	}

	private async Task<IResult<string>> SendSignedPostRequest(Uri uri, JObject JData, Dictionary<string, string> DicData)
	{
		try
		{
			if (uri == null)
			{
				return Result.Fail<string>("Uri cannot be null!", null);
			}
			HttpRequestMessage signedRequest;
			if (JData != null)
			{
				JData.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
				JData.Add("_uid", _user.LoggedInUser.Pk.ToString());
				JData.Add("_csrftoken", _user.CsrfToken);
				signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, uri, _deviceInfo, JData);
			}
			else
			{
				DicData.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
				DicData.Add("_uid", _user.LoggedInUser.Pk.ToString());
				DicData.Add("_csrftoken", _user.CsrfToken);
				signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, uri, _deviceInfo, DicData);
			}
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<string>(response, text);
			}
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
			return Result.Fail<string>(exception2, null);
		}
	}

	public async Task<IResult<string>> SendPostRequestAsync(Uri uri, Dictionary<string, string> data)
	{
		try
		{
			if (uri == null)
			{
				return Result.Fail<string>("Uri cannot be null!", null);
			}
			data.Add("_uuid", _deviceInfo.DeviceGuid.ToString());
			data.Add("_uid", _user.LoggedInUser.Pk.ToString());
			data.Add("_csrftoken", _user.CsrfToken);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Post, uri, _deviceInfo, data);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<string>(response, text);
			}
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
			return Result.Fail<string>(exception2, null);
		}
	}

	public Stream GetStateDataAsStream()
	{
		CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(new Uri("https://i.instagram.com"));
		List<Cookie> list = new List<Cookie>();
		foreach (Cookie item in cookies)
		{
			list.Add(item);
		}
		return SerializationHelper.SerializeToStream(new StateData
		{
			DeviceInfo = _deviceInfo,
			IsAuthenticated = IsUserAuthenticated,
			UserSession = _user,
			Cookies = _httpRequestProcessor.HttpHandler.CookieContainer,
			RawCookies = list,
			InstaApiVersion = _apiVersionType
		});
	}

	public string GetStateDataAsString()
	{
		CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(new Uri("https://i.instagram.com"));
		List<Cookie> list = new List<Cookie>();
		foreach (Cookie item in cookies)
		{
			list.Add(item);
		}
		return SerializationHelper.SerializeToString(new StateData
		{
			DeviceInfo = _deviceInfo,
			IsAuthenticated = IsUserAuthenticated,
			UserSession = _user,
			Cookies = _httpRequestProcessor.HttpHandler.CookieContainer,
			RawCookies = list,
			InstaApiVersion = _apiVersionType
		});
	}

	public StateData GetStateDataAsObject()
	{
		CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(new Uri("https://i.instagram.com"));
		List<Cookie> list = new List<Cookie>();
		foreach (Cookie item in cookies)
		{
			list.Add(item);
		}
		return new StateData
		{
			DeviceInfo = _deviceInfo,
			IsAuthenticated = IsUserAuthenticated,
			UserSession = _user,
			Cookies = _httpRequestProcessor.HttpHandler.CookieContainer,
			RawCookies = list,
			InstaApiVersion = _apiVersionType
		};
	}

	public async Task<Stream> GetStateDataAsStreamAsync()
	{
		return await Task<Stream>.Factory.StartNew(delegate
		{
			Stream stateDataAsStream = GetStateDataAsStream();
			Task.Delay(1000);
			return stateDataAsStream;
		});
	}

	public async Task<string> GetStateDataAsStringAsync()
	{
		return await Task<string>.Factory.StartNew(delegate
		{
			string stateDataAsString = GetStateDataAsString();
			Task.Delay(1000);
			return stateDataAsString;
		});
	}

	public void LoadStateDataFromStream(Stream stream)
	{
		StateData stateData = SerializationHelper.DeserializeFromStream<StateData>(stream);
		if (!IsCustomDeviceSet)
		{
			_deviceInfo = stateData.DeviceInfo;
		}
		_user = stateData.UserSession;
		_httpRequestProcessor.RequestMessage.Username = stateData.UserSession.UserName;
		_httpRequestProcessor.RequestMessage.Password = stateData.UserSession.Password;
		_httpRequestProcessor.RequestMessage.DeviceId = stateData.DeviceInfo.DeviceId;
		_httpRequestProcessor.RequestMessage.PhoneId = stateData.DeviceInfo.PhoneGuid.ToString();
		_httpRequestProcessor.RequestMessage.Guid = stateData.DeviceInfo.DeviceGuid;
		_httpRequestProcessor.RequestMessage.AdId = stateData.DeviceInfo.AdId.ToString();
		foreach (Cookie rawCookie in stateData.RawCookies)
		{
			_httpRequestProcessor.HttpHandler.CookieContainer.Add(new Uri("https://i.instagram.com"), rawCookie);
		}
		if (!stateData.InstaApiVersion.HasValue)
		{
			stateData.InstaApiVersion = InstaApiVersionType.Version86;
		}
		_apiVersionType = stateData.InstaApiVersion.Value;
		_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(_apiVersionType);
		_httpHelper = new HttpHelper(_apiVersion);
		IsUserAuthenticated = stateData.IsAuthenticated;
		InvalidateProcessors();
	}

	public void LoadStateDataFromString(string json)
	{
		StateData stateData = SerializationHelper.DeserializeFromString<StateData>(json);
		if (!IsCustomDeviceSet)
		{
			_deviceInfo = stateData.DeviceInfo;
		}
		_user = stateData.UserSession;
		_httpRequestProcessor.RequestMessage.Username = stateData.UserSession.UserName;
		_httpRequestProcessor.RequestMessage.Password = stateData.UserSession.Password;
		_httpRequestProcessor.RequestMessage.DeviceId = stateData.DeviceInfo.DeviceId;
		_httpRequestProcessor.RequestMessage.PhoneId = stateData.DeviceInfo.PhoneGuid.ToString();
		_httpRequestProcessor.RequestMessage.Guid = stateData.DeviceInfo.DeviceGuid;
		_httpRequestProcessor.RequestMessage.AdId = stateData.DeviceInfo.AdId.ToString();
		foreach (Cookie rawCookie in stateData.RawCookies)
		{
			_httpRequestProcessor.HttpHandler.CookieContainer.Add(new Uri("https://i.instagram.com"), rawCookie);
		}
		if (!stateData.InstaApiVersion.HasValue)
		{
			stateData.InstaApiVersion = InstaApiVersionType.Version86;
		}
		_apiVersionType = stateData.InstaApiVersion.Value;
		_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(_apiVersionType);
		_httpHelper = new HttpHelper(_apiVersion);
		IsUserAuthenticated = stateData.IsAuthenticated;
		InvalidateProcessors();
	}

	public void LoadStateDataFromObject(StateData stateData)
	{
		if (!IsCustomDeviceSet)
		{
			_deviceInfo = stateData.DeviceInfo;
		}
		_user = stateData.UserSession;
		_httpRequestProcessor.RequestMessage.Username = stateData.UserSession.UserName;
		_httpRequestProcessor.RequestMessage.Password = stateData.UserSession.Password;
		_httpRequestProcessor.RequestMessage.DeviceId = stateData.DeviceInfo.DeviceId;
		_httpRequestProcessor.RequestMessage.PhoneId = stateData.DeviceInfo.PhoneGuid.ToString();
		_httpRequestProcessor.RequestMessage.Guid = stateData.DeviceInfo.DeviceGuid;
		_httpRequestProcessor.RequestMessage.AdId = stateData.DeviceInfo.AdId.ToString();
		foreach (Cookie rawCookie in stateData.RawCookies)
		{
			_httpRequestProcessor.HttpHandler.CookieContainer.Add(new Uri("https://i.instagram.com"), rawCookie);
		}
		if (!stateData.InstaApiVersion.HasValue)
		{
			stateData.InstaApiVersion = InstaApiVersionType.Version86;
		}
		_apiVersionType = stateData.InstaApiVersion.Value;
		_apiVersion = InstaApiVersionList.GetApiVersionList().GetApiVersion(_apiVersionType);
		_httpHelper = new HttpHelper(_apiVersion);
		IsUserAuthenticated = stateData.IsAuthenticated;
		InvalidateProcessors();
	}

	public async Task LoadStateDataFromStreamAsync(Stream stream)
	{
		await Task.Factory.StartNew(delegate
		{
			LoadStateDataFromStream(stream);
			Task.Delay(1000);
		});
	}

	public async Task LoadStateDataFromStringAsync(string json)
	{
		await Task.Factory.StartNew(delegate
		{
			LoadStateDataFromString(json);
			Task.Delay(1000);
		});
	}

	private void InvalidateProcessors()
	{
		_hashtagProcessor = new HashtagProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_locationProcessor = new LocationProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_collectionProcessor = new CollectionProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_mediaProcessor = new MediaProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_userProcessor = new UserProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_storyProcessor = new StoryProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_commentProcessor = new CommentProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_messagingProcessor = new MessagingProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_feedProcessor = new FeedProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_liveProcessor = new LiveProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_discoverProcessor = new DiscoverProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_accountProcessor = new AccountProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_helperProcessor = new HelperProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_tvProcessor = new TVProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_businessProcessor = new BusinessProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_shoppingProcessor = new ShoppingProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
		_webProcessor = new WebProcessor(_deviceInfo, _user, _httpRequestProcessor, _logger, _userAuthValidate, this, _httpHelper);
	}

	private void ValidateUserAsync(InstaUserShortResponse user, string csrfToken, bool validateExtra = true, string password = null)
	{
		try
		{
			IObjectConverter<InstaUserShort, InstaUserShortResponse> userShortConverter = ConvertersFabric.Instance.GetUserShortConverter(user);
			_user.LoggedInUser = userShortConverter.Convert();
			if (password != null)
			{
				_user.Password = password;
			}
			_user.UserName = _user.UserName;
			if (!validateExtra)
			{
				return;
			}
			_user.RankToken = $"{_user.LoggedInUser.Pk}_{_httpRequestProcessor.RequestMessage.PhoneId}";
			_user.CsrfToken = csrfToken;
			UserSessionData user2;
			object obj;
			if (string.IsNullOrEmpty(_user.CsrfToken))
			{
				CookieCollection cookies = _httpRequestProcessor.HttpHandler.CookieContainer.GetCookies(_httpRequestProcessor.Client.BaseAddress);
				user2 = _user;
				Cookie? cookie = cookies["csrftoken"];
				if (cookie == null)
				{
					obj = null;
				}
				else
				{
					obj = cookie!.Value;
					if (obj != null)
					{
						goto IL_00ee;
					}
				}
				obj = string.Empty;
				goto IL_00ee;
			}
			goto IL_00f3;
			IL_00f3:
			IsUserAuthenticated = true;
			InvalidateProcessors();
			return;
			IL_00ee:
			user2.CsrfToken = (string)obj;
			goto IL_00f3;
		}
		catch
		{
		}
	}

	private void ValidateUser()
	{
		if (string.IsNullOrEmpty(_user.UserName) || string.IsNullOrEmpty(_user.Password))
		{
			throw new ArgumentException("user name and password must be specified");
		}
	}

	private void ValidateLoggedIn()
	{
		if (!IsUserAuthenticated)
		{
			throw new ArgumentException("user must be authenticated");
		}
	}

	private void ValidateRequestMessage()
	{
		if (_httpRequestProcessor.RequestMessage == null || _httpRequestProcessor.RequestMessage.IsEmpty())
		{
			throw new ArgumentException("API request message null or empty");
		}
	}

	private void LogException(Exception exception)
	{
		_logger?.LogException(exception);
	}
}
