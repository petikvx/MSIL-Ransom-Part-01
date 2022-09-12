using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BluetoothConnectionState
{
	[Description("disconnected")]
	disconnected,
	[Description("disconnecting")]
	disconnecting,
	[Description("connected")]
	connected,
	[Description("connecting")]
	connecting
}
