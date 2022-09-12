using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PlaybackDirection
{
	[Description("normal")]
	normal,
	[Description("reverse")]
	reverse,
	[Description("alternate")]
	alternate,
	[Description("alternate-reverse")]
	alternatereverse
}
