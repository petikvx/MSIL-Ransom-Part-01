using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BluetoothAdapterState
{
	[Description("disabled")]
	disabled,
	[Description("disabling")]
	disabling,
	[Description("enabled")]
	enabled,
	[Description("enabling")]
	enabling
}
