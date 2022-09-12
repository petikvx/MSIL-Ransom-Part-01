using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCIceGatheringState
{
	[Description("new")]
	@new,
	[Description("gathering")]
	gathering,
	[Description("complete")]
	complete
}
