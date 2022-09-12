using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaSourceEnum
{
	[Description("camera")]
	camera,
	[Description("screen")]
	screen,
	[Description("application")]
	application,
	[Description("window")]
	window,
	[Description("browser")]
	browser,
	[Description("microphone")]
	microphone,
	[Description("audioCapture")]
	audioCapture,
	[Description("other")]
	other
}
