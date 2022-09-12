using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestCredentials
{
	[Description("omit")]
	omit,
	[Description("same-origin")]
	sameorigin,
	[Description("include")]
	include
}
