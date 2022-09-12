using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCStatsIceCandidatePairState
{
	[Description("frozen")]
	frozen,
	[Description("waiting")]
	waiting,
	[Description("inprogress")]
	inprogress,
	[Description("failed")]
	failed,
	[Description("succeeded")]
	succeeded,
	[Description("cancelled")]
	cancelled
}
