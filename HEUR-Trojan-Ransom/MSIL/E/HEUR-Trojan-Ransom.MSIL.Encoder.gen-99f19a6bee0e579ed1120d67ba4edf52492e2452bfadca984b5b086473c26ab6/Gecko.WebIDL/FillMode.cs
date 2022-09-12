using System.ComponentModel;

namespace Gecko.WebIDL;

public enum FillMode
{
	[Description("none")]
	none,
	[Description("forwards")]
	forwards,
	[Description("backwards")]
	backwards,
	[Description("both")]
	both,
	[Description("auto")]
	auto
}
