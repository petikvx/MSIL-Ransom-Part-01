using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCStatsIceCandidateType
{
	[Description("host")]
	host,
	[Description("serverreflexive")]
	serverreflexive,
	[Description("peerreflexive")]
	peerreflexive,
	[Description("relayed")]
	relayed
}
