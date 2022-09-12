using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaSourceEndOfStreamError
{
	[Description("network")]
	network,
	[Description("decode")]
	decode
}
