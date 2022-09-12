using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CallIdPresentation
{
	[Description("allowed")]
	allowed,
	[Description("restricted")]
	restricted,
	[Description("payphone")]
	payphone,
	[Description("unknown")]
	unknown
}
