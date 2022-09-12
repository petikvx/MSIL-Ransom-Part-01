using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestSyncTaskPolicyState
{
	[Description("enabled")]
	enabled,
	[Description("disabled")]
	disabled,
	[Description("wifiOnly")]
	wifiOnly
}
