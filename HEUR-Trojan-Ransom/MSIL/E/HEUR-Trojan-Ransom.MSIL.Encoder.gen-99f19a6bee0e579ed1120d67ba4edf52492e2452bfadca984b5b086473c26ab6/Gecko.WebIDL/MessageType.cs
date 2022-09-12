using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MessageType
{
	[Description("no-filtering")]
	nofiltering,
	[Description("sms")]
	sms,
	[Description("email")]
	email,
	[Description("mms")]
	mms
}
