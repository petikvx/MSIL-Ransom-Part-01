using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCSignalingState
{
	[Description("stable")]
	stable,
	[Description("have-local-offer")]
	havelocaloffer,
	[Description("have-remote-offer")]
	haveremoteoffer,
	[Description("have-local-pranswer")]
	havelocalpranswer,
	[Description("have-remote-pranswer")]
	haveremotepranswer,
	[Description("closed")]
	closed
}
