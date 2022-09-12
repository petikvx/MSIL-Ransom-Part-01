using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileNetworkType
{
	[Description("gsm")]
	gsm,
	[Description("wcdma")]
	wcdma,
	[Description("cdma")]
	cdma,
	[Description("evdo")]
	evdo,
	[Description("lte")]
	lte
}
