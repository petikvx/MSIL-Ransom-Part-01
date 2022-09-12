using System.ComponentModel;

namespace Gecko.WebIDL;

public enum WPSMethod
{
	[Description("pbc")]
	pbc,
	[Description("keypad")]
	keypad,
	[Description("display")]
	display
}
