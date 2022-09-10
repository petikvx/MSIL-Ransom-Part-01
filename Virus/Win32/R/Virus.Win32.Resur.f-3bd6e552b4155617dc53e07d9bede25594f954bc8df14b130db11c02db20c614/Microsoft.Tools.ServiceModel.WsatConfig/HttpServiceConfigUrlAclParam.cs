using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct HttpServiceConfigUrlAclParam
{
	[MarshalAs(UnmanagedType.LPWStr)]
	internal string pStringSecurityDescriptor;

	internal HttpServiceConfigUrlAclParam(string securityDescriptor)
	{
		pStringSecurityDescriptor = securityDescriptor;
	}
}
