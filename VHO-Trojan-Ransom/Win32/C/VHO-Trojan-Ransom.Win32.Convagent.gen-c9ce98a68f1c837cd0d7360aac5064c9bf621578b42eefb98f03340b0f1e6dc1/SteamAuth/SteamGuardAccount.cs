using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SteamAuth;

public class SteamGuardAccount
{
	public class WGTokenInvalidException : Exception
	{
		public WGTokenInvalidException()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	public class WGTokenExpiredException : Exception
	{
		public WGTokenExpiredException()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class6
	{
		internal class Class7
		{
			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private string string_1;

			[JsonProperty("token")]
			public string String_0
			{
				[CompilerGenerated]
				get
				{
					return string_0;
				}
				[CompilerGenerated]
				set
				{
					string_0 = value;
				}
			}

			[JsonProperty("token_secure")]
			public string String_1
			{
				[CompilerGenerated]
				get
				{
					return string_1;
				}
				[CompilerGenerated]
				set
				{
					string_1 = value;
				}
			}

			public Class7()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private Class7 class7_0;

		[JsonProperty("response")]
		public Class7 Class7_0
		{
			[CompilerGenerated]
			get
			{
				return class7_0;
			}
			[CompilerGenerated]
			set
			{
				class7_0 = value;
			}
		}

		public Class6()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class8
	{
		internal class Class9
		{
			[CompilerGenerated]
			private bool bool_0;

			[JsonProperty("success")]
			public bool Boolean_0
			{
				[CompilerGenerated]
				get
				{
					return bool_0;
				}
				[CompilerGenerated]
				set
				{
					bool_0 = value;
				}
			}

			public Class9()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private Class9 class9_0;

		[JsonProperty("response")]
		public Class9 Class9_0
		{
			[CompilerGenerated]
			get
			{
				return class9_0;
			}
			[CompilerGenerated]
			set
			{
				class9_0 = value;
			}
		}

		public Class8()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class10
	{
		[CompilerGenerated]
		private bool bool_0;

		[JsonProperty("success")]
		public bool Boolean_0
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public Class10()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class11
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private string string_0;

		[JsonProperty("success")]
		public bool Boolean_0
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		[JsonProperty("html")]
		public string String_0
		{
			[CompilerGenerated]
			get
			{
				return string_0;
			}
			[CompilerGenerated]
			set
			{
				string_0 = value;
			}
		}

		public Class11()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private string string_5;

	[CompilerGenerated]
	private string string_6;

	[CompilerGenerated]
	private string string_7;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_8;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private SessionData sessionData_0;

	private static byte[] byte_0;

	[JsonProperty("shared_secret")]
	public string SharedSecret
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	[JsonProperty("serial_number")]
	public string SerialNumber
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	[JsonProperty("revocation_code")]
	public string RevocationCode
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("uri")]
	public string URI
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	[JsonProperty("server_time")]
	public long ServerTime
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		set
		{
			long_0 = value;
		}
	}

	[JsonProperty("account_name")]
	public string AccountName
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	[JsonProperty("token_gid")]
	public string TokenGID
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	[JsonProperty("identity_secret")]
	public string IdentitySecret
	{
		[CompilerGenerated]
		get
		{
			return string_6;
		}
		[CompilerGenerated]
		set
		{
			string_6 = value;
		}
	}

	[JsonProperty("secret_1")]
	public string Secret1
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	[JsonProperty("status")]
	public int Status
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	[JsonProperty("device_id")]
	public string DeviceID
	{
		[CompilerGenerated]
		get
		{
			return string_8;
		}
		[CompilerGenerated]
		set
		{
			string_8 = value;
		}
	}

	[JsonProperty("fully_enrolled")]
	public bool FullyEnrolled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public SessionData Session
	{
		[CompilerGenerated]
		get
		{
			return sessionData_0;
		}
		[CompilerGenerated]
		set
		{
			sessionData_0 = value;
		}
	}

	public bool DeactivateAuthenticator(int scheme = 2)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("steamid", Session.SteamID.ToString());
		nameValueCollection.Add("steamguard_scheme", scheme.ToString());
		nameValueCollection.Add("revocation_code", RevocationCode);
		nameValueCollection.Add("access_token", Session.String_0);
		try
		{
			Class8 @class = JsonConvert.DeserializeObject<Class8>(SteamWeb.MobileLoginRequest("https://api.steampowered.com/ITwoFactorService/RemoveAuthenticator/v0001", "POST", nameValueCollection));
			if (@class != null && @class.Class9_0 != null && @class.Class9_0.Boolean_0)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public string GenerateSteamGuardCode()
	{
		return GenerateSteamGuardCodeForTime(TimeAligner.GetSteamTime());
	}

	public string GenerateSteamGuardCodeForTime(long time)
	{
		if (SharedSecret != null && SharedSecret.Length != 0)
		{
			byte[] key = Convert.FromBase64String(Regex.Unescape(SharedSecret));
			byte[] array = new byte[8];
			time /= 30L;
			for (int num = 8; num > 0; num--)
			{
				array[num - 1] = (byte)time;
				time >>= 8;
			}
			byte[] array2 = new HMACSHA1
			{
				Key = key
			}.ComputeHash(array);
			byte[] array3 = new byte[5];
			try
			{
				byte b = (byte)(array2[19] & 0xFu);
				int num2 = ((array2[b] & 0x7F) << 24) | ((array2[b + 1] & 0xFF) << 16) | ((array2[b + 2] & 0xFF) << 8) | (array2[b + 3] & 0xFF);
				for (int i = 0; i < 5; i++)
				{
					array3[i] = byte_0[num2 % byte_0.Length];
					num2 /= byte_0.Length;
				}
			}
			catch (Exception)
			{
				return null;
			}
			return Encoding.UTF8.GetString(array3);
		}
		return "";
	}

	public Confirmation[] FetchConfirmations()
	{
		string url = GenerateConfirmationURL();
		CookieContainer cookies = new CookieContainer();
		Session.AddCookies(cookies);
		string text = SteamWeb.Request(url, "GET", "", cookies);
		Regex regex = new Regex("<div class=\"mobileconf_list_entry\" id=\"conf[0-9]+\" data-confid=\"(\\d+)\" data-key=\"(\\d+)\" data-type=\"(\\d+)\" data-creator=\"(\\d+)\"");
		if (text != null && regex.IsMatch(text))
		{
			MatchCollection matchCollection = regex.Matches(text);
			List<Confirmation> list = new List<Confirmation>();
			foreach (Match item in matchCollection)
			{
				if (item.Groups.Count == 5 && ulong.TryParse(item.Groups[1].Value, out var result) && ulong.TryParse(item.Groups[2].Value, out var result2) && int.TryParse(item.Groups[3].Value, out var result3) && ulong.TryParse(item.Groups[4].Value, out var result4))
				{
					list.Add(new Confirmation(result, result2, result3, result4));
				}
			}
			return list.ToArray();
		}
		if (text == null || !text.Contains("<div>Nothing to confirm</div>"))
		{
			throw new WGTokenInvalidException();
		}
		return new Confirmation[0];
	}

	public async Task<Confirmation[]> FetchConfirmationsAsync()
	{
		string url = GenerateConfirmationURL();
		CookieContainer cookies = new CookieContainer();
		Session.AddCookies(cookies);
		string text = await SteamWeb.RequestAsync(url, "GET", null, cookies);
		Regex regex = new Regex("<div class=\"mobileconf_list_entry\" id=\"conf[0-9]+\" data-confid=\"(\\d+)\" data-key=\"(\\d+)\" data-type=\"(\\d+)\" data-creator=\"(\\d+)\"");
		if (text != null && regex.IsMatch(text))
		{
			MatchCollection matchCollection = regex.Matches(text);
			List<Confirmation> list = new List<Confirmation>();
			foreach (Match item in matchCollection)
			{
				if (item.Groups.Count == 5 && ulong.TryParse(item.Groups[1].Value, out var result) && ulong.TryParse(item.Groups[2].Value, out var result2) && int.TryParse(item.Groups[3].Value, out var result3) && ulong.TryParse(item.Groups[4].Value, out var result4))
				{
					list.Add(new Confirmation(result, result2, result3, result4));
				}
			}
			return list.ToArray();
		}
		if (text == null || !text.Contains("<div>Nothing to confirm</div>"))
		{
			throw new WGTokenInvalidException();
		}
		return new Confirmation[0];
	}

	public long GetConfirmationTradeOfferID(Confirmation conf)
	{
		if (conf.ConfType != Confirmation.ConfirmationType.Trade)
		{
			throw new ArgumentException("conf must be a trade confirmation.");
		}
		return (long)conf.Creator;
	}

	public bool AcceptMultipleConfirmations(Confirmation[] confs)
	{
		return method_2(confs, "allow");
	}

	public bool DenyMultipleConfirmations(Confirmation[] confs)
	{
		return method_2(confs, "cancel");
	}

	public bool AcceptConfirmation(Confirmation conf)
	{
		return method_1(conf, "allow");
	}

	public bool DenyConfirmation(Confirmation conf)
	{
		return method_1(conf, "cancel");
	}

	public bool RefreshSession()
	{
		string mOBILEAUTH_GETWGTOKEN = APIEndpoints.MOBILEAUTH_GETWGTOKEN;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("access_token", Session.String_0);
		string text = null;
		try
		{
			text = SteamWeb.Request(mOBILEAUTH_GETWGTOKEN, "POST", nameValueCollection);
		}
		catch (WebException)
		{
			return false;
		}
		if (text == null)
		{
			return false;
		}
		try
		{
			Class6 @class = JsonConvert.DeserializeObject<Class6>(text);
			if (@class != null && @class.Class7_0 != null && !string.IsNullOrEmpty(@class.Class7_0.String_0))
			{
				string steamLogin = Session.SteamID + "%7C%7C" + @class.Class7_0.String_0;
				string steamLoginSecure = Session.SteamID + "%7C%7C" + @class.Class7_0.String_1;
				Session.SteamLogin = steamLogin;
				Session.SteamLoginSecure = steamLoginSecure;
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public async Task<bool> RefreshSessionAsync()
	{
		string mOBILEAUTH_GETWGTOKEN = APIEndpoints.MOBILEAUTH_GETWGTOKEN;
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("access_token", Session.String_0);
		string text;
		try
		{
			text = await SteamWeb.RequestAsync(mOBILEAUTH_GETWGTOKEN, "POST", nameValueCollection);
		}
		catch (WebException)
		{
			return false;
		}
		if (text != null)
		{
			try
			{
				Class6 @class = JsonConvert.DeserializeObject<Class6>(text);
				if (@class != null && @class.Class7_0 != null && !string.IsNullOrEmpty(@class.Class7_0.String_0))
				{
					string steamLogin = Session.SteamID + "%7C%7C" + @class.Class7_0.String_0;
					string steamLoginSecure = Session.SteamID + "%7C%7C" + @class.Class7_0.String_1;
					Session.SteamLogin = steamLogin;
					Session.SteamLoginSecure = steamLoginSecure;
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}

	private Class11 method_0(Confirmation confirmation_0)
	{
		string text = "https://steamcommunity.com/mobileconf/details/" + confirmation_0.ID + "?";
		string text2 = GenerateConfirmationQueryParams("details");
		string url = text + text2;
		CookieContainer cookies = new CookieContainer();
		Session.AddCookies(cookies);
		GenerateConfirmationURL();
		string text3 = SteamWeb.Request(url, "GET", "", cookies);
		if (string.IsNullOrEmpty(text3))
		{
			return null;
		}
		Class11 @class = JsonConvert.DeserializeObject<Class11>(text3);
		if (@class == null)
		{
			return null;
		}
		return @class;
	}

	private bool method_1(Confirmation confirmation_0, string string_9)
	{
		string text = "https://steamcommunity.com/mobileconf/ajaxop";
		string text2 = "?op=" + string_9 + "&";
		text2 += GenerateConfirmationQueryParams(string_9);
		text2 = text2 + "&cid=" + confirmation_0.ID + "&ck=" + confirmation_0.Key;
		text += text2;
		CookieContainer cookies = new CookieContainer();
		Session.AddCookies(cookies);
		GenerateConfirmationURL();
		string text3 = SteamWeb.Request(text, "GET", "", cookies);
		if (text3 == null)
		{
			return false;
		}
		return JsonConvert.DeserializeObject<Class10>(text3).Boolean_0;
	}

	private bool method_2(Confirmation[] confirmation_0, string string_9)
	{
		string url = "https://steamcommunity.com/mobileconf/multiajaxop";
		string text = "op=" + string_9 + "&" + GenerateConfirmationQueryParams(string_9);
		foreach (Confirmation confirmation in confirmation_0)
		{
			text = text + "&cid[]=" + confirmation.ID + "&ck[]=" + confirmation.Key;
		}
		CookieContainer cookies = new CookieContainer();
		Session.AddCookies(cookies);
		GenerateConfirmationURL();
		string text2 = SteamWeb.Request(url, "POST", text, cookies);
		if (text2 == null)
		{
			return false;
		}
		return JsonConvert.DeserializeObject<Class10>(text2).Boolean_0;
	}

	public string GenerateConfirmationURL(string tag = "conf")
	{
		string text = GenerateConfirmationQueryParams(tag);
		return "https://steamcommunity.com/mobileconf/conf?" + text;
	}

	public string GenerateConfirmationQueryParams(string tag)
	{
		if (string.IsNullOrEmpty(DeviceID))
		{
			throw new ArgumentException("Device ID is not present");
		}
		NameValueCollection nameValueCollection = GenerateConfirmationQueryParamsAsNVC(tag);
		return "p=" + nameValueCollection["p"] + "&a=" + nameValueCollection["a"] + "&k=" + nameValueCollection["k"] + "&t=" + nameValueCollection["t"] + "&m=android&tag=" + nameValueCollection["tag"];
	}

	public NameValueCollection GenerateConfirmationQueryParamsAsNVC(string tag)
	{
		if (string.IsNullOrEmpty(DeviceID))
		{
			throw new ArgumentException("Device ID is not present");
		}
		long steamTime = TimeAligner.GetSteamTime();
		return new NameValueCollection
		{
			{ "p", DeviceID },
			{
				"a",
				Session.SteamID.ToString()
			},
			{
				"k",
				method_3(steamTime, tag)
			},
			{
				"t",
				steamTime.ToString()
			},
			{ "m", "android" },
			{ "tag", tag }
		};
	}

	private string method_3(long long_1, string string_9)
	{
		byte[] key = Convert.FromBase64String(IdentitySecret);
		int num = 8;
		if (string_9 != null)
		{
			num = ((string_9.Length <= 32) ? (8 + string_9.Length) : 40);
		}
		byte[] array = new byte[num];
		int num2 = 8;
		while (true)
		{
			int num3 = num2 - 1;
			if (num2 <= 0)
			{
				break;
			}
			array[num3] = (byte)long_1;
			long_1 >>= 8;
			num2 = num3;
		}
		if (string_9 != null)
		{
			Array.Copy(Encoding.UTF8.GetBytes(string_9), 0, array, 8, num - 8);
		}
		try
		{
			return WebUtility.UrlEncode(Convert.ToBase64String(new HMACSHA1
			{
				Key = key
			}.ComputeHash(array), Base64FormattingOptions.None));
		}
		catch
		{
			return null;
		}
	}

	public SteamGuardAccount()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}

	static SteamGuardAccount()
	{
		Class24.nhQmSIPz7n4eU();
		byte_0 = new byte[26]
		{
			50, 51, 52, 53, 54, 55, 56, 57, 66, 67,
			68, 70, 71, 72, 74, 75, 77, 78, 80, 81,
			82, 84, 86, 87, 88, 89
		};
	}
}
