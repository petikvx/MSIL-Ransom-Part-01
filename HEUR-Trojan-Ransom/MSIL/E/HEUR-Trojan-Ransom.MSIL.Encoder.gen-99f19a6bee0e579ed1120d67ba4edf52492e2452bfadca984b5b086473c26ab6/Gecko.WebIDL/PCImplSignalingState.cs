using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PCImplSignalingState
{
	[Description("SignalingInvalid")]
	SignalingInvalid,
	[Description("SignalingStable")]
	SignalingStable,
	[Description("SignalingHaveLocalOffer")]
	SignalingHaveLocalOffer,
	[Description("SignalingHaveRemoteOffer")]
	SignalingHaveRemoteOffer,
	[Description("SignalingHaveLocalPranswer")]
	SignalingHaveLocalPranswer,
	[Description("SignalingHaveRemotePranswer")]
	SignalingHaveRemotePranswer,
	[Description("SignalingClosed")]
	SignalingClosed
}
