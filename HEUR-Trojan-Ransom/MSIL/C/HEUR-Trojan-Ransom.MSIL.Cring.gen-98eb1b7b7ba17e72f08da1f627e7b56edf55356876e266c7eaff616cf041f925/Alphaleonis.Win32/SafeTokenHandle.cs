using System;
using System.Security;
using Alphaleonis.Win32.Filesystem;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32;

[SecurityCritical]
public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	public SafeTokenHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeTokenHandle(IntPtr handle, bool callerHandle)
		: base(callerHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.CloseHandle(handle);
	}
}
