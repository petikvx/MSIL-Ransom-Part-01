using System.ComponentModel;

namespace Gecko.WebIDL;

public enum AudioContextState
{
	[Description("suspended")]
	suspended,
	[Description("running")]
	running,
	[Description("closed")]
	closed
}
