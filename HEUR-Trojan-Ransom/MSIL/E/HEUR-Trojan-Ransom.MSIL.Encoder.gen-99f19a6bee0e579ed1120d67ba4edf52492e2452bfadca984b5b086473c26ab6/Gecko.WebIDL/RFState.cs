using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RFState
{
	[Description("idle")]
	idle,
	[Description("listen")]
	listen,
	[Description("discovery")]
	discovery
}
