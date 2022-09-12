using System.ComponentModel;

namespace Gecko.WebIDL;

public enum AutoCompleteErrorReason
{
	[Description("cancel")]
	cancel,
	[Description("disabled")]
	disabled,
	[Description("invalid")]
	invalid
}
