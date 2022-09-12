using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PromiseDebuggingState
{
	[Description("pending")]
	pending,
	[Description("fulfilled")]
	fulfilled,
	[Description("rejected")]
	rejected
}
