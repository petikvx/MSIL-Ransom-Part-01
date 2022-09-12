using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IccMvnoType
{
	[Description("imsi")]
	imsi,
	[Description("spn")]
	spn,
	[Description("gid")]
	gid
}
