using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TCPReadyState
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
