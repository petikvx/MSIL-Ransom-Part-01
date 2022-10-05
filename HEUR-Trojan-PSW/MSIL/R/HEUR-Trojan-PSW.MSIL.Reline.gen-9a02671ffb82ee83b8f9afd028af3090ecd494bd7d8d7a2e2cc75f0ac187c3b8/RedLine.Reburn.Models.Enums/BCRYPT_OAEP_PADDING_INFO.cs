using System;
using System.Runtime.InteropServices;

namespace RedLine.Reburn.Models.Enums;

public struct BCRYPT_OAEP_PADDING_INFO
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	public IntPtr pbLabel;

	public int cbLabel;

	public BCRYPT_OAEP_PADDING_INFO(string alg)
	{
		pszAlgId = alg;
		pbLabel = IntPtr.Zero;
		cbLabel = 0;
	}
}
