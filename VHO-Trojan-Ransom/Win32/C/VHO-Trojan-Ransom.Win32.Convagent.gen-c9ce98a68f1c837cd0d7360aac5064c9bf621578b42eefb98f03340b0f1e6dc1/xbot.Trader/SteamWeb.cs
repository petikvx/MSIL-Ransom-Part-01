using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;
using Newtonsoft.Json;

namespace xbot.Trader;

public class SteamWeb
{
	public const string SteamCommunityDomain = "steamcommunity.com";

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	private string string_3;

	private CookieContainer cookieContainer_0;

	public string Token
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public string SessionId
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	public string TokenSecure
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		private set
		{
			string_2 = value;
		}
	}

	public string AcceptLanguageHeader
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
		}
	}

	public string Fetch(string url, string method, NameValueCollection data = null, bool ajax = true, string referer = "", bool fetchError = false)
	{
		using HttpWebResponse httpWebResponse = Request(url, method, data, ajax, referer, fetchError);
		using Stream stream = httpWebResponse.GetResponseStream();
		if (stream != null)
		{
			using (StreamReader streamReader = new StreamReader(stream))
			{
				return streamReader.ReadToEnd();
			}
		}
		return "";
	}

	public HttpWebResponse Request(string url, string method, NameValueCollection data = null, bool ajax = true, string referer = "", bool fetchError = false)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.data = data;
		bool num = method.ToLower() == "get";
		string text = ((CS_0024_003C_003E8__locals0.data == null) ? null : string.Join("&", Array.ConvertAll(CS_0024_003C_003E8__locals0.data.AllKeys, (string key) => $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(CS_0024_003C_003E8__locals0.data[key])}")));
		if (num && !string.IsNullOrEmpty(text))
		{
			url = url + (url.Contains("?") ? "&" : "?") + text;
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
		httpWebRequest.Method = method;
		httpWebRequest.Accept = "application/json, text/javascript;q=0.9, */*;q=0.5";
		httpWebRequest.Headers[HttpRequestHeader.AcceptLanguage] = AcceptLanguageHeader;
		httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
		httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
		httpWebRequest.Referer = (string.IsNullOrEmpty(referer) ? "http://steamcommunity.com/trade/1" : referer);
		httpWebRequest.Timeout = 50000;
		httpWebRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Revalidate);
		httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
		if (ajax)
		{
			httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
			httpWebRequest.Headers.Add("X-Prototype-Version", "1.7");
		}
		httpWebRequest.CookieContainer = cookieContainer_0;
		if (!num && !string.IsNullOrEmpty(text))
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			httpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = httpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			try
			{
				return httpWebRequest.GetResponse() as HttpWebResponse;
			}
			catch (WebException ex)
			{
				if (!fetchError || !(ex.Response is HttpWebResponse result))
				{
					throw;
				}
				return result;
			}
		}
		return httpWebRequest.GetResponse() as HttpWebResponse;
	}

	public bool DoLogin(string username, string password)
	{
		NameValueCollection data = new NameValueCollection { { "username", username } };
		GetRsaKey getRsaKey = JsonConvert.DeserializeObject<GetRsaKey>(Fetch("https://steamcommunity.com/login/getrsakey", "POST", data, ajax: false));
		if (!getRsaKey.success)
		{
			return false;
		}
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		RSAParameters parameters = new RSAParameters
		{
			Exponent = method_0(getRsaKey.publickey_exp),
			Modulus = method_0(getRsaKey.publickey_mod)
		};
		rSACryptoServiceProvider.ImportParameters(parameters);
		byte[] bytes = Encoding.ASCII.GetBytes(password);
		string value = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false));
		SteamResult steamResult = null;
		string value2 = "";
		string value3 = "";
		CookieCollection cookies;
		do
		{
			Console.WriteLine("SteamWeb: Logging In...");
			bool flag = steamResult?.captcha_needed ?? false;
			bool num = steamResult?.emailauth_needed ?? false;
			string value4 = Uri.EscapeDataString(getRsaKey.timestamp);
			string text = string.Empty;
			if (steamResult != null && steamResult.captcha_gid != null)
			{
				text = Uri.EscapeDataString(steamResult.captcha_gid);
			}
			data = new NameValueCollection
			{
				{ "password", value },
				{ "username", username }
			};
			string text2 = "";
			if (flag)
			{
				Console.WriteLine("SteamWeb: Captcha is needed.");
				Process.Start("https://steamcommunity.com/public/captcha.php?gid=" + steamResult.captcha_gid);
				Console.WriteLine("SteamWeb: Type the captcha:");
				string text3 = Console.ReadLine();
				if (!string.IsNullOrEmpty(text3))
				{
					text2 = Uri.EscapeDataString(text3);
				}
			}
			data.Add("captchagid", flag ? text : "");
			data.Add("captcha_text", flag ? text2 : "");
			data.Add("twofactorcode", "");
			data.Add("remember_login", "false");
			if (num)
			{
				Console.WriteLine("SteamWeb: SteamGuard is needed.");
				Console.WriteLine("SteamWeb: Type the code:");
				string text4 = Console.ReadLine();
				if (!string.IsNullOrEmpty(text4))
				{
					value2 = Uri.EscapeDataString(text4);
				}
				value3 = steamResult.emailsteamid;
				Console.WriteLine("SteamWeb: Type your machine name:");
				text4 = Console.ReadLine();
				string text5 = (string.IsNullOrEmpty(text4) ? "" : Uri.EscapeDataString(text4));
				data.Add("loginfriendlyname", (text5 != "") ? text5 : "defaultSteamBotMachine");
			}
			data.Add("emailauth", value2);
			data.Add("emailsteamid", value3);
			int num2 = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
			data.Add("donotcache", num2 + "000");
			data.Add("rsatimestamp", value4);
			using HttpWebResponse httpWebResponse = Request("https://steamcommunity.com/login/dologin/", "POST", data, ajax: false);
			Stream responseStream = httpWebResponse.GetResponseStream();
			if (responseStream != null)
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					steamResult = JsonConvert.DeserializeObject<SteamResult>(streamReader.ReadToEnd());
					cookies = httpWebResponse.Cookies;
				}
				continue;
			}
			return false;
		}
		while (steamResult.captcha_needed || steamResult.emailauth_needed);
		if (steamResult.success)
		{
			cookieContainer_0 = new CookieContainer();
			foreach (Cookie item in cookies)
			{
				cookieContainer_0.Add(item);
			}
			smethod_0(cookieContainer_0);
			return true;
		}
		Console.WriteLine("SteamWeb Error: " + steamResult.message);
		return false;
	}

	public void Authenticate(IEnumerable<Cookie> cookies)
	{
		CookieContainer cookieContainer = new CookieContainer();
		string text = null;
		string text2 = null;
		string text3 = null;
		foreach (Cookie cookie in cookies)
		{
			if (cookie.Name == "sessionid")
			{
				text3 = cookie.Value;
			}
			else if (cookie.Name == "steamLogin")
			{
				text = cookie.Value;
			}
			else if (cookie.Name == "steamLoginSecure")
			{
				text2 = cookie.Value;
			}
			cookieContainer.Add(cookie);
		}
		if (text == null)
		{
			throw new ArgumentException("Cookie with name \"steamLogin\" is not found.");
		}
		if (text2 == null)
		{
			throw new ArgumentException("Cookie with name \"steamLoginSecure\" is not found.");
		}
		if (text3 == null)
		{
			throw new ArgumentException("Cookie with name \"sessionid\" is not found.");
		}
		Token = text;
		TokenSecure = text2;
		SessionId = text3;
		cookieContainer_0 = cookieContainer;
	}

	public bool VerifyCookies()
	{
		using HttpWebResponse httpWebResponse = Request("http://steamcommunity.com/", "HEAD");
		return httpWebResponse.Cookies["steamLogin"] == null || !httpWebResponse.Cookies["steamLogin"]!.Value.Equals("deleted");
	}

	private static void smethod_0(CookieContainer cookieContainer_1)
	{
		if (WebRequest.Create("https://steamcommunity.com/") is HttpWebRequest httpWebRequest)
		{
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.CookieContainer = cookieContainer_1;
			httpWebRequest.ContentLength = 0L;
			httpWebRequest.GetResponse().Close();
		}
	}

	private byte[] method_0(string string_4)
	{
		if (string_4.Length % 2 == 1)
		{
			throw new Exception("The binary key cannot have an odd number of digits");
		}
		byte[] array = new byte[string_4.Length >> 1];
		int length = string_4.Length;
		for (int i = 0; i < length >> 1; i++)
		{
			array[i] = (byte)((method_1(string_4[i << 1]) << 4) + method_1(string_4[(i << 1) + 1]));
		}
		return array;
	}

	private int method_1(char char_0)
	{
		return char_0 - ((char_0 < ':') ? 48 : 55);
	}

	public bool ValidateRemoteCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors)
	{
		return true;
	}

	public SteamWeb()
	{
		Class24.nhQmSIPz7n4eU();
		string_3 = ((Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en") ? (Thread.CurrentThread.CurrentCulture.ToString() + ",en;q=0.8") : (Thread.CurrentThread.CurrentCulture.ToString() + "," + Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName + ";q=0.8,en;q=0.6"));
		cookieContainer_0 = new CookieContainer();
		base._002Ector();
	}
}
