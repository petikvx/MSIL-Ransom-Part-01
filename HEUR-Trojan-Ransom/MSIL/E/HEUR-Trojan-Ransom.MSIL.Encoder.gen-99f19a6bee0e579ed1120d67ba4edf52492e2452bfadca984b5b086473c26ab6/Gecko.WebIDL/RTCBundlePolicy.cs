using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RTCBundlePolicy
{
	[Description("balanced")]
	balanced,
	[Description("max-compat")]
	maxcompat,
	[Description("max-bundle")]
	maxbundle
}
