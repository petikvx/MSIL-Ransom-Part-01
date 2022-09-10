using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal abstract class SafeClusterHandle : SafeHandle
{
	public override bool IsInvalid
	{
		get
		{
			if (!base.IsClosed)
			{
				return handle == IntPtr.Zero;
			}
			return true;
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeClusterHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}
}
