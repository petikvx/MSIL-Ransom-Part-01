using System.Security;
using Microsoft.Win32.SafeHandles;

namespace System.Runtime.Caching;

[SecurityCritical]
internal class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	internal SafeRegistryHandle()
		: base(ownsHandle: true)
	{
	}

	[SecurityCritical]
	protected override bool ReleaseHandle()
	{
		int num = UnsafeNativeMethods.RegCloseKey(handle);
		return num == 0;
	}
}
