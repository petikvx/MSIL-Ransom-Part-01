using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BluetoothDeviceAttribute
{
	[Description("unknown")]
	unknown,
	[Description("cod")]
	cod,
	[Description("name")]
	name,
	[Description("paired")]
	paired,
	[Description("uuids")]
	uuids
}
