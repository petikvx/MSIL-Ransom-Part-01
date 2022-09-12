using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ConnectionStatus
{
	[Description("connecting")]
	connecting,
	[Description("authenticating")]
	authenticating,
	[Description("associated")]
	associated,
	[Description("connected")]
	connected,
	[Description("disconnected")]
	disconnected,
	[Description("wps-timedout")]
	wpstimedout,
	[Description("wps-failed")]
	wpsfailed,
	[Description("wps-overlapped")]
	wpsoverlapped,
	[Description("connectingfailed")]
	connectingfailed
}
