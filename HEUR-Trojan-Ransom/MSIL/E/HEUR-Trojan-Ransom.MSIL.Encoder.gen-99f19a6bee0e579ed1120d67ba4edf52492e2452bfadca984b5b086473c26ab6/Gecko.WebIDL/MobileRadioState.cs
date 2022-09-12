using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileRadioState
{
	[Description("enabling")]
	enabling,
	[Description("enabled")]
	enabled,
	[Description("disabling")]
	disabling,
	[Description("disabled")]
	disabled
}
