using System.ComponentModel;

namespace Gecko.WebIDL;

public enum DeviceStorageAreaChangedEventOperation
{
	[Description("added")]
	added,
	[Description("removed")]
	removed,
	[Description("unknown")]
	unknown
}
