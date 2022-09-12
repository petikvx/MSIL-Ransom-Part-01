using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SteamAuth;

public class SteamWeb
{
	public static string MobileLoginRequest(string url, string method, NameValueCollection data = null, CookieContainer cookies = null, NameValueCollection headers = null)
	{
		return Request(url, method, data, cookies, headers, "https://steamcommunity.com/mobilelogin?oauth_client_id=DE45CD61&oauth_scope=read_profile%20write_profile%20read_client%20write_client");
	}

	public static string Request(string url, string method, NameValueCollection data = null, CookieContainer cookies = null, NameValueCollection headers = null, string referer = "https://steamcommunity.com")
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.data = data;
		string text = ((CS_0024_003C_003E8__locals0.data == null) ? string.Empty : string.Join("&", Array.ConvertAll(CS_0024_003C_003E8__locals0.data.AllKeys, (string key) => $"{WebUtility.UrlEncode(key)}={WebUtility.UrlEncode(CS_0024_003C_003E8__locals0.data[key])}")));
		if (method == "GET")
		{
			url = url + (url.Contains("?") ? "&" : "?") + text;
		}
		return Request(url, method, text, cookies, headers, referer);
	}

	public static string Request(string url, string method, string dataString = null, CookieContainer cookies = null, NameValueCollection headers = null, string referer = "https://steamcommunity.com")
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.Method = method;
		httpWebRequest.Accept = "text/javascript, text/html, application/xml, text/xml, */*";
		httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; U; Android 4.1.1; en-us; Google Nexus 4 - 4.1.1 - API 16 - 768x1280 Build/JRO03S) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30";
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Referer = referer;
		if (headers != null)
		{
			httpWebRequest.Headers.Add(headers);
		}
		if (cookies != null)
		{
			httpWebRequest.CookieContainer = cookies;
		}
		if (method == "POST")
		{
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.ContentLength = dataString.Length;
			StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
			streamWriter.Write(dataString);
			streamWriter.Close();
		}
		try
		{
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				return streamReader.ReadToEnd();
			}
			smethod_0(httpWebResponse, url);
			return null;
		}
		catch (WebException ex)
		{
			smethod_0(ex.Response as HttpWebResponse, url);
			return null;
		}
	}

	public static async Task<string> RequestAsync(string url, string method, NameValueCollection data = null, CookieContainer cookies = null, NameValueCollection headers = null, string referer = "https://steamcommunity.com")
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0.data = data;
		string text = ((CS_0024_003C_003E8__locals0.data == null) ? string.Empty : string.Join("&", Array.ConvertAll(CS_0024_003C_003E8__locals0.data.AllKeys, (string key) => $"{WebUtility.UrlEncode(key)}={WebUtility.UrlEncode(CS_0024_003C_003E8__locals0.data[key])}")));
		if (method == "GET")
		{
			url = url + (url.Contains("?") ? "&" : "?") + text;
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.Method = method;
		httpWebRequest.Accept = "text/javascript, text/html, application/xml, text/xml, */*";
		httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; U; Android 4.1.1; en-us; Google Nexus 4 - 4.1.1 - API 16 - 768x1280 Build/JRO03S) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30";
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		httpWebRequest.Referer = referer;
		if (headers != null)
		{
			httpWebRequest.Headers.Add(headers);
		}
		if (cookies != null)
		{
			httpWebRequest.CookieContainer = cookies;
		}
		if (method == "POST")
		{
			httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
			httpWebRequest.ContentLength = text.Length;
			StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
			streamWriter.Write(text);
			streamWriter.Close();
		}
		try
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)(await httpWebRequest.GetResponseAsync());
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				using StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				return streamReader.ReadToEnd();
			}
			smethod_0(httpWebResponse, url);
			return null;
		}
		catch (WebException ex)
		{
			smethod_0(ex.Response as HttpWebResponse, url);
			return null;
		}
	}

	private static void smethod_0(object object_0, string string_0)
	{
		if (object_0 != null && ((HttpWebResponse)object_0).StatusCode == HttpStatusCode.Found)
		{
			string text = ((WebResponse)object_0).Headers.Get("Location");
			if (!string.IsNullOrEmpty(text) && text == "steammobile://lostauth" && string_0 == APIEndpoints.MOBILEAUTH_GETWGTOKEN)
			{
				throw new SteamGuardAccount.WGTokenExpiredException();
			}
		}
	}

	public SteamWeb()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
