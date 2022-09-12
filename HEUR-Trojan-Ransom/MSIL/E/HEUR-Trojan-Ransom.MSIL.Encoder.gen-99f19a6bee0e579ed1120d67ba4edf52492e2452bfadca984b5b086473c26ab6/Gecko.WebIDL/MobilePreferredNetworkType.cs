using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobilePreferredNetworkType
{
	[Description("wcdma/gsm")]
	wcdmagsm,
	[Description("gsm")]
	gsm,
	[Description("wcdma")]
	wcdma,
	[Description("wcdma/gsm-auto")]
	wcdmagsmauto,
	[Description("cdma/evdo")]
	cdmaevdo,
	[Description("cdma")]
	cdma,
	[Description("evdo")]
	evdo,
	[Description("wcdma/gsm/cdma/evdo")]
	wcdmagsmcdmaevdo,
	[Description("lte/cdma/evdo")]
	ltecdmaevdo,
	[Description("lte/wcdma/gsm")]
	ltewcdmagsm,
	[Description("lte/wcdma/gsm/cdma/evdo")]
	ltewcdmagsmcdmaevdo,
	[Description("lte")]
	lte,
	[Description("lte/wcdma")]
	ltewcdma
}
