using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TVChannelType
{
	[Description("tv")]
	tv,
	[Description("radio")]
	radio,
	[Description("data")]
	data
}
