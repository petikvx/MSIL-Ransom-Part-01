using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ChannelCountMode
{
	[Description("max")]
	max,
	[Description("clamped-max")]
	clampedmax,
	[Description("explicit")]
	@explicit
}
