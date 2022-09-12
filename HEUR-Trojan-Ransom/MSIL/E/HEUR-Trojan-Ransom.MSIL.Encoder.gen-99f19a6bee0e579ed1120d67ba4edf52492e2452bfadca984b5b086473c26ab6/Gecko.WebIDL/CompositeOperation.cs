using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CompositeOperation
{
	[Description("replace")]
	replace,
	[Description("add")]
	add,
	[Description("accumulate")]
	accumulate
}
