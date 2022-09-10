using System;
using System.Runtime.InteropServices;

namespace FileEncryptor;

public struct CRYPT_KEY_PROV_INFO
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pwszContainerName;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string pwszProvName;

	public uint dwProvType;

	public uint dwFlags;

	public uint cProvParam;

	public IntPtr rgProvParam;

	public uint dwKeySpec;
}
