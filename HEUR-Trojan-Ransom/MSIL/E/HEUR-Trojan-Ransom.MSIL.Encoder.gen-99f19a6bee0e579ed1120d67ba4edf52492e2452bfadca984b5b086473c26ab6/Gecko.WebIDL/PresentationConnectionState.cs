using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PresentationConnectionState
{
	[Description("connected")]
	connected,
	[Description("closed")]
	closed,
	[Description("terminated")]
	terminated
}
