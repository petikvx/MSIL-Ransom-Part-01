using System;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.InfoCards;

internal sealed class SafeNativeHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private SafeNativeHandle()
		: base(ownsHandle: true)
	{
	}

	public SafeNativeHandle(IntPtr existingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(existingHandle);
	}

	protected override bool ReleaseHandle()
	{
		return NativeMethods.SafeHandleOnlyMethods.CloseHandle(handle);
	}
}
