using System.ComponentModel;

namespace Gecko.WebIDL;

public enum WifiSecurityMethod
{
	[Description("OPEN")]
	OPEN,
	[Description("WEP")]
	WEP,
	[Description("WPA-PSK")]
	WPAPSK,
	[Description("WPA-EAP")]
	WPAEAP
}
