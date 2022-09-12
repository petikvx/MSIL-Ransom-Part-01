using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using Newtonsoft.Json;

namespace SteamAuth;

public class AuthenticatorLinker
{
	public enum LinkResult
	{
		MustProvidePhoneNumber,
		MustRemovePhoneNumber,
		AwaitingFinalization,
		GeneralFailure,
		AuthenticatorPresent
	}

	public enum FinalizeResult
	{
		const_0,
		UnableToGenerateCorrectCodes,
		Success,
		GeneralFailure
	}

	private class Class1
	{
		[CompilerGenerated]
		private SteamGuardAccount steamGuardAccount_0;

		[JsonProperty("response")]
		public SteamGuardAccount SteamGuardAccount_0
		{
			[CompilerGenerated]
			get
			{
				return steamGuardAccount_0;
			}
			[CompilerGenerated]
			set
			{
				steamGuardAccount_0 = value;
			}
		}

		public Class1()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class2
	{
		internal class Class3
		{
			[CompilerGenerated]
			private int int_0;

			[CompilerGenerated]
			private long long_0;

			[CompilerGenerated]
			private bool bool_0;

			[CompilerGenerated]
			private bool bool_1;

			[JsonProperty("status")]
			public int Int32_0
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

			[JsonProperty("server_time")]
			public long Int64_0
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

			[JsonProperty("want_more")]
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

			[JsonProperty("success")]
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

			public Class3()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private Class3 class3_0;

		[JsonProperty("response")]
		public Class3 Class3_0
		{
			[CompilerGenerated]
			get
			{
				return class3_0;
			}
			[CompilerGenerated]
			set
			{
				class3_0 = value;
			}
		}

		public Class2()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class4
	{
		[CompilerGenerated]
		private bool bool_0;

		[JsonProperty("has_phone")]
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

		public Class4()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	private class Class5
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

		public Class5()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
		}
	}

	public string PhoneNumber;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private SteamGuardAccount steamGuardAccount_0;

	public bool Finalized;

	private SessionData sessionData_0;

	private CookieContainer cookieContainer_0;

	public string DeviceID
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

	public SteamGuardAccount LinkedAccount
	{
		[CompilerGenerated]
		get
		{
			return steamGuardAccount_0;
		}
		[CompilerGenerated]
		private set
		{
			steamGuardAccount_0 = value;
		}
	}

	public AuthenticatorLinker(SessionData session)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		sessionData_0 = session;
		DeviceID = GenerateDeviceID();
		cookieContainer_0 = new CookieContainer();
		session.AddCookies(cookieContainer_0);
	}

	public LinkResult AddAuthenticator()
	{
		bool flag;
		if ((flag = method_2()) && PhoneNumber != null)
		{
			return LinkResult.MustRemovePhoneNumber;
		}
		if (!flag && PhoneNumber == null)
		{
			return LinkResult.MustProvidePhoneNumber;
		}
		if (!flag && !method_1())
		{
			return LinkResult.GeneralFailure;
		}
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("access_token", sessionData_0.String_0);
		nameValueCollection.Add("steamid", sessionData_0.SteamID.ToString());
		nameValueCollection.Add("authenticator_type", "1");
		nameValueCollection.Add("device_identifier", DeviceID);
		nameValueCollection.Add("sms_phone_id", "1");
		string text = SteamWeb.MobileLoginRequest("https://api.steampowered.com/ITwoFactorService/AddAuthenticator/v0001", "POST", nameValueCollection);
		if (text == null)
		{
			return LinkResult.GeneralFailure;
		}
		Class1 @class = JsonConvert.DeserializeObject<Class1>(text);
		if (@class != null && @class.SteamGuardAccount_0 != null)
		{
			if (@class.SteamGuardAccount_0.Status == 29)
			{
				return LinkResult.AuthenticatorPresent;
			}
			if (@class.SteamGuardAccount_0.Status != 1)
			{
				return LinkResult.GeneralFailure;
			}
			LinkedAccount = @class.SteamGuardAccount_0;
			LinkedAccount.Session = sessionData_0;
			LinkedAccount.DeviceID = DeviceID;
			return LinkResult.AwaitingFinalization;
		}
		return LinkResult.GeneralFailure;
	}

	public FinalizeResult FinalizeAddAuthenticator(string smsCode)
	{
		if (!string.IsNullOrEmpty(PhoneNumber) && !method_0(smsCode))
		{
			return FinalizeResult.const_0;
		}
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("steamid", sessionData_0.SteamID.ToString());
		nameValueCollection.Add("access_token", sessionData_0.String_0);
		nameValueCollection.Add("activation_code", smsCode);
		int num = 0;
		while (true)
		{
			if (num <= 30)
			{
				nameValueCollection.Set("authenticator_code", LinkedAccount.GenerateSteamGuardCode());
				nameValueCollection.Set("authenticator_time", TimeAligner.GetSteamTime().ToString());
				string text = SteamWeb.MobileLoginRequest("https://api.steampowered.com/ITwoFactorService/FinalizeAddAuthenticator/v0001", "POST", nameValueCollection);
				if (text != null)
				{
					Class2 @class = JsonConvert.DeserializeObject<Class2>(text);
					if (@class == null || @class.Class3_0 == null)
					{
						break;
					}
					if (@class.Class3_0.Int32_0 != 89)
					{
						if (@class.Class3_0.Int32_0 != 88 || num < 30)
						{
							if (@class.Class3_0.Boolean_1)
							{
								if (@class.Class3_0.Boolean_0)
								{
									num++;
									continue;
								}
								LinkedAccount.FullyEnrolled = true;
								return FinalizeResult.Success;
							}
							return FinalizeResult.GeneralFailure;
						}
						return FinalizeResult.UnableToGenerateCorrectCodes;
					}
					return FinalizeResult.const_0;
				}
				return FinalizeResult.GeneralFailure;
			}
			return FinalizeResult.GeneralFailure;
		}
		return FinalizeResult.GeneralFailure;
	}

	private bool method_0(string string_1)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("op", "check_sms_code");
		nameValueCollection.Add("arg", string_1);
		nameValueCollection.Add("checkfortos", "0");
		nameValueCollection.Add("skipvoip", "1");
		nameValueCollection.Add("sessionid", sessionData_0.SessionID);
		string text = SteamWeb.Request("https://steamcommunity.com/steamguard/phoneajax", "POST", nameValueCollection, cookieContainer_0);
		if (text == null)
		{
			return false;
		}
		if (!JsonConvert.DeserializeObject<Class5>(text).Boolean_0)
		{
			Thread.Sleep(3500);
			return method_2();
		}
		return true;
	}

	private bool method_1()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("op", "add_phone_number");
		nameValueCollection.Add("arg", PhoneNumber);
		nameValueCollection.Add("sessionid", sessionData_0.SessionID);
		string text = SteamWeb.Request("https://steamcommunity.com/steamguard/phoneajax", "POST", nameValueCollection, cookieContainer_0);
		if (text == null)
		{
			return false;
		}
		return JsonConvert.DeserializeObject<Class5>(text).Boolean_0;
	}

	private bool method_2()
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("op", "has_phone");
		nameValueCollection.Add("arg", "null");
		nameValueCollection.Add("sessionid", sessionData_0.SessionID);
		string text = SteamWeb.Request("https://steamcommunity.com/steamguard/phoneajax", "POST", nameValueCollection, cookieContainer_0);
		if (text == null)
		{
			return false;
		}
		return JsonConvert.DeserializeObject<Class4>(text).Boolean_0;
	}

	public static string GenerateDeviceID()
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[8];
		rNGCryptoServiceProvider.GetBytes(array);
		string string_ = BitConverter.ToString(sHA1Managed.ComputeHash(array)).Replace("-", "").Substring(0, 32)
			.ToLower();
		return "android:" + smethod_0(string_, new int[5] { 8, 4, 4, 4, 12 }, "-");
	}

	private static string smethod_0(string string_1, object object_0, string string_2)
	{
		string text = "";
		int startIndex = 0;
		for (int i = 0; i < ((Array)object_0).Length; i++)
		{
			text += string_1.Substring(startIndex, ((int[])object_0)[i]);
			startIndex = ((int[])object_0)[i];
			if (i < ((Array)object_0).Length - 1)
			{
				text += string_2;
			}
		}
		return text;
	}
}
