using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ClientType
{
	[Description("window")]
	window,
	[Description("worker")]
	worker,
	[Description("sharedworker")]
	sharedworker,
	[Description("all")]
	all
}
