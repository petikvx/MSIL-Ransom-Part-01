using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("F7898AF5-CAC4-4632-A2EC-DA06E5111AF2")]
[TypeLibType(4160)]
internal interface INetFirewallMgr
{
	[DispId(1)]
	INetFirewallPolicy LocalPolicy { get; }

	[DispId(2)]
	NetFirewallProfileType CurrentProfileType { get; }

	[DispId(3)]
	void RestoreDefaults();

	[DispId(4)]
	void IsPortAllowed([MarshalAs(UnmanagedType.BStr)] string imageFileName, NetFirewallIPVersion ipVersion, int portNumber, [MarshalAs(UnmanagedType.BStr)] string localAddress, NetFirewallIPProtocol ipProtocol, [MarshalAs(UnmanagedType.Struct)] ref object allowed, [MarshalAs(UnmanagedType.Struct)] ref object restricted);

	[DispId(5)]
	void IsIcmpTypeAllowed(NetFirewallIPVersion ipVersion, [MarshalAs(UnmanagedType.BStr)] string localAddress, byte type, [MarshalAs(UnmanagedType.Struct)] ref INetFirewallIcmpSettings allowed, [MarshalAs(UnmanagedType.Struct)] ref object restricted);
}
