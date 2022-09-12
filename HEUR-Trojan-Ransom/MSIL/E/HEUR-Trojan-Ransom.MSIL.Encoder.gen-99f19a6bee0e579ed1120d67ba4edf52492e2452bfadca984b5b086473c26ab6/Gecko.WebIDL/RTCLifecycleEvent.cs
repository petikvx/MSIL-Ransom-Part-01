using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCLifecycleEvent
{
	[Description("initialized")]
	initialized,
	[Description("icegatheringstatechange")]
	icegatheringstatechange,
	[Description("iceconnectionstatechange")]
	iceconnectionstatechange
}
