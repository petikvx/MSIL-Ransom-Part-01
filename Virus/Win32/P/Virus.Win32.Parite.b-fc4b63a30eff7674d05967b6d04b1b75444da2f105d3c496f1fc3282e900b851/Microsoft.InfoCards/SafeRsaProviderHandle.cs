using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SafeRsaProviderHandle : SafeHandle
{
	public override bool IsInvalid => IntPtr.Zero == handle;

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CryptAcquireContextW(out SafeRsaProviderHandle hProv, [In] string pszContainer, [In] string pszProvider, [In] uint dwProvType, [In] uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CryptReleaseContext([In] IntPtr hProv, [In] uint dwFlags);

	public static SafeRsaProviderHandle Construct()
	{
		if (!CryptAcquireContextW(out var hProv, null, null, 24u, 4026531840u))
		{
			Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
			InfoCardTrace.CloseInvalidOutSafeHandle((SafeHandle)hProv);
			InfoCardTrace.TraceAndLogException((Exception)ex);
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new CommunicationException(ex.Message));
		}
		return hProv;
	}

	private SafeRsaProviderHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	protected override bool ReleaseHandle()
	{
		return CryptReleaseContext(handle, 0u);
	}
}
