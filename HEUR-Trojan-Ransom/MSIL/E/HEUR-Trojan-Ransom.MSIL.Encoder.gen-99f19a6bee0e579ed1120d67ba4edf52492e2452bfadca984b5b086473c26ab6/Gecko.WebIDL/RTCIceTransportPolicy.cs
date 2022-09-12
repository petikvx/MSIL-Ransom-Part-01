using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCIceTransportPolicy
{
	[Description("none")]
	none,
	[Description("relay")]
	relay,
	[Description("all")]
	all
}
