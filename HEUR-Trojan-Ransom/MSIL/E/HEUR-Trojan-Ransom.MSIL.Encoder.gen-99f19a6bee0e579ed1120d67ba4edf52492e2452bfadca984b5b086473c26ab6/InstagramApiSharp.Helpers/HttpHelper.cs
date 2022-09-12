using System;
using System.Collections.Generic;
using System.Net.Http;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Versions;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Helpers;

internal class HttpHelper
{
	public InstaApiVersion _apiVersion;

	internal HttpHelper(InstaApiVersion apiVersionType)
	{
		_apiVersion = apiVersionType;
	}

	public HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo)
	{
		string value = deviceInfo.GenerateUserAgent(_apiVersion);
		return new HttpRequestMessage(method, uri)
		{
			Headers = 
			{
				{
					"Accept-Language",
					InstaApiConstants.ACCEPT_LANGUAGE
				},
				{ "X-IG-Capabilities", _apiVersion.Capabilities },
				{ "X-IG-Connection-Type", "WIFI" },
				{ "User-Agent", value },
				{ "X-IG-App-ID", "567067343352427" }
			},
			Properties = 
			{
				new KeyValuePair<string, object>("X-Google-AD-ID", deviceInfo.GoogleAdId.ToString())
			}
		};
	}

	public HttpRequestMessage GetDefaultRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo, Dictionary<string, string> data)
	{
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
		defaultRequest.Content = new FormUrlEncodedContent(data);
		return defaultRequest;
	}

	public HttpRequestMessage GetWebRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo)
	{
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Get, uri, deviceInfo);
		defaultRequest.Headers.Remove("User-Agent");
		defaultRequest.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.102 Safari/537.36 OPR/57.0.3098.116");
		return defaultRequest;
	}

	public HttpRequestMessage GetSignedRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo, Dictionary<string, string> data)
	{
		string text = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, JsonConvert.SerializeObject(data));
		string text2 = JsonConvert.SerializeObject(data);
		string value = text + "." + text2;
		Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
		{
			{ "signed_body", value },
			{ "ig_sig_key_version", "4" }
		};
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
		defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
		defaultRequest.Properties.Add("signed_body", value);
		defaultRequest.Properties.Add("ig_sig_key_version", "4");
		return defaultRequest;
	}

	public HttpRequestMessage GetSignedRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo, Dictionary<string, int> data)
	{
		string text = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, JsonConvert.SerializeObject(data));
		string text2 = JsonConvert.SerializeObject(data);
		string value = text + "." + text2;
		Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
		{
			{ "signed_body", value },
			{ "ig_sig_key_version", "4" }
		};
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
		defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
		defaultRequest.Properties.Add("signed_body", value);
		defaultRequest.Properties.Add("ig_sig_key_version", "4");
		return defaultRequest;
	}

	public HttpRequestMessage GetSignedRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo, Dictionary<string, object> data)
	{
		string text = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, JsonConvert.SerializeObject(data));
		string text2 = JsonConvert.SerializeObject(data);
		string value = text + "." + text2;
		Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
		{
			{ "signed_body", value },
			{ "ig_sig_key_version", "4" }
		};
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
		defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
		defaultRequest.Properties.Add("signed_body", value);
		defaultRequest.Properties.Add("ig_sig_key_version", "4");
		return defaultRequest;
	}

	public HttpRequestMessage GetSignedRequest(HttpMethod method, Uri uri, AndroidDevice deviceInfo, JObject data)
	{
		string text = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, data.ToString(Formatting.None));
		string text2 = data.ToString(Formatting.None);
		string value = text + "." + text2;
		Dictionary<string, string> nameValueCollection = new Dictionary<string, string>
		{
			{ "signed_body", value },
			{ "ig_sig_key_version", "4" }
		};
		HttpRequestMessage defaultRequest = GetDefaultRequest(HttpMethod.Post, uri, deviceInfo);
		defaultRequest.Content = new FormUrlEncodedContent(nameValueCollection);
		defaultRequest.Properties.Add("signed_body", value);
		defaultRequest.Properties.Add("ig_sig_key_version", "4");
		return defaultRequest;
	}

	public string GetSignature(JObject data)
	{
		string text = CryptoHelper.CalculateHash(_apiVersion.SignatureKey, data.ToString(Formatting.None));
		string text2 = data.ToString(Formatting.None);
		return text + "." + text2;
	}
}
