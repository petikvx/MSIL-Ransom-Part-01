using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SafeRegistryKey : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeRegistryKey()
		: base(ownsHandle: false)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeRegistryKey(IntPtr preexistingHandle, bool ownsHandle)
		: base(ownsHandle)
	{
		SetHandle(preexistingHandle);
	}

	protected override bool ReleaseHandle()
	{
		int num = SafeNativeMethods.RegCloseKey(handle);
		return num == 0;
	}
}
