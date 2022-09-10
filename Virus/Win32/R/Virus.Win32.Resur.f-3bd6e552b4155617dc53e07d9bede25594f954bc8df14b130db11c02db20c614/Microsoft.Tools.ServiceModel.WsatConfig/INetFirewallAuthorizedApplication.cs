using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("B5E64FFA-C2C5-444E-A301-FB5E00018050")]
[TypeLibType(4160)]
internal interface INetFirewallAuthorizedApplication
{
	[DispId(1)]
	string Name { get; set; }

	[DispId(2)]
	string ProcessImageFileName { get; set; }

	[DispId(3)]
	NetFirewallIPVersion IPVersion { get; set; }

	[DispId(4)]
	NetFirewallScope Scope { get; set; }

	[DispId(5)]
	string RemoteAddresses { get; set; }

	[DispId(6)]
	bool Enabled { get; set; }
}
