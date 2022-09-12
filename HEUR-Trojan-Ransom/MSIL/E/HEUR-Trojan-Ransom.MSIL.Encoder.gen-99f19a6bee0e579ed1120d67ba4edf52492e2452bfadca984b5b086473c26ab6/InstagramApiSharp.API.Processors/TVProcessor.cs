using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;
using InstagramApiSharp.Converters;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using InstagramApiSharp.Logger;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.API.Processors;

internal class TVProcessor : ITVProcessor
{
	private readonly AndroidDevice _deviceInfo;

	private readonly HttpHelper _httpHelper;

	private readonly IHttpRequestProcessor _httpRequestProcessor;

	private readonly InstaApi _instaApi;

	private readonly IInstaLogger _logger;

	private readonly UserSessionData _user;

	private readonly UserAuthValidate _userAuthValidate;

	public TVProcessor(AndroidDevice deviceInfo, UserSessionData user, IHttpRequestProcessor httpRequestProcessor, IInstaLogger logger, UserAuthValidate userAuthValidate, InstaApi instaApi, HttpHelper httpHelper)
	{
		_deviceInfo = deviceInfo;
		_user = user;
		_httpRequestProcessor = httpRequestProcessor;
		_logger = logger;
		_userAuthValidate = userAuthValidate;
		_instaApi = instaApi;
		_httpHelper = httpHelper;
	}

	public async Task<IResult<InstaTVChannel>> GetChannelByIdAsync(long userId, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await GetChannel(null, userId, paginationParameters);
	}

	public async Task<IResult<InstaTVChannel>> GetChannelByTypeAsync(InstaTVChannelType channelType, PaginationParameters paginationParameters)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await GetChannel(channelType, null, paginationParameters);
	}

	public async Task<IResult<InstaTVSearch>> GetSuggestedSearchesAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri iGTVSuggestedSearchesUri = UriCreator.GetIGTVSuggestedSearchesUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, iGTVSuggestedSearchesUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTVSearch>(response, text);
			}
			InstaTVSearchResponse response2 = JsonConvert.DeserializeObject<InstaTVSearchResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetTVSearchConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTVSearch>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTVSearch>(exception2);
		}
	}

	public async Task<IResult<InstaTV>> GetTVGuideAsync()
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri iGTVGuideUri = UriCreator.GetIGTVGuideUri();
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, iGTVGuideUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTV>(response, text);
			}
			InstaTVResponse response2 = JsonConvert.DeserializeObject<InstaTVResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetTVConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTV>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTV>(exception2);
		}
	}

	public async Task<IResult<InstaTVSearch>> SearchAsync(string query)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		try
		{
			Uri iGTVSearchUri = UriCreator.GetIGTVSearchUri(query);
			HttpRequestMessage defaultRequest = _httpHelper.GetDefaultRequest(HttpMethod.Get, iGTVSearchUri, _deviceInfo);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(defaultRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTVSearch>(response, text);
			}
			InstaTVSearchResponse response2 = JsonConvert.DeserializeObject<InstaTVSearchResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetTVSearchConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTVSearch>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTVSearch>(exception2);
		}
	}

	public async Task<IResult<InstaMedia>> UploadVideoAsync(InstaVideoUpload video, string title, string caption)
	{
		return await UploadVideoAsync(null, video, title, caption);
	}

	public async Task<IResult<InstaMedia>> UploadVideoAsync(Action<InstaUploaderProgress> progress, InstaVideoUpload video, string title, string caption)
	{
		UserAuthValidator.Validate(_userAuthValidate);
		return await _instaApi.HelperProcessor.SendIGTVVideoAsync(progress, video, title, caption);
	}

	private async Task<IResult<InstaTVChannel>> GetChannel(InstaTVChannelType? channelType, long? userId, PaginationParameters paginationParameters)
	{
		try
		{
			Uri iGTVChannelUri = UriCreator.GetIGTVChannelUri();
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
			if (channelType.HasValue)
			{
				jObject.Add("id", channelType.Value.GetRealChannelType());
			}
			else
			{
				jObject.Add("id", $"user_{userId}");
			}
			if (paginationParameters != null && !string.IsNullOrEmpty(paginationParameters.NextMaxId))
			{
				jObject.Add("max_id", paginationParameters.NextMaxId);
			}
			HttpRequestMessage signedRequest = _httpHelper.GetSignedRequest(HttpMethod.Post, iGTVChannelUri, _deviceInfo, jObject);
			HttpResponseMessage response = await _httpRequestProcessor.SendAsync(signedRequest);
			string text = await response.Content.ReadAsStringAsync();
			if (response.StatusCode != HttpStatusCode.OK)
			{
				return Result.UnExpectedResponse<InstaTVChannel>(response, text);
			}
			InstaTVChannelResponse response2 = JsonConvert.DeserializeObject<InstaTVChannelResponse>(text);
			return Result.Success(ConvertersFabric.Instance.GetTVChannelConverter(response2).Convert());
		}
		catch (HttpRequestException exception)
		{
			_logger?.LogException(exception);
			return Result.Fail<InstaTVChannel>(exception, null, ResponseType.NetworkProblem);
		}
		catch (Exception exception2)
		{
			_logger?.LogException(exception2);
			return Result.Fail<InstaTVChannel>(exception2);
		}
	}
}
