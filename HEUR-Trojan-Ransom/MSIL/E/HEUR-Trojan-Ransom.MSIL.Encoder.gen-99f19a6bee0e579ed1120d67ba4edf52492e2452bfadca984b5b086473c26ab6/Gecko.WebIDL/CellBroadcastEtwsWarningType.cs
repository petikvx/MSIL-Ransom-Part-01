using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CellBroadcastEtwsWarningType
{
	[Description("earthquake")]
	earthquake,
	[Description("tsunami")]
	tsunami,
	[Description("earthquake-tsunami")]
	earthquaketsunami,
	[Description("test")]
	test,
	[Description("other")]
	other
}
