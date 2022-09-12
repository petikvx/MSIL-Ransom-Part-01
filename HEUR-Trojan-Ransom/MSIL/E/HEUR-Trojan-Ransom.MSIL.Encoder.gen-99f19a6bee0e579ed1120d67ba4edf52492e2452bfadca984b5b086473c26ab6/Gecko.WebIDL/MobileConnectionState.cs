using System.ComponentModel;

namespace Gecko.WebIDL;

public enum MobileConnectionState
{
	[Description("notSearching")]
	notSearching,
	[Description("searching")]
	searching,
	[Description("denied")]
	denied,
	[Description("registered")]
	registered
}
