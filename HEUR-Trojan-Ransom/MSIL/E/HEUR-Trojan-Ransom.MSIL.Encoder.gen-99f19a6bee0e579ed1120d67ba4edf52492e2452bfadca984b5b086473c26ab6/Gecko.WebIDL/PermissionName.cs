using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PermissionName
{
	[Description("geolocation")]
	geolocation,
	[Description("notifications")]
	notifications,
	[Description("push")]
	push,
	[Description("midi")]
	midi
}
