using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaKeyStatus
{
	[Description("usable")]
	usable,
	[Description("expired")]
	expired,
	[Description("released")]
	released,
	[Description("output-restricted")]
	outputrestricted,
	[Description("output-downscaled")]
	outputdownscaled,
	[Description("status-pending")]
	statuspending,
	[Description("internal-error")]
	internalerror
}
