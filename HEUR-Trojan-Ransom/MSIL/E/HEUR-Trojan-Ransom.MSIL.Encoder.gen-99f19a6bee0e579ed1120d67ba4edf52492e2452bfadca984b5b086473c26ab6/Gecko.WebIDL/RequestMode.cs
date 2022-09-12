using System.ComponentModel;

namespace Gecko.WebIDL;

public enum RequestMode
{
	[Description("same-origin")]
	sameorigin,
	[Description("no-cors")]
	nocors,
	[Description("cors")]
	cors
}
