using System.ComponentModel;

namespace Gecko.WebIDL;

public enum StorageType
{
	[Description("persistent")]
	persistent,
	[Description("temporary")]
	temporary,
	[Description("default")]
	@default
}
