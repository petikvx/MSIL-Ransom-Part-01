using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCDataChannelState
{
	[Description("connecting")]
	connecting,
	[Description("open")]
	open,
	[Description("closing")]
	closing,
	[Description("closed")]
	closed
}
