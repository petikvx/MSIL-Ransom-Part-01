using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SafeLocalAllocation : SafeHandleZeroOrMinusOneIsInvalid
{
	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeLocalAllocation(int size)
		: base(ownsHandle: true)
	{
		IntPtr intPtr = SafeNativeMethods.LocalAlloc(64, size);
		SetHandle(intPtr);
	}

	internal void Copy(byte[] source, int startIndex, int count)
	{
		Marshal.Copy(source, startIndex, handle, count);
	}

	protected override bool ReleaseHandle()
	{
		IntPtr intPtr = SafeNativeMethods.LocalFree(handle);
		return intPtr == IntPtr.Zero;
	}
}
