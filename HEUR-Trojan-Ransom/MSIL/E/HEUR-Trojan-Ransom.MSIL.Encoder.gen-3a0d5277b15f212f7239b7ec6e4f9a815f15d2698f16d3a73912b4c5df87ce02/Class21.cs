using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;

internal class Class21
{
	internal class Class22
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class Class23
		{
			public static readonly Class23 _003C_003E9;

			public static RemoteCertificateValidationCallback _003C_003E9__1_0;

			static Class23()
			{
				_003CModule_003E.Class0.smethod_0();
				_003C_003E9 = new Class23();
			}

			public Class23()
			{
				_003CModule_003E.Class0.smethod_0();
				base._002Ector();
			}

			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				_003CModule_003E.Class0.smethod_0();
				return true;
			}
		}

		private const string string_0 = "041B6566A801CC518B5AC35FE91FCF4BDD9E94F3AE8156DF327083B7DA8A62D5CE2A4C25245F1567A0AC51EF12C549E8D62CC27DB1398DE17F62015ADF00207D5D";

		public static void smethod_0()
		{
			_003CModule_003E.Class0.smethod_0();
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(smethod_2));
		}

		public static void smethod_1()
		{
			_003CModule_003E.Class0.smethod_0();
			ServicePointManager.ServerCertificateValidationCallback = delegate
			{
				_003CModule_003E.Class0.smethod_0();
				return true;
			};
		}

		private static bool smethod_2(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			_003CModule_003E.Class0.smethod_0();
			return x509Certificate_0 != null && x509Certificate_0.GetPublicKeyString() == "041B6566A801CC518B5AC35FE91FCF4BDD9E94F3AE8156DF327083B7DA8A62D5CE2A4C25245F1567A0AC51EF12C549E8D62CC27DB1398DE17F62015ADF00207D5D";
		}

		public Class22()
		{
			_003CModule_003E.Class0.smethod_0();
			base._002Ector();
		}

		static void smethod_6(RemoteCertificateValidationCallback remoteCertificateValidationCallback_0)
		{
			ServicePointManager.ServerCertificateValidationCallback = remoteCertificateValidationCallback_0;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class24
	{
		public static readonly Class24 _003C_003E9;

		public static Func<string, char> _003C_003E9__2_0;

		static Class24()
		{
			_003CModule_003E.Class0.smethod_0();
			_003C_003E9 = new Class24();
		}

		public Class24()
		{
			_003CModule_003E.Class0.smethod_0();
			base._002Ector();
		}

		internal char method_0(string string_0)
		{
			_003CModule_003E.Class0.smethod_0();
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	[CompilerGenerated]
	private static class Class25
	{
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;

		public static CallSite<Func<CallSite, object, object>> callSite_2;

		public static CallSite<Func<CallSite, object, string>> callSite_3;

		public static CallSite<Func<CallSite, object, object>> callSite_4;

		public static CallSite<Func<CallSite, object, string>> callSite_5;

		public static CallSite<Func<CallSite, object, object>> callSite_6;

		public static CallSite<Func<CallSite, object, string>> callSite_7;

		public static CallSite<Func<CallSite, object, object>> callSite_8;

		public static CallSite<Func<CallSite, object, string>> callSite_9;

		public static CallSite<Func<CallSite, object, object>> callSite_10;

		public static CallSite<Func<CallSite, object, string>> callSite_11;

		public static CallSite<Func<CallSite, object, object>> callSite_12;

		public static CallSite<Func<CallSite, object, string>> callSite_13;

		public static CallSite<Func<CallSite, object, object>> callSite_14;

		public static CallSite<Func<CallSite, object, string>> callSite_15;

		public static CallSite<Func<CallSite, object, object>> callSite_16;

		public static CallSite<Func<CallSite, object, string>> callSite_17;

		public static CallSite<Func<CallSite, object, object>> callSite_18;

		public static CallSite<Func<CallSite, object, string>> callSite_19;
	}

	[CompilerGenerated]
	private static class Class26
	{
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;

		public static CallSite<Func<CallSite, object, object>> callSite_2;

		public static CallSite<Func<CallSite, object, string>> callSite_3;

		public static CallSite<Func<CallSite, object, object>> callSite_4;

		public static CallSite<Func<CallSite, object, string>> callSite_5;

		public static CallSite<Func<CallSite, object, object>> callSite_6;

		public static CallSite<Func<CallSite, object, string>> callSite_7;

		public static CallSite<Func<CallSite, object, object>> callSite_8;

		public static CallSite<Func<CallSite, object, string>> callSite_9;

		public static CallSite<Func<CallSite, object, object>> callSite_10;

		public static CallSite<Func<CallSite, object, string>> callSite_11;

		public static CallSite<Func<CallSite, object, object>> callSite_12;

		public static CallSite<Func<CallSite, object, string>> callSite_13;

		public static CallSite<Func<CallSite, object, object>> callSite_14;

		public static CallSite<Func<CallSite, object, string>> callSite_15;

		public static CallSite<Func<CallSite, object, object>> callSite_16;

		public static CallSite<Func<CallSite, object, string>> callSite_17;

		public static CallSite<Func<CallSite, object, object>> callSite_18;

		public static CallSite<Func<CallSite, object, string>> callSite_19;

		public static CallSite<Func<CallSite, object, object>> callSite_20;

		public static CallSite<Func<CallSite, object, string>> callSite_21;

		public static CallSite<Func<CallSite, object, object>> callSite_22;

		public static CallSite<Func<CallSite, object, string>> callSite_23;

		public static CallSite<Func<CallSite, object, object>> callSite_24;

		public static CallSite<Func<CallSite, object, object>> callSite_25;

		public static CallSite<Func<CallSite, Type, object, object>> callSite_26;

		public static CallSite<Func<CallSite, object, Dictionary<string, object>>> callSite_27;
	}

	[CompilerGenerated]
	private static class Class27
	{
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;
	}

	[CompilerGenerated]
	private static class Class28
	{
		public static CallSite<Func<CallSite, object, object>> callSite_0;

		public static CallSite<Func<CallSite, object, string>> callSite_1;
	}

	private static Dictionary<string, object> dictionary_0;

	private static Random random_0;

	public static string smethod_0(int int_0)
	{
		_003CModule_003E.Class0.smethod_0();
		return new string(Enumerable.Repeat("123456789", int_0).Select(delegate(string string_0)
		{
			_003CModule_003E.Class0.smethod_0();
			return string_0[random_0.Next(string_0.Length)];
		}).ToArray());
	}

	public static int smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		Random random = new Random(DateTime.Now.Millisecond);
		return random.Next(10, 50);
	}

	public static void smethod_2()
	{
		//IL_0758: Unknown result type (might be due to invalid IL or missing references)
		_003CModule_003E.Class0.smethod_0();
		Class22.smethod_0();
		using (WebClient webClient = new WebClient())
		{
			try
			{
				webClient.Proxy = null;
				WebRequest.DefaultWebProxy = new WebProxy();
				webClient.Headers["User-Agent"] = "AuthGG";
				NameValueCollection nameValueCollection = new NameValueCollection();
				int int_ = smethod_1();
				string text = smethod_0(int_);
				string value = Class30.string_2 + text;
				nameValueCollection["type"] = "start";
				nameValueCollection["aid"] = Class30.string_0;
				nameValueCollection["secret"] = Class30.string_1;
				nameValueCollection["random"] = int_.ToString();
				nameValueCollection["apikey"] = value;
				byte[] bytes = webClient.UploadValues("https://api.auth.gg/version2/api.php", nameValueCollection);
				string @string = Encoding.Default.GetString(bytes);
				dynamic val = JsonConvert.DeserializeObject(@string);
				Class29.smethod_19((string)val.hashed);
				Class29.smethod_17((string)val.status);
				Class29.smethod_3((string)val.hash);
				Class29.smethod_1((string)val.version);
				Class29.smethod_11((string)val.downloadlink);
				Class29.smethod_9((string)val.freemode);
				Class29.smethod_15((string)val.login);
				Class29.smethod_13((string)val.register);
				Class29.smethod_7((string)val.developermode);
				Class29.smethod_5((string)val.applicationname);
				if (Class29.smethod_16() == "Failed")
				{
					MessageBox.Show("Premium API key does not match!", "Auth.GG | Licensing System", (MessageBoxButtons)0, (MessageBoxIcon)16);
					Process.GetCurrentProcess().Kill();
				}
				if (Class29.smethod_18() != Class30.string_2)
				{
					Process.GetCurrentProcess().Kill();
				}
				if (Class29.smethod_16() == "Disabled")
				{
					Process.GetCurrentProcess().Kill();
				}
				if (Class29.smethod_6() == "Disabled")
				{
					if (Class29.smethod_0() != Class30.string_3)
					{
						Process.Start(Class29.smethod_10());
					}
					string text2 = smethod_8(Application.get_ExecutablePath());
					if (Class29.smethod_2() != text2)
					{
						Process.GetCurrentProcess().Kill();
					}
				}
			}
			catch
			{
			}
		}
		Class22.smethod_1();
	}

	public static void smethod_3(string string_0, string string_1)
	{
		_003CModule_003E.Class0.smethod_0();
		Class22.smethod_0();
		using (WebClient webClient = new WebClient())
		{
			try
			{
				webClient.Proxy = null;
				WebRequest.DefaultWebProxy = new WebProxy();
				webClient.Headers["User-Agent"] = "AuthGG";
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["type"] = "log";
				nameValueCollection["aid"] = Class30.string_0;
				nameValueCollection["secret"] = Class30.string_1;
				nameValueCollection["time"] = Class30.smethod_1();
				nameValueCollection["username"] = string_0;
				nameValueCollection["pcuser"] = Environment.UserName;
				nameValueCollection["action"] = string_1;
				webClient.UploadValues("https://api.auth.gg/version2/api.php", nameValueCollection);
			}
			catch
			{
			}
		}
		Class22.smethod_1();
	}

	public static bool smethod_4(string string_0, string string_1)
	{
		_003CModule_003E.Class0.smethod_0();
		if (Class29.smethod_14() != "Enabled")
		{
			Process.GetCurrentProcess().Kill();
		}
		using WebClient webClient = new WebClient();
		try
		{
			Class22.smethod_0();
			webClient.Proxy = null;
			WebRequest.DefaultWebProxy = new WebProxy();
			webClient.Headers["User-Agent"] = "AuthGG";
			NameValueCollection nameValueCollection = new NameValueCollection();
			int int_ = smethod_1();
			string text = smethod_0(int_);
			string value = Class30.string_2 + text;
			nameValueCollection["type"] = "login";
			nameValueCollection["username"] = string_0;
			nameValueCollection["password"] = string_1;
			nameValueCollection["hwid"] = Class30.smethod_0();
			nameValueCollection["aid"] = Class30.string_0;
			nameValueCollection["secret"] = Class30.string_1;
			nameValueCollection["time"] = Class30.smethod_1();
			nameValueCollection["random"] = int_.ToString();
			nameValueCollection["apikey"] = value;
			byte[] bytes = webClient.UploadValues("https://api.auth.gg/version2/api.php", nameValueCollection);
			string @string = Encoding.Default.GetString(bytes);
			dynamic val = JsonConvert.DeserializeObject(@string);
			Class22.smethod_1();
			if ((string)val.status == "Failed")
			{
				Process.GetCurrentProcess().Kill();
			}
			if ((string)val.hashed != Class30.string_2)
			{
				Process.GetCurrentProcess().Kill();
			}
			switch ((string)val.result)
			{
			case "success":
				Class31.smethod_3((string)val.id);
				Class31.smethod_1(bool.Parse((string)val.logged_in));
				Class31.smethod_7((string)val.username);
				Class31.smethod_13((string)val.email);
				Class31.smethod_11((string)val.hwid);
				Class31.smethod_15((string)val.variable);
				Class31.smethod_19((string)val.expiry);
				Class31.smethod_17((string)val.rank);
				Class31.smethod_5((string)val.ip);
				dictionary_0 = JsonConvert.DeserializeObject<Dictionary<string, object>>(val.vars.ToString());
				return true;
			case "invalid_details":
				return false;
			case "invalid_hwid":
				return false;
			case "hwid_updated":
				return false;
			case "time_expired":
				return false;
			case "net_error":
				return false;
			default:
				return false;
			}
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_5(string string_0, string string_1, string string_2, string string_3)
	{
		_003CModule_003E.Class0.smethod_0();
		if (Class29.smethod_12() != "Enabled")
		{
			Process.GetCurrentProcess().Kill();
		}
		try
		{
			Class22.smethod_0();
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			WebRequest.DefaultWebProxy = new WebProxy();
			webClient.Headers["User-Agent"] = "AuthGG";
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "register";
			nameValueCollection["username"] = string_0;
			nameValueCollection["password"] = string_1;
			nameValueCollection["email"] = string_2;
			nameValueCollection["token"] = string_3;
			nameValueCollection["hwid"] = Class30.smethod_0();
			nameValueCollection["aid"] = Class30.string_0;
			nameValueCollection["secret"] = Class30.string_1;
			byte[] bytes = webClient.UploadValues("https://api.auth.gg/version2/api.php", nameValueCollection);
			string @string = Encoding.Default.GetString(bytes);
			dynamic val = JsonConvert.DeserializeObject(@string);
			Class22.smethod_1();
			return (string)val.result switch
			{
				"success" => true, 
				"email_used" => false, 
				"invalid_username" => false, 
				"invalid_token" => false, 
				_ => false, 
			};
		}
		catch
		{
			return false;
		}
	}

	public static bool smethod_6(string string_0)
	{
		_003CModule_003E.Class0.smethod_0();
		if (!smethod_4(string_0, string_0))
		{
			if (smethod_5(string_0, string_0, string_0, string_0))
			{
				Process.GetCurrentProcess().Kill();
				return true;
			}
			return false;
		}
		return true;
	}

	public static bool smethod_7(string string_0, string string_1, string string_2)
	{
		_003CModule_003E.Class0.smethod_0();
		try
		{
			Class22.smethod_0();
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			WebRequest.DefaultWebProxy = new WebProxy();
			webClient.Headers["User-Agent"] = "AuthGG";
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = "redeem";
			nameValueCollection["username"] = string_0;
			nameValueCollection["password"] = string_1;
			nameValueCollection["token"] = string_2;
			nameValueCollection["aid"] = Class30.string_0;
			nameValueCollection["secret"] = Class30.string_1;
			byte[] bytes = webClient.UploadValues("https://api.auth.gg/version2/api.php", nameValueCollection);
			string @string = Encoding.Default.GetString(bytes);
			dynamic val = JsonConvert.DeserializeObject(@string);
			Class22.smethod_1();
			return (string)val.result switch
			{
				"success" => true, 
				"invalid_details" => false, 
				"net_error" => false, 
				"invalid_token" => false, 
				_ => false, 
			};
		}
		catch
		{
		}
		return false;
	}

	private static string smethod_8(string string_0)
	{
		_003CModule_003E.Class0.smethod_0();
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(string_0);
		byte[] array = mD.ComputeHash(inputStream);
		return BitConverter.ToString(array).Replace("-", "").ToLowerInvariant();
	}

	public static string smethod_9(string string_0)
	{
		_003CModule_003E.Class0.smethod_0();
		try
		{
			if (!Class31.smethod_0())
			{
				if (Class29.smethod_8() == "Enabled")
				{
					return dictionary_0[string_0].ToString();
				}
				return "[ERROR] : You are not logged in!";
			}
			return dictionary_0[string_0].ToString();
		}
		catch
		{
			return "[ERROR] : Variable does not exist!";
		}
	}

	public Class21()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static Class21()
	{
		_003CModule_003E.Class0.smethod_0();
		dictionary_0 = new Dictionary<string, object>();
		random_0 = new Random();
	}

	static object smethod_11(char[] char_0)
	{
		return new string(char_0);
	}

	static object smethod_13()
	{
		return new WebClient();
	}

	static void smethod_27()
	{
		Class22.smethod_1();
	}

	static object smethod_40(CSharpBinderFlags csharpBinderFlags_0, string string_0, Type type_0, IEnumerable<CSharpArgumentInfo> ienumerable_0)
	{
		return Binder.GetMember(csharpBinderFlags_0, string_0, type_0, ienumerable_0);
	}
}
