using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SocketReadyState
{
	[Description("opening")]
	opening,
	[Description("open")]
	open,
	[Description("closing")]
	closing,
	[Description("closed")]
	closed,
	[Description("halfclosed")]
	halfclosed
}
