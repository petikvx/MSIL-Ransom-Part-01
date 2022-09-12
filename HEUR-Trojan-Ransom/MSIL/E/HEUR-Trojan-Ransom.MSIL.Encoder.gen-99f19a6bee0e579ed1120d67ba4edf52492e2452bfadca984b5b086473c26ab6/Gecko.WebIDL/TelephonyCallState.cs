using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TelephonyCallState
{
	[Description("dialing")]
	dialing,
	[Description("alerting")]
	alerting,
	[Description("connected")]
	connected,
	[Description("held")]
	held,
	[Description("disconnected")]
	disconnected,
	[Description("incoming")]
	incoming
}
