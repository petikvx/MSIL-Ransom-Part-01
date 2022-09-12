using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace SteamAuth;

public class UserLogin
{
	private class Class14
	{
		internal class Class15
		{
			[CompilerGenerated]
			private ulong ulong_0;

			[CompilerGenerated]
			private string string_0;

			[CompilerGenerated]
			private string string_1;

			[CompilerGenerated]
			private string string_2;

			[CompilerGenerated]
			private string string_3;

			[JsonProperty("steamid")]
			public ulong HbMazlThem
			{
				[CompilerGenerated]
				get
				{
					return ulong_0;
				}
				[CompilerGenerated]
				set
				{
					ulong_0 = value;
				}
			}

			[JsonProperty("oauth_token")]
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

			[JsonProperty("wgtoken")]
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

			[JsonProperty("wgtoken_secure")]
			public string String_2
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

			[JsonProperty("webcookie")]
			public string String_3
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

			public Class15()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private ulong ulong_0;

		[CompilerGenerated]
		private bool bool_3;

		[CompilerGenerated]
		private bool bool_4;

		[CompilerGenerated]
		private string string_2;

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

		[JsonProperty("login_complete")]
		public bool Boolean_1
		{
			[CompilerGenerated]
			get
			{
				return bool_1;
			}
			[CompilerGenerated]
			set
			{
				bool_1 = value;
			}
		}

		[JsonProperty("oauth")]
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

		[JsonProperty("captcha_needed")]
		public bool Boolean_2
		{
			[CompilerGenerated]
			get
			{
				return bool_2;
			}
			[CompilerGenerated]
			set
			{
				bool_2 = value;
			}
		}

		[JsonProperty("captcha_gid")]
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

		[JsonProperty("emailsteamid")]
		public ulong UInt64_0
		{
			[CompilerGenerated]
			get
			{
				return ulong_0;
			}
			[CompilerGenerated]
			set
			{
				ulong_0 = value;
			}
		}

		[JsonProperty("emailauth_needed")]
		public bool Boolean_3
		{
			[CompilerGenerated]
			get
			{
				return bool_3;
			}
			[CompilerGenerated]
			set
			{
				bool_3 = value;
			}
		}

		[JsonProperty("requires_twofactor")]
		public bool Boolean_4
		{
			[CompilerGenerated]
			get
			{
				return bool_4;
			}
			[CompilerGenerated]
			set
			{
				bool_4 = value;
			}
		}

		[JsonProperty("message")]
		public string String_2
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

		[SpecialName]
		public Class15 method_0()
		{
			if (String_0 == null)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<Class15>(String_0);
		}

		public Class14()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class16
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private ulong ulong_0;

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

		[JsonProperty("publickey_exp")]
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

		[JsonProperty("publickey_mod")]
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

		[JsonProperty("timestamp")]
		public string String_2
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

		[JsonProperty("steamid")]
		public ulong UInt64_0
		{
			[CompilerGenerated]
			get
			{
				return ulong_0;
			}
			[CompilerGenerated]
			set
			{
				ulong_0 = value;
			}
		}

		public Class16()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	public string Username;

	public string Password;

	public ulong SteamID;

	public bool RequiresCaptcha;

	public string string_0;

	public string CaptchaText;

	public bool RequiresEmail;

	public string EmailDomain;

	public string EmailCode;

	public bool bool_0;

	public string TwoFactorCode;

	public SessionData Session;

	public bool LoggedIn;

	private CookieContainer cookieContainer_0;

	public UserLogin(string username, string password)
	{
		Class24.nhQmSIPz7n4eU();
		cookieContainer_0 = new CookieContainer();
		base._002Ector();
		Username = username;
		Password = password;
	}

	public LoginResult DoLogin()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		CookieContainer cookieContainer = cookieContainer_0;
		string text = null;
		if (cookieContainer.Count == 0)
		{
			cookieContainer.Add(new Cookie("mobileClientVersion", "0 (2.1.3)", "/", ".steamcommunity.com"));
			cookieContainer.Add(new Cookie("mobileClient", "android", "/", ".steamcommunity.com"));
			cookieContainer.Add(new Cookie("Steam_Language", "english", "/", ".steamcommunity.com"));
			NameValueCollection nameValueCollection2 = new NameValueCollection();
			nameValueCollection2.Add("X-Requested-With", "com.valvesoftware.android.steam.community");
			SteamWeb.MobileLoginRequest("https://steamcommunity.com/login?oauth_client_id=DE45CD61&oauth_scope=read_profile%20write_profile%20read_client%20write_client", "GET", null, cookieContainer, nameValueCollection2);
		}
		nameValueCollection.Add("username", Username);
		text = SteamWeb.MobileLoginRequest("https://steamcommunity.com/login/getrsakey", "POST", nameValueCollection, cookieContainer);
		if (text != null && !text.Contains("<BODY>\nAn error occurred while processing your request."))
		{
			Class16 @class = JsonConvert.DeserializeObject<Class16>(text);
			if (!@class.Boolean_0)
			{
				return LoginResult.BadRSA;
			}
			new RNGCryptoServiceProvider();
			byte[] inArray;
			using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
			{
				byte[] bytes = Encoding.ASCII.GetBytes(Password);
				RSAParameters parameters = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
				parameters.Exponent = Util.HexStringToByteArray(@class.String_0);
				parameters.Modulus = Util.HexStringToByteArray(@class.String_1);
				rSACryptoServiceProvider.ImportParameters(parameters);
				inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
			}
			string value = Convert.ToBase64String(inArray);
			nameValueCollection.Clear();
			nameValueCollection.Add("username", Username);
			nameValueCollection.Add("password", value);
			nameValueCollection.Add("twofactorcode", TwoFactorCode ?? "");
			nameValueCollection.Add("captchagid", RequiresCaptcha ? string_0 : "-1");
			nameValueCollection.Add("captcha_text", RequiresCaptcha ? CaptchaText : "");
			nameValueCollection.Add("emailsteamid", (bool_0 || RequiresEmail) ? SteamID.ToString() : "");
			nameValueCollection.Add("emailauth", RequiresEmail ? EmailCode : "");
			nameValueCollection.Add("rsatimestamp", @class.String_2);
			nameValueCollection.Add("remember_login", "false");
			nameValueCollection.Add("oauth_client_id", "DE45CD61");
			nameValueCollection.Add("oauth_scope", "read_profile write_profile read_client write_client");
			nameValueCollection.Add("loginfriendlyname", "#login_emailauth_friendlyname_mobile");
			nameValueCollection.Add("donotcache", Util.GetSystemUnixTime().ToString());
			text = SteamWeb.MobileLoginRequest("https://steamcommunity.com/login/dologin", "POST", nameValueCollection, cookieContainer);
			if (text == null)
			{
				return LoginResult.GeneralFailure;
			}
			Class14 class2 = JsonConvert.DeserializeObject<Class14>(text);
			if (class2.String_2 != null && class2.String_2.Contains("Incorrect login"))
			{
				return LoginResult.BadCredentials;
			}
			if (class2.Boolean_2)
			{
				RequiresCaptcha = true;
				string_0 = class2.String_1;
				return LoginResult.NeedCaptcha;
			}
			if (class2.Boolean_3)
			{
				RequiresEmail = true;
				SteamID = class2.UInt64_0;
				return LoginResult.NeedEmail;
			}
			if (class2.Boolean_4 && !class2.Boolean_0)
			{
				bool_0 = true;
				return LoginResult.Need2FA;
			}
			if (class2.String_2 != null && class2.String_2.Contains("too many login failures"))
			{
				return LoginResult.TooManyFailedLogins;
			}
			if (class2.method_0() != null && class2.method_0().String_0 != null && class2.method_0().String_0.Length != 0)
			{
				if (!class2.Boolean_1)
				{
					return LoginResult.BadCredentials;
				}
				CookieCollection cookies = cookieContainer.GetCookies(new Uri("https://steamcommunity.com"));
				Class14.Class15 class3 = class2.method_0();
				SessionData sessionData = new SessionData();
				sessionData.String_0 = class3.String_0;
				sessionData.SteamID = class3.HbMazlThem;
				sessionData.SteamLogin = sessionData.SteamID + "%7C%7C" + class3.String_1;
				sessionData.SteamLoginSecure = sessionData.SteamID + "%7C%7C" + class3.String_2;
				sessionData.WebCookie = class3.String_3;
				sessionData.SessionID = cookies["sessionid"]!.Value;
				Session = sessionData;
				LoggedIn = true;
				return LoginResult.LoginOkay;
			}
			return LoginResult.GeneralFailure;
		}
		return LoginResult.GeneralFailure;
	}
}
