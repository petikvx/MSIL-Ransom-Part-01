using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SessionType
{
	[Description("temporary")]
	temporary,
	[Description("persistent")]
	persistent
}
