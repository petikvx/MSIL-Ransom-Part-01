using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ResponseType
{
	[Description("basic")]
	basic,
	[Description("cors")]
	cors,
	[Description("default")]
	@default,
	[Description("error")]
	error,
	[Description("opaque")]
	opaque,
	[Description("opaqueredirect")]
	opaqueredirect
}
