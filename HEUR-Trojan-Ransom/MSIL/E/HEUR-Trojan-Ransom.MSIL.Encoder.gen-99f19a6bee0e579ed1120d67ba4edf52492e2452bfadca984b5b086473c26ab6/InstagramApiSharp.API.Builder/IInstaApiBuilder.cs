using System;
using System.Net.Http;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Logger;

namespace InstagramApiSharp.API.Builder;

public interface IInstaApiBuilder
{
	IInstaApi Build();

	IInstaApiBuilder UseLogger(IInstaLogger logger);

	IInstaApiBuilder UseHttpClient(HttpClient httpClient);

	IInstaApiBuilder UseHttpClientHandler(HttpClientHandler handler);

	IInstaApiBuilder SetUser(UserSessionData user);

	IInstaApiBuilder SetApiRequestMessage(ApiRequestMessage requestMessage);

	IInstaApiBuilder SetRequestDelay(IRequestDelay delay);

	[Obsolete("Deprecated. Please use IInstaApi.SetDevice instead.")]
	IInstaApiBuilder SetDevice(AndroidDevice androidDevice);

	[Obsolete("Deprecated. Please use IInstaApi.SetApiVersion instead.")]
	IInstaApiBuilder SetApiVersion(InstaApiVersionType apiVersion);

	IInstaApiBuilder SetHttpRequestProcessor(IHttpRequestProcessor httpRequestProcessor);

	IInstaApiBuilder SetSessionHandler(ISessionHandler sessionHandler);
}
