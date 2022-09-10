using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[TypeLibType(4160)]
[Guid("D4BECDDF-6F73-4A83-B832-9C66874CD20E")]
internal interface INetFirewallRemoteAdminSettings
{
	[DispId(1)]
	NetFirewallIPVersion IPVersion { get; set; }

	[DispId(2)]
	NetFirewallScope Scope { get; set; }

	[DispId(3)]
	string RemoteAddresses { get; set; }

	[DispId(4)]
	bool Enabled { get; set; }
}
