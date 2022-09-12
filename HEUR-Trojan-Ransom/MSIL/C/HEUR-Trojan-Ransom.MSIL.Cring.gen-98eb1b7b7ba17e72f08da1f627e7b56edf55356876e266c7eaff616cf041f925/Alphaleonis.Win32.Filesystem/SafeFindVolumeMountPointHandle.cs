using System;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SecurityCritical]
internal sealed class SafeFindVolumeMountPointHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeFindVolumeMountPointHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeFindVolumeMountPointHandle(IntPtr handle, bool callerHandle)
		: base(callerHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.FindVolumeMountPointClose(handle);
	}
}
