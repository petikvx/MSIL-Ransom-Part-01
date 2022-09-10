using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SafeCertificateStore : SafeHandleZeroOrMinusOneIsInvalid
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	private SafeCertificateStore()
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		return SafeNativeMethods.CertCloseStore(handle, 0);
	}
}
