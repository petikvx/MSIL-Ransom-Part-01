using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BluetoothAdapterAttribute
{
	[Description("unknown")]
	unknown,
	[Description("state")]
	state,
	[Description("address")]
	address,
	[Description("name")]
	name,
	[Description("discoverable")]
	discoverable,
	[Description("discovering")]
	discovering
}
