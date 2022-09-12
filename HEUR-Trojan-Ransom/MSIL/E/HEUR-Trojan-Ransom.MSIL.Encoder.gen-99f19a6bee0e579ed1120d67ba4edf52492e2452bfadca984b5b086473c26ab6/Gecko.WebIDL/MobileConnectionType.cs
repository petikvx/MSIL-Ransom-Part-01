using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileConnectionType
{
	[Description("gsm")]
	gsm,
	[Description("gprs")]
	gprs,
	[Description("edge")]
	edge,
	[Description("umts")]
	umts,
	[Description("hsdpa")]
	hsdpa,
	[Description("hsupa")]
	hsupa,
	[Description("hspa")]
	hspa,
	[Description("hspa+")]
	hspa7,
	[Description("is95a")]
	is95a,
	[Description("is95b")]
	is95b,
	[Description("1xrtt")]
	_1xrtt,
	[Description("evdo0")]
	evdo0,
	[Description("evdoa")]
	evdoa,
	[Description("evdob")]
	evdob,
	[Description("ehrpd")]
	ehrpd,
	[Description("lte")]
	lte
}
