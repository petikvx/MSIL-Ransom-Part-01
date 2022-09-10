using System.Collections;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("C0E9D7FA-E07E-430A-B19A-090CE82D92E2")]
[TypeLibType(4160)]
internal interface INetFirewallOpenPortsCollection : IEnumerable
{
	[DispId(1)]
	int Count { get; }

	[DispId(2)]
	void Add([MarshalAs(UnmanagedType.Interface)] INetFirewallOpenPort port);

	[DispId(3)]
	void Remove(int portNumber, NetFirewallIPProtocol ipProtocol);

	[DispId(4)]
	INetFirewallOpenPort Item([MarshalAs(UnmanagedType.Interface)] int port, NetFirewallIPProtocol portNumber);

	[TypeLibFunc(1)]
	[DispId(-4)]
	new IEnumerator GetEnumerator();
}
