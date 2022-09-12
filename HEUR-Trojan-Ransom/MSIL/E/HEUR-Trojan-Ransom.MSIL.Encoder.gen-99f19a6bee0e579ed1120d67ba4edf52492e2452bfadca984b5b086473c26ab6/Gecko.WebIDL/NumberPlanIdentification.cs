using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NumberPlanIdentification
{
	[Description("unknown")]
	unknown,
	[Description("isdn")]
	isdn,
	[Description("data")]
	data,
	[Description("telex")]
	telex,
	[Description("national")]
	national,
	[Description("private")]
	@private
}
