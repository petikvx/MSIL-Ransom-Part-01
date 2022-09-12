using System.ComponentModel;

namespace Gecko.WebIDL;

public enum FrameType
{
	[Description("auxiliary")]
	auxiliary,
	[Description("top-level")]
	toplevel,
	[Description("nested")]
	nested,
	[Description("none")]
	none
}
