using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PCObserverStateType
{
	[Description("None")]
	None,
	[Description("IceConnectionState")]
	IceConnectionState,
	[Description("IceGatheringState")]
	IceGatheringState,
	[Description("SdpState")]
	SdpState,
	[Description("SipccState")]
	SipccState,
	[Description("SignalingState")]
	SignalingState
}
