using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PCImplIceConnectionState
{
	[Description("new")]
	@new,
	[Description("checking")]
	checking,
	[Description("connected")]
	connected,
	[Description("completed")]
	completed,
	[Description("failed")]
	failed,
	[Description("disconnected")]
	disconnected,
	[Description("closed")]
	closed
}
