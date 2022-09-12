using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCStatsType
{
	[Description("inboundrtp")]
	inboundrtp,
	[Description("outboundrtp")]
	outboundrtp,
	[Description("session")]
	session,
	[Description("track")]
	track,
	[Description("transport")]
	transport,
	[Description("candidatepair")]
	candidatepair,
	[Description("localcandidate")]
	localcandidate,
	[Description("remotecandidate")]
	remotecandidate
}
