using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NotificationDirection
{
	[Description("auto")]
	auto,
	[Description("ltr")]
	ltr,
	[Description("rtl")]
	rtl
}
