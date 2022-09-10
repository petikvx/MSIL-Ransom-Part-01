using System.Collections;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[TypeLibType(4160)]
[Guid("79649BB4-903E-421B-94C9-79848E79F6EE")]
internal interface INetFirewallServicesCollection : IEnumerable
{
	[DispId(1)]
	int Count { get; }

	[DispId(2)]
	INetFirewallService Item([MarshalAs(UnmanagedType.Interface)] NetFirewallServiceType serviceType);

	[DispId(-4)]
	[TypeLibFunc(1)]
	new IEnumerator GetEnumerator();
}
