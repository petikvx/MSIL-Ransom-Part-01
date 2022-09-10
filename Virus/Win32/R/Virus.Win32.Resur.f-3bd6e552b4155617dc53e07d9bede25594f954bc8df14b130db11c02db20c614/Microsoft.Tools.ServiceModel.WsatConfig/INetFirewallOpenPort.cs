using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("E0483BA0-47FF-4D9C-A6D6-7741D0B195F7")]
[TypeLibType(4160)]
internal interface INetFirewallOpenPort
{
	[DispId(1)]
	string Name { get; set; }

	[DispId(2)]
	NetFirewallIPVersion IPVersion { get; set; }

	[DispId(3)]
	NetFirewallIPProtocol Protocol { get; set; }

	[DispId(4)]
	int Port { get; set; }

	[DispId(5)]
	NetFirewallScope Scope { get; set; }

	[DispId(6)]
	string RemoteAddresses { get; set; }

	[DispId(7)]
	bool Enabled { get; set; }

	[DispId(8)]
	bool BuiltIn { get; }
}
