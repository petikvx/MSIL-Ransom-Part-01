using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct HttpServiceConfigUrlAclKey
{
	[MarshalAs(UnmanagedType.LPWStr)]
	internal string pUrlPrefix;

	internal HttpServiceConfigUrlAclKey(string urlPrefix)
	{
		pUrlPrefix = urlPrefix;
	}
}
