using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaSourceReadyState
{
	[Description("closed")]
	closed,
	[Description("open")]
	open,
	[Description("ended")]
	ended
}
