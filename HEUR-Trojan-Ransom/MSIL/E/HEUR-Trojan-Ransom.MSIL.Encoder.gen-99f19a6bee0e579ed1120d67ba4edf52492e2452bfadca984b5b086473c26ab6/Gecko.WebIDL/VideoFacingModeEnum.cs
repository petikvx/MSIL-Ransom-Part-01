using System.ComponentModel;

namespace Gecko.WebIDL;

public enum VideoFacingModeEnum
{
	[Description("user")]
	user,
	[Description("environment")]
	environment,
	[Description("left")]
	left,
	[Description("right")]
	right
}
