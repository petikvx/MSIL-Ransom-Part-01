using System.ComponentModel;

namespace Gecko.WebIDL;

public enum OrientationLockType
{
	[Description("any")]
	any,
	[Description("natural")]
	natural,
	[Description("landscape")]
	landscape,
	[Description("portrait")]
	portrait,
	[Description("portrait-primary")]
	portraitprimary,
	[Description("portrait-secondary")]
	portraitsecondary,
	[Description("landscape-primary")]
	landscapeprimary,
	[Description("landscape-secondary")]
	landscapesecondary
}
