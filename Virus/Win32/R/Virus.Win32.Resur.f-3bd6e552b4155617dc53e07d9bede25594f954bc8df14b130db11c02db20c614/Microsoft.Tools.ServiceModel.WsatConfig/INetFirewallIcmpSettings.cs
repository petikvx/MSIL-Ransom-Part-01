using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

[ComImport]
[TypeLibType(4160)]
[Guid("A6207B2E-7CDD-426A-951E-5E1CBC5AFEAD")]
internal interface INetFirewallIcmpSettings
{
	[DispId(1)]
	bool AllowOutboundDestinationUnreachable { get; set; }

	[DispId(2)]
	bool AllowRedirect { get; set; }

	[DispId(3)]
	bool AllowInboundEchoRequest { get; set; }

	[DispId(4)]
	bool AllowOutboundTimeExceeded { get; set; }

	[DispId(5)]
	bool AllowOutboundParameterProblem { get; set; }

	[DispId(6)]
	bool AllowOutboundSourceQuench { get; set; }

	[DispId(7)]
	bool AllowInboundRouterRequest { get; set; }

	[DispId(8)]
	bool AllowInboundTimestampRequest { get; set; }

	[DispId(9)]
	bool AllowInboundMaskRequest { get; set; }

	[DispId(10)]
	bool AllowOutboundPacketTooBig { get; set; }
}
