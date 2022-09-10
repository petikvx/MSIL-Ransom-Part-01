using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[Guid("D46D2478-9AC9-4008-9DC7-5563CE5536CC")]
[TypeLibType(4160)]
internal interface INetFirewallPolicy
{
	[DispId(1)]
	INetFirewallProfile CurrentProfile { get; }

	[DispId(2)]
	INetFirewallProfile GetProfileByType([MarshalAs(UnmanagedType.Interface)] NetFirewallProfileType profileType);
}
