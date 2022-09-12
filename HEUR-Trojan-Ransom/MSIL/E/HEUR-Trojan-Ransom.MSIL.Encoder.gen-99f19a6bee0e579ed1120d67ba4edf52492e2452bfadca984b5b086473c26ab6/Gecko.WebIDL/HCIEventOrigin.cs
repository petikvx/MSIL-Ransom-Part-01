using System.ComponentModel;

namespace Gecko.WebIDL;

public enum HCIEventOrigin
{
	[Description("SIM")]
	SIM,
	[Description("eSE")]
	eSE,
	[Description("ASSD")]
	ASSD
}
