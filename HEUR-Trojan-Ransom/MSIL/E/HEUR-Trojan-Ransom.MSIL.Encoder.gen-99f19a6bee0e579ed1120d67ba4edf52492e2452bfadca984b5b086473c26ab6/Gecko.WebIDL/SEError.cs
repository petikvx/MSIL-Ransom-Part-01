using System.ComponentModel;

namespace Gecko.WebIDL;

public enum SEError
{
	[Description("SESecurityError")]
	SESecurityError,
	[Description("SEIoError")]
	SEIoError,
	[Description("SEBadStateError")]
	SEBadStateError,
	[Description("SEInvalidChannelError")]
	SEInvalidChannelError,
	[Description("SEInvalidApplicationError")]
	SEInvalidApplicationError,
	[Description("SENotPresentError")]
	SENotPresentError,
	[Description("SEIllegalParameterError")]
	SEIllegalParameterError,
	[Description("SEGenericError")]
	SEGenericError
}
