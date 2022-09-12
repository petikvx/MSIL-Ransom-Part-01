using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BluetoothDeviceType
{
	[Description("unknown")]
	unknown,
	[Description("classic")]
	classic,
	[Description("le")]
	le,
	[Description("dual")]
	dual
}
