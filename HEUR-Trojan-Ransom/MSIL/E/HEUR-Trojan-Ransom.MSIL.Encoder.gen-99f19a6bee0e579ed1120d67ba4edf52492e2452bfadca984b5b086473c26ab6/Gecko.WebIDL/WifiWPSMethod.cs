using System.ComponentModel;

namespace Gecko.WebIDL;

public enum WifiWPSMethod
{
	[Description("pbc")]
	pbc,
	[Description("pin")]
	pin,
	[Description("cancel")]
	cancel
}
