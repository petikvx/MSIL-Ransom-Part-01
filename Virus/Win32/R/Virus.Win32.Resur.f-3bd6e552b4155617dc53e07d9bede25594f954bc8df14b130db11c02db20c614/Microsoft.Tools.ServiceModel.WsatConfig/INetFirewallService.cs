using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("79FD57C8-908E-4A36-9888-D5B3F0A444CF")]
[TypeLibType(4160)]
internal interface INetFirewallService
{
	[DispId(1)]
	string Name { get; }

	[DispId(2)]
	NetFirewallServiceType Type { get; }

	[DispId(3)]
	bool Customized { get; }

	[DispId(4)]
	NetFirewallIPVersion IPVersion { get; set; }

	[DispId(5)]
	NetFirewallScope Scope { get; set; }

	[DispId(6)]
	string RemoteAddresses { get; set; }

	[DispId(7)]
	bool Enabled { get; set; }

	[DispId(8)]
	INetFirewallOpenPortsCollection GloballyOpenPorts { get; }
}
