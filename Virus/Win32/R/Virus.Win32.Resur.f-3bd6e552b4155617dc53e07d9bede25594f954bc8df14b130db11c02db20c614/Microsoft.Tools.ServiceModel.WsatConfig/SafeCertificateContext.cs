using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SafeCertificateContext : SafeHandleZeroOrMinusOneIsInvalid
{
	public override bool IsInvalid => handle == IntPtr.Zero;

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal SafeCertificateContext()
		: base(ownsHandle: false)
	{
	}

	protected override bool ReleaseHandle()
	{
		int num = SafeNativeMethods.CertFreeCertificateContext(handle);
		return num == 0;
	}

	internal X509Certificate2 GetNewX509Certificate()
	{
		return new X509Certificate2(handle);
	}
}
