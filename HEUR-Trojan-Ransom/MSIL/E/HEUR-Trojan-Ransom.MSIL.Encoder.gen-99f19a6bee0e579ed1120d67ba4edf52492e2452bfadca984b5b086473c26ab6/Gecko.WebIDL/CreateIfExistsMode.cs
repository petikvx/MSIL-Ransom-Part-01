using System.ComponentModel;

namespace Gecko.WebIDL;

public enum CreateIfExistsMode
{
	[Description("replace")]
	replace,
	[Description("fail")]
	fail
}
