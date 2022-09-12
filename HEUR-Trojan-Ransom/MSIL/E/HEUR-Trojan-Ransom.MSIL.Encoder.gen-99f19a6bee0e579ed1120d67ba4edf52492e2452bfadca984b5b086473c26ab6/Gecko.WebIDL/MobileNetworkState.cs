using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileNetworkState
{
	[Description("available")]
	available,
	[Description("connected")]
	connected,
	[Description("forbidden")]
	forbidden
}
