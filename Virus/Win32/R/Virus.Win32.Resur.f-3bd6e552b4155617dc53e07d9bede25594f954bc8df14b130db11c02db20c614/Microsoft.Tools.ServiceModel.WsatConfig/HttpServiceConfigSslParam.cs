using System;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct HttpServiceConfigSslParam
{
	internal int SslHashLength;

	internal SafeLocalAllocation pSslHash;

	internal Guid AppId;

	[MarshalAs(UnmanagedType.LPWStr)]
	internal string pSslCertStoreName;

	internal int DefaultCertCheckMode;

	internal int DefaultRevocationFreshnessTime;

	internal int DefaultRevocationUrlRetrievalTimeout;

	[MarshalAs(UnmanagedType.LPWStr)]
	internal string pDefaultSslCtlIdentifier;

	[MarshalAs(UnmanagedType.LPWStr)]
	internal string pDefaultSslCtlStoreName;

	internal int DefaultFlags;
}
