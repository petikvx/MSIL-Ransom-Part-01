using System.ComponentModel;

namespace Gecko.WebIDL;

public enum Priority
{
	[Description("no-filtering")]
	nofiltering,
	[Description("high-priority")]
	highpriority,
	[Description("non-priority")]
	nonpriority
}
