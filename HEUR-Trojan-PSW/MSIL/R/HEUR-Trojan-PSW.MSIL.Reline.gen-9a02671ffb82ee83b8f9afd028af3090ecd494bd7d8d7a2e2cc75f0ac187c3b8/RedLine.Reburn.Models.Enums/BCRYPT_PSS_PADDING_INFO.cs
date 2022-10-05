using System.Runtime.InteropServices;

namespace RedLine.Reburn.Models.Enums;

public struct BCRYPT_PSS_PADDING_INFO
{
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	public int cbSalt;

	public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
	{
		this.pszAlgId = pszAlgId;
		this.cbSalt = cbSalt;
	}
}
