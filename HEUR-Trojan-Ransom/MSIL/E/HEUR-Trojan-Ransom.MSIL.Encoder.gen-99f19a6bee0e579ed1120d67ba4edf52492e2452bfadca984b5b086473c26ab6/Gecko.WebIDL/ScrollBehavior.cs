using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ScrollBehavior
{
	[Description("auto")]
	auto,
	[Description("instant")]
	instant,
	[Description("smooth")]
	smooth
}
