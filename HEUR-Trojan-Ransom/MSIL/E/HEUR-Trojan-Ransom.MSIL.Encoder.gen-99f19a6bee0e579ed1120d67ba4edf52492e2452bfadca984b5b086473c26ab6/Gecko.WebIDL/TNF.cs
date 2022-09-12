using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TNF
{
	[Description("empty")]
	empty,
	[Description("well-known")]
	wellknown,
	[Description("media-type")]
	mediatype,
	[Description("absolute-uri")]
	absoluteuri,
	[Description("external")]
	external,
	[Description("unknown")]
	unknown,
	[Description("unchanged")]
	unchanged
}
