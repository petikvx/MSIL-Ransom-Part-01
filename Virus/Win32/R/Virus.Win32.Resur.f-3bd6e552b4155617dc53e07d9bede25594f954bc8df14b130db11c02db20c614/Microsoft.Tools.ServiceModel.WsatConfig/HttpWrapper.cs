using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
internal struct HttpWrapper
{
	internal static HttpApiVersion HttpApiVersion1 = new HttpApiVersion(1, 0);

	internal static HttpApiVersion HttpApiVersion2 = new HttpApiVersion(2, 0);
}
