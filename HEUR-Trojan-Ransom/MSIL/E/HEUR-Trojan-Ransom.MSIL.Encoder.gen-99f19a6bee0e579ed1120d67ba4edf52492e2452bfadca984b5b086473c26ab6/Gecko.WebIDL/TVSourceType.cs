using System.ComponentModel;

namespace Gecko.WebIDL;

public enum TVSourceType
{
	[Description("dvb-t")]
	dvbt,
	[Description("dvb-t2")]
	dvbt2,
	[Description("dvb-c")]
	dvbc,
	[Description("dvb-c2")]
	dvbc2,
	[Description("dvb-s")]
	dvbs,
	[Description("dvb-s2")]
	dvbs2,
	[Description("dvb-h")]
	dvbh,
	[Description("dvb-sh")]
	dvbsh,
	[Description("atsc")]
	atsc,
	[Description("atsc-m/h")]
	atscmh,
	[Description("isdb-t")]
	isdbt,
	[Description("isdb-tb")]
	isdbtb,
	[Description("isdb-s")]
	isdbs,
	[Description("isdb-c")]
	isdbc,
	[Description("1seg")]
	_1seg,
	[Description("dtmb")]
	dtmb,
	[Description("cmmb")]
	cmmb,
	[Description("t-dmb")]
	tdmb,
	[Description("s-dmb")]
	sdmb
}
