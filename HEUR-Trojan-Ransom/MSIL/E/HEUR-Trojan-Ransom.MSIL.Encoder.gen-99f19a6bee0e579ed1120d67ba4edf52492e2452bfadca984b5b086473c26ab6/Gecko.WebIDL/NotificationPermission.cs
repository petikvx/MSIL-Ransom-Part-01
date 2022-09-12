using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NotificationPermission
{
	[Description("default")]
	@default,
	[Description("denied")]
	denied,
	[Description("granted")]
	granted
}
