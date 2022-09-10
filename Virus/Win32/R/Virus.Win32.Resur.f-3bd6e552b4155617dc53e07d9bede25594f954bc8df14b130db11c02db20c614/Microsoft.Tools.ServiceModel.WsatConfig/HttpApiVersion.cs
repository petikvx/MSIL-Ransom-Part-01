using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal struct HttpApiVersion
{
	internal ushort HttpApiMajorVersion;

	internal ushort HttpApiMinorVersion;

	internal HttpApiVersion(ushort majorVersion, ushort minorVersion)
	{
		HttpApiMajorVersion = majorVersion;
		HttpApiMinorVersion = minorVersion;
	}
}
