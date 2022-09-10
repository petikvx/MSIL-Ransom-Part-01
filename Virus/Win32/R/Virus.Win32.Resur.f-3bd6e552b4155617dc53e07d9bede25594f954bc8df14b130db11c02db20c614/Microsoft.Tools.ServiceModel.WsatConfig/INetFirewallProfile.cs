using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[TypeLibType(4160)]
[Guid("174A0DDA-E9F9-449D-993B-21AB667CA456")]
internal interface INetFirewallProfile
{
	[DispId(1)]
	NetFirewallProfileType Type { get; }

	[DispId(2)]
	bool FirewallEnabled { get; set; }

	[DispId(3)]
	bool ExceptionsNotAllowed { get; set; }

	[DispId(4)]
	bool NotificationsDisabled { get; set; }

	[DispId(5)]
	bool UnicastResponsesToMulticastBroadcastDisabled { get; set; }

	[DispId(6)]
	INetFirewallRemoteAdminSettings RemoteAdminSettings { get; }

	[DispId(7)]
	INetFirewallIcmpSettings IcmpSettings { get; }

	[DispId(8)]
	INetFirewallOpenPortsCollection GloballyOpenPorts { get; }

	[DispId(9)]
	INetFirewallServicesCollection Services { get; }

	[DispId(10)]
	INetFirewallAuthorizedApplicationsCollection AuthorizedApplications { get; }
}
