using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp.Helpers;

public class InstaFbHelper
{
	public static readonly Uri FacebookMobileAddress = new Uri("https://m.facebook.com/");

	public static readonly Uri FacebookAddress = new Uri("https://facebook.com/");

	public static readonly Uri FacebookAddressWithWWWAddress = new Uri("https://www.facebook.com/");

	public static Uri GetFacebookLoginUri()
	{
		try
		{
			JObject jObject = new JObject { 
			{
				"init",
				DateTime.UtcNow.ToUnixTimeMiliSeconds()
			} };
			if (Uri.TryCreate($"https://m.facebook.com/v2.3/dialog/oauth?access_token=&client_id=124024574287414&e2e={jObject.ToString(Formatting.None)}&scope=email&default_audience=friends&redirect_uri=fbconnect://success&display=touch&response_type=token,signed_request&return_scopes=true", UriKind.RelativeOrAbsolute, out var result))
			{
				return result;
			}
		}
		catch
		{
		}
		return null;
	}

	public static string GetFacebookUserAgent()
	{
		return "Mozilla/5.0 (Linux; Android 7.0; PRA-LA1 Build/HONORPRA-LA1; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/69.0.3497.100 Mobile Safari/537.36";
	}

	public static bool IsLoggedIn(string html)
	{
		if (!html.Contains("window.location.href=\"fbconnect://success#"))
		{
			return html.Contains("window.location.href=\"fbconnect:\\/\\/success");
		}
		return true;
	}

	public static string GetAccessToken(string html)
	{
		try
		{
			string text = "type=\"text/javascript\">window.location.href=\"fbconnect:\\/\\/success";
			string value = "</script>";
			if (html.Contains(text))
			{
				string text2 = html.Substring(html.IndexOf(text) + text.Length);
				text2 = text2.Substring(0, text2.IndexOf(value));
				text = "&access_token=";
				value = "&";
				string text3 = text2.Substring(text2.IndexOf(text) + text.Length);
				return text3.Substring(0, text3.IndexOf(value));
			}
		}
		catch
		{
		}
		return null;
	}
}
