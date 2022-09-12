using System.ComponentModel;

namespace Gecko.WebIDL;

public enum NfcErrorMessage
{
	[Description("IOError")]
	IOError,
	[Description("Timeout")]
	Timeout,
	[Description("Busy")]
	Busy,
	[Description("ErrorConnect")]
	ErrorConnect,
	[Description("ErrorDisconnect")]
	ErrorDisconnect,
	[Description("ErrorRead")]
	ErrorRead,
	[Description("ErrorWrite")]
	ErrorWrite,
	[Description("InvalidParameter")]
	InvalidParameter,
	[Description("InsufficientResource")]
	InsufficientResource,
	[Description("ErrorSocketCreation")]
	ErrorSocketCreation,
	[Description("FailEnableDiscovery")]
	FailEnableDiscovery,
	[Description("FailDisableDiscovery")]
	FailDisableDiscovery,
	[Description("NotInitialize")]
	NotInitialize,
	[Description("InitializeFail")]
	InitializeFail,
	[Description("DeinitializeFail")]
	DeinitializeFail,
	[Description("NotSupport")]
	NotSupport,
	[Description("FailEnableLowPowerMode")]
	FailEnableLowPowerMode,
	[Description("FailDisableLowPowerMode")]
	FailDisableLowPowerMode
}
