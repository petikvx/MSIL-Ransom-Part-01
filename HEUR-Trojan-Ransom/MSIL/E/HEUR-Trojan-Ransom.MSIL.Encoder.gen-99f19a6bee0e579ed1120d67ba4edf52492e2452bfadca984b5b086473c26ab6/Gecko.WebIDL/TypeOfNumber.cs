using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TypeOfNumber
{
	[Description("unknown")]
	unknown,
	[Description("international")]
	international,
	[Description("national")]
	national,
	[Description("network-specific")]
	networkspecific,
	[Description("dedicated-access-short-code")]
	dedicatedaccessshortcode
}
