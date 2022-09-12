using System;
using System.Net.Http;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Logger;

namespace InstagramApiSharp.API.Builder;

public class InstaApiBuilder : IInstaApiBuilder
{
	private IRequestDelay _delay = RequestDelay.Empty();

	private AndroidDevice _device;

	private HttpClient _httpClient;

	private HttpClientHandler _httpHandler = new HttpClientHandler();

	private IHttpRequestProcessor _httpRequestProcessor;

	private IInstaLogger _logger;

	private ApiRequestMessage _requestMessage;

	private UserSessionData _user;

	private InstaApiVersionType? _apiVersionType;

	private ISessionHandler _sessionHandler;

	private InstaApiBuilder()
	{
	}

	public IInstaApi Build()
	{
		if (_user == null)
		{
			_user = UserSessionData.Empty;
		}
		if (_httpHandler == null)
		{
			_httpHandler = new HttpClientHandler();
		}
		if (_httpClient == null)
		{
			_httpClient = new HttpClient(_httpHandler)
			{
				BaseAddress = new Uri("https://i.instagram.com")
			};
		}
		if (_requestMessage == null)
		{
			if (_device == null)
			{
				_device = AndroidDeviceGenerator.GetRandomAndroidDevice();
			}
			_requestMessage = new ApiRequestMessage
			{
				PhoneId = _device.PhoneGuid.ToString(),
				Guid = _device.DeviceGuid,
				Password = _user?.Password,
				Username = _user?.UserName,
				DeviceId = ApiRequestMessage.GenerateDeviceId(),
				AdId = _device.AdId.ToString()
			};
		}
		if (string.IsNullOrEmpty(_requestMessage.Password))
		{
			_requestMessage.Password = _user?.Password;
		}
		if (string.IsNullOrEmpty(_requestMessage.Username))
		{
			_requestMessage.Username = _user?.UserName;
		}
		try
		{
			InstaApiConstants.TIMEZONE_OFFSET = int.Parse(DateTimeOffset.Now.Offset.TotalSeconds.ToString());
		}
		catch
		{
		}
		if (_httpRequestProcessor == null)
		{
			_httpRequestProcessor = new HttpRequestProcessor(_delay, _httpClient, _httpHandler, _requestMessage, _logger);
		}
		if (!_apiVersionType.HasValue)
		{
			_apiVersionType = InstaApiVersionType.Version86;
		}
		InstaApi instaApi = new InstaApi(_user, _logger, _device, _httpRequestProcessor, _apiVersionType.Value);
		if (_sessionHandler != null)
		{
			_sessionHandler.InstaApi = instaApi;
			instaApi.SessionHandler = _sessionHandler;
		}
		return instaApi;
	}

	public IInstaApiBuilder UseLogger(IInstaLogger logger)
	{
		_logger = logger;
		return this;
	}

	public IInstaApiBuilder UseHttpClient(HttpClient httpClient)
	{
		_httpClient = httpClient;
		return this;
	}

	public IInstaApiBuilder UseHttpClientHandler(HttpClientHandler handler)
	{
		_httpHandler = handler;
		return this;
	}

	public IInstaApiBuilder SetUser(UserSessionData user)
	{
		_user = user;
		return this;
	}

	public IInstaApiBuilder SetApiRequestMessage(ApiRequestMessage requestMessage)
	{
		_requestMessage = requestMessage;
		return this;
	}

	public IInstaApiBuilder SetRequestDelay(IRequestDelay delay)
	{
		if (delay == null)
		{
			delay = RequestDelay.Empty();
		}
		_delay = delay;
		return this;
	}

	public IInstaApiBuilder SetDevice(AndroidDevice androidDevice)
	{
		_device = androidDevice;
		return this;
	}

	public IInstaApiBuilder SetApiVersion(InstaApiVersionType apiVersion)
	{
		_apiVersionType = apiVersion;
		return this;
	}

	public IInstaApiBuilder SetSessionHandler(ISessionHandler sessionHandler)
	{
		_sessionHandler = sessionHandler;
		return this;
	}

	public IInstaApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor)
	{
		_httpRequestProcessor = httpRequestProcessor;
		return this;
	}

	public static IInstaApiBuilder CreateBuilder()
	{
		return new InstaApiBuilder();
	}
}
