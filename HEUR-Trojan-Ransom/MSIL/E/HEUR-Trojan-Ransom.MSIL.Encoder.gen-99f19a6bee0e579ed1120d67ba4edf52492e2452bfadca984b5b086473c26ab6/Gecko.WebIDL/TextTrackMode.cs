using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TextTrackMode
{
	[Description("disabled")]
	disabled,
	[Description("hidden")]
	hidden,
	[Description("showing")]
	showing
}
