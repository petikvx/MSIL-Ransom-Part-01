using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TetheringType
{
	[Description("bluetooth")]
	bluetooth,
	[Description("usb")]
	usb,
	[Description("wifi")]
	wifi
}
