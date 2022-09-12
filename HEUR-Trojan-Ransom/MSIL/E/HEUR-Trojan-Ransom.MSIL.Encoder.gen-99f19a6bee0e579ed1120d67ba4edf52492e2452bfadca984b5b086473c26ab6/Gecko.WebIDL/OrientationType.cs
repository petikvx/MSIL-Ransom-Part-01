using System.ComponentModel;

namespace Gecko.WebIDL;

public enum OrientationType
{
	[Description("portrait-primary")]
	portraitprimary,
	[Description("portrait-secondary")]
	portraitsecondary,
	[Description("landscape-primary")]
	landscapeprimary,
	[Description("landscape-secondary")]
	landscapesecondary
}
