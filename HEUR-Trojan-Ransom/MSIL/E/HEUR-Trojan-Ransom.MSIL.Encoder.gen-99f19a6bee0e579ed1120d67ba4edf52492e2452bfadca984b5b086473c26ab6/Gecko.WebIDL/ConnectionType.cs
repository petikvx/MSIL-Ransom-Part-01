using System.ComponentModel;

namespace Gecko.WebIDL;

public enum ConnectionType
{
	[Description("cellular")]
	cellular,
	[Description("bluetooth")]
	bluetooth,
	[Description("ethernet")]
	ethernet,
	[Description("wifi")]
	wifi,
	[Description("other")]
	other,
	[Description("none")]
	none,
	[Description("unknown")]
	unknown
}
