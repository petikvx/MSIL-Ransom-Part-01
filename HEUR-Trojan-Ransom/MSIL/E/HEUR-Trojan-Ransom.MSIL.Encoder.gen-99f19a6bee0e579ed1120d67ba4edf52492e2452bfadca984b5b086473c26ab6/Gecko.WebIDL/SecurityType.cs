using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SecurityType
{
	[Description("open")]
	open,
	[Description("wpa-psk")]
	wpapsk,
	[Description("wpa2-psk")]
	wpa2psk
}
