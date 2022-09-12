using System.ComponentModel;

namespace Gecko.WebIDL;

public enum IccType
{
	[Description("sim")]
	sim,
	[Description("usim")]
	usim,
	[Description("csim")]
	csim,
	[Description("ruim")]
	ruim
}
