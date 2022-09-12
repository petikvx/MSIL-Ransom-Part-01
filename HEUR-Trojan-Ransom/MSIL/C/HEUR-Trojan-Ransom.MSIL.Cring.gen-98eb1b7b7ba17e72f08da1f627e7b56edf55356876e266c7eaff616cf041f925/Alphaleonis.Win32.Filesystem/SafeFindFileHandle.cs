using System;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SecurityCritical]
public sealed class SafeFindFileHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeFindFileHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeFindFileHandle(IntPtr handle, bool callerHandle)
		: base(callerHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.FindClose(handle);
	}
}
