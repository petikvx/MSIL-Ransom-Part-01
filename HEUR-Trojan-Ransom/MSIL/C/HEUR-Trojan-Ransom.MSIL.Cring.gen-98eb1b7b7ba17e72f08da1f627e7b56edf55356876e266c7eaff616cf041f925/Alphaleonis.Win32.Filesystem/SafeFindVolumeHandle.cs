using System;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SecurityCritical]
public sealed class SafeFindVolumeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeFindVolumeHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeFindVolumeHandle(IntPtr handle, bool callerHandle)
		: base(callerHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.FindVolumeClose(handle);
	}
}
