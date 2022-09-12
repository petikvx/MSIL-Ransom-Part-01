using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MediaKeySystemStatus
{
	[Description("available")]
	available,
	[Description("api-disabled")]
	apidisabled,
	[Description("cdm-disabled")]
	cdmdisabled,
	[Description("cdm-not-supported")]
	cdmnotsupported,
	[Description("cdm-not-installed")]
	cdmnotinstalled,
	[Description("cdm-insufficient-version")]
	cdminsufficientversion,
	[Description("cdm-created")]
	cdmcreated,
	[Description("error")]
	error
}
