using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

internal class SafeKernelTransactionHandle : SafeHandleMinusOneIsInvalid
{
	public SafeKernelTransactionHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		return NativeMethods.CloseHandle(handle);
	}
}
