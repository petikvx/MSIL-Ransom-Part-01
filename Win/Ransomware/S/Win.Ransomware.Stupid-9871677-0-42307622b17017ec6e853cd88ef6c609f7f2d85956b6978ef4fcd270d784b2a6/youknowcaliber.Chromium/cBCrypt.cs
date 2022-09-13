using System;
using System.Runtime.InteropServices;

namespace youknowcaliber.Chromium;

public static class cBCrypt
{
	public struct BCRYPT_PSS_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public int cbSalt;

		public extern BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt);
	}

	public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
	{
		public int cbSize;

		public int dwInfoVersion;

		public IntPtr pbNonce;

		public int cbNonce;

		public IntPtr pbAuthData;

		public int cbAuthData;

		public IntPtr pbTag;

		public int cbTag;

		public IntPtr pbMacContext;

		public int cbMacContext;

		public int cbAAD;

		public long cbData;

		public int dwFlags;

		public extern BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag);

		public extern void Dispose();
	}

	public struct BCRYPT_KEY_LENGTHS_STRUCT
	{
		public int dwMinLength;

		public int dwMaxLength;

		public int dwIncrement;
	}

	public struct BCRYPT_OAEP_PADDING_INFO
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pszAlgId;

		public IntPtr pbLabel;

		public int cbLabel;

		public extern BCRYPT_OAEP_PADDING_INFO(string alg);
	}

	public const uint ERROR_SUCCESS = 0u;

	public const uint BCRYPT_PAD_PSS = 8u;

	public const uint BCRYPT_PAD_OAEP = 4u;

	public static readonly byte[] BCRYPT_KEY_DATA_BLOB_MAGIC;

	public static readonly string BCRYPT_OBJECT_LENGTH;

	public static readonly string BCRYPT_CHAIN_MODE_GCM;

	public static readonly string BCRYPT_AUTH_TAG_LENGTH;

	public static readonly string BCRYPT_CHAINING_MODE;

	public static readonly string BCRYPT_KEY_DATA_BLOB;

	public static readonly string BCRYPT_AES_ALGORITHM;

	public static readonly string MS_PRIMITIVE_PROVIDER;

	public static readonly int BCRYPT_AUTH_MODE_CHAIN_CALLS_FLAG;

	public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION;

	public static readonly uint STATUS_AUTH_TAG_MISMATCH;

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, uint flags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptSetProperty(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr hKey);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptEncrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, uint dwFlags);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);
}
