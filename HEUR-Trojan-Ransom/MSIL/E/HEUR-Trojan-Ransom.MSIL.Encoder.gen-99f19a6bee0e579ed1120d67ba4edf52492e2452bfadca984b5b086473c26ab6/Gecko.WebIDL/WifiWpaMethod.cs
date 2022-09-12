using System.ComponentModel;

namespace Gecko.WebIDL;

public enum WifiWpaMethod
{
	[Description("SIM")]
	SIM,
	[Description("PEAP")]
	PEAP,
	[Description("TTLS")]
	TTLS,
	[Description("TLS")]
	TLS
}
