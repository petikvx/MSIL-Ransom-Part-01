using System.ComponentModel;

namespace Gecko.WebIDL;

public enum AudioChannel
{
	[Description("normal")]
	normal,
	[Description("content")]
	content,
	[Description("notification")]
	notification,
	[Description("alarm")]
	alarm,
	[Description("telephony")]
	telephony,
	[Description("ringer")]
	ringer,
	[Description("publicnotification")]
	publicnotification,
	[Description("system")]
	system
}
