using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileRoamingMode
{
	[Description("home")]
	home,
	[Description("affiliated")]
	affiliated,
	[Description("any")]
	any
}
