using System;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace Alphaleonis.Win32.Filesystem;

[SecurityCritical]
internal sealed class SafeEncryptedFileRawHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeEncryptedFileRawHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeEncryptedFileRawHandle(IntPtr handle, bool callerHandle)
		: base(callerHandle)
	{
		SetHandle(handle);
	}

	protected override bool ReleaseHandle()
	{
		NativeMethods.CloseEncryptedFileRaw(handle);
		return true;
	}
}
