using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaDeviceKind
{
	[Description("audioinput")]
	audioinput,
	[Description("audiooutput")]
	audiooutput,
	[Description("videoinput")]
	videoinput
}
