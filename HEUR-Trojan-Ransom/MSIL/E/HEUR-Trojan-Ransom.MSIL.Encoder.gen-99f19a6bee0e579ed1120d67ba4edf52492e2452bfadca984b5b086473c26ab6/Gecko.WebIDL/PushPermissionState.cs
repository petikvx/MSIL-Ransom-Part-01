using System.ComponentModel;

namespace Gecko.WebIDL;

public enum PushPermissionState
{
	[Description("granted")]
	granted,
	[Description("denied")]
	denied,
	[Description("prompt")]
	prompt
}
