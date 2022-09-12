using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NfcNotificationType
{
	[Description("initialized")]
	initialized,
	[Description("techDiscovered")]
	techDiscovered,
	[Description("techLost")]
	techLost,
	[Description("hciEventTransaction")]
	hciEventTransaction,
	[Description("ndefReceived")]
	ndefReceived
}
