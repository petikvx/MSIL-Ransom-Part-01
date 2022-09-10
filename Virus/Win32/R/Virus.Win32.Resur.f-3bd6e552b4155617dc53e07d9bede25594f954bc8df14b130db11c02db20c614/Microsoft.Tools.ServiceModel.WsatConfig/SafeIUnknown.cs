using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SafeIUnknown : SafeHandle
{
	public override bool IsInvalid
	{
		get
		{
			if (!base.IsClosed)
			{
				return IntPtr.Zero == handle;
			}
			return true;
		}
	}

	internal SafeIUnknown()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	internal SafeIUnknown(IntPtr unknown)
		: base(IntPtr.Zero, ownsHandle: true)
	{
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
		}
		finally
		{
			handle = unknown;
		}
	}

	protected override bool ReleaseHandle()
	{
		IntPtr intPtr = handle;
		handle = IntPtr.Zero;
		if (IntPtr.Zero != intPtr)
		{
			Marshal.Release(intPtr);
		}
		return true;
	}
}
