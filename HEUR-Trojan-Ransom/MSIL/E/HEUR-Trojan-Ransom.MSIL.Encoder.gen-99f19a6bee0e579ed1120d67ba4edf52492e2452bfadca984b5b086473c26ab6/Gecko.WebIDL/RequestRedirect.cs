using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestRedirect
{
	[Description("follow")]
	follow,
	[Description("error")]
	error,
	[Description("manual")]
	manual
}
