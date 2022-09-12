using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ReadStatus
{
	[Description("no-filtering")]
	nofiltering,
	[Description("unread")]
	unread,
	[Description("read")]
	read
}
