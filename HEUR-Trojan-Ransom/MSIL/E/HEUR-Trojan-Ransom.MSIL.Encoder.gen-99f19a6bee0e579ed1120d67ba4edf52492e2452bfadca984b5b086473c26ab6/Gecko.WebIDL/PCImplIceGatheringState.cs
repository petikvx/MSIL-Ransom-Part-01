using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PCImplIceGatheringState
{
	[Description("new")]
	@new,
	[Description("gathering")]
	gathering,
	[Description("complete")]
	complete
}
