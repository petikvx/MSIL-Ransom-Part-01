using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IccLockType
{
	[Description("pin")]
	pin,
	[Description("pin2")]
	pin2,
	[Description("puk")]
	puk,
	[Description("puk2")]
	puk2,
	[Description("nck")]
	nck,
	[Description("nsck")]
	nsck,
	[Description("nck1")]
	nck1,
	[Description("nck2")]
	nck2,
	[Description("hnck")]
	hnck,
	[Description("cck")]
	cck,
	[Description("spck")]
	spck,
	[Description("pck")]
	pck,
	[Description("rcck")]
	rcck,
	[Description("rspck")]
	rspck,
	[Description("nckPuk")]
	nckPuk,
	[Description("nsckPuk")]
	nsckPuk,
	[Description("nck1Puk")]
	nck1Puk,
	[Description("nck2Puk")]
	nck2Puk,
	[Description("hnckPuk")]
	hnckPuk,
	[Description("cckPuk")]
	cckPuk,
	[Description("spckPuk")]
	spckPuk,
	[Description("pckPuk")]
	pckPuk,
	[Description("rcckPuk")]
	rcckPuk,
	[Description("rspckPuk")]
	rspckPuk,
	[Description("fdn")]
	fdn
}
