using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.InfoCards;

internal class SafeCryptoKeyHandle : SafeHandle
{
	public override bool IsInvalid => IntPtr.Zero == handle;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CryptDestroyKey([In] IntPtr hKey);

	private SafeCryptoKeyHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		return CryptDestroyKey(handle);
	}
}
